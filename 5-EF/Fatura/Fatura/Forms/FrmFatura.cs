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
    public partial class FrmFatura : Form
    {
        public FrmFatura()
        {
            InitializeComponent();
        }
        int gelenFatNo;
        FatDetay secFatDetay;
        bool _sevk;
        FaturaDbEntities db = new FaturaDbEntities();
        ComboBox cbUrun = new ComboBox();
        Label lbUrun = new Label();
        Button btnOk = new Button();
        public FrmFatura(int fatNoId, bool sevk)
        {
            InitializeComponent();
            gelenFatNo = fatNoId;
            _sevk = sevk;
            btnEkle.Enabled = !_sevk;
            btnGuncel.Enabled = !_sevk;
            btnSil.Enabled = !_sevk;
            btnSevk.Enabled = !_sevk;
        }

        private void FrmFatura_Load(object sender, EventArgs e)
        {
            if(_sevk == true)
            {
                lbSevk.Text = "Bu Fatura Sevk Edilmiş";
            }
            else
            {
                lbSevk.Text = "Bu Fatura Sevk Edilmemiş";
            }
            FatMaster();
            FatDetay(gelenFatNo);
        }
        private void FatDetay(int gelenFatNo)
        {
            var fdlist = db.Set<FatDetay>().Select(x => new
            {
                x.FatNoId,
                x.UrunId,
                x.Urun.UrunAd,
                x.Bfiyat,
                x.Miktar,
                x.Urun.Birim.BirimAd,
                toplam = x.Bfiyat * x.Miktar
            }).Where(x => x.FatNoId == gelenFatNo).ToList();
            dataGridView1.DataSource = fdlist;
            txFatTop.Text = fdlist.Sum(x => x.toplam).ToString();
        }
        private void FatMaster()
        {
            FatMaster fm = db.Set<FatMaster>().Find(gelenFatNo);
            txAd.Text = fm.Musteri.MusteriAd;
            txFatNo.Text = gelenFatNo.ToString();
            txSoyad.Text = fm.Musteri.MusteriSoyad;
            txTarih.Text = fm.FatTarih.ToString();
            txAdres.Text = fm.Musteri.MusteriAdres;
        }

        private void btnGuncel_Click(object sender, EventArgs e)
        {
            secFatDetay.Miktar = Convert.ToInt32(txMiktar.Text);
            db.SaveChanges();
            FatDetay(gelenFatNo);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            int secUrunId = (int)dataGridView1.CurrentRow.Cells[1].Value;
            secFatDetay = db.Set<FatDetay>().Find(secId, secUrunId);
            txMiktar.Text = secFatDetay.Miktar.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            db.Set<FatDetay>().Remove(secFatDetay);
            db.SaveChanges();
            FatDetay(gelenFatNo);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Combo();
        }

        private void Combo()
        {
            lbUrun.Text = "Ürün";
            btnOk.Text = "Ok";
            cbUrun.DataSource = db.Set<Urun>().Select(x => new
            {
                x.UrunId,
                x.UrunAd
            }).ToList();
            cbUrun.DisplayMember = "UrunAd";
            cbUrun.ValueMember = "UrunId";
            flowLayoutPanel1.Controls.Add(lbUrun);
            flowLayoutPanel1.Controls.Add(cbUrun);
            flowLayoutPanel1.Controls.Add(btnOk);
            txMiktar.Text = "1";
            btnOk.Click += BtnOk_Click;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            //1. Yol
            //try
            //{
            //    FatDetay fd = new FatDetay();
            //    Urun secUrun = db.Set<Urun>().Find((int)cbUrun.SelectedValue);
            //    fd.Bfiyat = secUrun.UrunBFiyat;
            //    fd.FatNoId = gelenFatNo;
            //    fd.Miktar = Convert.ToInt32(txMiktar.Text);
            //    fd.UrunId = secUrun.UrunId;
            //    db.Set<FatDetay>().Add(fd);
            //    db.SaveChanges();
            //    FatDetay(gelenFatNo);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //2. Yol

            FatDetay fd = new FatDetay();
            Urun secUrun = db.Set<Urun>().Find((int)cbUrun.SelectedValue);
            FatDetay fdCheck = db.Set<FatDetay>().Find(gelenFatNo, secUrun.UrunId);
            if(fdCheck == null)
            {
                fd.Bfiyat = secUrun.UrunBFiyat;
                fd.FatNoId = gelenFatNo;
                fd.Miktar = Convert.ToInt32(txMiktar.Text);
                fd.UrunId = secUrun.UrunId;
                db.Set<FatDetay>().Add(fd);
                db.SaveChanges();
                FatDetay(gelenFatNo);
            }
            else
            {
                MessageBox.Show("Böyle bir ürün mevcuttur.");
            }
            

        }

        private void btnSevk_Click(object sender, EventArgs e)
        {
            db.Set<FatMaster>().Find(gelenFatNo).SevkTarihi = DateTime.Now;
            db.SaveChanges();
            MessageBox.Show("İrsaliye basıldı sevkiyat hazır.");
        }
    }
}
