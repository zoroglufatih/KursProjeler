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
        FaturaDbEntities db = new FaturaDbEntities();
        public FrmFatura(int fatNoId)
        {
            InitializeComponent();
            gelenFatNo = fatNoId;
        }

        private void FrmFatura_Load(object sender, EventArgs e)
        {
            FatMaster fm = db.Set<FatMaster>().Find(gelenFatNo);
            txAd.Text = fm.Musteri.MusteriAd;
            txFatNo.Text = gelenFatNo.ToString();
            txSoyad.Text = fm.Musteri.MusteriSoyad;
            txTarih.Text = fm.FatTarih.ToString();
            txAdres.Text = fm.Musteri.MusteriAdres;
        }
    }
}
