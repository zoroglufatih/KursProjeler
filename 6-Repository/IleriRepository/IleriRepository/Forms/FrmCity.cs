using IleriRepository.Concrete;
using IleriRepository.Repositories.BaseRepository.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IleriRepository.Forms
{
    public partial class FrmCity : Form
    {
        public FrmCity()
        {
            InitializeComponent();
        }
        CityRepository cityRep = new CityRepository();
        City selectedCity;
        private void FrmCity_Load(object sender, EventArgs e)
        {
            Fill();
        }
        private void Fill()
        {
            dataGridView1.DataSource = cityRep.SummaryList();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedCity = cityRep.Find((int)dataGridView1.CurrentRow.Cells[0].Value);
            txCity.Text = selectedCity.Name;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            City city = new City();
            city.Name = txCity.Text;
            cityRep.Add(city);
            cityRep.Update();
            Fill();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            selectedCity.Name = txCity.Text;
            cityRep.Update();
            Fill();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cityRep.Delete(selectedCity);
            cityRep.Update();
            Fill();
        }
    }
}
