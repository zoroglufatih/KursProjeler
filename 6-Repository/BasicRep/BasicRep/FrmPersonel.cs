using BasicRep.Context;
using BasicRep.Repositories;
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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        Repository<Personel> repPersonel = new Repository<Personel>();
        PerDbEntities db = new PerDbEntities();
        Personel secPersonel;
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            Doldur();
            CbUnvanDoldur();
            CbYoneticiDoldur();
        }
        private void CbYoneticiDoldur()
        {
            cbYonetici.DataSource = db.Set<Personel>().Where(x => x.Unvan.UnvanId<3).Select(x => new
            {
                x.PersonelId,
                AdSoy = x.Ad + " " + x.Soyad
            }).ToList();
            cbYonetici.DisplayMember = "AdSoy";
            cbYonetici.ValueMember = "PersonelId";
        }
        private void CbUnvanDoldur()
        {
            cbUnvan.DataSource = db.Set<Unvan>().Select(x => new
            {
                x.UnvanId,
                x.UnvanAd
            }).ToList();
            cbUnvan.DisplayMember = "UnvanAd";
            cbUnvan.ValueMember = "UnvanId";
        }

        private void Doldur()
        {
            dataGridView1.DataSource = repPersonel.Set().Select(x => new
            {
                x.PersonelId,
                x.Ad,
                x.Soyad,
                x.Maaş,
                x.Unvan.UnvanAd,
                Yonetici = x.Personel2.Ad + " " + x.Personel2.Soyad
            }).ToList();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            secPersonel = repPersonel.Bul((int)dataGridView1.CurrentRow.Cells[0].Value);
            txAd.Text = secPersonel.Ad;
            txSoyad.Text = secPersonel.Soyad;
            txMaas.Text = secPersonel.Maaş.ToString();
            cbUnvan.SelectedValue = secPersonel.Unvan.UnvanId;
            if (secPersonel.YoneticiId != null)
            {
                cbYonetici.SelectedValue = secPersonel.Personel2.PersonelId;
            }
            else
            {
                cbYonetici.Text = "";
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            personel.Ad = txAd.Text;
            personel.Soyad = txSoyad.Text;
            personel.Maaş = Convert.ToInt32(txMaas.Text);
            personel.YoneticiId = Convert.ToInt32((int)cbYonetici.SelectedValue);
            personel.UnvanId = Convert.ToInt32((int)cbUnvan.SelectedValue);
            repPersonel.Ekle(personel);
            repPersonel.Kaydet();
            Doldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            repPersonel.Sil(secPersonel);
            repPersonel.Kaydet();
            Doldur();
        }

        private void btnGuncel_Click(object sender, EventArgs e)
        {
            secPersonel.Ad = txAd.Text;
            secPersonel.Soyad = txSoyad.Text;
            secPersonel.Maaş = Convert.ToInt32(txMaas.Text);
            secPersonel.YoneticiId = Convert.ToInt32(cbYonetici.SelectedValue);
            secPersonel.UnvanId = Convert.ToInt32(cbUnvan.SelectedValue);
            repPersonel.Guncelle();
            Doldur();
        }
    }
}
