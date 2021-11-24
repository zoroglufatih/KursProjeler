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
    public partial class FrmEgitmen : Form
    {
        public FrmEgitmen()
        {
            InitializeComponent();
        }
        PersonelContext db = new PersonelContext();
        Egitmen secEgitmen;
        private void FrmEgitmen_Load(object sender, EventArgs e)
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
            }).Where(x => x.SehirId == v).ToList();
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
            dataGridView1.DataSource = db.Set<Egitmen>().Select(x => new InsanDTO
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

            secilenSehirId = (int)cbSehir.SelectedValue;



            DoldurCmIlce(secilenSehirId);
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            secEgitmen = db.Set<Egitmen>().Find(secId);
            txAd.Text = secEgitmen.Ad;
            txSoyad.Text = secEgitmen.Soyad;
            txMaas.Text = secEgitmen.Maas.ToString();
            txUnvan.Text = secEgitmen.Unvan;
            cbIlce.SelectedValue = secEgitmen.IlceId;
            cbSehir.SelectedValue = secEgitmen.Ilce.Sehir.Id;
            cbEgitim.SelectedValue = secEgitmen.EgitimId;
            lsAdres.DataSource = secEgitmen.AdresAl();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Egitmen egitmen = new Egitmen();
            egitmen.Ad = txAd.Text;
            egitmen.Soyad = txSoyad.Text;
            egitmen.Maas = Convert.ToDecimal(txMaas.Text);
            egitmen.IlceId = (int)cbIlce.SelectedValue;
            egitmen.EgitimId = (int)cbEgitim.SelectedValue;
            egitmen.Unvan = txUnvan.Text;
            db.Set<Egitmen>().Add(egitmen);
            db.SaveChanges();
            Doldur();
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            secEgitmen.Ad = txAd.Text;
            secEgitmen.Soyad = txSoyad.Text;
            secEgitmen.Maas = Convert.ToDecimal(txMaas.Text);
            secEgitmen.IlceId = (int)cbIlce.SelectedValue;
            secEgitmen.EgitimId = (int)cbEgitim.SelectedValue;
            secEgitmen.Unvan = txUnvan.Text;
            db.SaveChanges();
            Doldur();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            db.Set<Egitmen>().Remove(secEgitmen);
            db.SaveChanges();
            Doldur();
        }
    }
}
