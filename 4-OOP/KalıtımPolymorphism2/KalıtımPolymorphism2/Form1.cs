using KalıtımPolymorphism2.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalıtımPolymorphism2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDortgen_Click(object sender, EventArgs e)
        {
            DortgenProfil d = new DortgenProfil();
            d.Id = 1;
            d.KKenar = 5;
            d.UKenar = 12;
            d.Yukseklik = 17;
            d.UrunAd = "5x12x17 Aliminyum Profil";
            d.FireOran = 0.2m;
            txFire.Text = d.Fire().ToString();
            txHacim.Text = d.Hacim().ToString();
            txTaban.Text = d.TabanAlan().ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnKup_Click(object sender, EventArgs e)
        {
            KupProfil k = new KupProfil();
            k.Id = 1;
            k.Yukseklik = 17;
            k.UrunAd = "17x17x17 Aliminyum Profil";
            k.FireOran = 0.2m;
            txFire.Text = k.Fire().ToString();
            txHacim.Text = k.Hacim().ToString();
            txTaban.Text = k.TabanAlan().ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SilindirProfil s = new SilindirProfil();
            s.Id = 1;
            s.YariCap = 15;
            s.Yukseklik = 17;
            s.UrunAd = "15x15x17 Aliminyum Profil";
            s.FireOran = 0.2m;
            txFire.Text = s.Fire().ToString();
            txHacim.Text = s.Hacim().ToString();
            txTaban.Text = s.TabanAlan().ToString();
        }
    }
}
