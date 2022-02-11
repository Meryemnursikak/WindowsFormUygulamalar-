using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18._01._2022_WindowsFormUygulama
{
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //combo ile dolduruyoruz
            //comboboxdoldur();
            //lisbox ile dolduruyoruz
            listboxdoldur();
            checkedlistedoldur();
        }

        private void checkedlistedoldur()
        {
            foreach (var item in SanalDatabase.urunler)
            {
                chkliste.Items.Add(item);
            }
        }

        private void listboxdoldur()
        {
            //listboxda görünmesini istediğim field buraya da yazabiliriz listboxa ait özellik.
            lsturunler.DisplayMember = "urunAdi";
            lsturunler.DataSource = SanalDatabase.urunler;
        }

        //private void comboboxdoldur()
        //{
        //    foreach (var item in SanalDatabase.urunler)
        //    {
        //        cmburunler.Items.Add(item);
        //    }
        //}

        private void cmburunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////tip belirttik ve combo da seçilen ürünü işaret ettik
            //Urun urun = (Urun)cmburunler.SelectedItem;

            ////TextBox içerisine sanaldatabase deki ürünleri attık.
            //txturunad.Text = urun.urunAdi;
            //txtkategori.Text = urun.urunKategori;
            //txtstok.Text = urun.stokAdet.ToString();
            //txtyazar.Text = urun.Yazar;
            //rchaciklama.Text = urun.aciklama;

            //pcbResim.Image = Image.FromFile(urun.urunResim);
            //pcbResim.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lsturunler_SelectedIndexChanged(object sender, EventArgs e)
        {

            //tip belirttik ve combo da seçilen ürünü işaret ettik
            

            //listedeki selected ıtemları al secim bir ise bir ürün alıcak değil ise yeni ekranı açacak
            int secim = lsturunler.SelectedItems.Count;
            if(secim==1)
            {
                Urun urun = (Urun)lsturunler.SelectedItem;
                //TextBox içerisine sanaldatabase deki ürünleri attık.
                txturunad.Text = urun.urunAdi;
                txtkategori.Text = urun.urunKategori;
                txtstok.Text = urun.stokAdet.ToString();
                txtyazar.Text = urun.Yazar;
                rchaciklama.Text = urun.aciklama;

                pcbResim.Image = Image.FromFile(urun.urunResim);
                pcbResim.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (secim>1)
            {
                List<Urun> secilenliste = new List<Urun>();

                foreach (Urun item in lsturunler.SelectedItems)
                {
                    secilenliste.Add(item);
                }

                secimekrani ekran = new secimekrani(secilenliste);
                ekran.ShowDialog();
            }

        }

        private void chkliste_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkliste_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //yeni değeri seçilmişse
            if(e.NewValue == CheckState.Checked)
            {
                //listenin o indexteki itemsi
                Urun urun = (Urun)chkliste.Items[e.Index];
                txtkategori.Text = urun.urunKategori;
                txturunad.Text = urun.urunAdi;
                txtstok.Text = urun.stokAdet.ToString();
                txtyazar.Text = urun.Yazar;
                rchaciklama.Text = urun.aciklama;
                pcbResim.Image = Image.FromFile(urun.urunResim);
            }
        }
    }
}
