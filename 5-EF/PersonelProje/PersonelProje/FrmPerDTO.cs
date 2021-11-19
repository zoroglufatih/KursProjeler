using PersonelProje.Context;
using PersonelProje.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelProje
{
    public partial class FrmPerDTO : Form
    {
        public FrmPerDTO()
        {
            InitializeComponent();
        }
        PersonelContext db = new PersonelContext();
        Personel secPersonel = new Personel();
        List<PersonelDTO> plist = new List<PersonelDTO>();
        private void FrmPerDTO_Load(object sender, EventArgs e)
        {
            Doldur();
            CmDoldur();
        }

        private void CmDoldur()
        {
            var slist = db.Set<Sehir>().Select(x => new
            {
                x.SehirId, x.SehirAd
            }).ToList();
            cmPer.DataSource = slist;
            cmPer.DisplayMember = "SehirAd";
            cmPer.ValueMember = "SehirId";
        }

        private void Doldur()
        {
            plist = db.Set<Personel>().Select(x => new PersonelDTO
            {
                Id = x.Id,
                Ad = x.Ad,
                Soyad = x.Soyad,
                Maas = x.Maas,
                Cins = x.Cins,
                SehirAd = x.Sehir.SehirAd
            }).ToList();
            dataGridView1.DataSource = plist;

            //decimal tmaas = plist.Sum(x => x.Maas);
            txToplam.Text = plist.Sum(x => x.Maas).ToString();
            //decimal omaas = plist.Average(x => x.Maas);
            txOrt.Text = plist.Average(x => x.Maas).ToString();
            txPer.Text = plist.Count.ToString();
            txToplamE.Text = plist.Where(x => x.Cins == "E").Sum(x => x.Maas).ToString();
            txToplamK.Text = plist.Where(x => x.Cins == "K").Sum(x => x.Maas).ToString();
            txOrtEr.Text = plist.Where(x => x.Cins == "E").Average(x => x.Maas).ToString();
            txOrtKd.Text = plist.Where(x => x.Cins == "K").Average(x => x.Maas).ToString();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            secPersonel = db.Set<Personel>().Find(secId);
            txAd.Text = secPersonel.Ad;
            txSoyad.Text = secPersonel.Soyad;
            txCins.Text = secPersonel.Cins;
            txMaas.Text = secPersonel.Maas.ToString();
            //txSehirId.Text = secPersonel.SehirId.ToString();
            cmPer.SelectedValue = secPersonel.SehirId;
        }

        private void ckAdSira_CheckedChanged(object sender, EventArgs e)
        {
            //plist = plist.OrderBy(x => x.Ad).ToList();
            //dataGridView1.DataSource = plist;
        }

        private void ckMaasSira_CheckedChanged(object sender, EventArgs e)
        {
            //plist = plist.OrderBy(x => x.Maas).ToList();
            //dataGridView1.DataSource = plist;
        }

        private void ckAdSira_CheckStateChanged(object sender, EventArgs e)
        {
            if (ckAdSira.Checked)
            {
                plist = plist.OrderBy(x => x.Ad).ToList();
                dataGridView1.DataSource = plist;
            }
            else
            {
                plist = plist.OrderBy(x => x.Id).ToList();
                dataGridView1.DataSource = plist;
            }
        }

        private void ckMaasSira_CheckStateChanged(object sender, EventArgs e)
        {
            if (ckMaasSira.Checked)
            {
                plist = plist.OrderBy(x => x.Maas).ToList();
                dataGridView1.DataSource = plist;
            }
            else
            {
                plist = plist.OrderBy(x => x.Id).ToList();
                dataGridView1.DataSource = plist;
            }
        }

        private void txAra_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txAra.Text))
            {
                List<PersonelDTO> ylist = plist.Where(x => x.Ad.ToLower().Contains(txAra.Text.ToLower()) ||
                    x.Soyad.ToLower().Contains(txAra.Text.ToLower())).ToList();
                dataGridView1.DataSource = ylist;
            }
            else
            {
                Doldur();
                //plist = plist.OrderBy(x => x.Id).ToList();
                //dataGridView1.DataSource = plist;
            }
            
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Personel ypersonel = new Personel();
            ypersonel.Ad = txAd.Text;
            ypersonel.Soyad = txSoyad.Text;
            ypersonel.Cins = txCins.Text;
            ypersonel.Maas = Convert.ToDecimal(txMaas.Text);
            //ypersonel.SehirId = Convert.ToInt32(txSehirId.Text);
            ypersonel.SehirId = (int)cmPer.SelectedValue;
            db.Set<Personel>().Add(ypersonel);
            db.SaveChanges();
            Doldur();
        }

        private void btnGuncel_Click(object sender, EventArgs e)
        {
            secPersonel.Ad = txAd.Text;
            secPersonel.Cins = txCins.Text;
            secPersonel.Soyad = txSoyad.Text;
            //secPersonel.SehirId = Convert.ToInt32(txSehirId.Text);
            secPersonel.SehirId = (int)cmPer.SelectedValue;
            secPersonel.Maas = Convert.ToDecimal(txMaas.Text);
            db.SaveChanges();
            Doldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            db.Set<Personel>().Remove(secPersonel);
            db.SaveChanges();
            Doldur();
        }
    }
}
