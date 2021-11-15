using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalitim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ogrenciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrenci form = new FrmOgrenci();
            form.Show();
        }

        private void eğitmenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEgitmen form = new FrmEgitmen();
            form.Show();
        }
    }
}
