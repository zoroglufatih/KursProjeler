﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tanitim
{
    public partial class frmAna : Form
    {
        public frmAna()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click oldu");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Mouse Enter");
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            MessageBox.Show("Mouse Leave");
        }
    }
}
