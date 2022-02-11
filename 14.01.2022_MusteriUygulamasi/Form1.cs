using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14._01._2022_MusteriUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lstmusteriler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            
            //nesneyi doldurduk butonlara girilen verilerle
            SanalDatabase.db.Add(new Musteri()
            { 
                Id=1,
                isim=txtisim.Text,
                soyisim=txtsoyisim.Text,
                email=txtemail.Text,
                telefon=txttel.Text
            });

            ekrandalistele();
            ekranitemizle(this.Controls);
            
        }

        private void ekranitemizle(Control.ControlCollection kontrol)
        {
            //birden fazla textbox olursa bu şekilde yazarız temizlemek için
            foreach (Control item in kontrol)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
                else
                {
                    ekranitemizle(item.Controls);
                }
            }

            //TextBox t1= ((TextBox)this.Controls["txtisim"]);

            txtisim.Text = string.Empty;
            txtsoyisim.Text = string.Empty;
            txtemail.Text = string.Empty;
            txttel.Text = string.Empty;
        }

        private void ekrandalistele()
        {

            lstmusteriler.Items.Add(txtisim.Text);

            //aşağıda yazılan datasource neden sonuç vermedi.
            //tostring metodu çalıştığı için override ettik
            //lstmusteriler.DataSource = SanalDatabase.db;
        }

        private void txtisim_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bildirim_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void btnonizleme_click(object sender, EventArgs e)
        {
            btnonizleme onizleme = new onizleme();
     
        }
    }
}
