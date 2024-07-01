using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmYoneticiPanel : Form
    {
        public frmYoneticiPanel()
        {
            InitializeComponent();
        }

        private void ts_btn_otelekle_Click(object sender, EventArgs e)
        {
            frmOtelEkle aracEkle = new frmOtelEkle();
            aracEkle.Show();
        }

        private void ts_lbl_otelekle_Click(object sender, EventArgs e)
        {
            frmOtelEkle aracEkle = new frmOtelEkle();
            aracEkle.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmOtelEkle frmOtelEkle = new frmOtelEkle();
            frmOtelEkle.Show();
        }
    }
}
