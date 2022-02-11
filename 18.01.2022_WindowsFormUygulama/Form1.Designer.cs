
namespace _18._01._2022_WindowsFormUygulama
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
            this.cmburunler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpbox1 = new System.Windows.Forms.GroupBox();
            this.txturunad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkategori = new System.Windows.Forms.TextBox();
            this.txtstok = new System.Windows.Forms.TextBox();
            this.txtyazar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rchaciklama = new System.Windows.Forms.RichTextBox();
            this.pcbResim = new System.Windows.Forms.PictureBox();
            this.lsturunler = new System.Windows.Forms.ListBox();
            this.chkliste = new System.Windows.Forms.CheckedListBox();
            this.grpbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // cmburunler
            // 
            this.cmburunler.FormattingEnabled = true;
            this.cmburunler.Location = new System.Drawing.Point(178, 34);
            this.cmburunler.Name = "cmburunler";
            this.cmburunler.Size = new System.Drawing.Size(406, 24);
            this.cmburunler.TabIndex = 0;
            this.cmburunler.SelectedIndexChanged += new System.EventHandler(this.cmburunler_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(52, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Listesi";
            // 
            // grpbox1
            // 
            this.grpbox1.Controls.Add(this.pcbResim);
            this.grpbox1.Controls.Add(this.rchaciklama);
            this.grpbox1.Controls.Add(this.label5);
            this.grpbox1.Controls.Add(this.label4);
            this.grpbox1.Controls.Add(this.label3);
            this.grpbox1.Controls.Add(this.label2);
            this.grpbox1.Controls.Add(this.txtyazar);
            this.grpbox1.Controls.Add(this.txtstok);
            this.grpbox1.Controls.Add(this.txtkategori);
            this.grpbox1.Controls.Add(this.txturunad);
            this.grpbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpbox1.Location = new System.Drawing.Point(12, 92);
            this.grpbox1.Name = "grpbox1";
            this.grpbox1.Size = new System.Drawing.Size(572, 482);
            this.grpbox1.TabIndex = 2;
            this.grpbox1.TabStop = false;
            this.grpbox1.Text = "Ürün Detay Bilgisi";
            // 
            // txturunad
            // 
            this.txturunad.Location = new System.Drawing.Point(301, 40);
            this.txturunad.Multiline = true;
            this.txturunad.Name = "txturunad";
            this.txturunad.Size = new System.Drawing.Size(256, 29);
            this.txturunad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ürün Adı";
            // 
            // txtkategori
            // 
            this.txtkategori.Location = new System.Drawing.Point(301, 83);
            this.txtkategori.Multiline = true;
            this.txtkategori.Name = "txtkategori";
            this.txtkategori.Size = new System.Drawing.Size(256, 29);
            this.txtkategori.TabIndex = 3;
            this.txtkategori.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtstok
            // 
            this.txtstok.Location = new System.Drawing.Point(301, 126);
            this.txtstok.Multiline = true;
            this.txtstok.Name = "txtstok";
            this.txtstok.Size = new System.Drawing.Size(256, 29);
            this.txtstok.TabIndex = 3;
            this.txtstok.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtyazar
            // 
            this.txtyazar.Location = new System.Drawing.Point(301, 169);
            this.txtyazar.Multiline = true;
            this.txtyazar.Name = "txtyazar";
            this.txtyazar.Size = new System.Drawing.Size(256, 29);
            this.txtyazar.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kategori";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Stok Adet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yazar";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // rchaciklama
            // 
            this.rchaciklama.Location = new System.Drawing.Point(27, 271);
            this.rchaciklama.Name = "rchaciklama";
            this.rchaciklama.Size = new System.Drawing.Size(530, 187);
            this.rchaciklama.TabIndex = 5;
            this.rchaciklama.Text = "";
            // 
            // pcbResim
            // 
            this.pcbResim.Location = new System.Drawing.Point(6, 40);
            this.pcbResim.Name = "pcbResim";
            this.pcbResim.Size = new System.Drawing.Size(162, 170);
            this.pcbResim.TabIndex = 6;
            this.pcbResim.TabStop = false;
            // 
            // lsturunler
            // 
            this.lsturunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lsturunler.FormattingEnabled = true;
            this.lsturunler.HorizontalScrollbar = true;
            this.lsturunler.ItemHeight = 20;
            this.lsturunler.Location = new System.Drawing.Point(590, 30);
            this.lsturunler.Name = "lsturunler";
            this.lsturunler.ScrollAlwaysVisible = true;
            this.lsturunler.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsturunler.Size = new System.Drawing.Size(274, 544);
            this.lsturunler.TabIndex = 3;
            this.lsturunler.SelectedIndexChanged += new System.EventHandler(this.lsturunler_SelectedIndexChanged);
            // 
            // chkliste
            // 
            this.chkliste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkliste.FormattingEnabled = true;
            this.chkliste.Location = new System.Drawing.Point(870, 34);
            this.chkliste.Name = "chkliste";
            this.chkliste.Size = new System.Drawing.Size(285, 529);
            this.chkliste.TabIndex = 4;
            this.chkliste.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkliste_ItemCheck);
            this.chkliste.SelectedIndexChanged += new System.EventHandler(this.chkliste_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 586);
            this.Controls.Add(this.chkliste);
            this.Controls.Add(this.lsturunler);
            this.Controls.Add(this.grpbox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmburunler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpbox1.ResumeLayout(false);
            this.grpbox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmburunler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpbox1;
        private System.Windows.Forms.RichTextBox rchaciklama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtyazar;
        private System.Windows.Forms.TextBox txtstok;
        private System.Windows.Forms.TextBox txtkategori;
        private System.Windows.Forms.TextBox txturunad;
        private System.Windows.Forms.PictureBox pcbResim;
        private System.Windows.Forms.ListBox lsturunler;
        private System.Windows.Forms.CheckedListBox chkliste;
    }
}

