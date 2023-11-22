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

namespace rapor
{
    public partial class Satis : Form
    {
        public Satis()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-C6HUCTV\\SQLEXPRESS;Initial Catalog=E-Ticaret-I;Integrated Security=True");

        private void Satiş_Load(object sender, EventArgs e)
        {
           

            Listele();
            SqlCommand komut2 = new SqlCommand("SELECT * FROM Urun ", bag);
            SqlDataReader dr2;
            bag.Open();
            dr2 = komut2.ExecuteReader();
            CbÜrünAdi.Items.Clear();
            while (dr2.Read())
            {
               
                CbÜrünAdi.Items.Add(dr2["UrunAdi"]);
            }
            bag.Close();



        }

        private void Listele()
        {//sepet datagridviev veri cekme 
            //string sorgu = ("SELECT * FROM SepetEklenenler");
            //SqlDataAdapter adtr = new SqlDataAdapter(sorgu, bag);
            //DataTable table = new DataTable();
            //adtr.Fill(table);
            //DataGridSepet.DataSource = table;


         //siparis datagridviex veri cekme
            string sorgu1 = ("SELECT * FROM Urun");
            SqlDataAdapter adtr1 = new SqlDataAdapter(sorgu1, bag);
            DataTable table1 = new DataTable();
            adtr1.Fill(table1);
            dataGridView1.DataSource = table1;

        }

        private void BtnSepeteEkle_Click(object sender, EventArgs e)
        {

      



        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        // Kategoriler.KategoriAdi, Markalar.MarkaAdi, Ürünler.ÜrünAdi VALUES @KategoriAdi, @MarkaAdi, @ÜrünAdi
    }
}
