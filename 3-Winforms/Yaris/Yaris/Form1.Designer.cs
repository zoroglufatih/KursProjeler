
namespace Yaris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pcBoxBeyaz = new System.Windows.Forms.PictureBox();
            this.pcBoxSiyah = new System.Windows.Forms.PictureBox();
            this.pnlFin = new System.Windows.Forms.Panel();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnPanelCol = new System.Windows.Forms.Button();
            this.btnFormCol = new System.Windows.Forms.Button();
            this.btnYerDeg = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnBasla = new System.Windows.Forms.Button();
            this.tmBasla = new System.Windows.Forms.Timer(this.components);
            this.cmBoxSev = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.tmBasla2 = new System.Windows.Forms.Timer(this.components);
            this.ClDiaForm = new System.Windows.Forms.ColorDialog();
            this.ClDiaPanel = new System.Windows.Forms.ColorDialog();
            this.fontDialog2 = new System.Windows.Forms.FontDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formRengiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelRengiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yerDeğiştirmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yarışlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriYarışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxBeyaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxSiyah)).BeginInit();
            this.pnlFin.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcBoxBeyaz
            // 
            this.pcBoxBeyaz.Image = ((System.Drawing.Image)(resources.GetObject("pcBoxBeyaz.Image")));
            this.pcBoxBeyaz.Location = new System.Drawing.Point(0, 99);
            this.pcBoxBeyaz.Name = "pcBoxBeyaz";
            this.pcBoxBeyaz.Size = new System.Drawing.Size(100, 95);
            this.pcBoxBeyaz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBoxBeyaz.TabIndex = 0;
            this.pcBoxBeyaz.TabStop = false;
            // 
            // pcBoxSiyah
            // 
            this.pcBoxSiyah.Image = ((System.Drawing.Image)(resources.GetObject("pcBoxSiyah.Image")));
            this.pcBoxSiyah.Location = new System.Drawing.Point(0, 216);
            this.pcBoxSiyah.Name = "pcBoxSiyah";
            this.pcBoxSiyah.Size = new System.Drawing.Size(100, 95);
            this.pcBoxSiyah.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBoxSiyah.TabIndex = 1;
            this.pcBoxSiyah.TabStop = false;
            // 
            // pnlFin
            // 
            this.pnlFin.BackColor = System.Drawing.Color.Red;
            this.pnlFin.Controls.Add(this.btnFont);
            this.pnlFin.Controls.Add(this.btnPanelCol);
            this.pnlFin.Controls.Add(this.btnFormCol);
            this.pnlFin.Controls.Add(this.btnYerDeg);
            this.pnlFin.Controls.Add(this.btnGeri);
            this.pnlFin.Controls.Add(this.btnBasla);
            this.pnlFin.Location = new System.Drawing.Point(720, 0);
            this.pnlFin.Name = "pnlFin";
            this.pnlFin.Size = new System.Drawing.Size(85, 449);
            this.pnlFin.TabIndex = 2;
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(3, 157);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(75, 23);
            this.btnFont.TabIndex = 8;
            this.btnFont.Text = "Font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnPanelCol
            // 
            this.btnPanelCol.Location = new System.Drawing.Point(3, 128);
            this.btnPanelCol.Name = "btnPanelCol";
            this.btnPanelCol.Size = new System.Drawing.Size(75, 23);
            this.btnPanelCol.TabIndex = 7;
            this.btnPanelCol.Text = "Panel Renk";
            this.btnPanelCol.UseVisualStyleBackColor = true;
            this.btnPanelCol.Click += new System.EventHandler(this.btnPanelCol_Click);
            // 
            // btnFormCol
            // 
            this.btnFormCol.Location = new System.Drawing.Point(3, 99);
            this.btnFormCol.Name = "btnFormCol";
            this.btnFormCol.Size = new System.Drawing.Size(75, 23);
            this.btnFormCol.TabIndex = 6;
            this.btnFormCol.Text = "Form Renk";
            this.btnFormCol.UseVisualStyleBackColor = true;
            this.btnFormCol.Click += new System.EventHandler(this.btnFormCol_Click);
            // 
            // btnYerDeg
            // 
            this.btnYerDeg.Location = new System.Drawing.Point(3, 70);
            this.btnYerDeg.Name = "btnYerDeg";
            this.btnYerDeg.Size = new System.Drawing.Size(75, 23);
            this.btnYerDeg.TabIndex = 5;
            this.btnYerDeg.Text = "Yer Değiştir";
            this.btnYerDeg.UseVisualStyleBackColor = true;
            this.btnYerDeg.Click += new System.EventHandler(this.btnYerDeg_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(3, 41);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 4;
            this.btnGeri.Text = "TersYaris";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(3, 12);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(75, 23);
            this.btnBasla.TabIndex = 3;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // tmBasla
            // 
            this.tmBasla.Tick += new System.EventHandler(this.tmBasla_Tick);
            // 
            // cmBoxSev
            // 
            this.cmBoxSev.FormattingEnabled = true;
            this.cmBoxSev.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmBoxSev.Location = new System.Drawing.Point(58, 341);
            this.cmBoxSev.Name = "cmBoxSev";
            this.cmBoxSev.Size = new System.Drawing.Size(121, 21);
            this.cmBoxSev.TabIndex = 3;
            this.cmBoxSev.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 341);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(39, 13);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Seviye";
            // 
            // tmBasla2
            // 
            this.tmBasla2.Tick += new System.EventHandler(this.tmBasla2_Tick);
            // 
            // fontDialog2
            // 
            this.fontDialog2.Apply += new System.EventHandler(this.fontDialog2_Apply);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayarlarToolStripMenuItem,
            this.yarışlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formRengiToolStripMenuItem,
            this.panelRengiToolStripMenuItem,
            this.yerDeğiştirmeToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // formRengiToolStripMenuItem
            // 
            this.formRengiToolStripMenuItem.Name = "formRengiToolStripMenuItem";
            this.formRengiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.formRengiToolStripMenuItem.Text = "Form Rengi";
            this.formRengiToolStripMenuItem.Click += new System.EventHandler(this.formRengiToolStripMenuItem_Click);
            // 
            // panelRengiToolStripMenuItem
            // 
            this.panelRengiToolStripMenuItem.Name = "panelRengiToolStripMenuItem";
            this.panelRengiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.panelRengiToolStripMenuItem.Text = "Panel Rengi";
            this.panelRengiToolStripMenuItem.Click += new System.EventHandler(this.panelRengiToolStripMenuItem_Click);
            // 
            // yerDeğiştirmeToolStripMenuItem
            // 
            this.yerDeğiştirmeToolStripMenuItem.Name = "yerDeğiştirmeToolStripMenuItem";
            this.yerDeğiştirmeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yerDeğiştirmeToolStripMenuItem.Text = "Yer Değiştirme";
            this.yerDeğiştirmeToolStripMenuItem.Click += new System.EventHandler(this.yerDeğiştirmeToolStripMenuItem_Click);
            // 
            // yarışlarToolStripMenuItem
            // 
            this.yarışlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ileriToolStripMenuItem,
            this.geriYarışToolStripMenuItem});
            this.yarışlarToolStripMenuItem.Name = "yarışlarToolStripMenuItem";
            this.yarışlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yarışlarToolStripMenuItem.Text = "Yarışlar";
            // 
            // ileriToolStripMenuItem
            // 
            this.ileriToolStripMenuItem.Name = "ileriToolStripMenuItem";
            this.ileriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ileriToolStripMenuItem.Text = "İleri Yarış";
            this.ileriToolStripMenuItem.Click += new System.EventHandler(this.ileriToolStripMenuItem_Click);
            // 
            // geriYarışToolStripMenuItem
            // 
            this.geriYarışToolStripMenuItem.Name = "geriYarışToolStripMenuItem";
            this.geriYarışToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.geriYarışToolStripMenuItem.Text = "Geri Yarış";
            this.geriYarışToolStripMenuItem.Click += new System.EventHandler(this.geriYarışToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.cmBoxSev);
            this.Controls.Add(this.pnlFin);
            this.Controls.Add(this.pcBoxSiyah);
            this.Controls.Add(this.pcBoxBeyaz);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxBeyaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxSiyah)).EndInit();
            this.pnlFin.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcBoxBeyaz;
        private System.Windows.Forms.PictureBox pcBoxSiyah;
        private System.Windows.Forms.Panel pnlFin;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Timer tmBasla;
        private System.Windows.Forms.ComboBox cmBoxSev;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Timer tmBasla2;
        private System.Windows.Forms.Button btnYerDeg;
        private System.Windows.Forms.Button btnFormCol;
        private System.Windows.Forms.ColorDialog ClDiaForm;
        private System.Windows.Forms.Button btnPanelCol;
        private System.Windows.Forms.ColorDialog ClDiaPanel;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.FontDialog fontDialog2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formRengiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panelRengiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yerDeğiştirmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yarışlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geriYarışToolStripMenuItem;
    }
}

