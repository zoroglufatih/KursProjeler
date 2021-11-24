using IleriPersonel.Context;
using IleriPersonel.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IleriPersonel
{
    public partial class FrmCalisan : FrmTemel
    {
        public FrmCalisan()
        {
            InitializeComponent();
        }
        PersonelContext db = new PersonelContext();
        Calisan secCalisan;
        private void FrmCalisan_Load(object sender, EventArgs e)
        {
            Doldur();
            DoldurCmBoxes();
            DoldurCmIlce(1);
        }

        private void DoldurCmIlce(int v)
        {
            cbIlce.DataSource = db.Set<Ilce>().Select(x => new
            {
                Ad = x.Ad,
                Id = x.Id,
                SehirId = x.SehirId
            }).Where(x=> x.SehirId == v).ToList();
            cbIlce.DisplayMember = "Ad";
            cbIlce.ValueMember = "Id";
        }

        private void DoldurCmBoxes()
        {
            cbEgitim.DataSource = db.Set<Egitim>().Select(x => new
            {
                Ad = x.Ad,
                Id = x.Id
            }).ToList();
            cbEgitim.DisplayMember = "Ad";
            cbEgitim.ValueMember = "Id";

            cbSehir.DisplayMember = "Ad";
            cbSehir.ValueMember = "Id";
            cbSehir.DataSource = db.Set<Sehir>().Select(x => new
            {
                Ad = x.Ad,
                Id = x.Id
            }).ToList();
            

        }

        private void Doldur()
        {
            dataGridView1.DataSource = db.Set<Calisan>().Select(x => new InsanDTO
            {
                Id = x.Id,
                Ad = x.Ad,
                Soyad = x.Soyad,
                Ilce = x.Ilce.Ad,
                Sehir = x.Ilce.Sehir.Ad
            }).ToList();
        }

        private void cbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secilenSehirId = 0;
            try
            {
                secilenSehirId = (int)cbSehir.SelectedValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            DoldurCmIlce(secilenSehirId);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            secCalisan = db.Set<Calisan>().Find(secId);
            txAd.Text = secCalisan.Ad;
            txSoyad.Text = secCalisan.Soyad;
            txMaas.Text = secCalisan.Maas.ToString();
            cbIlce.SelectedValue = secCalisan.IlceId;
            cbSehir.SelectedValue = secCalisan.Ilce.SehirId;
            cbEgitim.SelectedValue = secCalisan.EgitimId;
            lsAdres.DataSource = secCalisan.AdresAl();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Calisan calisan = new Calisan();
            calisan.Ad = txAd.Text;
            calisan.Soyad = txSoyad.Text;
            calisan.Maas = Convert.ToDecimal(txMaas.Text);
            calisan.IlceId = (int)cbIlce.SelectedValue;
            calisan.EgitimId = (int)cbEgitim.SelectedValue;
            db.Set<Calisan>().Add(calisan);
            db.SaveChanges();
            Doldur();
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            secCalisan.Ad = txAd.Text;
            secCalisan.Soyad = txSoyad.Text;
            secCalisan.Maas = Convert.ToDecimal(txMaas.Text);
            secCalisan.IlceId = (int)cbIlce.SelectedValue;
            secCalisan.EgitimId = (int)cbEgitim.SelectedValue;
            db.SaveChanges();
            Doldur();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            db.Set<Calisan>().Remove(secCalisan);
            db.SaveChanges();
            Doldur();
        }
    }
}
