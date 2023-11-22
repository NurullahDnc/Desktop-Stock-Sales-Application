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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace rapor
{
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }

        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-C6HUCTV\\SQLEXPRESS;Initial Catalog=E-Ticaret-I;Integrated Security=True");

        private void Ürün_Load(object sender, EventArgs e)
        {
            Listele();


            //Combox veri cekme
            SqlCommand komut = new SqlCommand("SELECT * FROM Kategori", bag);
            SqlDataReader dr;
            bag.Open();
            dr = komut.ExecuteReader();

            while (dr.Read())
            {
                CbKategoriAdi.Items.Add(dr["KategoriAdi"]);

            }
            bag.Close();

            SqlCommand komut3 = new SqlCommand("SELECT * FROM AltKategori", bag);
            SqlDataReader dr3;
            bag.Open();
            dr3 = komut3.ExecuteReader();

            while (dr3.Read())
            {
                CbAltKategoriAdi.Items.Add(dr3["AltKategoriAdi"]);

            }
            bag.Close();

            SqlCommand komut2 = new SqlCommand("SELECT * FROM Marka ", bag);
            SqlDataReader dr2;
            bag.Open();
            dr2 = komut2.ExecuteReader();

            while (dr2.Read())
            {
                CbMarkaAdi.Items.Add(dr2["MarkaAdi"]);

            }
            bag.Close();

        }

        private void Listele()
        {
            //dataGridView1 veri cekme
            string sorgu = ("select DISTINCT Urun.UrunId, UrunKodu, Kategori.KategoriAdi, AltKategori.AltKategoriAdi, Marka.MarkaAdi, Urun.UrunAdi, Urun.UrunFiyati,UrunStok, Urun.UrunAcıklama, UrunRenk.RenkAdi, UrunBeden.BedenNo, UrunMateryal.MateryalAdi, UrunTarih from Urun, Kategori, AltKategori, Marka, UrunOzelik, UrunBeden, UrunRenk, UrunMateryal where Urun.UrunId =UrunOzelik.UrunId and UrunRenk.RenkId = UrunOzelik.RenkId and  UrunBeden.BedenId = UrunOzelik.UrunOzelikId and UrunMateryal.MateryalId=UrunOzelik.MateryalId   and Kategori.KategoriId = Urun.KategoriId and AltKategori.AltKategoriId = Urun.AltKategoriId  and  Urun.MarkaId = Marka.MarkaId"); SqlDataAdapter adtr = new SqlDataAdapter(sorgu, bag);
            DataTable table = new DataTable();
            adtr.Fill(table);
            dataGridView1.DataSource = table;
        }


        private void BtnKaydet_Click(object sender, EventArgs e)
        {//Ürün ekleme

            if (TbUrunKodu.Text.Length > 0)
            {

                String sorgu = "insert into urun(KategoriId, AltKategoriId, MarkaId, UrunKodu, UrunAdi, UrunFiyati, UrunStok, UrunAcıklama, UrunTarih) values(@KategoriId, @AltKategoriId, @MarkaId, @UrunKodu, @UrunAdi, @UrunFiyat, @UrunStok, @UrunAcıklama, @UrunTarih)";
                SqlCommand cmd = new SqlCommand(sorgu, bag);
                cmd.Parameters.AddWithValue("@KategoriId", CbKategoriAdi.SelectedText);
                cmd.Parameters.AddWithValue("@AltKategoriId", CbKategoriAdi.SelectedText);
                cmd.Parameters.AddWithValue("@MarkaId", CbMarkaAdi.SelectedText);
                cmd.Parameters.AddWithValue("@UrunKodu", TbUrunKodu.Text);
                cmd.Parameters.AddWithValue("@UrunAdi", TbUrunAdi.Text);
                cmd.Parameters.AddWithValue("@UrunFiyat", TbFiyati.Text);
                cmd.Parameters.AddWithValue("@UrunStok", TbStokAdeti.Text);
                cmd.Parameters.AddWithValue("@UrunAcıklama", TbUrunAcıklama.Text);
                cmd.Parameters.AddWithValue("@UrunTarih", DateKayıtTarihi.Value);
                bag.Open();
                cmd.ExecuteNonQuery();
                Listele();
                //Mesaj
                LblMesaj.Text = "Başarılı seklide ürün eklenmistir";
                LblMesaj.ForeColor = Color.Green;

                //eklem sonrası tb leri temizleme
                CbKategoriAdi.ResetText();
                CbMarkaAdi.ResetText();
                TbUrunKodu.Clear();
                TbUrunAdi.Clear();
                TbFiyati.Clear();
                TbStokAdeti.Clear();
                TbUrunAcıklama.Clear();
                DateKayıtTarihi.ResetText();

            }
            else
            {
                LblMesaj.Text = "Kayıt yapmak icin deger giriniz";
                LblMesaj.ForeColor = Color.Red;
            }


        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {//Tabloları temizle
            CbKategoriAdi.ResetText();
            CbMarkaAdi.ResetText();
            TbUrunKodu.Clear();
            TbUrunAdi.Clear();
            TbUrunAcıklama.Clear();
            TbFiyati.Clear();
            DateKayıtTarihi.ResetText();
            TbStokAdeti.Clear();
        }

        private void BtnCıkış_Click(object sender, EventArgs e)
        {//Cıkıs
            Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
