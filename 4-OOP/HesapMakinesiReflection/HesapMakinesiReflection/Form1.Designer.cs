﻿
namespace HesapMakinesiReflection
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
            this.label4 = new System.Windows.Forms.Label();
            this.txSonuc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmIslem = new System.Windows.Forms.ComboBox();
            this.txS2 = new System.Windows.Forms.TextBox();
            this.txS1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Sonuç";
            // 
            // txSonuc
            // 
            this.txSonuc.Location = new System.Drawing.Point(397, 69);
            this.txSonuc.Name = "txSonuc";
            this.txSonuc.Size = new System.Drawing.Size(100, 20);
            this.txSonuc.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sayı2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "İşlem";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sayı1";
            // 
            // cmIslem
            // 
            this.cmIslem.FormattingEnabled = true;
            this.cmIslem.Location = new System.Drawing.Point(272, 69);
            this.cmIslem.Name = "cmIslem";
            this.cmIslem.Size = new System.Drawing.Size(119, 21);
            this.cmIslem.TabIndex = 10;
            this.cmIslem.SelectedIndexChanged += new System.EventHandler(this.cmIslem_SelectedIndexChanged);
            // 
            // txS2
            // 
            this.txS2.Location = new System.Drawing.Point(166, 69);
            this.txS2.Name = "txS2";
            this.txS2.Size = new System.Drawing.Size(100, 20);
            this.txS2.TabIndex = 9;
            // 
            // txS1
            // 
            this.txS1.Location = new System.Drawing.Point(60, 69);
            this.txS1.Name = "txS1";
            this.txS1.Size = new System.Drawing.Size(100, 20);
            this.txS1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txSonuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmIslem);
            this.Controls.Add(this.txS2);
            this.Controls.Add(this.txS1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txSonuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmIslem;
        private System.Windows.Forms.TextBox txS2;
        private System.Windows.Forms.TextBox txS1;
    }
}

