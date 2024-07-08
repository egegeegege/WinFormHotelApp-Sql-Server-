namespace WindowsFormsApp2
{
    partial class frmOtelListesi
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_OtelerListesi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OtelerListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(521, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oteller";
            // 
            // dgv_OtelerListesi
            // 
            this.dgv_OtelerListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OtelerListesi.Location = new System.Drawing.Point(213, 137);
            this.dgv_OtelerListesi.Name = "dgv_OtelerListesi";
            this.dgv_OtelerListesi.Size = new System.Drawing.Size(745, 399);
            this.dgv_OtelerListesi.TabIndex = 1;
            this.dgv_OtelerListesi.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_OtelerListesi_CellMouseClick);
            // 
            // frmOtelListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 640);
            this.Controls.Add(this.dgv_OtelerListesi);
            this.Controls.Add(this.label1);
            this.Name = "frmOtelListesi";
            this.Text = "frmOtelListesi";
            this.Load += new System.EventHandler(this.frmOtelListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OtelerListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_OtelerListesi;
    }
}