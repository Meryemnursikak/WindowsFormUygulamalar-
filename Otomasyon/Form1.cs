using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rdbince_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nudadet_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listsepet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbebat_SelectedIndexChanged(object sender, EventArgs e)
        {
   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ebat kucuk = new Ebat()
            { Adi = "Küçük", Carpan = 1 };
            cmbebat.Items.Add(kucuk);

            Ebat orta = new Ebat()
            { Adi = "Orta", Carpan = 1.5m };
            cmbebat.Items.Add(orta);

            Ebat buyuk = new Ebat()
            { Adi = "Büyük", Carpan = 2 };
            cmbebat.Items.Add(buyuk);

            Pizza klasik = new Pizza()
            { Adi = "Klasik", Fiyat = 20 };

            lstpizzalar.Items.Add(klasik);

            Pizza karisik = new Pizza()
            { Adi = "Karışık", Fiyat = 25 };

            lstpizzalar.Items.Add(karisik);

            Pizza vejeteryan = new Pizza()
            { Adi = "Vejeteryan", Fiyat = 15 };

            lstpizzalar.Items.Add(vejeteryan);

            KenarTipi ince = new KenarTipi()
            { Adi = "İnce Kenar", EkFiyat = 0 };
            rdbince.Tag = ince;

            KenarTipi kalin = new KenarTipi()
            { Adi = "Kalın Kenar", EkFiyat = 3 };
            rdbkalin.Tag = kalin;


        }

        private void txttutar_TextChanged(object sender, EventArgs e)
        {

        }

        Siparis siparis;
        private void btnhesapla_Click(object sender, EventArgs e)
        {
            
            Pizza p = (Pizza)lstpizzalar.SelectedItem;
            p.Ebati = (Ebat)cmbebat.SelectedItem;

            //böyle de yazılabilir.
            //if (rdbince.Checked)
            //{
            //    p.Kenartip = (KenarTipi)rdbince.Tag;
            //}
            //else
            //    p.Kenartip = (KenarTipi)rdbkalin.Tag;


            //if else diğer kullanımı ? if demek : else demek.. Eğer rdbince tagi seçiliyse onu hesapla değilse kalına git.
            p.Kenartip = rdbince.Checked ? (KenarTipi)rdbince.Tag : (KenarTipi)rdbkalin.Tag;

            p.Malzemeler = new List<string>();
            foreach (CheckBox item in groupBox1.Controls) //groupBox1 in her bir kontrolleri checbox
            {
                if (item.Checked)
                    p.Malzemeler.Add(item.Text);
            }

            //decimal tutar = ((p.Ebati.Carpan) * (p.Fiyat)) + p.Kenartip.EkFiyat;
            decimal tutar = (decimal)(p.Tutar * (decimal)(nudadet.Value));
            txttutar.Text = tutar.ToString();


            siparis = new Siparis();
            siparis.Pizza = p;
            siparis.Adet = (int)nudadet.Value;


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnsepet_Click(object sender, EventArgs e)
        {
            if(siparis!=null)
              listsepet.Items.Add(siparis);
        }
    }
}
