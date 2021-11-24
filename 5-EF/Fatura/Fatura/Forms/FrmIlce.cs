using Fatura.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fatura.Forms
{
    public partial class FrmIlce : Form
    {
        public FrmIlce()
        {
            InitializeComponent();
        }
        FaturaDbEntities db = new FaturaDbEntities();
        Ilce secIlce = new Ilce();
        private void FrmIlce_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void Doldur()
        {
            dataGridView1.DataSource = db.Set<Ilce>().Select(x=> new
            {
                Id = x.IlceId,
                Ad = x.IlceAd
            }).ToList();
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            secIlce = db.Set<Ilce>().Find(secId);
            txIlceAd.Text = secIlce.IlceAd;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //int secId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            Ilce yIlce = new Ilce();
            yIlce.IlceAd = txIlceAd.Text;
            db.Set<Ilce>().Add(yIlce);
            db.SaveChanges();
            Doldur();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            secIlce.IlceAd = txIlceAd.Text;
            db.SaveChanges();
            Doldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            db.Set<Ilce>().Remove(secIlce);
            db.SaveChanges();
            Doldur();
        }
    }
}
