using IleriRepository.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IleriRepository
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void eğitimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEducation frm = new FrmEducation();
            frm.Show();
        }

        private void ilçeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCounty frm = new FrmCounty();
            frm.Show();
        }

        private void şehirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCity frm = new FrmCity();
            frm.Show();
        }

        private void çalışanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmployees frm = new FrmEmployees();
            frm.Show();
        }

        private void öğrencilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStudents frm = new FrmStudents();
            frm.Show();
        }

        private void eğitmenlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLecturers frm = new FrmLecturers();
            frm.Show();
        }
    }
}
