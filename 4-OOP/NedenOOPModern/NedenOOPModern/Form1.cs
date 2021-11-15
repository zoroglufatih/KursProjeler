﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NedenOOPModern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            txKurum.Text = Kurum.KurumYaz();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Id = Convert.ToInt32(txId.Text);
            ogrenci.Ad = txAd.Text;
            ogrenci.Soyad = txSoyad.Text;
            ogrenci.DogumTarihi = dtDtarih.Value;
            ogrenci.Cinsiyet = ckCins.Checked;
            txOzet.Text = ogrenci.AdSoy();
            txDetay.Text = ogrenci.DetayYaz();
            txOzet2 = ogrenci.AdSoy(txOzet2);
            
        }
    }
}
