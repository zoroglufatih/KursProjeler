using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FakeDataTT;

namespace PersonelProjeT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Personel> plist = new List<Personel>();
        Personel secPersonel;
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 101; i++)
            {
                Personel p = new Personel();
                p.Id = i;
                p.Ad = FakeDataTT.NameData.GetFirstName();
                p.Soyad = FakeDataTT.NameData.GetSurname();
                p.Cadde = FakeDataTT.PlaceData.GetStreetName();
                p.Sehir = FakeDataTT.PlaceData.GetCity();
                p.Maas = FakeDataTT.NumberData.GetNumber(10000, 50000);
                plist.Add(p);
            }
            dataGridView1.DataSource = plist;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            secPersonel = (Personel)dataGridView1.CurrentRow.DataBoundItem;
            txId.Text = secPersonel.Id.ToString();
            txAd.Text = secPersonel.Ad;
            txSoyad.Text = secPersonel.Soyad;
            txSehir.Text = secPersonel.Sehir;
            txCadde.Text = secPersonel.Cadde;
        }
    }
}
