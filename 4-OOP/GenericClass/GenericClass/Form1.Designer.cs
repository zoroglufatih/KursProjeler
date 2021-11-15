
namespace GenericClass
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
            this.lsArray = new System.Windows.Forms.ListBox();
            this.btnArr = new System.Windows.Forms.Button();
            this.btnArray2 = new System.Windows.Forms.Button();
            this.lsArrList = new System.Windows.Forms.ListBox();
            this.btnArL1 = new System.Windows.Forms.Button();
            this.btnArrL2 = new System.Windows.Forms.Button();
            this.lsBoxGen = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtS1 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lsArray
            // 
            this.lsArray.FormattingEnabled = true;
            this.lsArray.Location = new System.Drawing.Point(12, 12);
            this.lsArray.Name = "lsArray";
            this.lsArray.Size = new System.Drawing.Size(120, 95);
            this.lsArray.TabIndex = 0;
            // 
            // btnArr
            // 
            this.btnArr.Location = new System.Drawing.Point(12, 113);
            this.btnArr.Name = "btnArr";
            this.btnArr.Size = new System.Drawing.Size(75, 23);
            this.btnArr.TabIndex = 1;
            this.btnArr.Text = "Array";
            this.btnArr.UseVisualStyleBackColor = true;
            this.btnArr.Click += new System.EventHandler(this.btnArr_Click);
            // 
            // btnArray2
            // 
            this.btnArray2.Location = new System.Drawing.Point(12, 142);
            this.btnArray2.Name = "btnArray2";
            this.btnArray2.Size = new System.Drawing.Size(75, 23);
            this.btnArray2.TabIndex = 2;
            this.btnArray2.Text = "Array2";
            this.btnArray2.UseVisualStyleBackColor = true;
            this.btnArray2.Click += new System.EventHandler(this.btnArray2_Click);
            // 
            // lsArrList
            // 
            this.lsArrList.FormattingEnabled = true;
            this.lsArrList.Location = new System.Drawing.Point(185, 12);
            this.lsArrList.Name = "lsArrList";
            this.lsArrList.Size = new System.Drawing.Size(120, 95);
            this.lsArrList.TabIndex = 3;
            // 
            // btnArL1
            // 
            this.btnArL1.Location = new System.Drawing.Point(185, 113);
            this.btnArL1.Name = "btnArL1";
            this.btnArL1.Size = new System.Drawing.Size(75, 23);
            this.btnArL1.TabIndex = 4;
            this.btnArL1.Text = "ArrayList";
            this.btnArL1.UseVisualStyleBackColor = true;
            this.btnArL1.Click += new System.EventHandler(this.btnArL1_Click);
            // 
            // btnArrL2
            // 
            this.btnArrL2.Location = new System.Drawing.Point(185, 142);
            this.btnArrL2.Name = "btnArrL2";
            this.btnArrL2.Size = new System.Drawing.Size(75, 23);
            this.btnArrL2.TabIndex = 5;
            this.btnArrL2.Text = "ArrayList2";
            this.btnArrL2.UseVisualStyleBackColor = true;
            // 
            // lsBoxGen
            // 
            this.lsBoxGen.FormattingEnabled = true;
            this.lsBoxGen.Location = new System.Drawing.Point(372, 12);
            this.lsBoxGen.Name = "lsBoxGen";
            this.lsBoxGen.Size = new System.Drawing.Size(120, 95);
            this.lsBoxGen.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Gen2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(372, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Gen1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(515, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(273, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(515, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Gen3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(515, 218);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Çocuk Sayısı";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtS1
            // 
            this.txtS1.Location = new System.Drawing.Point(633, 221);
            this.txtS1.Name = "txtS1";
            this.txtS1.Size = new System.Drawing.Size(100, 20);
            this.txtS1.TabIndex = 12;
            this.txtS1.Text = "0";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(533, 268);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(238, 141);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txtS1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lsBoxGen);
            this.Controls.Add(this.btnArrL2);
            this.Controls.Add(this.btnArL1);
            this.Controls.Add(this.lsArrList);
            this.Controls.Add(this.btnArray2);
            this.Controls.Add(this.btnArr);
            this.Controls.Add(this.lsArray);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsArray;
        private System.Windows.Forms.Button btnArr;
        private System.Windows.Forms.Button btnArray2;
        private System.Windows.Forms.ListBox lsArrList;
        private System.Windows.Forms.Button btnArL1;
        private System.Windows.Forms.Button btnArrL2;
        private System.Windows.Forms.ListBox lsBoxGen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtS1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

