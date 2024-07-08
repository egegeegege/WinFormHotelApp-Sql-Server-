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
        internal string kid;
        internal string base64Image;
        internal int id;
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

        private void btn_rezerveEt_Click(object sender, EventArgs e)
        {
            Oteller otelvarmi = db.Otellers.Where(a => a.ID == id && a.Aktifmi == true).FirstOrDefault();
            Oteller oteller = db.Otellers.Where(a => a.ID == id).FirstOrDefault();

            if (otelvarmi != null)
            {
                MessageBox.Show("Seçtiğiniz otel odası şuan kiralık durumda");
            }
            else
            {
                Rezervasyon rezervasyon = new Rezervasyon()
                {
                    OdaID = id,
                    YoneticiID = int.Parse(kid),
                    RezerveTarihi = dtp_alısTarihi.Value,
                    OdaTeslimTarihi = dtp_teslimTarihi.Value,
                    KullanımSuresi = gun,
                    FaturaTutari = Convert.ToDouble(lbl_faturatutar.Text),
                    Aktifmi = false,
                };

                oteller.Aktifmi = true;
                db.Rezervasyons.Add(rezervasyon);
                db.SaveChanges();
                MessageBox.Show("Otel odanız kiralandı");
                this.Hide();
            }
        }

        private void dtp_alısTarihi_ValueChanged(object sender, EventArgs e)
        {
            dtp_teslimTarihi.Enabled = true;
        }

        private void dtp_teslimTarihi_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan GunFarki = dtp_teslimTarihi.Value.Subtract(dtp_alısTarihi.Value);
            gun = GunFarki.Days;

            if (gun < 1)
            {
                MessageBox.Show("Teslim Tarihi Alış Tarihinden önce ve aynı gün olamaz!");
                lbl_gunsayisi.Text = null;
                lbl_faturatutar.Text = null;
            }
            else
            {
                lbl_gunsayisi.Text = gun.ToString();
                int faturatutari = gun * Convert.ToInt32(lbl_faturatutar.Text);
                lbl_faturatutar.Text = faturatutari.ToString();
            }
        }
    }
}   