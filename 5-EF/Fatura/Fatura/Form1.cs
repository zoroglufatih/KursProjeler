using Fatura.Context;
using Fatura.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FaturaDbEntities db = new FaturaDbEntities();
        Label lb = new Label();
        TextBox txFatNo = new TextBox();
        Button btnOk = new Button();
        private void şehirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSehir frm = new FrmSehir();
            frm.Show();
        }

        private void ilçeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIlce frm = new FrmIlce();
            frm.Show();
        }

        private void urunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUrun frm = new FrmUrun();
            frm.Show();
        }

        private void musteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMusteri frm = new FrmMusteri();
            frm.Show();
        }

        private void birimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBirim frm = new FrmBirim();
            frm.Show();
        }

        private void goruntulemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnOk.Text = "Ok";
            lb.Text = "Fatura No";
            this.flowLayoutPanel1.Controls.Add(lb);
            flowLayoutPanel1.Controls.Add(txFatNo);
            flowLayoutPanel1.Controls.Add(btnOk);
            btnOk.Click += BtnOk_Click;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            FatMaster fm = db.Set<FatMaster>().Find(Convert.ToInt32(txFatNo.Text));
            if (fm == null)
            {
                MessageBox.Show("Böyle bir fatura yoktur.");
            }
            else
            {
                if (fm.SevkTarihi == null)
                {
                    FrmFatura frm = new FrmFatura(fm.FatNoId, false);
                    frm.Show();
                }
                else
                {
                    FrmFatura frm = new FrmFatura(fm.FatNoId, true);
                    frm.Show();
                }           
            }
        }

        private void girisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYFatura frm = new FrmYFatura();
            frm.Show();
        }
    }
}
