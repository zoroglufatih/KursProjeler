using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FakeDataT;
using FakeDataTT;

namespace PersonelProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Personel> plist = new List<Personel>();
        Personel secPersonel;
        RandomData randomData = new RandomData();
        NameData nameData = new NameData();
        private void Form1_Load(object sender, EventArgs e)
        {
            


            for (int i = 1; i < 11; i++)
            {
                Personel p = new Personel();
                //p.Ad = FakeData.NameData.GetFirstName();
                p.Cadde = FakeData.PlaceData.GetStreetName();
                int c = FakeData.NumberData.GetNumber(0, 2);
                p.Ad = nameData.GetFirstName();
                //p.Cadde = randomData.IsimGetir();
                if (c == 1)
                {
                    p.Cins = "E";
                }
                else p.Cins = "K";
                p.Sehir = FakeData.PlaceData.GetCity();
                p.Id = i;
                p.Soyad = FakeData.NameData.GetSurname();
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
            txSehir.Text = secPersonel.Ad;
            txCadde.Text = secPersonel.Cadde;
            txCins.Text = secPersonel.Cins;
        }
    }
}
