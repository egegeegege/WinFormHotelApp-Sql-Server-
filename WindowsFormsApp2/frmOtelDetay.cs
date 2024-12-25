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
    public partial class frmOtelDetay : Form
    {
        public string kid;
        public int id;
        public string base64Image;
        public int gun;

        ProjectContext db = new ProjectContext();

        public frmOtelDetay()
        {
            InitializeComponent();
        }
        private void frmOtelDetay_Load(object sender, EventArgs e)
        {
            List<Oteller> otellers = new List<Oteller>();
            otellers = db.Otellers.Where(a => a.ID == id).ToList();

            foreach (var otel in otellers)
            {
                lbl_otelAdı.Text = otel.OtelAdı.ToString();
                lbl_yıldızSayısı.Text = otel.YıldızSayısı.ToString();
                lbl_OdaNo.Text = otel.OdaSayısı.ToString();
                lbl_GünlükFiyatı.Text = otel.GünlükFiyatı.ToString();
                lbl_Havuz.Text = otel.Havuz.ToString();
                lbl_SporSalonu.Text = otel.SporSalonu.ToString();
                lbl_Adres.Text = otel.Adres.ToString();
                pb_otelResim.Image = ConvertBase64ToImage(otel.ImageUrl);
            }
        }
        private Image ConvertBase64ToImage(string imageUrl)
        {
            byte[] imageBytes = Convert.FromBase64String(imageUrl);
            using (MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                ms.Write(imageBytes, 0, imageBytes.Length);
                return Image.FromStream(ms, true);
            }
        }


        private void btn_iptal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

	}
}   