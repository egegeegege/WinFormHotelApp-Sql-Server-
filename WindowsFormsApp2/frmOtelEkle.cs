using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.ORM.Context;
using WindowsFormsApp2.ORM.Entity;

namespace WindowsFormsApp2
{
    public partial class frmOtelEkle : Form
    {
        ProjectContext Database = new ProjectContext();
        public frmOtelEkle()
        {
            InitializeComponent();
        }

        private void bt_fileDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg;*.jpeg;*.png;*.gif;*.bmp) | *.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PB_Resim.Image = new Bitmap(ofd.FileName);
                FileName.Text = ofd.FileName;
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            string base64;
            using (Image image = PB_Resim.Image.Clone() as Image)
            {
                base64 = ConvertImageToBase64(image);
            }
            Oteller oteller = new Oteller()
            {
                OtelAdı = txt_OtelAdı.Text,
                GünlükFiyatı = Convert.ToDouble(txt_Fiyat.Text),
                Adres = txt_Adres.Text,
                OdaSayısı = (int)Convert.ToUInt32(txt_OdaSayısı.Text),
                Havuz = Cmb_Havuz.Text,
                SporSalonu = Cmb_SSalonu.Text,
                YıldızSayısı = Cmb_Yıldız.Text,
                ImageUrl = base64,
                Aktifmi = false,
            };
            Database.Otellers.Add(oteller);
            Database.SaveChanges();
            MessageBox.Show("Otel başarıyla eklendi");
            this.Hide();
        }
        private string ConvertImageToBase64(Image image)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, image.RawFormat);
                byte[] imageBytes = memoryStream.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }
    }
}
