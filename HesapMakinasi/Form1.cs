using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinasi
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       
        

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txsayi1.Text);
            int sayi2 = Convert.ToInt32(txtsayi2.Text);
            sonuc = sayi1 - sayi2;
            txtsonuc.Text = sonuc.ToString();
        }

        private void txsayi1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

            txsayi1.Text = string.Empty;
            txtsayi2.Text = string.Empty;
            txtsonuc.Text = string.Empty;

        }

        public int sayi1 = 0;
        public int sayi2 = 0;
        public int sonuc = 0;

        private void button1_Click(object sender, EventArgs e)
        {

        int sayi1 = Convert.ToInt32(txsayi1.Text);
        int sayi2 = Convert.ToInt32(txtsayi2.Text);
        sonuc = sayi1 + sayi2;
        txtsonuc.Text = sonuc.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txsayi1.Text);
            int sayi2 = Convert.ToInt32(txtsayi2.Text);
            sonuc = sayi1 * sayi2;
            txtsonuc.Text = sonuc.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txsayi1.Text);
            int sayi2 = Convert.ToInt32(txtsayi2.Text);
            sonuc = sayi1/sayi2;
            txtsonuc.Text = sonuc.ToString();
        }
    }
}
