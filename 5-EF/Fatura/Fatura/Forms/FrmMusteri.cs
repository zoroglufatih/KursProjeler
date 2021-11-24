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
    public partial class FrmMusteri : Form
    {
        public FrmMusteri()
        {
            InitializeComponent();
        }
        FaturaDbEntities db = new FaturaDbEntities();
        Musteri secMusteri = new Musteri();
        private void FrmMusteri_Load(object sender, EventArgs e)
        {
            Doldur();
            CbSehirDoldur(1);
        }

        private void CbSehirDoldur(int v)
        {
            cbSehir.DataSource = db.Set<Sehir>().Select(x => new
            {
                Ad = x.SehirAd,
                Id = x.SehirId,
            }).ToList();
            cbSehir.DisplayMember = "Ad";
            cbSehir.ValueMember = "Id";
        }

        private void Doldur()
        {
            dataGridView1.DataSource = db.Set<Musteri>().Select(x=> new
            {
                Id = x.MusteriId,
                Ad = x.MusteriAd,
                Soyad = x.MusteriSoyad,
                Sehir = x.Sehir.SehirAd,
                Adres = x.MusteriAdres
            }).ToList();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            secMusteri = db.Set<Musteri>().Find(secId);
            txAd.Text = secMusteri.MusteriAd;
            txSoyad.Text = secMusteri.MusteriSoyad;
            txAdres.Text = secMusteri.MusteriAdres;
            cbSehir.SelectedValue = secMusteri.Sehir.SehirId;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Musteri ymusteri = new Musteri();
            ymusteri.MusteriAd = txAd.Text;
            ymusteri.MusteriSoyad = txSoyad.Text;
            ymusteri.MusteriAdres = txAdres.Text;
            ymusteri.SehirId = (int)cbSehir.SelectedValue;
            db.Set<Musteri>().Add(ymusteri);
            db.SaveChanges();
            Doldur();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            secMusteri.MusteriAd = txAd.Text;
            secMusteri.MusteriSoyad= txSoyad.Text;
            secMusteri.MusteriAdres = txAdres.Text;
            secMusteri.SehirId = (int)cbSehir.SelectedValue;
            db.SaveChanges();
            Doldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            db.Set<Musteri>().Remove(secMusteri);
            db.SaveChanges();
            Doldur();
        }
    }
}
