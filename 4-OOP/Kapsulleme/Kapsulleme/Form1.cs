using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kapsulleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Musteri m = new Musteri();
            m.Ad = txAd.Text;
            m.Id = Convert.ToInt32(txId.Text);
            m.Soyad1 = txSoyad.Text;
            m.KKNO1 = txKKNO.Text;
            txOzet.Text = m.Ad + " " + m.Soyad1 + " " + m.KKNO1;
        }
    }
}
