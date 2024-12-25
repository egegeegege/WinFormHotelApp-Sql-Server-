using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Policy;
using System.Windows.Forms;
using WindowsFormsApp2.ORM.Context;
using WindowsFormsApp2.ORM.Entity;

namespace WindowsFormsApp2
{
    public partial class frmGirisyap : Form
    {
        ProjectContext DataBase = new ProjectContext();
        string Ad = "";
        string Sifre = "";
        int id;

        public frmGirisyap()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }


        public void btn_login_Click(object sender, EventArgs e)
        {
			if (string.IsNullOrWhiteSpace(txt_ad.Text) || string.IsNullOrWhiteSpace(txt_sifre.Text))
			{
				MessageBox.Show("Lütfen boş alan bırakmayınız!");
				return; // İşlemi sonlandır
			}

			List<Yoneticiler> ynt = new List<Yoneticiler>();
            ynt = DataBase.Yoneticilers.Where(y => y.Ad == txt_ad.Text).ToList();
            string ad = txt_ad.Text;
            foreach (Yoneticiler y in ynt)
            {
                Ad = y.Ad.ToString();
                Sifre = y.Sifre.ToString();
                id = y.ID;
            }

            if (Ad == txt_ad.Text)
            {
                if (Sifre == txt_sifre.Text)
                {
                    MessageBox.Show($"Hoşgeldin {ad}");
                    frmYoneticiPanel frmYoneticiPanel = new frmYoneticiPanel();
                    frmYoneticiPanel.kid = id.ToString();
                    frmYoneticiPanel.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Şifre Hatalı");
                }
            }
            else
            {
                MessageBox.Show("Ad Hatalı");
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_sifre.PasswordChar = Cb_Created.Checked ? '\0' : '*';
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmKayıtOl frmKayıtOl = new frmKayıtOl();
            frmKayıtOl.Show();
            this.Hide();
        }
    }
}
