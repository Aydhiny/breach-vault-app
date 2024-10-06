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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            btnIzvrsi = new Button();
            txtPoruka = new TextBox();
            label3 = new Label();
            err = new ErrorProvider(components);
            pictureBox2 = new PictureBox();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 281);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            btnIzvrsi.Size = new Size(280, 39);
            btnIzvrsi.TabIndex = 2;
            btnIzvrsi.Text = "Izvrši steganografiju";
            btnIzvrsi.UseVisualStyleBackColor = false;
            // 
            // txtPoruka
            // 
            txtPoruka.Location = new Point(14, 362);
            txtPoruka.Name = "txtPoruka";
            txtPoruka.Size = new Size(278, 23);
            txtPoruka.TabIndex = 3;
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
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(365, 60);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(280, 281);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
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
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(365, 391);
            button1.Name = "button1";
            button1.Size = new Size(280, 39);
            button1.TabIndex = 2;
            button1.Text = "Pronađi tajni kod";
            button1.UseVisualStyleBackColor = false;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.ForeColor = SystemColors.MenuHighlight;
            label6.Location = new Point(597, 361);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 1;
            label6.Text = "NULL";
            // 
            // frmStegano
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(672, 453);
            Controls.Add(txtPoruka);
            Controls.Add(button1);
            Controls.Add(btnIzvrsi);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmStegano";
            Text = "Steganografija :: Primjer";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button btnIzvrsi;
        private TextBox txtPoruka;
        private Label label3;
        private ErrorProvider err;
        private Button button1;
        private Label label4;
        private PictureBox pictureBox2;
        private Label label6;
        private Label label5;
    }
}