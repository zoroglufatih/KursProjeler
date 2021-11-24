using PersonelDbFirst.Context;
using PersonelDbFirst.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelDbFirst
{
    public partial class FrmUnvan : Form
    {
        public FrmUnvan()
        {
            InitializeComponent();
        }
        PersonelContext db = new PersonelContext();
        Unvan secUnvan;
        private void FrmUnvan_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Set<Unvan>().Select(x => new
            {
                x.UnvanId,
                x.UnvanAd
            }).ToList();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            secUnvan = db.Set<Unvan>().Find(secId);
            var personeller = secUnvan.Personel;
            lsEleman.Items.Clear();
            foreach (var item in personeller)
            {
                lsEleman.Items.Add(item);
            }
        }
    }
}
