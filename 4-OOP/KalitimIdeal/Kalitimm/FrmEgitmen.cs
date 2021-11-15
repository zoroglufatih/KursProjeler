using Kalitimm.Concrete;
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
    public partial class FrmEgitmen : Form
    {
        public FrmEgitmen()
        {
            InitializeComponent();
        }
        List<Egitmen> elist = new List<Egitmen>();
        private void FrmEgitmen_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 11; i++)
            {
                Egitmen egt = new Egitmen();
                egt.Id = i;
                egt.Ad = FakeData.NameData.GetFirstName();
                egt.Soyad = FakeData.NameData.GetSurname();
                egt.Bolum = "Yazılım";
                egt.Brans = "Bilişim";
                egt.Cadde = FakeData.PlaceData.GetStreetName();
                egt.Ilce = FakeData.PlaceData.GetCounty();
                egt.Sehir = FakeData.PlaceData.GetCity();
                egt.Maas = FakeData.NumberData.GetNumber(10000, 80000);
                egt.No = FakeData.NumberData.GetNumber(1, 200);
                egt.Sokak = FakeData.PlaceData.GetStreetName();
                elist.Add(egt);
            }
            dataGridView1.DataSource = elist;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Egitmen secEgitmen =(Egitmen) dataGridView1.CurrentRow.DataBoundItem;
            listBox1.DataSource = secEgitmen.AdresAl();
        }
    }
}
