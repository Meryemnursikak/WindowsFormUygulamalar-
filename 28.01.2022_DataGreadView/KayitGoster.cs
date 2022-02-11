using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28._01._2022_DataGreadView
{
    public partial class KayitGoster : Form
    {
        Musteri data;
        public KayitGoster(Musteri musteri)
        {
            InitializeComponent();
            data = musteri;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void KayitGoster_Load(object sender, EventArgs e)
        {
            txtisimi.Text = data.isim;
            txtsoyisimi.Text = data.soyisim;
            txttamadii.Text = data.tamAdi;
            txtemaili.Text = data.email;
            txttelnoi.Text = data.telno;
            txtililce.Text = $"{data.il}/{data.ilce}";
            txtadresi.Text = data.adres;
        }
    }
}
