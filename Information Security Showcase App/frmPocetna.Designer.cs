namespace Information_Security_Showcase_App
{
    partial class frmPocetna
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPocetna));
            pcbSteg = new PictureBox();
            btnStega = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblGithub = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            btnKeyLogger = new Button();
            label4 = new Label();
            groupBox1 = new GroupBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbSteg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pcbSteg
            // 
            pcbSteg.BorderStyle = BorderStyle.FixedSingle;
            pcbSteg.Image = (Image)resources.GetObject("pcbSteg.Image");
            pcbSteg.Location = new Point(6, 22);
            pcbSteg.Name = "pcbSteg";
            pcbSteg.Size = new Size(311, 236);
            pcbSteg.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbSteg.TabIndex = 0;
            pcbSteg.TabStop = false;
            // 
            // btnStega
            // 
            btnStega.BackColor = SystemColors.HotTrack;
            btnStega.FlatAppearance.BorderColor = Color.Lavender;
            btnStega.FlatAppearance.BorderSize = 0;
            btnStega.FlatStyle = FlatStyle.Popup;
            btnStega.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnStega.ForeColor = Color.White;
            btnStega.Location = new Point(6, 264);
            btnStega.Name = "btnStega";
            btnStega.Size = new Size(83, 35);
            btnStega.TabIndex = 2;
            btnStega.Text = "Pokreni";
            btnStega.UseVisualStyleBackColor = false;
            btnStega.Click += btnStega_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(229, 270);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 1;
            label1.Text = "Steganografija";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(669, 325);
            label2.Name = "label2";
            label2.Size = new Size(141, 20);
            label2.TabIndex = 3;
            label2.Text = "Više primjera soon...";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(18, 57);
            label3.Name = "label3";
            label3.Size = new Size(136, 15);
            label3.TabIndex = 1;
            label3.Text = "Informacijska sigurnost";
            // 
            // lblGithub
            // 
            lblGithub.AutoSize = true;
            lblGithub.BackColor = Color.Transparent;
            lblGithub.Cursor = Cursors.Hand;
            lblGithub.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblGithub.ForeColor = Color.RoyalBlue;
            lblGithub.Location = new Point(695, 373);
            lblGithub.Name = "lblGithub";
            lblGithub.Size = new Size(115, 15);
            lblGithub.TabIndex = 1;
            lblGithub.Text = "github.com/Aydhiny";
            lblGithub.Click += lblGithub_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(670, 353);
            label5.Name = "label5";
            label5.Size = new Size(140, 20);
            label5.TabIndex = 1;
            label5.Text = "Ajdin Mehmedović";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(323, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(311, 236);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlLight;
            label6.Location = new Point(570, 270);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 1;
            label6.Text = "Keylogger";
            // 
            // btnKeyLogger
            // 
            btnKeyLogger.BackColor = Color.RoyalBlue;
            btnKeyLogger.FlatAppearance.BorderColor = Color.BlueViolet;
            btnKeyLogger.FlatAppearance.BorderSize = 0;
            btnKeyLogger.FlatStyle = FlatStyle.Flat;
            btnKeyLogger.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnKeyLogger.ForeColor = Color.Transparent;
            btnKeyLogger.Location = new Point(323, 264);
            btnKeyLogger.Name = "btnKeyLogger";
            btnKeyLogger.Size = new Size(83, 35);
            btnKeyLogger.TabIndex = 2;
            btnKeyLogger.Text = "Pokreni";
            btnKeyLogger.UseVisualStyleBackColor = false;
            btnKeyLogger.Click += btnStega_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("ARP 240", 19F, FontStyle.Bold);
            label4.ForeColor = SystemColors.MenuHighlight;
            label4.Location = new Point(11, 21);
            label4.Name = "label4";
            label4.Size = new Size(263, 35);
            label4.TabIndex = 1;
            label4.Text = "Breach Vault";
            label4.Click += label4_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pcbSteg);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btnKeyLogger);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnStega);
            groupBox1.Controls.Add(label6);
            groupBox1.ForeColor = SystemColors.ControlLight;
            groupBox1.Location = new Point(12, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(651, 318);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Primjeri";
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(736, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(74, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // frmPocetna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 27, 27);
            ClientSize = new Size(824, 417);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(lblGithub);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmPocetna";
            Text = "Pocetna forma :: Examples";
            ((System.ComponentModel.ISupportInitialize)pcbSteg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbSteg;
        private Button btnStega;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblGithub;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label6;
        private Button btnKeyLogger;
        private Label label4;
        private GroupBox groupBox1;
        private PictureBox pictureBox2;
    }
}
