using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayınTarlası
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            //
            Random rnd = new Random();
            int mayin1 = rnd.Next(1, 15);
            int mayin2 = rnd.Next(16, 35);
            int mayin3 = rnd.Next(36, 50);

            for (int i = 1; i < 51; i++)
            {
                Button btn = new Button();
                btn.Name = "btn" + i.ToString();
                btn.Size = new System.Drawing.Size(40, 40);
                btn.Text = i.ToString();
                btn.UseVisualStyleBackColor = true;

                /*btn.Tag = null;*/ //tag üzerinden basılan butonu tutarız.
                if (i == mayin1 || i == mayin2 || i == mayin3)
                {
                    btn.Tag = true;
                }
                else
                    btn.Tag = false;

                btn.Click += btn_Click; //butonun clik eventini çalıştırmasını sağlayacak.

                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button basilanbuton = (Button)sender;
            bool mayin = (bool)basilanbuton.Tag;


            if (mayin)
            {
                basilanbuton.BackColor = Color.Red;
                int maysayi = int.Parse(lblm.Text);
                maysayi++;
                lblm.Text = maysayi.ToString(); //mayın sayısını stringe dönüştürdük.
            }
            else
            {
                basilanbuton.BackColor = Color.Green;
                int secilensayi = int.Parse(lbls.Text);
                secilensayi++;
                lbls.Text = secilensayi.ToString();
            }
        }

        private void form_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
