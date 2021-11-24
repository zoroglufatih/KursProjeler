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
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }
        FaturaDbEntities db = new FaturaDbEntities();
        Urun secUrun = new Urun();
        private void FrmUrun_Load(object sender, EventArgs e)
        {
            Doldur();
            CbBirimDoldur();
        }

        private void CbBirimDoldur()
        {
            cbBirim.DataSource = db.Set<Birim>().Select(x => new
            {
                Ad = x.BirimAd,
                Id = x.BirimId
            }).ToList();
            cbBirim.DisplayMember = "Ad";
            cbBirim.ValueMember = "Id";
        }

        private void Doldur()
        {
            dataGridView1.DataSource = db.Set<Urun>().Select(x => new
            {
                Id = x.UrunId,
                UrunAd = x.UrunAd,
                BFiyat = x.UrunBFiyat,
                Birim = x.Birim.BirimAd
            }).ToList();
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secId = (int) dataGridView1.CurrentRow.Cells[0].Value;
            secUrun = db.Set<Urun>().Find(secId);
            txUrunAd.Text = secUrun.UrunAd;
            txFiyat.Text = secUrun.UrunBFiyat.ToString();
            cbBirim.SelectedValue = secUrun.BirimId;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Urun yurun = new Urun();
            yurun.UrunAd = txUrunAd.Text;
            yurun.UrunBFiyat = Convert.ToDecimal(txFiyat.Text);
            yurun.BirimId = cbBirim.SelectedValue.ToString();
            db.Set<Urun>().Add(yurun);
            db.SaveChanges();
            Doldur();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            secUrun.UrunAd = txUrunAd.Text;
            secUrun.UrunBFiyat = Convert.ToDecimal(txFiyat.Text);
            secUrun.BirimId = cbBirim.SelectedValue.ToString();
            db.SaveChanges();
            Doldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            db.Set<Urun>().Remove(secUrun);
            db.SaveChanges();
            Doldur();
        }
    }
}
