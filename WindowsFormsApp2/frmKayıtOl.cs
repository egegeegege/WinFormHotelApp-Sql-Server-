using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.ORM.Context;
using WindowsFormsApp2.ORM.Entity;

namespace WindowsFormsApp2
{
    public partial class frmKayıtOl : Form
    {
        ProjectContext DataBase = new ProjectContext();
        public frmKayıtOl()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmGirisyap frmGirisyap = new frmGirisyap();
            frmGirisyap.Show();
            this.Hide();
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            List<Yoneticiler> ynt = new List<Yoneticiler>();
            ynt = DataBase.Yoneticilers.ToList();
            bool kullanıcıVar = false;
            foreach (var yönetici in ynt)
            {
                if (yönetici.TelefonNo == txt_telefonNo.Text)
                {
                    kullanıcıVar = true;
                }
            }

            if (kullanıcıVar)
            {
                MessageBox.Show("bu Telefon Numarasına sahip bir kullanıcı zaten var");
            }
            else
            {
                Yoneticiler y = new Yoneticiler()
                {
                    Ad = txt_ad.Text,
                    Soyad = txt_soyad.Text,
                    Email = txt_email.Text,
                    TelefonNo = txt_telefonNo.Text,
                    Sifre = txt_sifre.Text,
                    Aktifmi = true,
                }; 

                DataBase.Yoneticilers.Add(y);
                DataBase.SaveChanges();
                MessageBox.Show("Kayıt Oluşturuldu");
                frmGirisyap frmGirisyap = new frmGirisyap();
                frmGirisyap.Show();
                this.Hide();
                
            }
        }

        private void Cb_Created_CheckedChanged(object sender, EventArgs e)
        {
            txt_sifre.PasswordChar = Cb_Created.Checked ? '\0' : '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

		private void label8_Click(object sender, EventArgs e)
		{

		}
	}
}
