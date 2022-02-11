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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string kulad = txtkulad.Text;
            string sifre = txtsifre.Text;

            //arama fonksiyonu find: => her demek
            Kullanici kullanici = SanalDatabase.Kullanicilar.Find(i => i.kullaniciAdi == kulad && i.sifre == sifre);

            if (kullanici != null)
            {
                Kullaniciform kform = new Kullaniciform(kullanici);
                kform.ShowDialog(); //açılan ekran kapanmadan diğer ekrana müdahale edemem.
                //kform.Show(); ekran açılır fakat diğer ekranlara giriş yapablirim.

            }
            else
            {
                MessageBox.Show("Yanlış bilgi girdiniz lütfen tekrar deneyiniz..","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtkulad_Enter(object sender, EventArgs e)
        {
            //1.yöntem sadece bir textbox için geçerli olur
            //txtkulad.BackColor = Color.OrangeRed;

            //diğer yöntem bütün textboxlar için geçerli olsun diye yazılan kod
            TextBox t1 = (TextBox)sender;
            t1.BackColor = Color.Gray;
        }

        private void txtkulad_Leave(object sender, EventArgs e)
        {
            //1.yontem sadece bir textbox için geçerli olur
            //txtkulad.BackColor = Color.White;

            TextBox t1 = (TextBox)sender;
            t1.BackColor = Color.White;
        }
    }
}
