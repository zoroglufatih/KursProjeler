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
    public partial class FrmBirim : Form
    {
        public FrmBirim()
        {
            InitializeComponent();
        }
        FaturaDbEntities db = new FaturaDbEntities();
        Birim secBirim = new Birim();
        private void FrmBirim_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void Doldur()
        {
            dataGridView1.DataSource = db.Set<Birim>().Select(x => new
            {
                Id = x.BirimId,
                BirimAd = x.BirimAd
            }).ToList();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string secId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            secBirim = db.Set<Birim>().Find(secId);
            txId.Text = secBirim.BirimId;
            txAd.Text = secBirim.BirimAd;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Birim ybirim = new Birim();
            ybirim.BirimId = txId.Text;
            ybirim.BirimAd = txAd.Text;
            db.Set<Birim>().Add(ybirim);
            db.SaveChanges();
            Doldur();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //secBirim.BirimId = txId.Text.ToString();
            secBirim.BirimAd = txAd.Text;
            db.SaveChanges();
            Doldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            db.Set<Birim>().Remove(secBirim);
            db.SaveChanges();
            Doldur();
        }
    }
}
