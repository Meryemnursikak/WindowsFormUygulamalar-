
namespace _14._01._2022_MusteriUygulamasi
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtsoyisim = new System.Windows.Forms.TextBox();
            this.txtisim = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstmusteriler = new System.Windows.Forms.ListBox();
            this.bildirim = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnonizleme = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnonizleme);
            this.groupBox1.Controls.Add(this.btnekle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txttel);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.txtsoyisim);
            this.groupBox1.Controls.Add(this.txtisim);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(53, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 320);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Müşteri Ekleme Formu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(8, 206);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(195, 34);
            this.btnekle.TabIndex = 4;
            this.btnekle.Text = "Yeni Müşteri Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Telefon";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyisim";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "İsim";
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(83, 148);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(120, 26);
            this.txttel.TabIndex = 3;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(83, 106);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(120, 26);
            this.txtemail.TabIndex = 2;
            // 
            // txtsoyisim
            // 
            this.txtsoyisim.Location = new System.Drawing.Point(83, 74);
            this.txtsoyisim.Name = "txtsoyisim";
            this.txtsoyisim.Size = new System.Drawing.Size(120, 26);
            this.txtsoyisim.TabIndex = 1;
            // 
            // txtisim
            // 
            this.txtisim.Location = new System.Drawing.Point(83, 34);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(120, 26);
            this.txtisim.TabIndex = 0;
            this.txtisim.TextChanged += new System.EventHandler(this.txtisim_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstmusteriler);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(388, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 320);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Kayıt Listesi";
            // 
            // lstmusteriler
            // 
            this.lstmusteriler.FormattingEnabled = true;
            this.lstmusteriler.ItemHeight = 20;
            this.lstmusteriler.Location = new System.Drawing.Point(6, 34);
            this.lstmusteriler.Name = "lstmusteriler";
            this.lstmusteriler.Size = new System.Drawing.Size(201, 264);
            this.lstmusteriler.TabIndex = 0;
            this.lstmusteriler.SelectedIndexChanged += new System.EventHandler(this.lstmusteriler_SelectedIndexChanged);
            // 
            // bildirim
            // 
            this.bildirim.Text = "notifyIcon1";
            this.bildirim.Visible = true;
            this.bildirim.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.bildirim_MouseDoubleClick);
            // 
            // btnonizleme
            // 
            this.btnonizleme.Location = new System.Drawing.Point(10, 265);
            this.btnonizleme.Name = "btnonizleme";
            this.btnonizleme.Size = new System.Drawing.Size(193, 33);
            this.btnonizleme.TabIndex = 5;
            this.btnonizleme.Text = "Önizleme";
            this.btnonizleme.UseVisualStyleBackColor = true;
            this.btnonizleme.Click += new System.EventHandler(this.btnonizleme_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 422);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtsoyisim;
        private System.Windows.Forms.ListBox lstmusteriler;
        private System.Windows.Forms.NotifyIcon bildirim;
        private System.Windows.Forms.Button btnonizleme;
    }
}

