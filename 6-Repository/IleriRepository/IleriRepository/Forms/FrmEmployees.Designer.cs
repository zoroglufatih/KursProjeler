
namespace IleriRepository.Forms
{
    partial class FrmEmployees
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txHead = new System.Windows.Forms.TextBox();
            this.cbSehir = new System.Windows.Forms.ComboBox();
            this.cbIlce = new System.Windows.Forms.ComboBox();
            this.cbEgitim = new System.Windows.Forms.ComboBox();
            this.txName = new System.Windows.Forms.TextBox();
            this.txSurname = new System.Windows.Forms.TextBox();
            this.txStreet = new System.Windows.Forms.TextBox();
            this.txAvenue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpBirthDay = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txSalary = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txHouseNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(676, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // txHead
            // 
            this.txHead.Location = new System.Drawing.Point(195, 34);
            this.txHead.Name = "txHead";
            this.txHead.Size = new System.Drawing.Size(414, 20);
            this.txHead.TabIndex = 1;
            // 
            // cbSehir
            // 
            this.cbSehir.FormattingEnabled = true;
            this.cbSehir.Location = new System.Drawing.Point(372, 234);
            this.cbSehir.Name = "cbSehir";
            this.cbSehir.Size = new System.Drawing.Size(121, 21);
            this.cbSehir.TabIndex = 2;
            this.cbSehir.SelectedIndexChanged += new System.EventHandler(this.cbSehir_SelectedIndexChanged);
            // 
            // cbIlce
            // 
            this.cbIlce.FormattingEnabled = true;
            this.cbIlce.Location = new System.Drawing.Point(372, 261);
            this.cbIlce.Name = "cbIlce";
            this.cbIlce.Size = new System.Drawing.Size(121, 21);
            this.cbIlce.TabIndex = 3;
            // 
            // cbEgitim
            // 
            this.cbEgitim.FormattingEnabled = true;
            this.cbEgitim.Location = new System.Drawing.Point(372, 288);
            this.cbEgitim.Name = "cbEgitim";
            this.cbEgitim.Size = new System.Drawing.Size(121, 21);
            this.cbEgitim.TabIndex = 4;
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(163, 235);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(100, 20);
            this.txName.TabIndex = 5;
            // 
            // txSurname
            // 
            this.txSurname.Location = new System.Drawing.Point(163, 261);
            this.txSurname.Name = "txSurname";
            this.txSurname.Size = new System.Drawing.Size(100, 20);
            this.txSurname.TabIndex = 6;
            // 
            // txStreet
            // 
            this.txStreet.Location = new System.Drawing.Point(163, 342);
            this.txStreet.Name = "txStreet";
            this.txStreet.Size = new System.Drawing.Size(100, 20);
            this.txStreet.TabIndex = 8;
            // 
            // txAvenue
            // 
            this.txAvenue.Location = new System.Drawing.Point(163, 313);
            this.txAvenue.Name = "txAvenue";
            this.txAvenue.Size = new System.Drawing.Size(100, 20);
            this.txAvenue.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Doğum Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Sokak";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cadde";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(314, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "İlçe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(314, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Şehir";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(314, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Eğitim";
            // 
            // dtpBirthDay
            // 
            this.dtpBirthDay.Location = new System.Drawing.Point(163, 287);
            this.dtpBirthDay.Name = "dtpBirthDay";
            this.dtpBirthDay.Size = new System.Drawing.Size(100, 20);
            this.dtpBirthDay.TabIndex = 22;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(372, 315);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 23);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(372, 344);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 23);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(372, 373);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 23);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Maaş";
            // 
            // txSalary
            // 
            this.txSalary.Location = new System.Drawing.Point(163, 394);
            this.txSalary.Name = "txSalary";
            this.txSalary.Size = new System.Drawing.Size(100, 20);
            this.txSalary.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(87, 371);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Bina No";
            // 
            // txHouseNumber
            // 
            this.txHouseNumber.Location = new System.Drawing.Point(163, 368);
            this.txHouseNumber.Name = "txHouseNumber";
            this.txHouseNumber.Size = new System.Drawing.Size(100, 20);
            this.txHouseNumber.TabIndex = 28;
            // 
            // FrmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txHouseNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txSalary);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpBirthDay);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txAvenue);
            this.Controls.Add(this.txStreet);
            this.Controls.Add(this.txSurname);
            this.Controls.Add(this.txName);
            this.Controls.Add(this.cbEgitim);
            this.Controls.Add(this.cbIlce);
            this.Controls.Add(this.cbSehir);
            this.Controls.Add(this.txHead);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmEmployees";
            this.Text = "FrmEmployees";
            this.Load += new System.EventHandler(this.FrmEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txHead;
        private System.Windows.Forms.ComboBox cbSehir;
        private System.Windows.Forms.ComboBox cbIlce;
        private System.Windows.Forms.ComboBox cbEgitim;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.TextBox txSurname;
        private System.Windows.Forms.TextBox txStreet;
        private System.Windows.Forms.TextBox txAvenue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpBirthDay;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txSalary;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txHouseNumber;
    }
}