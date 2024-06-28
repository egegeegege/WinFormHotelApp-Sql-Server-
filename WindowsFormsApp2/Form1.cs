using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void Form1_load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 30; // Adjust the value to change the roundness of the corners
                             // Create a rounded rectangle path using the form's size and radius
            path.AddArc(0, 0, radius, radius, 180, 90); // Top-left corner
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90); // Top-right corner
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90); // Bottom-right corner
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90); // Bottom-left corner I
            // Create a region with the rounded rectangle path and apply it to the form
            this.Region = new Region(path);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

            if (txt_username.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("lütfen bilgileri boş girmeyiniz");
            }
            else 
            {
                if (txt_username.Text == "Ege" && txt_password.Text == "ege200842")
                {
                    MessageBox.Show($"Hoşgeldiniz {username} bey sisteme başarıyla giriş yaptınız");
                }
                else 
                {
                    MessageBox.Show("lütfen bilgilerinizi doğru giriniz");
                }
            }
        }

        {

        }
    }
}
