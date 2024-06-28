using System;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        private void Form_Load(object sender, EventArgs e)
        {
            // Yuvarlak köşeler için bir GraphicsPath oluşturun
            GraphicsPath path = new GraphicsPath();
            int radius = 30; // Köşe yarıçapı
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);

            // Sol üst köşe
            path.AddArc(new Rectangle(Point.Empty, size), 180, 90);
            // Sağ üst köşe
            path.AddArc(new Rectangle(new Point(this.Width - diameter, 0), size), 270, 90);
            // Sağ alt köşe
            path.AddArc(new Rectangle(new Point(this.Width - diameter, this.Height - diameter), size), 0, 90);
            // Sol alt köşe
            path.AddArc(new Rectangle(new Point(0, this.Height - diameter), size), 90, 90);

            // Kapalı bir yol oluşturmak için çizgiyi ekleyin
            path.CloseFigure();
            this.Region = new Region(path);

            // Çizim için Paint olayını ele alın
            this.Paint += new PaintEventHandler(this.Form_Paint);
        }

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            // Sınırı çiz
            int borderWidth = 0;
            Color borderColor = Color.Black;
            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            }
        }
        public void btn_login_Click(object sender, EventArgs e)
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
                    form2 form2 = new form2();
                    form2.Show();
                    this.Hide();
                }
                else 
                {
                    MessageBox.Show("lütfen bilgilerinizi doğru giriniz");
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_password.PasswordChar = Cb_Created.Checked ? '\0' : '*';
        }
    }
}
