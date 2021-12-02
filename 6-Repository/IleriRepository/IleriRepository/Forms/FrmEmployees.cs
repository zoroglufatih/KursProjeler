using IleriRepository.Concrete;
using IleriRepository.Context;
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
    public partial class FrmEmployees : Form
    {
        public FrmEmployees()
        {
            InitializeComponent();
        }
        //PerContext db = new PerContext();
        EmpRepository empRep = new EmpRepository();
        EducationRepository edRep = new EducationRepository();
        CountyRepository countyRep = new CountyRepository();
        CityRepository cityRep = new CityRepository();
        Employees selectedEmp;
        private void FrmEmployees_Load(object sender, EventArgs e)
        {
            Fill();
            CbEducationFill();
            CbCityFill();
        }
        private void CbEducationFill()
        {
            edRep.GetCombo(cbEgitim);
        }

        private void CbCityFill()
        {
            cityRep.GetCombo(cbSehir);
        }

        private void Fill()
        {
            dataGridView1.DataSource = empRep.SummaryList();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedEmp = empRep.Find((int)dataGridView1.CurrentRow.Cells[0].Value);
            txHead.Text = selectedEmp.GetTitle() + " " + selectedEmp.GetAge();
            txName.Text = selectedEmp.Name;
            txSurname.Text = selectedEmp.Surname;
            txAvenue.Text = selectedEmp.Avenue;
            txStreet.Text = selectedEmp.Street;
            txHouseNumber.Text = selectedEmp.HouseNumber;
            txSalary.Text = selectedEmp.Salary.ToString();
            cbEgitim.SelectedValue = selectedEmp.EducationId;
            cbSehir.SelectedValue = selectedEmp.County.City.Id;
            cbIlce.SelectedValue = selectedEmp.CountyId;
            dtpBirthDay.Value = selectedEmp.BirthofDate;
        }

        private void cbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            countyRep.GetCombo(cbIlce, cbSehir);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            employees.Name = txName.Text;
            employees.Surname = txSurname.Text;
            employees.Avenue = txAvenue.Text;
            employees.Street = txStreet.Text;
            employees.Salary = Convert.ToInt32(txSalary.Text);
            employees.HouseNumber = txHouseNumber.Text;
            employees.EducationId = Convert.ToInt32(cbEgitim.SelectedValue);
            employees.CountyId = Convert.ToInt32(cbIlce.SelectedValue);
            employees.BirthofDate = dtpBirthDay.Value;
            empRep.Add(employees);
            empRep.Update();
            Fill();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            selectedEmp.Name = txName.Text;
            selectedEmp.Surname = txSurname.Text;
            selectedEmp.Salary = Convert.ToInt32(txSalary.Text);
            selectedEmp.Avenue = txAvenue.Text;
            selectedEmp.Street = txStreet.Text;
            selectedEmp.HouseNumber = txHouseNumber.Text;
            selectedEmp.BirthofDate= dtpBirthDay.Value;
            selectedEmp.CountyId = Convert.ToInt32(cbIlce.SelectedValue);
            selectedEmp.EducationId = Convert.ToInt32(cbEgitim.SelectedValue);
            empRep.Update();
            Fill();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            empRep.Delete(selectedEmp);
            empRep.Update();
            Fill();
        }
    }
}
