using PersonelProje.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelProje
{
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        PersonelContext db = new PersonelContext();
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void Doldur()
        {

            List<Personel> plist = db.Set<Personel>().ToList();
            dataGridView1.DataSource = plist;
        }
    }
}
