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

namespace WindowsFormsApp2
{
    public partial class frmOtelEkle : Form
    {
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
    }
}
