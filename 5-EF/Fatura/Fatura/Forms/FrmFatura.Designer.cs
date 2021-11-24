
namespace Fatura.Forms
{
    partial class FrmFatura
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
            this.txFatNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txTarih = new System.Windows.Forms.TextBox();
            this.txAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txSoyad = new System.Windows.Forms.TextBox();
            this.txAdres = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "FaturaNo";
            // 
            // txFatNo
            // 
            this.txFatNo.Location = new System.Drawing.Point(22, 59);
            this.txFatNo.Name = "txFatNo";
            this.txFatNo.Size = new System.Drawing.Size(100, 20);
            this.txFatNo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tarih";
            // 
            // txTarih
            // 
            this.txTarih.Location = new System.Drawing.Point(128, 59);
            this.txTarih.Name = "txTarih";
            this.txTarih.Size = new System.Drawing.Size(100, 20);
            this.txTarih.TabIndex = 4;
            // 
            // txAd
            // 
            this.txAd.Location = new System.Drawing.Point(234, 59);
            this.txAd.Name = "txAd";
            this.txAd.Size = new System.Drawing.Size(100, 20);
            this.txAd.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Soyad";
            // 
            // txSoyad
            // 
            this.txSoyad.Location = new System.Drawing.Point(340, 59);
            this.txSoyad.Name = "txSoyad";
            this.txSoyad.Size = new System.Drawing.Size(100, 20);
            this.txSoyad.TabIndex = 9;
            // 
            // txAdres
            // 
            this.txAdres.Location = new System.Drawing.Point(277, 85);
            this.txAdres.Multiline = true;
            this.txAdres.Name = "txAdres";
            this.txAdres.Size = new System.Drawing.Size(126, 75);
            this.txAdres.TabIndex = 10;
            // 
            // FrmFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txAdres);
            this.Controls.Add(this.txSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txAd);
            this.Controls.Add(this.txTarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txFatNo);
            this.Controls.Add(this.label1);
            this.Name = "FrmFatura";
            this.Text = "FrmFatura";
            this.Load += new System.EventHandler(this.FrmFatura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txFatNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txTarih;
        private System.Windows.Forms.TextBox txAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txSoyad;
        private System.Windows.Forms.TextBox txAdres;
    }
}