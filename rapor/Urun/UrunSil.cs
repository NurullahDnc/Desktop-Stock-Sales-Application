using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rapor.Ürünler
{
    public partial class UrunSil : Form
    {
        public UrunSil()
        {
            InitializeComponent();
        }

        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-C6HUCTV\\SQLEXPRESS;Initial Catalog=E-Ticaret-I;Integrated Security=True");

        private void ÜrünSil_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {//veri cekme
            string sorgu = ("SELECT * FROM Urun");
            SqlDataAdapter adtr = new SqlDataAdapter(sorgu, bag);
            DataTable table = new DataTable();
            adtr.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {//ürürn sil
            if (TbUrunKodu.Text.Length>0)
            {

                string sorgu = ("DELETE  FROM Urun WHERE UrunKodu=@UrunKodu");
                SqlCommand cmd = new SqlCommand(sorgu, bag);
                cmd.Parameters.AddWithValue("UrunKodu", TbUrunKodu.Text);
                bag.Open();
                cmd.ExecuteNonQuery();
                Listele();
                LblMesaj.Text = "Başarılı Sekilde Ürün Silinmistir.";
                LblMesaj.ForeColor = Color.Green;
                bag.Close();
                //
                TbUrunKodu.Clear();
            }
            else
            {
                LblMesaj.Text = "Lütfen Ürün Kodunu Giriniz.";
                LblMesaj.ForeColor = Color.Red; 
            }
         
              
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TbUrunKodu.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TbUrunKodu.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void BtnCıkış_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
