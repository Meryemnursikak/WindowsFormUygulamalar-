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
    public partial class secimekrani : Form
    {
        List<Urun> urunler;
        public secimekrani(List<Urun> liste)
        {
            InitializeComponent();
            urunler = liste;
        }

  

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void secimekrani_Load(object sender, EventArgs e)
        {
            foreach (var item in urunler)
            {
                Button btn = new Button();
                btn.Text = item.urunAdi;
                btn.Name = "btn" + item.id.ToString();
                btn.Tag = item;
                btn.Size = new System.Drawing.Size(300, 30);
                btn.Click += Btn_Click;
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            //butona tıklayınca diğer forma erişmek için 
            Button btn = sender as Button;
            Form f1 = Application.OpenForms["Form1"];
            f1.Controls["grpbox1"].Controls["txturunAd"].Text = ((Urun)btn.Tag).urunAdi;
            f1.Controls["grpbox1"].Controls["txturunAd"].Text = ((Urun)btn.Tag).urunKategori;
            f1.Controls["grpbox1"].Controls["txturunAd"].Text = ((Urun)btn.Tag).aciklama;
            f1.Controls["grpbox1"].Controls["txturunAd"].Text = ((Urun)btn.Tag).stokAdet.ToString();
            f1.Controls["grpbox1"].Controls["txturunAd"].Text = ((Urun)btn.Tag).Yazar;
            PictureBox p = ((PictureBox)(f1.Controls["grpbox1"]).Controls["pcbResim"]);
            p.Image=Image.FromFile(((Urun)btn.Tag).urunResim);

            this.Close();
        }
    }
}
