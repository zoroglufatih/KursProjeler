using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicRep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void unvanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUnvan frm = new FrmUnvan();
            frm.Show();
        }

        private void personelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonel frm = new FrmPersonel();
            frm.Show();
        }

        private void personel2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonel2 frm = new FrmPersonel2();
            frm.Show();
        }
    }
}
