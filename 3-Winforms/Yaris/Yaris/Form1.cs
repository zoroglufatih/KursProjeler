using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yaris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void btnBasla_Click(object sender, EventArgs e)
        {
            SolaYasla();
        }
        private void SolaYasla()
        {
            pcBoxBeyaz.Left = 0;
            pcBoxSiyah.Left = 0;
            tmBasla.Enabled = true;
        }

        private void tmBasla_Tick(object sender, EventArgs e)
        {
            pcBoxSiyah.Left += rnd.Next(1, 20);
            pcBoxBeyaz.Left += rnd.Next(1, 20);
            if (pcBoxBeyaz.Right>= pnlFin.Left || pcBoxSiyah.Right >= pnlFin.Left)
            {
                tmBasla.Enabled = false;
                if (pcBoxSiyah.Right > pcBoxBeyaz.Right)
                {
                    MessageBox.Show("Siyah Kazandı!");
                }
                else if (pcBoxBeyaz.Right > pcBoxSiyah.Right)
                {
                    MessageBox.Show("Beyaz Kazandı!");
                }
                else
                {
                    MessageBox.Show("Berabere!");
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tmBasla.Interval = Convert.ToInt32(cmBoxSev.SelectedItem) * 100;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            SagaYasla();
        }
        private void SagaYasla()
        {
            pcBoxBeyaz.Left = pnlFin.Left - pcBoxBeyaz.Width;
            pcBoxSiyah.Left = pnlFin.Left - pcBoxSiyah.Width;
            tmBasla2.Enabled = true;
        }


        private void tmBasla2_Tick(object sender, EventArgs e)
        {
            pcBoxSiyah.Left -= rnd.Next(1, 20);
            pcBoxBeyaz.Left -= rnd.Next(1, 20);
            if (pcBoxBeyaz.Left<=0 || pcBoxSiyah.Left<=0)
            {
                tmBasla2.Enabled = false;
                if (pcBoxSiyah.Left < pcBoxBeyaz.Left)
                {
                    MessageBox.Show("Siyah Kazandı!");
                }
                else if (pcBoxBeyaz.Left < pcBoxSiyah.Left)
                {
                    MessageBox.Show("Beyaz Kazandı!");
                }
                else
                {
                    MessageBox.Show("Berabere!");
                }
            }
        }

        private void btnYerDeg_Click(object sender, EventArgs e)
        {
            YerDegis();
        }

        private void YerDegis()
        {
            int siyahTop = pcBoxSiyah.Top;
            int beyazTop = pcBoxBeyaz.Top;

            pcBoxBeyaz.Top = siyahTop;
            pcBoxSiyah.Top = beyazTop;
        }

        private void btnFormCol_Click(object sender, EventArgs e)
        {
            FormRenk();
        }

        private void FormRenk()
        {
            if (ClDiaForm.ShowDialog() == DialogResult.OK)
            {
                Color formrenk = ClDiaForm.Color;
                this.BackColor = formrenk;
            }
        }

        private void btnPanelCol_Click(object sender, EventArgs e)
        {
            PanelRenk();
        }

        private void PanelRenk()
        {
            if (ClDiaPanel.ShowDialog() == DialogResult.OK)
            {
                Color panelrenk = ClDiaPanel.Color;
                this.pnlFin.BackColor = panelrenk;
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            Fontt();
        }

        private void Fontt()
        {
            if (fontDialog2.ShowDialog() == DialogResult.OK)
            {
                Font fnt = fontDialog2.Font;
                this.Font = fnt;

            }
        }

        private void fontDialog2_Apply(object sender, EventArgs e)
        {
            
        }

        private void ileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SolaYasla();
        }

        private void geriYarışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SagaYasla();
        }

        private void formRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRenk();
        }

        private void panelRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelRenk();
        }

        private void yerDeğiştirmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YerDegis();
        }
    }
}
