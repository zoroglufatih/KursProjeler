
namespace NedenOOPModern
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
            this.txId = new System.Windows.Forms.TextBox();
            this.txAd = new System.Windows.Forms.TextBox();
            this.txSoyad = new System.Windows.Forms.TextBox();
            this.dtDtarih = new System.Windows.Forms.DateTimePicker();
            this.ckCins = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.txOzet = new System.Windows.Forms.TextBox();
            this.txDetay = new System.Windows.Forms.TextBox();
            this.txOzet2 = new System.Windows.Forms.TextBox();
            this.txKurum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txId
            // 
            this.txId.Location = new System.Drawing.Point(96, 36);
            this.txId.Name = "txId";
            this.txId.Size = new System.Drawing.Size(100, 20);
            this.txId.TabIndex = 0;
            // 
            // txAd
            // 
            this.txAd.Location = new System.Drawing.Point(96, 62);
            this.txAd.Name = "txAd";
            this.txAd.Size = new System.Drawing.Size(100, 20);
            this.txAd.TabIndex = 1;
            // 
            // txSoyad
            // 
            this.txSoyad.Location = new System.Drawing.Point(96, 88);
            this.txSoyad.Name = "txSoyad";
            this.txSoyad.Size = new System.Drawing.Size(100, 20);
            this.txSoyad.TabIndex = 2;
            // 
            // dtDtarih
            // 
            this.dtDtarih.Location = new System.Drawing.Point(96, 114);
            this.dtDtarih.Name = "dtDtarih";
            this.dtDtarih.Size = new System.Drawing.Size(200, 20);
            this.dtDtarih.TabIndex = 4;
            // 
            // ckCins
            // 
            this.ckCins.AutoSize = true;
            this.ckCins.Location = new System.Drawing.Point(96, 140);
            this.ckCins.Name = "ckCins";
            this.ckCins.Size = new System.Drawing.Size(54, 17);
            this.ckCins.TabIndex = 5;
            this.ckCins.Text = "Erkek";
            this.ckCins.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Soyad";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dogum Tarihi";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(96, 164);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Oluştur";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txOzet
            // 
            this.txOzet.Location = new System.Drawing.Point(96, 193);
            this.txOzet.Name = "txOzet";
            this.txOzet.Size = new System.Drawing.Size(284, 20);
            this.txOzet.TabIndex = 11;
            // 
            // txDetay
            // 
            this.txDetay.Location = new System.Drawing.Point(96, 219);
            this.txDetay.Name = "txDetay";
            this.txDetay.Size = new System.Drawing.Size(284, 20);
            this.txDetay.TabIndex = 12;
            // 
            // txOzet2
            // 
            this.txOzet2.Location = new System.Drawing.Point(96, 245);
            this.txOzet2.Name = "txOzet2";
            this.txOzet2.Size = new System.Drawing.Size(284, 20);
            this.txOzet2.TabIndex = 13;
            // 
            // txKurum
            // 
            this.txKurum.Location = new System.Drawing.Point(297, 12);
            this.txKurum.Name = "txKurum";
            this.txKurum.Size = new System.Drawing.Size(284, 20);
            this.txKurum.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txKurum);
            this.Controls.Add(this.txOzet2);
            this.Controls.Add(this.txDetay);
            this.Controls.Add(this.txOzet);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckCins);
            this.Controls.Add(this.dtDtarih);
            this.Controls.Add(this.txSoyad);
            this.Controls.Add(this.txAd);
            this.Controls.Add(this.txId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txId;
        private System.Windows.Forms.TextBox txAd;
        private System.Windows.Forms.TextBox txSoyad;
        private System.Windows.Forms.DateTimePicker dtDtarih;
        private System.Windows.Forms.CheckBox ckCins;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txOzet;
        private System.Windows.Forms.TextBox txDetay;
        private System.Windows.Forms.TextBox txOzet2;
        private System.Windows.Forms.TextBox txKurum;
    }
}

