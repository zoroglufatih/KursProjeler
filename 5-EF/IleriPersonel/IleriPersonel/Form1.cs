﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IleriPersonel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void çalışanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCalisan frm = new FrmCalisan();
            frm.Show();
        }

        private void eğitmenlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
