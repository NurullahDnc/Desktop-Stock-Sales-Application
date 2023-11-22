using rapor.Kullanıcı;
using rapor.Müşteriler;
using rapor.Ürünler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rapor
{
    public partial class AnaSayfa : Form
    {

        public AnaSayfa()
        {
            InitializeComponent();
        }
        //Müşteriler
        private void müsteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriEkle form = new MusteriEkle();
            form.ShowDialog();
        }

        private void müşteriGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriGuncelle form = new MusteriGuncelle();
            form.ShowDialog();
        }

        private void müşteriSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriSil form = new MusteriSil();
            form.ShowDialog();

        }

        private void ürünEkleGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunEkle from = new UrunEkle();
            from.ShowDialog();
        }
        //Müşteriler
        //Ürünler
        private void ürürnGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunGuncelle form = new UrunGuncelle();
            form.ShowDialog();
        }

        private void ürünSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunSil from = new UrunSil();
            from.ShowDialog();
        }
        //Ürünler
        private void sepetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Satis from = new Satis();
            from.ShowDialog();
        }

        private void kategoriEleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kategoriİslemleri from = new Kategoriİslemleri();
            from.ShowDialog();
        }      

   

        private void cıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniKulanıcı form = new YeniKulanıcı();
            form.ShowDialog();
            
            
        }

        private void denemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
