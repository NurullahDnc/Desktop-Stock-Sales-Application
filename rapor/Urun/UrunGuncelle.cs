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
    public partial class UrunGuncelle : Form
    {
        public UrunGuncelle()
        {
            InitializeComponent();
        }

        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-C6HUCTV\\SQLEXPRESS;Initial Catalog=E-Ticaret-I;Integrated Security=True");
        private void ÜrünGuncelle_Load(object sender, EventArgs e)
        {
            Listele();


            //Combox veri cekme
            SqlCommand komut = new SqlCommand("SELECT * FROM Kategori,Marka ", bag);
            SqlDataReader dr;
            bag.Open();
            dr = komut.ExecuteReader();

            while (dr.Read())
            {
                CbKategoriAdi.Items.Add(dr["KategoriAdi"]);
                CbMarkaAdi.Items.Add(dr["MarkaAdi"]);

            }
            bag.Close();

        }

        private void Listele()
        {//datagridview veri cekme
            string sorgu = ("select DISTINCT Urun.UrunId, UrunKodu, Kategori.KategoriAdi, AltKategori.AltKategoriAdi, Marka.MarkaAdi, Urun.UrunAdi, Urun.UrunFiyati,UrunStok, Urun.UrunAcıklama, UrunRenk.RenkAdi, UrunBeden.BedenNo, UrunMateryal.MateryalAdi, UrunTarih from Urun, Kategori, AltKategori, Marka, UrunOzelik, UrunBeden, UrunRenk, UrunMateryal where Urun.UrunId =UrunOzelik.UrunId and UrunRenk.RenkId = UrunOzelik.RenkId and  UrunBeden.BedenId = UrunOzelik.UrunOzelikId and UrunMateryal.MateryalId=UrunOzelik.MateryalId   and Kategori.KategoriId = Urun.KategoriId and AltKategori.AltKategoriId = Urun.AltKategoriId  and  Urun.MarkaId = Marka.MarkaId");
            SqlDataAdapter adtr = new SqlDataAdapter(sorgu, bag);
            DataTable table = new DataTable();
            adtr.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void BtnGuncelle_Click_1(object sender, EventArgs e)
        {
            //guncelleme
            string sorgula = ("UPDATE Urun Set KategoriId=@KategoriId, AltKategoriId=@AltKategoriId, MarkaId=@MarkaId,  UrunAdi=@UrunAdi, UrunFiyati=@UrunFiyati, UrunStok=@UrunStok, UrunAcıklama=@UrunAcıklama WHERE UrunKodu=@UrunKodu");
            SqlCommand cmd = new SqlCommand(sorgula, bag);
            cmd.Parameters.AddWithValue("UrunKodu", TbUrunKodu.Text);

            cmd.Parameters.AddWithValue("KategoriId", CbKategoriAdi.Text);
            cmd.Parameters.AddWithValue("AltKategoriId", CbAltKategoriAdi.Text);
            cmd.Parameters.AddWithValue("MarkaId", CbMarkaAdi.Text);
            cmd.Parameters.AddWithValue("UrunAdi", TbUrunAdi.Text);
            cmd.Parameters.AddWithValue("UrunFiyati", TbFiyati.Text);
            cmd.Parameters.AddWithValue("UrunStok", TbStokAdeti.Text);
            cmd.Parameters.AddWithValue("UrunAcıklama", TbUrunAcıklama.Text);

            bag.Open();
            cmd.ExecuteNonQuery();
            Listele();
            //Mesaj
            LblMesaj.Text = "Başarılı Şekilde Ürün Guncellenmistir";
            LblMesaj.ForeColor = Color.Green;

            //Temizleme
            CbKategoriAdi.ResetText();
            CbMarkaAdi.ResetText();
            TbUrunKodu.Clear();
            TbUrunAdi.Clear();
            TbFiyati.Clear();
            TbStokAdeti.Clear();
            TbUrunAcıklama.Clear();
            DateKayıtTarihi.ResetText();
            bag.Close();


            //combobox verileri cek !!!
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {//datagrid deki verileri tablolara cekme 
            CbKategoriAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            CbAltKategoriAdi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            CbMarkaAdi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            TbUrunKodu.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            TbUrunAdi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            TbFiyati.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            TbStokAdeti.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            TbUrunAcıklama.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
   

        }
        private void BtnTemizle_Click_1(object sender, EventArgs e)
        {
            CbKategoriAdi.ResetText();
            CbMarkaAdi.ResetText();
            TbUrunKodu.Clear();
            TbUrunAdi.Clear();
            TbFiyati.Clear();
            TbStokAdeti.Clear();
            TbUrunAcıklama.Clear();
            DateKayıtTarihi.ResetText();
        }

        private void BtnCıkış_Click(object sender, EventArgs e)
        {
            Close();
        }

      
    }
}
