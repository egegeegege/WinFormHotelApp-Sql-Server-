namespace WindowsFormsApp2
{
    partial class frmKayıtOl
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txt_email = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_sifre = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_ad = new System.Windows.Forms.TextBox();
			this.txt_soyad = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txt_telefonNo = new System.Windows.Forms.TextBox();
			this.Cb_Created = new System.Windows.Forms.CheckBox();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.btn_kayit = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.label8 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1158, 30);
			this.panel1.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(12, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "Hebebiy/Katyusa";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.Highlight;
			this.button1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.pngwing_com;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button1.Dock = System.Windows.Forms.DockStyle.Right;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(1128, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(30, 30);
			this.button1.TabIndex = 1;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlLight;
			this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox3.Location = new System.Drawing.Point(0, 0);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(1158, 679);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 6;
			this.pictureBox3.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(90, 133);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(28, 15);
			this.label1.TabIndex = 8;
			this.label1.Text = "Ad :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(90, 221);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 15);
			this.label3.TabIndex = 8;
			this.label3.Text = "Şifre :";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(90, 174);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(45, 15);
			this.label7.TabIndex = 8;
			this.label7.Text = "Soyad :";
			// 
			// txt_email
			// 
			this.txt_email.Location = new System.Drawing.Point(119, 291);
			this.txt_email.Name = "txt_email";
			this.txt_email.Size = new System.Drawing.Size(200, 23);
			this.txt_email.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(90, 273);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 15);
			this.label4.TabIndex = 8;
			this.label4.Text = "Email :";
			// 
			// txt_sifre
			// 
			this.txt_sifre.Location = new System.Drawing.Point(119, 239);
			this.txt_sifre.Name = "txt_sifre";
			this.txt_sifre.Size = new System.Drawing.Size(200, 23);
			this.txt_sifre.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(90, 324);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 15);
			this.label5.TabIndex = 8;
			this.label5.Text = "Telefon No:";
			// 
			// txt_ad
			// 
			this.txt_ad.Location = new System.Drawing.Point(119, 151);
			this.txt_ad.Name = "txt_ad";
			this.txt_ad.Size = new System.Drawing.Size(200, 23);
			this.txt_ad.TabIndex = 7;
			// 
			// txt_soyad
			// 
			this.txt_soyad.Location = new System.Drawing.Point(119, 192);
			this.txt_soyad.Name = "txt_soyad";
			this.txt_soyad.Size = new System.Drawing.Size(200, 23);
			this.txt_soyad.TabIndex = 7;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(181, 105);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 20);
			this.label6.TabIndex = 9;
			this.label6.Text = "Kayıt Ol";
			// 
			// txt_telefonNo
			// 
			this.txt_telefonNo.Location = new System.Drawing.Point(119, 342);
			this.txt_telefonNo.Name = "txt_telefonNo";
			this.txt_telefonNo.Size = new System.Drawing.Size(200, 23);
			this.txt_telefonNo.TabIndex = 7;
			// 
			// Cb_Created
			// 
			this.Cb_Created.AutoSize = true;
			this.Cb_Created.BackColor = System.Drawing.Color.Transparent;
			this.Cb_Created.Checked = true;
			this.Cb_Created.CheckState = System.Windows.Forms.CheckState.Checked;
			this.Cb_Created.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Cb_Created.Location = new System.Drawing.Point(151, 378);
			this.Cb_Created.Name = "Cb_Created";
			this.Cb_Created.Size = new System.Drawing.Size(122, 21);
			this.Cb_Created.TabIndex = 11;
			this.Cb_Created.Text = "Show Password";
			this.Cb_Created.UseVisualStyleBackColor = false;
			this.Cb_Created.CheckedChanged += new System.EventHandler(this.Cb_Created_CheckedChanged);
			// 
			// linkLabel2
			// 
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.DisabledLinkColor = System.Drawing.Color.White;
			this.linkLabel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.linkLabel2.LinkColor = System.Drawing.SystemColors.ButtonFace;
			this.linkLabel2.Location = new System.Drawing.Point(128, 472);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(181, 15);
			this.linkLabel2.TabIndex = 12;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "Do you already have an account?";
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			// 
			// btn_kayit
			// 
			this.btn_kayit.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btn_kayit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.btn_kayit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btn_kayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_kayit.ForeColor = System.Drawing.Color.White;
			this.btn_kayit.Location = new System.Drawing.Point(131, 415);
			this.btn_kayit.Name = "btn_kayit";
			this.btn_kayit.Size = new System.Drawing.Size(160, 40);
			this.btn_kayit.TabIndex = 15;
			this.btn_kayit.Text = "Kayıt Ol";
			this.btn_kayit.UseVisualStyleBackColor = true;
			this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
			// 
			// panel2
			// 
			this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
			this.panel2.Controls.Add(this.btn_kayit);
			this.panel2.Controls.Add(this.linkLabel2);
			this.panel2.Controls.Add(this.Cb_Created);
			this.panel2.Controls.Add(this.txt_telefonNo);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.txt_soyad);
			this.panel2.Controls.Add(this.txt_ad);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.txt_sifre);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.txt_email);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.panel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.panel2.Location = new System.Drawing.Point(0, 26);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(431, 653);
			this.panel2.TabIndex = 10;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlLight;
			this.pictureBox4.Image = global::WindowsFormsApp2.Properties.Resources.Geek_Photoroom;
			this.pictureBox4.Location = new System.Drawing.Point(1027, 45);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(101, 83);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 12;
			this.pictureBox4.TabStop = false;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.SystemColors.ControlLight;
			this.label8.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
			this.label8.Location = new System.Drawing.Point(451, 413);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(605, 96);
			this.label8.TabIndex = 11;
			this.label8.Text = "Geek Hotel Uygulamamıza Hos geldiniz \r\nLütfen Kayıt Olunuz ve Daha Sonra\r\nGiriş Y" +
    "apmayı Deneyiniz\r\n";
			this.label8.Click += new System.EventHandler(this.label8_Click);
			// 
			// frmKayıtOl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1158, 679);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmKayıtOl";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmKayıtOl";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_kayitol;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txt_email;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_sifre;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt_ad;
		private System.Windows.Forms.TextBox txt_soyad;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txt_telefonNo;
		private System.Windows.Forms.CheckBox Cb_Created;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.Button btn_kayit;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label label8;
	}
}