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
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class frmOtelListesi : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        public string kid;
        public int id;
        public string ImageBase64;
        ProjectContext db = new ProjectContext();

        public frmOtelListesi()
        {
            InitializeComponent();
        }
        
        void verigetir()
        {
            baglanti = new SqlConnection("Server=.;Initial Catalog=ALog;Integrated Security=SSPI");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT *FROM Otellers",baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dgv_OtelerListesi.DataSource = tablo;
            baglanti.Close();
        }

        private void frmOtelListesi_Load(object sender, EventArgs e)
        {
            verigetir();
            dgv_OtelerListesi.DataSource = db.Otellers.ToList();
            dgv_OtelerListesi.Columns[7].Visible = false;//resim
            dgv_OtelerListesi.Columns[8].Visible = false; //ID
            dgv_OtelerListesi.Columns[9].Visible = false; //adddate
            dgv_OtelerListesi.Columns[10].Visible = false; //uptatedate
            dgv_OtelerListesi.Columns[11].Visible = false; //deletedate
            dgv_OtelerListesi.Columns[12].Visible = false; //aktifmi
           
        }

        private void dgv_OtelerListesi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmOtelDetay frmOtelDetay = new frmOtelDetay();
            frmOtelDetay.kid = kid;
            id = int.Parse(dgv_OtelerListesi.CurrentRow.Cells[8].Value.ToString());
            ImageBase64 = db.Otellers.Where(a => a.ID == id).First().ImageUrl.ToString();
            frmOtelDetay.id = id;
            frmOtelDetay.base64Image = ImageBase64;
            frmOtelDetay.Show();
        }
    }
}
