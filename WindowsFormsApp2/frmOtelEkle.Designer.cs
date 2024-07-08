namespace WindowsFormsApp2
{
    partial class frmOtelEkle
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
            this.txt_OtelAdı = new System.Windows.Forms.TextBox();
            this.txt_Fiyat = new System.Windows.Forms.TextBox();
            this.txt_OdaSayısı = new System.Windows.Forms.TextBox();
            this.FileName = new System.Windows.Forms.TextBox();
            this.txt_Adres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Cmb_Yıldız = new System.Windows.Forms.ComboBox();
            this.Cmb_Havuz = new System.Windows.Forms.ComboBox();
            this.Cmb_SSalonu = new System.Windows.Forms.ComboBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_fileDialog = new System.Windows.Forms.Button();
            this.PB_Resim = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Resim)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_OtelAdı
            // 
            this.txt_OtelAdı.Location = new System.Drawing.Point(58, 91);
            this.txt_OtelAdı.Name = "txt_OtelAdı";
            this.txt_OtelAdı.Size = new System.Drawing.Size(151, 20);
            this.txt_OtelAdı.TabIndex = 0;
            // 
            // txt_Fiyat
            // 
            this.txt_Fiyat.Location = new System.Drawing.Point(58, 214);
            this.txt_Fiyat.Name = "txt_Fiyat";
            this.txt_Fiyat.Size = new System.Drawing.Size(153, 20);
            this.txt_Fiyat.TabIndex = 0;
            // 
            // txt_OdaSayısı
            // 
            this.txt_OdaSayısı.Location = new System.Drawing.Point(346, 214);
            this.txt_OdaSayısı.Name = "txt_OdaSayısı";
            this.txt_OdaSayısı.Size = new System.Drawing.Size(153, 20);
            this.txt_OdaSayısı.TabIndex = 0;
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(192, 262);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(108, 20);
            this.FileName.TabIndex = 0;
            // 
            // txt_Adres
            // 
            this.txt_Adres.Location = new System.Drawing.Point(157, 306);
            this.txt_Adres.Multiline = true;
            this.txt_Adres.Name = "txt_Adres";
            this.txt_Adres.Size = new System.Drawing.Size(228, 83);
            this.txt_Adres.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Otel Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kaç Yıldızlı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Günlük Fiyatı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Oda Sayısı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Havuz";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Spor Salonu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(159, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Resim";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(124, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Adres";
            // 
            // Cmb_Yıldız
            // 
            this.Cmb_Yıldız.FormattingEnabled = true;
            this.Cmb_Yıldız.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Cmb_Yıldız.Location = new System.Drawing.Point(58, 150);
            this.Cmb_Yıldız.Name = "Cmb_Yıldız";
            this.Cmb_Yıldız.Size = new System.Drawing.Size(151, 21);
            this.Cmb_Yıldız.TabIndex = 2;
            // 
            // Cmb_Havuz
            // 
            this.Cmb_Havuz.FormattingEnabled = true;
            this.Cmb_Havuz.Items.AddRange(new object[] {
            "Var",
            "Yok"});
            this.Cmb_Havuz.Location = new System.Drawing.Point(346, 91);
            this.Cmb_Havuz.Name = "Cmb_Havuz";
            this.Cmb_Havuz.Size = new System.Drawing.Size(151, 21);
            this.Cmb_Havuz.TabIndex = 2;
            // 
            // Cmb_SSalonu
            // 
            this.Cmb_SSalonu.FormattingEnabled = true;
            this.Cmb_SSalonu.Items.AddRange(new object[] {
            "Var",
            "Yok"});
            this.Cmb_SSalonu.Location = new System.Drawing.Point(346, 150);
            this.Cmb_SSalonu.Name = "Cmb_SSalonu";
            this.Cmb_SSalonu.Size = new System.Drawing.Size(151, 21);
            this.Cmb_SSalonu.TabIndex = 2;
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.ForeColor = System.Drawing.Color.White;
            this.btn_ekle.Location = new System.Drawing.Point(139, 426);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(257, 70);
            this.btn_ekle.TabIndex = 3;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.bt_fileDialog);
            this.panel1.Controls.Add(this.txt_Adres);
            this.panel1.Controls.Add(this.btn_ekle);
            this.panel1.Controls.Add(this.txt_OtelAdı);
            this.panel1.Controls.Add(this.Cmb_SSalonu);
            this.panel1.Controls.Add(this.txt_Fiyat);
            this.panel1.Controls.Add(this.Cmb_Havuz);
            this.panel1.Controls.Add(this.FileName);
            this.panel1.Controls.Add(this.Cmb_Yıldız);
            this.panel1.Controls.Add(this.txt_OdaSayısı);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(595, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 646);
            this.panel1.TabIndex = 4;
            // 
            // bt_fileDialog
            // 
            this.bt_fileDialog.Location = new System.Drawing.Point(306, 261);
            this.bt_fileDialog.Name = "bt_fileDialog";
            this.bt_fileDialog.Size = new System.Drawing.Size(78, 23);
            this.bt_fileDialog.TabIndex = 4;
            this.bt_fileDialog.Text = "Resim Yükle";
            this.bt_fileDialog.UseVisualStyleBackColor = true;
            this.bt_fileDialog.Click += new System.EventHandler(this.bt_fileDialog_Click);
            // 
            // PB_Resim
            // 
            this.PB_Resim.Location = new System.Drawing.Point(27, 107);
            this.PB_Resim.Name = "PB_Resim";
            this.PB_Resim.Size = new System.Drawing.Size(533, 356);
            this.PB_Resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Resim.TabIndex = 5;
            this.PB_Resim.TabStop = false;
            // 
            // frmOtelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 640);
            this.Controls.Add(this.PB_Resim);
            this.Controls.Add(this.panel1);
            this.Name = "frmOtelEkle";
            this.Text = "frmOtelEkle";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Resim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_OtelAdı;
        private System.Windows.Forms.TextBox txt_Fiyat;
        private System.Windows.Forms.TextBox txt_OdaSayısı;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.TextBox txt_Adres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Cmb_Yıldız;
        private System.Windows.Forms.ComboBox Cmb_Havuz;
        private System.Windows.Forms.ComboBox Cmb_SSalonu;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PB_Resim;
        private System.Windows.Forms.Button bt_fileDialog;
    }
}