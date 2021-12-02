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
    public partial class FrmCounty : Form
    {
        public FrmCounty()
        {
            InitializeComponent();
        }
        CountyRepository countyRep = new CountyRepository();
        CityRepository cityRep = new CityRepository();
        County selectedCounty;
        private void FrmCounty_Load(object sender, EventArgs e)
        {
            Fill();
            FillTheCbCity();
        }

        private void FillTheCbCity()
        {
            cityRep.GetCombo(cbCity);
        }

        private void Fill()
        {
            dataGridView1.DataSource = countyRep.SummaryList();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedCounty = countyRep.Find((int)dataGridView1.CurrentRow.Cells[0].Value);
            txCounty.Text = selectedCounty.Name;
            cbCity.SelectedValue = selectedCounty.CityId;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            County county = new County();
            county.Name = txCounty.Text;
            county.CityId = Convert.ToInt32(cbCity.SelectedValue);
            countyRep.Add(county);
            countyRep.Update();
            Fill();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            selectedCounty.Name = txCounty.Text;
            selectedCounty.CityId = Convert.ToInt32(cbCity.SelectedValue);
            countyRep.Update();
            Fill();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            countyRep.Delete(selectedCounty);
            countyRep.Update();
            Fill();
        }
    }
}
