using Information_Security_Showcase_App.examples;
using System.Diagnostics;

namespace Information_Security_Showcase_App
{
    public partial class frmPocetna : Form
    {
        public frmPocetna()
        {
            InitializeComponent();
        }

        private void btnStega_Click(object sender, EventArgs e)
        {
            frmStegano steganoGrafija = new frmStegano();
            steganoGrafija.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblGithub_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/Aydhiny",
                UseShellExecute = true
            });
        }
    }
}
