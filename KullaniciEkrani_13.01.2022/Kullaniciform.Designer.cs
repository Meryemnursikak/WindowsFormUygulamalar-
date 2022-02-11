
namespace KullaniciEkrani_13._01._2022
{
    partial class Kullaniciform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtkuladi_ = new System.Windows.Forms.TextBox();
            this.txtsifre2 = new System.Windows.Forms.TextBox();
            this.txtaciklama = new System.Windows.Forms.TextBox();
            this.txtisim = new System.Windows.Forms.TextBox();
            this.txtsoyisim = new System.Windows.Forms.TextBox();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyisim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kullanıcı Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(489, 152);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Şifre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 272);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Açıklama";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtkuladi_
            // 
            this.txtkuladi_.Location = new System.Drawing.Point(596, 74);
            this.txtkuladi_.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtkuladi_.Multiline = true;
            this.txtkuladi_.Name = "txtkuladi_";
            this.txtkuladi_.Size = new System.Drawing.Size(202, 43);
            this.txtkuladi_.TabIndex = 9;
            // 
            // txtsifre2
            // 
            this.txtsifre2.Location = new System.Drawing.Point(596, 149);
            this.txtsifre2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsifre2.Multiline = true;
            this.txtsifre2.Name = "txtsifre2";
            this.txtsifre2.Size = new System.Drawing.Size(202, 43);
            this.txtsifre2.TabIndex = 10;
            // 
            // txtaciklama
            // 
            this.txtaciklama.Location = new System.Drawing.Point(158, 242);
            this.txtaciklama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtaciklama.Multiline = true;
            this.txtaciklama.Name = "txtaciklama";
            this.txtaciklama.Size = new System.Drawing.Size(640, 92);
            this.txtaciklama.TabIndex = 11;
            this.txtaciklama.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtisim
            // 
            this.txtisim.Location = new System.Drawing.Point(158, 74);
            this.txtisim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtisim.Multiline = true;
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(202, 43);
            this.txtisim.TabIndex = 12;
            this.txtisim.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtsoyisim
            // 
            this.txtsoyisim.Location = new System.Drawing.Point(158, 149);
            this.txtsoyisim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsoyisim.Multiline = true;
            this.txtsoyisim.Name = "txtsoyisim";
            this.txtsoyisim.Size = new System.Drawing.Size(202, 43);
            this.txtsoyisim.TabIndex = 13;
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(352, 360);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(266, 60);
            this.btnguncelle.TabIndex = 14;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // Kullaniciform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(905, 450);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.txtsoyisim);
            this.Controls.Add(this.txtisim);
            this.Controls.Add(this.txtaciklama);
            this.Controls.Add(this.txtsifre2);
            this.Controls.Add(this.txtkuladi_);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Kullaniciform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullaniciform";
            this.Load += new System.EventHandler(this.Kullaniciform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtkuladi_;
        private System.Windows.Forms.TextBox txtsifre2;
        private System.Windows.Forms.TextBox txtaciklama;
        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.TextBox txtsoyisim;
        private System.Windows.Forms.Button btnguncelle;
    }
}