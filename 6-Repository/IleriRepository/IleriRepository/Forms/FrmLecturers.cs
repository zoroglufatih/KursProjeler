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
    public partial class FrmLecturers : Form
    {
        public FrmLecturers()
        {
            InitializeComponent();
        }
        LecRepository lecRep = new LecRepository();
        EducationRepository edRep = new EducationRepository();
        CountyRepository countyRep = new CountyRepository();
        CityRepository cityRep = new CityRepository();
        Lecturer selectedLecturer;
        private void FrmLecturers_Load(object sender, EventArgs e)
        {
            Fill();
            CbCityFill();
            CbEducationFill();
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
            dataGridView1.DataSource = lecRep.SummaryList();
        }

        private void cbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            countyRep.GetCombo(cbIlce, cbSehir);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedLecturer = lecRep.Find((int)dataGridView1.CurrentRow.Cells[0].Value);
            txName.Text = selectedLecturer.Name;
            txSurname.Text = selectedLecturer.Surname;
            txStreet.Text = selectedLecturer.Street;
            txSalary.Text = selectedLecturer.Salary.ToString();
            txHouseNumber.Text = selectedLecturer.HouseNumber;
            txBranch.Text = selectedLecturer.Branch;
            txAvenue.Text = selectedLecturer.Avenue;
            txAcademicTitle.Text = selectedLecturer.AcedemicTitle;
            dtpBirthDay.Value = selectedLecturer.BirthofDate;
            cbEgitim.SelectedValue = selectedLecturer.EducationId;
            cbSehir.SelectedValue = selectedLecturer.County.CityId;
            cbIlce.SelectedValue = selectedLecturer.CountyId;
            txHead.Text = selectedLecturer.GetTitle() + " " + selectedLecturer.GetAge();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Lecturer lecturer = new Lecturer();
            lecturer.Name = txName.Text;
            lecturer.Surname = txSurname.Text;
            lecturer.Street = txStreet.Text;
            lecturer.Salary = Convert.ToInt32(txSalary.Text);
            lecturer.HouseNumber = txHouseNumber.Text;
            lecturer.Branch = txBranch.Text;
            lecturer.Avenue = txAvenue.Text;
            lecturer.AcedemicTitle = txAcademicTitle.Text;
            lecturer.BirthofDate = dtpBirthDay.Value;
            lecturer.EducationId = Convert.ToInt32(cbEgitim.SelectedValue);
            lecturer.CountyId = Convert.ToInt32(cbIlce.SelectedValue);
            lecRep.Add(lecturer);
            lecRep.Update();
            Fill();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            selectedLecturer.Name = txName.Text;
            selectedLecturer.Surname = txSurname.Text;
            selectedLecturer.Street = txStreet.Text;
            selectedLecturer.Salary = Convert.ToInt32(txSalary.Text);
            selectedLecturer.HouseNumber = txHouseNumber.Text;
            selectedLecturer.Branch = txBranch.Text;
            selectedLecturer.Avenue = txAvenue.Text;
            selectedLecturer.AcedemicTitle = txAcademicTitle.Text;
            selectedLecturer.BirthofDate = dtpBirthDay.Value;
            selectedLecturer.EducationId = Convert.ToInt32(cbEgitim.SelectedValue);
            selectedLecturer.CountyId = Convert.ToInt32(cbIlce.SelectedValue);
            lecRep.Update();
            Fill();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lecRep.Delete(selectedLecturer);
            lecRep.Update();
            Fill();
        }
    }
}
