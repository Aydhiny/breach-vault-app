namespace Information_Security_Showcase_App.examples
{
    partial class frmStegano
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStegano));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            imageToolStripMenuItem = new ToolStripMenuItem();
            textToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            imageToolStripMenuItem1 = new ToolStripMenuItem();
            textToolStripMenuItem1 = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            btnSakrij = new Button();
            encryptCheckBox = new CheckBox();
            grpEncrypt = new GroupBox();
            label1 = new Label();
            passwordTextBox = new TextBox();
            imagePictureBox = new PictureBox();
            notesLabel = new Label();
            dataTextBox = new TextBox();
            btnExtract = new Button();
            menuStrip1.SuspendLayout();
            grpEncrypt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagePictureBox).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(446, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { imageToolStripMenuItem, textToolStripMenuItem });
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(103, 22);
            openToolStripMenuItem.Text = "Open";
            // 
            // imageToolStripMenuItem
            // 
            imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            imageToolStripMenuItem.Size = new Size(107, 22);
            imageToolStripMenuItem.Text = "Image";
            imageToolStripMenuItem.Click += imageToolStripMenuItem_Click;
            // 
            // textToolStripMenuItem
            // 
            textToolStripMenuItem.Name = "textToolStripMenuItem";
            textToolStripMenuItem.Size = new Size(107, 22);
            textToolStripMenuItem.Text = "Text";
            textToolStripMenuItem.Click += textToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { imageToolStripMenuItem1, textToolStripMenuItem1 });
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(103, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // imageToolStripMenuItem1
            // 
            imageToolStripMenuItem1.Name = "imageToolStripMenuItem1";
            imageToolStripMenuItem1.Size = new Size(107, 22);
            imageToolStripMenuItem1.Text = "Image";
            imageToolStripMenuItem1.Click += imageToolStripMenuItem1_Click;
            // 
            // textToolStripMenuItem1
            // 
            textToolStripMenuItem1.Name = "textToolStripMenuItem1";
            textToolStripMenuItem1.Size = new Size(107, 22);
            textToolStripMenuItem1.Text = "Text";
            textToolStripMenuItem1.Click += textToolStripMenuItem1_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // btnSakrij
            // 
            btnSakrij.BackColor = SystemColors.MenuHighlight;
            btnSakrij.FlatStyle = FlatStyle.Flat;
            btnSakrij.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSakrij.ForeColor = SystemColors.ControlLightLight;
            btnSakrij.Location = new Point(12, 533);
            btnSakrij.Name = "btnSakrij";
            btnSakrij.Size = new Size(168, 51);
            btnSakrij.TabIndex = 1;
            btnSakrij.Text = "Sakrij poruku";
            btnSakrij.UseVisualStyleBackColor = false;
            btnSakrij.Click += btnSakrij_Click;
            // 
            // encryptCheckBox
            // 
            encryptCheckBox.AutoSize = true;
            encryptCheckBox.ForeColor = SystemColors.ControlLightLight;
            encryptCheckBox.Location = new Point(6, 26);
            encryptCheckBox.Name = "encryptCheckBox";
            encryptCheckBox.Size = new Size(79, 19);
            encryptCheckBox.TabIndex = 2;
            encryptCheckBox.Text = "Encrypted";
            encryptCheckBox.UseVisualStyleBackColor = true;
            // 
            // grpEncrypt
            // 
            grpEncrypt.Controls.Add(label1);
            grpEncrypt.Controls.Add(passwordTextBox);
            grpEncrypt.Controls.Add(encryptCheckBox);
            grpEncrypt.ForeColor = SystemColors.ControlLightLight;
            grpEncrypt.Location = new Point(12, 467);
            grpEncrypt.Name = "grpEncrypt";
            grpEncrypt.Size = new Size(422, 60);
            grpEncrypt.TabIndex = 3;
            grpEncrypt.TabStop = false;
            grpEncrypt.Text = "Encryption";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 27);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 4;
            label1.Text = "Password:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(174, 22);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(242, 23);
            passwordTextBox.TabIndex = 3;
            // 
            // imagePictureBox
            // 
            imagePictureBox.Image = (Image)resources.GetObject("imagePictureBox.Image");
            imagePictureBox.Location = new Point(12, 27);
            imagePictureBox.Name = "imagePictureBox";
            imagePictureBox.Size = new Size(422, 312);
            imagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            imagePictureBox.TabIndex = 4;
            imagePictureBox.TabStop = false;
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            notesLabel.ForeColor = SystemColors.ControlLightLight;
            notesLabel.Location = new Point(12, 587);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new Size(59, 21);
            notesLabel.TabIndex = 6;
            notesLabel.Text = "Notes:";
            // 
            // dataTextBox
            // 
            dataTextBox.Location = new Point(12, 345);
            dataTextBox.Multiline = true;
            dataTextBox.Name = "dataTextBox";
            dataTextBox.Size = new Size(422, 116);
            dataTextBox.TabIndex = 7;
            // 
            // btnExtract
            // 
            btnExtract.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnExtract.Location = new Point(186, 533);
            btnExtract.Name = "btnExtract";
            btnExtract.Size = new Size(248, 51);
            btnExtract.TabIndex = 8;
            btnExtract.Text = "Extract File";
            btnExtract.UseVisualStyleBackColor = true;
            btnExtract.Click += btnExtract_Click;
            // 
            // frmStegano
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 25);
            ClientSize = new Size(446, 624);
            Controls.Add(btnExtract);
            Controls.Add(dataTextBox);
            Controls.Add(notesLabel);
            Controls.Add(imagePictureBox);
            Controls.Add(grpEncrypt);
            Controls.Add(btnSakrij);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "frmStegano";
            Text = "Steganografija";
            Load += frmStegano_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            grpEncrypt.ResumeLayout(false);
            grpEncrypt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imagePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private Button btnSakrij;
        private CheckBox encryptCheckBox;
        private GroupBox grpEncrypt;
        private Label label1;
        private TextBox passwordTextBox;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem imageToolStripMenuItem;
        private ToolStripMenuItem textToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem imageToolStripMenuItem1;
        private ToolStripMenuItem textToolStripMenuItem1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private PictureBox imagePictureBox;
        private Label notesLabel;
        private TextBox dataTextBox;
        private Button btnExtract;
    }
}