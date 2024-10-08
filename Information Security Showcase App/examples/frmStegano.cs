using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Information_Security_Showcase_App.examples
{
    public partial class frmStegano : Form
    {
        public frmStegano()
        {
            InitializeComponent();
        }

        private void btnIzvrsi_Click(object sender, EventArgs e)
        {
            if (!IsMessageValid(txtPoruka.Text))
            {
                MessageBox.Show("Message can only contain ASCII characters.");
                return;
            }
            if (pcbPrije.Image != null)
            {
                Bitmap bmp = new Bitmap((Image)pcbPrije.Image);
                HideMessageInImage(bmp, txtPoruka.Text);
                MessageBox.Show("Message hidden successfully!");
            }
            else
            {
                MessageBox.Show("Please load an image first.");
            }
        }

        public void HideMessageInImage(Bitmap bmp, string message)
        {
            // Add a terminator to mark the end of the message
            message += "\0";

            char[] messageChars = message.ToCharArray();
            int messageIndex = 0;

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color pixel = bmp.GetPixel(i, j);

                    if (messageIndex < messageChars.Length)
                    {
                        int value = Convert.ToInt32(messageChars[messageIndex]);

                        // Modify the RGB values to embed the character bits
                        Color newPixel = Color.FromArgb(
                            (pixel.R & 0xFE) | ((value >> 7) & 1),
                            (pixel.G & 0xFE) | ((value >> 6) & 1),
                            (pixel.B & 0xFE) | ((value >> 5) & 1)
                        );

                        bmp.SetPixel(i, j, newPixel);
                        messageIndex++;
                    }
                }
            }
        }

        private void btnPronadji_Click(object sender, EventArgs e)
        {
            if (pcbPoslije.Image != null)
            {
                Bitmap bmp = new Bitmap((Image)pcbPoslije.Image);
                string hiddenMessage = RevealMessageInImage(bmp);
                lblPronadji.Text = hiddenMessage;
            }
            else
            {
                MessageBox.Show("Please load an image first.");
            }
        }
        public string RevealMessageInImage(Bitmap bmp)
        {
            StringBuilder message = new StringBuilder();
            char currentChar;

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color pixel = bmp.GetPixel(i, j);

                    // Reconstruct the character using the least significant bits
                    int value = 0;
                    value |= (pixel.R & 1) << 7; // Bit 7 from R
                    value |= (pixel.G & 1) << 6; // Bit 6 from G
                    value |= (pixel.B & 1) << 5; // Bit 5 from B

                    if (value < 128) // Limit to valid ASCII range
                    {
                        currentChar = (char)value;
                        if (currentChar == '\0') // Check for null terminator
                            return message.ToString();

                        message.Append(currentChar);
                    }
                }
            }

            return message.ToString();
        }

        private void txtPoruka_DoubleClick(object sender, EventArgs e)
        {

        }

        private void pcbPrije_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select an Image";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"; // Filter for image formats

            // Show the dialog and check if the user clicked OK
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Load the selected image into the PictureBox as a BMP
                    using (Bitmap tempBmp = new Bitmap(openFileDialog.FileName))
                    {
                        // Convert to BMP format
                        using (Bitmap bmp = new Bitmap(tempBmp))
                        {
                            pcbPrije.Image = new Bitmap(bmp); // Assigning to PictureBox
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur (e.g., file format issues)
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save Modified Image";
            saveFileDialog.Filter = "Bitmap Image|*.bmp|JPEG Image|*.jpg;*.jpeg|PNG Image|*.png|GIF Image|*.gif"; // Filter for image formats

            // Show the dialog and check if the user clicked OK
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Use the current image from the PictureBox
                Bitmap bmp = new Bitmap(pcbPrije.Image);

                try
                {
                    // Determine the image format based on the selected file extension
                    string extension = System.IO.Path.GetExtension(saveFileDialog.FileName).ToLower();
                    System.Drawing.Imaging.ImageFormat format;

                    switch (extension)
                    {
                        case ".jpg":
                        case ".jpeg":
                            format = System.Drawing.Imaging.ImageFormat.Jpeg;
                            break;
                        case ".png":
                            format = System.Drawing.Imaging.ImageFormat.Png;
                            break;
                        case ".gif":
                            format = System.Drawing.Imaging.ImageFormat.Gif;
                            break;
                        case ".bmp":
                        default:
                            format = System.Drawing.Imaging.ImageFormat.Bmp; // Default to BMP
                            break;
                    }

                    // Save the modified image in the specified format
                    bmp.Save(saveFileDialog.FileName, format);
                    MessageBox.Show("Image saved successfully!");
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur (e.g., file save issues)
                    MessageBox.Show("Error saving image: " + ex.Message);
                }
            }
        }

        private void pcbPoslije_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select an Image";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"; // Filter for image formats

            // Show the dialog and check if the user clicked OK
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Load the selected image into the PictureBox
                try
                {
                    // Set the PictureBox's image to the selected file
                    pcbPoslije.Image = new Bitmap(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur (e.g., file format issues)
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }

        private bool IsMessageValid(string message)
        {
            foreach (char c in message)
            {
                if (c < 0 || c > 127) // Allow only ASCII characters
                {
                    return false;
                }
            }
            return true;
        }
    }
}
