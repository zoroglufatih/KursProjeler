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
    public partial class FrmYFatura : Form
    {
        public FrmYFatura()
        {
            InitializeComponent();
        }
        FaturaDbEntities db = new FaturaDbEntities();
        private void FrmYFatura_Load(object sender, EventArgs e)
        {
            Combo();
        }

        private void FMaster()
        {
            FatMaster fm = new FatMaster();
            fm.FatTarih = DateTime.Now;
            fm.MusteriId = (int)cbMusteri.SelectedValue;
            db.Set<FatMaster>().Add(fm);
            db.SaveChanges();
            FrmFatura frm = new FrmFatura(fm.FatNoId, false);
            frm.Show();
        }
        private void Combo()
        {
            cbMusteri.DataSource = db.Set<Musteri>().Select(x=> new
            {
                x.MusteriId,
                x.MusteriAd
            }).ToList();
            cbMusteri.DisplayMember = "MusteriAd";
            cbMusteri.ValueMember = "MusteriId";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FMaster();
        }
    }
}
