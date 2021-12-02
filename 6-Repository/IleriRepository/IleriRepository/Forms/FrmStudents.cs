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
    public partial class FrmStudents : Form
    {
        public FrmStudents()
        {
            InitializeComponent();
        }
        StudentRepository stdRep = new StudentRepository();
        CityRepository cityRep = new CityRepository();
        EducationRepository edRep = new EducationRepository();
        CountyRepository countyRep = new CountyRepository();
        Student selectedStudent;
        PerContext db = new PerContext();
        private void FrmStudents_Load(object sender, EventArgs e)
        {
            Fill();
            CbCityFill();
            CbLecturerFill();
            CbEducationFill();
        }

        private void CbLecturerFill()
        {
            cbLecturer.DataSource = db.Set<Lecturer>().Select(x => new
            {
                x.Id,
                NameSurname = x.Name + " " + x.Surname
            }).ToList();
            cbLecturer.DisplayMember = "NameSurname";
            cbLecturer.ValueMember = "Id";
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
            dataGridView1.DataSource = stdRep.SummaryList();
        }

        private void cbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            countyRep.GetCombo(cbIlce, cbSehir);
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedStudent = stdRep.Find((int)dataGridView1.CurrentRow.Cells[0].Value);
            txName.Text = selectedStudent.Name;
            txSurname.Text = selectedStudent.Surname;
            txStreet.Text = selectedStudent.Street;
            txHouseNumber.Text = selectedStudent.HouseNumber;
            txAvenue.Text = selectedStudent.Avenue;
            txUniDep.Text = selectedStudent.UniversityDep;
            dtpBirthDay.Value = selectedStudent.BirthofDate;
            cbEgitim.SelectedValue = selectedStudent.EducationId;
            cbSehir.SelectedValue = selectedStudent.County.CityId;
            cbIlce.SelectedValue = selectedStudent.CountyId;
            cbLecturer.SelectedValue = selectedStudent.LecturerId;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Name = txName.Text;
            student.Surname = txSurname.Text;
            student.Street = txStreet.Text;
            student.Avenue = txAvenue.Text;
            student.UniversityDep = txUniDep.Text;
            student.HouseNumber = txHouseNumber.Text;
            student.BirthofDate = dtpBirthDay.Value;
            student.CountyId = Convert.ToInt32(cbIlce.SelectedValue);
            student.LecturerId = Convert.ToInt32(cbLecturer.SelectedValue);
            student.EducationId = Convert.ToInt32(cbEgitim.SelectedValue);
            stdRep.Add(student);
            stdRep.Update();
            Fill();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            selectedStudent.Name = txName.Text;
            selectedStudent.Surname = txSurname.Text;
            selectedStudent.Street = txStreet.Text;
            selectedStudent.Avenue = txAvenue.Text;
            selectedStudent.UniversityDep = txUniDep.Text;
            selectedStudent.HouseNumber = txHouseNumber.Text;
            selectedStudent.BirthofDate= dtpBirthDay.Value;
            selectedStudent.CountyId = Convert.ToInt32(cbIlce.SelectedValue);
            selectedStudent.LecturerId = Convert.ToInt32(cbLecturer.SelectedValue);
            selectedStudent.EducationId = Convert.ToInt32(cbEgitim.SelectedValue);
            stdRep.Update();
            Fill();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            stdRep.Delete(selectedStudent);
            stdRep.Update();
            Fill();
        }
    }
}
