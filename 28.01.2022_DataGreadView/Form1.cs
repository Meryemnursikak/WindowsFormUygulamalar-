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
    public partial class Form1 : Form
    {
        Database db;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           db = new Database();

            //string isim = FakeData.NameData.GetFirstName();
            //string soyisim = FakeData.NameData.GetSurname();
            //MessageBox.Show(isim + " " + soyisim);


            List<Musteri> liste = db.musterilistele();
            dataGridView1.DataSource = liste;


            //müşteri id si görünmesin istersek visible false yaparız.
            //dataGridView1.Columns["id"].Visible = false;

            dataGridView1.Columns[0].HeaderText = "Müşteri ID";
            dataGridView1.Columns[1].HeaderText = "Müşteri İsim";
            dataGridView1.Columns[2].HeaderText = "Müşteri Soyisim";
            dataGridView1.Columns[3].HeaderText = "Tam İsim";
            dataGridView1.Columns[4].HeaderText = "Email";
            dataGridView1.Columns[5].HeaderText = "Telefon Numarası";
            dataGridView1.Columns[6].HeaderText = "İl";
            dataGridView1.Columns[7].HeaderText = "İlçe";
            dataGridView1.Columns[8].HeaderText = "Adres";

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int mid = (int)dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value;
            
            Musteri m;
            m = db.musterilistesi.FindAll(i => i.id == mid).FirstOrDefault();
            KayitGoster kform = new KayitGoster(m);
            kform.Show();
        }
    }
}
