﻿
namespace Kalitim
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
            this.ıslemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ogrenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eğitmenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ıslemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(299, 213);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(202, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ıslemlerToolStripMenuItem
            // 
            this.ıslemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ogrenciToolStripMenuItem,
            this.eğitmenToolStripMenuItem});
            this.ıslemlerToolStripMenuItem.Name = "ıslemlerToolStripMenuItem";
            this.ıslemlerToolStripMenuItem.ShowShortcutKeys = false;
            this.ıslemlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.ıslemlerToolStripMenuItem.Text = "Islemler";
            // 
            // ogrenciToolStripMenuItem
            // 
            this.ogrenciToolStripMenuItem.Name = "ogrenciToolStripMenuItem";
            this.ogrenciToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ogrenciToolStripMenuItem.Text = "Öğrenci";
            // 
            // eğitmenToolStripMenuItem
            // 
            this.eğitmenToolStripMenuItem.Name = "eğitmenToolStripMenuItem";
            this.eğitmenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eğitmenToolStripMenuItem.Text = "Eğitmen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ıslemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ogrenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eğitmenToolStripMenuItem;
    }
}

