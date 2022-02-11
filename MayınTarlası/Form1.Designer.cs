
namespace MayınTarlası
{
    partial class form
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
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblmayin = new System.Windows.Forms.Label();
            this.lblsecilen = new System.Windows.Forms.Label();
            this.lblm = new System.Windows.Forms.Label();
            this.lbls = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(548, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 106);
            this.button1.TabIndex = 0;
            this.button1.Text = "Üret";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(27, 30);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(499, 385);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // lblmayin
            // 
            this.lblmayin.AutoSize = true;
            this.lblmayin.Location = new System.Drawing.Point(544, 166);
            this.lblmayin.Name = "lblmayin";
            this.lblmayin.Size = new System.Drawing.Size(53, 20);
            this.lblmayin.TabIndex = 2;
            this.lblmayin.Text = "Mayın";
            this.lblmayin.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblsecilen
            // 
            this.lblsecilen.AutoSize = true;
            this.lblsecilen.Location = new System.Drawing.Point(544, 225);
            this.lblsecilen.Name = "lblsecilen";
            this.lblsecilen.Size = new System.Drawing.Size(64, 20);
            this.lblsecilen.TabIndex = 3;
            this.lblsecilen.Text = "Seçilen";
            // 
            // lblm
            // 
            this.lblm.AutoSize = true;
            this.lblm.Location = new System.Drawing.Point(658, 166);
            this.lblm.Name = "lblm";
            this.lblm.Size = new System.Drawing.Size(18, 20);
            this.lblm.TabIndex = 4;
            this.lblm.Text = "0";
            // 
            // lbls
            // 
            this.lbls.AutoSize = true;
            this.lbls.Location = new System.Drawing.Point(658, 225);
            this.lbls.Name = "lbls";
            this.lbls.Size = new System.Drawing.Size(18, 20);
            this.lbls.TabIndex = 5;
            this.lbls.Text = "0";
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 435);
            this.Controls.Add(this.lbls);
            this.Controls.Add(this.lblm);
            this.Controls.Add(this.lblsecilen);
            this.Controls.Add(this.lblmayin);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblmayin;
        private System.Windows.Forms.Label lblsecilen;
        private System.Windows.Forms.Label lblm;
        private System.Windows.Forms.Label lbls;
    }
}

