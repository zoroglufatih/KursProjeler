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
    public partial class FrmEducation : Form
    {
        public FrmEducation()
        {
            InitializeComponent();
        }
        EducationRepository edRep = new EducationRepository();
        Education selectedEducation;
        private void FrmEducation_Load(object sender, EventArgs e)
        {
            Fill();
        }
        private void Fill()
        {
            dataGridView1.DataSource = edRep.SummaryList();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedEducation = edRep.Find((int)dataGridView1.CurrentRow.Cells[0].Value);
            txEducation.Text = selectedEducation.Name;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Education education = new Education();
            education.Name = txEducation.Text;
            edRep.Add(education);
            edRep.Update();
            Fill();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            selectedEducation.Name = txEducation.Text;
            edRep.Update();
            Fill();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            edRep.Delete(selectedEducation);
            edRep.Update();
            Fill();
        }
    }
}
