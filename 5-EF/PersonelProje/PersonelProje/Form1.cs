using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void şehirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSehir frm = new FrmSehir();
            frm.Show();
        }

        private void personelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonel frm = new FrmPersonel();
            frm.Show();
        }

        private void dTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPerDTO frm = new FrmPerDTO();
            frm.Show();
        }
    }
}
