
namespace Otomasyon
{
    partial class Form1
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
            this.cmbebat = new System.Windows.Forms.ComboBox();
            this.lstpizzalar = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbince = new System.Windows.Forms.RadioButton();
            this.rdbkalin = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.nudadet = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.listsepet = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttutar = new System.Windows.Forms.TextBox();
            this.btnsepet = new System.Windows.Forms.Button();
            this.btnsiparis = new System.Windows.Forms.Button();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudadet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(321, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizza Otomasyon";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(60, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ebat";
            // 
            // cmbebat
            // 
            this.cmbebat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbebat.FormattingEnabled = true;
            this.cmbebat.Location = new System.Drawing.Point(139, 100);
            this.cmbebat.Name = "cmbebat";
            this.cmbebat.Size = new System.Drawing.Size(202, 28);
            this.cmbebat.TabIndex = 1;
            this.cmbebat.SelectedIndexChanged += new System.EventHandler(this.cmbebat_SelectedIndexChanged);
            // 
            // lstpizzalar
            // 
            this.lstpizzalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstpizzalar.FormattingEnabled = true;
            this.lstpizzalar.ItemHeight = 20;
            this.lstpizzalar.Location = new System.Drawing.Point(64, 171);
            this.lstpizzalar.Name = "lstpizzalar";
            this.lstpizzalar.Size = new System.Drawing.Size(277, 124);
            this.lstpizzalar.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(60, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pizzalar";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // rdbince
            // 
            this.rdbince.AutoSize = true;
            this.rdbince.Checked = true;
            this.rdbince.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbince.Location = new System.Drawing.Point(64, 310);
            this.rdbince.Name = "rdbince";
            this.rdbince.Size = new System.Drawing.Size(110, 24);
            this.rdbince.TabIndex = 3;
            this.rdbince.TabStop = true;
            this.rdbince.Text = "İnce Kenar";
            this.rdbince.UseVisualStyleBackColor = true;
            this.rdbince.CheckedChanged += new System.EventHandler(this.rdbince_CheckedChanged);
            // 
            // rdbkalin
            // 
            this.rdbkalin.AutoSize = true;
            this.rdbkalin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbkalin.Location = new System.Drawing.Point(238, 310);
            this.rdbkalin.Name = "rdbkalin";
            this.rdbkalin.Size = new System.Drawing.Size(116, 24);
            this.rdbkalin.TabIndex = 4;
            this.rdbkalin.Text = "Kalın Kenar";
            this.rdbkalin.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox8);
            this.groupBox1.Controls.Add(this.checkBox7);
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(64, 363);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 202);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Malzemeler";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 25);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Sucuk";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 55);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(75, 24);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Zeytin";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 86);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(83, 24);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Mantar";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 116);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(73, 24);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Sosis";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(164, 86);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(78, 24);
            this.checkBox5.TabIndex = 6;
            this.checkBox5.Text = "Peynir";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(164, 116);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(106, 24);
            this.checkBox6.TabIndex = 7;
            this.checkBox6.Text = "Ton Balığı";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(164, 25);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(68, 24);
            this.checkBox7.TabIndex = 4;
            this.checkBox7.Text = "Mısır";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(164, 55);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(78, 24);
            this.checkBox8.TabIndex = 5;
            this.checkBox8.Text = "Salam";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // nudadet
            // 
            this.nudadet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudadet.Location = new System.Drawing.Point(128, 593);
            this.nudadet.Name = "nudadet";
            this.nudadet.Size = new System.Drawing.Size(100, 26);
            this.nudadet.TabIndex = 6;
            this.nudadet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudadet.ValueChanged += new System.EventHandler(this.nudadet_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(66, 593);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Adet";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // listsepet
            // 
            this.listsepet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listsepet.FormattingEnabled = true;
            this.listsepet.ItemHeight = 20;
            this.listsepet.Location = new System.Drawing.Point(381, 100);
            this.listsepet.Name = "listsepet";
            this.listsepet.Size = new System.Drawing.Size(462, 464);
            this.listsepet.TabIndex = 8;
            this.listsepet.SelectedIndexChanged += new System.EventHandler(this.listsepet_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(377, 595);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tutar";
            // 
            // txttutar
            // 
            this.txttutar.Location = new System.Drawing.Point(442, 595);
            this.txttutar.Multiline = true;
            this.txttutar.Name = "txttutar";
            this.txttutar.Size = new System.Drawing.Size(131, 34);
            this.txttutar.TabIndex = 9;
            this.txttutar.TextChanged += new System.EventHandler(this.txttutar_TextChanged);
            // 
            // btnsepet
            // 
            this.btnsepet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsepet.Location = new System.Drawing.Point(592, 593);
            this.btnsepet.Name = "btnsepet";
            this.btnsepet.Size = new System.Drawing.Size(111, 36);
            this.btnsepet.TabIndex = 7;
            this.btnsepet.Text = "Sepete Ekle";
            this.btnsepet.UseVisualStyleBackColor = true;
            this.btnsepet.Click += new System.EventHandler(this.btnsepet_Click);
            // 
            // btnsiparis
            // 
            this.btnsiparis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsiparis.Location = new System.Drawing.Point(722, 592);
            this.btnsiparis.Name = "btnsiparis";
            this.btnsiparis.Size = new System.Drawing.Size(133, 37);
            this.btnsiparis.TabIndex = 10;
            this.btnsiparis.Text = "Siparişi Onayla";
            this.btnsiparis.UseVisualStyleBackColor = true;
            // 
            // btnhesapla
            // 
            this.btnhesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhesapla.Location = new System.Drawing.Point(251, 593);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(90, 30);
            this.btnhesapla.TabIndex = 11;
            this.btnhesapla.Text = "Hesapla";
            this.btnhesapla.UseVisualStyleBackColor = true;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(70, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kalın kenar için ek ücret 3 TL\'dir.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 659);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnhesapla);
            this.Controls.Add(this.btnsiparis);
            this.Controls.Add(this.btnsepet);
            this.Controls.Add(this.txttutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listsepet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nudadet);
            this.Controls.Add(this.rdbkalin);
            this.Controls.Add(this.rdbince);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstpizzalar);
            this.Controls.Add(this.cmbebat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudadet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbebat;
        private System.Windows.Forms.ListBox lstpizzalar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbince;
        private System.Windows.Forms.RadioButton rdbkalin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.NumericUpDown nudadet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listsepet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttutar;
        private System.Windows.Forms.Button btnsepet;
        private System.Windows.Forms.Button btnsiparis;
        private System.Windows.Forms.Button btnhesapla;
        private System.Windows.Forms.Label label6;
    }
}

