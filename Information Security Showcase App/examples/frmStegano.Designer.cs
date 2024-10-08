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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStegano));
            pcbPrije = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            btnIzvrsi = new Button();
            txtPoruka = new TextBox();
            label3 = new Label();
            err = new ErrorProvider(components);
            pcbPoslije = new PictureBox();
            label4 = new Label();
            btnPronadji = new Button();
            label5 = new Label();
            lblPronadji = new Label();
            btnSpremi = new Button();
            ((System.ComponentModel.ISupportInitialize)pcbPrije).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbPoslije).BeginInit();
            SuspendLayout();
            // 
            // pcbPrije
            // 
            pcbPrije.Image = (Image)resources.GetObject("pcbPrije.Image");
            pcbPrije.Location = new Point(12, 60);
            pcbPrije.Name = "pcbPrije";
            pcbPrije.Size = new Size(280, 281);
            pcbPrije.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbPrije.TabIndex = 0;
            pcbPrije.TabStop = false;
            pcbPrije.DoubleClick += pcbPrije_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(201, 15);
            label1.TabIndex = 1;
            label1.Text = "Vaša slika :: Insertovanje tajne poruke";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(12, 17);
            label2.Name = "label2";
            label2.Size = new Size(123, 21);
            label2.TabIndex = 1;
            label2.Text = "Steganografija";
            // 
            // btnIzvrsi
            // 
            btnIzvrsi.BackColor = SystemColors.HotTrack;
            btnIzvrsi.FlatAppearance.BorderSize = 0;
            btnIzvrsi.FlatStyle = FlatStyle.Flat;
            btnIzvrsi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnIzvrsi.ForeColor = SystemColors.Control;
            btnIzvrsi.Location = new Point(14, 391);
            btnIzvrsi.Name = "btnIzvrsi";
            btnIzvrsi.Size = new Size(150, 39);
            btnIzvrsi.TabIndex = 2;
            btnIzvrsi.Text = "Izvrši steganografiju";
            btnIzvrsi.UseVisualStyleBackColor = false;
            btnIzvrsi.Click += btnIzvrsi_Click;
            // 
            // txtPoruka
            // 
            txtPoruka.Location = new Point(14, 362);
            txtPoruka.Name = "txtPoruka";
            txtPoruka.Size = new Size(278, 23);
            txtPoruka.TabIndex = 3;
            txtPoruka.DoubleClick += txtPoruka_DoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(14, 344);
            label3.Name = "label3";
            label3.Size = new Size(137, 15);
            label3.TabIndex = 1;
            label3.Text = "Unesite skrivenu poruku:";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // pcbPoslije
            // 
            pcbPoslije.Image = (Image)resources.GetObject("pcbPoslije.Image");
            pcbPoslije.Location = new Point(365, 60);
            pcbPoslije.Name = "pcbPoslije";
            pcbPoslije.Size = new Size(280, 281);
            pcbPoslije.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbPoslije.TabIndex = 0;
            pcbPoslije.TabStop = false;
            pcbPoslije.DoubleClick += pcbPoslije_DoubleClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.ControlLight;
            label4.Location = new Point(365, 42);
            label4.Name = "label4";
            label4.Size = new Size(130, 15);
            label4.TabIndex = 1;
            label4.Text = "Pronalazak tajnog koda";
            // 
            // btnPronadji
            // 
            btnPronadji.BackColor = SystemColors.ActiveBorder;
            btnPronadji.FlatAppearance.BorderSize = 0;
            btnPronadji.FlatStyle = FlatStyle.Flat;
            btnPronadji.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPronadji.ForeColor = SystemColors.ControlText;
            btnPronadji.Location = new Point(365, 391);
            btnPronadji.Name = "btnPronadji";
            btnPronadji.Size = new Size(280, 39);
            btnPronadji.TabIndex = 2;
            btnPronadji.Text = "Pronađi tajni kod";
            btnPronadji.UseVisualStyleBackColor = false;
            btnPronadji.Click += btnPronadji_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(365, 361);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 1;
            label5.Text = "Pronađeni kod:";
            // 
            // lblPronadji
            // 
            lblPronadji.AutoSize = true;
            lblPronadji.BackColor = Color.Transparent;
            lblPronadji.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPronadji.ForeColor = SystemColors.MenuHighlight;
            lblPronadji.Location = new Point(597, 361);
            lblPronadji.Name = "lblPronadji";
            lblPronadji.Size = new Size(48, 20);
            lblPronadji.TabIndex = 1;
            lblPronadji.Text = "NULL";
            // 
            // btnSpremi
            // 
            btnSpremi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSpremi.Location = new Point(170, 391);
            btnSpremi.Name = "btnSpremi";
            btnSpremi.Size = new Size(122, 39);
            btnSpremi.TabIndex = 4;
            btnSpremi.Text = "Spremi modified";
            btnSpremi.UseVisualStyleBackColor = true;
            btnSpremi.Click += btnSpremi_Click;
            // 
            // frmStegano
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(672, 453);
            Controls.Add(btnSpremi);
            Controls.Add(txtPoruka);
            Controls.Add(btnPronadji);
            Controls.Add(btnIzvrsi);
            Controls.Add(label2);
            Controls.Add(lblPronadji);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(pcbPoslije);
            Controls.Add(pcbPrije);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmStegano";
            Text = "Steganografija :: Primjer";
            ((System.ComponentModel.ISupportInitialize)pcbPrije).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbPoslije).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbPrije;
        private Label label1;
        private Label label2;
        private Button btnIzvrsi;
        private TextBox txtPoruka;
        private Label label3;
        private ErrorProvider err;
        private Button btnPronadji;
        private Label label4;
        private PictureBox pcbPoslije;
        private Label lblPronadji;
        private Label label5;
        private Button btnSpremi;
    }
}