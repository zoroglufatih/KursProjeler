
namespace Fatura
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tanımlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şehirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilçeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.birimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goruntulemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tanımlarToolStripMenuItem,
            this.faturaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tanımlarToolStripMenuItem
            // 
            this.tanımlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şehirToolStripMenuItem,
            this.ilçeToolStripMenuItem,
            this.urunToolStripMenuItem,
            this.musteriToolStripMenuItem,
            this.birimToolStripMenuItem});
            this.tanımlarToolStripMenuItem.Name = "tanımlarToolStripMenuItem";
            this.tanımlarToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.tanımlarToolStripMenuItem.Text = "Tanımlar";
            // 
            // şehirToolStripMenuItem
            // 
            this.şehirToolStripMenuItem.Name = "şehirToolStripMenuItem";
            this.şehirToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.şehirToolStripMenuItem.Text = "Sehir";
            this.şehirToolStripMenuItem.Click += new System.EventHandler(this.şehirToolStripMenuItem_Click);
            // 
            // ilçeToolStripMenuItem
            // 
            this.ilçeToolStripMenuItem.Name = "ilçeToolStripMenuItem";
            this.ilçeToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.ilçeToolStripMenuItem.Text = "Ilce";
            this.ilçeToolStripMenuItem.Click += new System.EventHandler(this.ilçeToolStripMenuItem_Click);
            // 
            // urunToolStripMenuItem
            // 
            this.urunToolStripMenuItem.Name = "urunToolStripMenuItem";
            this.urunToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.urunToolStripMenuItem.Text = "Urun";
            this.urunToolStripMenuItem.Click += new System.EventHandler(this.urunToolStripMenuItem_Click);
            // 
            // musteriToolStripMenuItem
            // 
            this.musteriToolStripMenuItem.Name = "musteriToolStripMenuItem";
            this.musteriToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.musteriToolStripMenuItem.Text = "Musteri";
            this.musteriToolStripMenuItem.Click += new System.EventHandler(this.musteriToolStripMenuItem_Click);
            // 
            // birimToolStripMenuItem
            // 
            this.birimToolStripMenuItem.Name = "birimToolStripMenuItem";
            this.birimToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.birimToolStripMenuItem.Text = "Birim";
            this.birimToolStripMenuItem.Click += new System.EventHandler(this.birimToolStripMenuItem_Click);
            // 
            // faturaToolStripMenuItem
            // 
            this.faturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goruntulemeToolStripMenuItem,
            this.girisToolStripMenuItem});
            this.faturaToolStripMenuItem.Name = "faturaToolStripMenuItem";
            this.faturaToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.faturaToolStripMenuItem.Text = "Fatura";
            // 
            // goruntulemeToolStripMenuItem
            // 
            this.goruntulemeToolStripMenuItem.Name = "goruntulemeToolStripMenuItem";
            this.goruntulemeToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.goruntulemeToolStripMenuItem.Text = "Goruntuleme/Duzeltme";
            this.goruntulemeToolStripMenuItem.Click += new System.EventHandler(this.goruntulemeToolStripMenuItem_Click);
            // 
            // girisToolStripMenuItem
            // 
            this.girisToolStripMenuItem.Name = "girisToolStripMenuItem";
            this.girisToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.girisToolStripMenuItem.Text = "Giris";
            this.girisToolStripMenuItem.Click += new System.EventHandler(this.girisToolStripMenuItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(25, 83);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(346, 111);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tanımlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şehirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilçeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem birimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goruntulemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girisToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

