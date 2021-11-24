using PersonelDbFirst.Context;
using PersonelDbFirst.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelDbFirst
{
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        PersonelContext db = new PersonelContext();
        Personel secPer;
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            Doldur();
            CmDoldurYonetici();
            CmDoldurUnvan();
        }

        private void CmDoldurUnvan()
        {
            cbUnvan.DataSource = db.Set<Unvan>().Select(x => new
            {
                x.UnvanId,
                x.UnvanAd
            }).ToList();
            cbUnvan.DisplayMember = "UnvanAd";
            cbUnvan.ValueMember = "UnvanId";
        }

        private void CmDoldurYonetici()
        {
            cbYonetici.DataSource = db.Set<Personel>().Where(x => x.Personel1.Count>0).Select(x => new
            {
                x.PersonelId,
                AdSoy = x.Ad + " " + x.Soyad
            }).ToList();
            cbYonetici.DisplayMember = "AdSoy";
            cbYonetici.ValueMember = "PersonelId";
        }

        private void Doldur()
        {
            dataGridView1.DataSource = db.Set<Personel>().Select(x => new PersonelDTO
            {
                Id = x.PersonelId,
                AdSoy = x.Ad + " " + x.Soyad,
                Yoneticisi = x.Personel2.Ad + " " + x.Personel2.Soyad
            }).ToList();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            secPer = db.Set<Personel>().Find(secId);
            ICollection<Personel> plist = secPer.Personel1;
            lsEleman.Items.Clear();
            foreach (var item in plist)
            {
                lsEleman.Items.Add(item);
            }

            txAd.Text = secPer.Ad;
            txSoyad.Text = secPer.Soyad;
            txMaas.Text = secPer.Maaş.ToString();
            cbYonetici.SelectedValue = secPer.Personel2.PersonelId;
            cbUnvan.SelectedValue = secPer.UnvanId;
        }
    }
}
