using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullaniciEkrani_13._01._2022
{
    public partial class Kullaniciform : Form
    {
        private int index;

        public Kullaniciform(Kullanici kullanici)
        {

            InitializeComponent();
            txtisim.Text = kullanici.isim;
            txtsoyisim.Text = kullanici.soyisim;

            //kullanıcı adınının enabled ini false yaparsak kullanıcı adını değiştiremez.
            txtkuladi_.Text = kullanici.kullaniciAdi;
            txtkuladi_.Enabled = false;

            txtsifre2.Text = kullanici.sifre;
            txtaciklama.Text = kullanici.aciklama;
            btnguncelle.Tag = kullanici.id;
        }

        private void Kullaniciform_Load(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            DialogResult cevap=
            MessageBox.Show("Güncellemek istedğinizden emin misiniz?", "Soru", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {

            //object veriyi tür dönüşümü yaptık.int oldu.
            int sayi = (int)btnguncelle.Tag;
            
            //sanaldatabase class içinde kullanıcılar listesinde indexlere bak.id si sayıya eşit olanı güncelle.
            SanalDatabase.Kullanicilar.FindIndex(i => i.id == sayi);

            SanalDatabase.Kullanicilar[index].isim = txtisim.Text;
            SanalDatabase.Kullanicilar[index].soyisim = txtsoyisim.Text;
            SanalDatabase.Kullanicilar[index].sifre = txtsifre2.Text;
            SanalDatabase.Kullanicilar[index].aciklama = txtaciklama.Text;

            }
        }
    }
}
