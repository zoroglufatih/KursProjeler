using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalitimm
{
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }
        List<Ogrenci> olist = new List<Ogrenci>();
        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 11; i++)
            {
                Ogrenci ogr = new Ogrenci();
                ogr.Id = i;
                ogr.Ad = FakeData.NameData.GetFirstName();
                ogr.Soyad = FakeData.NameData.GetSurname();
                ogr.Bolum = "Yazılım";
                ogr.Adres.Cadde = FakeData.PlaceData.GetStreetName();
                ogr.Adres.Ilce = FakeData.PlaceData.GetCounty();
                ogr.Adres.Sehir = FakeData.PlaceData.GetCity();
                ogr.Adres.No = FakeData.NumberData.GetNumber(1, 200);
                ogr.Adres.Sokak = FakeData.PlaceData.GetStreetName();
                olist.Add(ogr);
            }
            dataGridView1.DataSource = olist;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Ogrenci secOgrenci = (Ogrenci)dataGridView1.CurrentRow.DataBoundItem;
            listBox1.DataSource = secOgrenci.Adres.AdresAl();
        }
    }
}
