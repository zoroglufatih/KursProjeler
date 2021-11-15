
namespace KalıtımPolymorphism2
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
            this.btnDortgen = new System.Windows.Forms.Button();
            this.btnKup = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txHacim = new System.Windows.Forms.TextBox();
            this.txTaban = new System.Windows.Forms.TextBox();
            this.txFire = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDortgen
            // 
            this.btnDortgen.Location = new System.Drawing.Point(26, 120);
            this.btnDortgen.Name = "btnDortgen";
            this.btnDortgen.Size = new System.Drawing.Size(75, 23);
            this.btnDortgen.TabIndex = 0;
            this.btnDortgen.Text = "Dörtgen";
            this.btnDortgen.UseVisualStyleBackColor = true;
            this.btnDortgen.Click += new System.EventHandler(this.btnDortgen_Click);
            // 
            // btnKup
            // 
            this.btnKup.Location = new System.Drawing.Point(151, 120);
            this.btnKup.Name = "btnKup";
            this.btnKup.Size = new System.Drawing.Size(75, 23);
            this.btnKup.TabIndex = 1;
            this.btnKup.Text = "Küp";
            this.btnKup.UseVisualStyleBackColor = true;
            this.btnKup.Click += new System.EventHandler(this.btnKup_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(278, 120);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Silindir";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txHacim
            // 
            this.txHacim.Location = new System.Drawing.Point(269, 158);
            this.txHacim.Name = "txHacim";
            this.txHacim.Size = new System.Drawing.Size(100, 20);
            this.txHacim.TabIndex = 3;
            // 
            // txTaban
            // 
            this.txTaban.Location = new System.Drawing.Point(141, 158);
            this.txTaban.Name = "txTaban";
            this.txTaban.Size = new System.Drawing.Size(100, 20);
            this.txTaban.TabIndex = 4;
            // 
            // txFire
            // 
            this.txFire.Location = new System.Drawing.Point(12, 158);
            this.txFire.Name = "txFire";
            this.txFire.Size = new System.Drawing.Size(100, 20);
            this.txFire.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fire Oranı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Taban Alanı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hacim";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txFire);
            this.Controls.Add(this.txTaban);
            this.Controls.Add(this.txHacim);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKup);
            this.Controls.Add(this.btnDortgen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDortgen;
        private System.Windows.Forms.Button btnKup;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txHacim;
        private System.Windows.Forms.TextBox txTaban;
        private System.Windows.Forms.TextBox txFire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

