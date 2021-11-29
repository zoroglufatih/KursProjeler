using BasicRep.Context;
using BasicRep.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicRep
{
    public partial class FrmPersonel2 : Form
    {
        public FrmPersonel2()
        {
            InitializeComponent();
        }
        Repository<Personel> repPersonel = new Repository<Personel>();
        private void FrmPersonel2_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void Doldur()
        {
            dataGridView1.DataSource = repPersonel.Liste();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var plist = repPersonel.Qry().Where(x=> x.PersonelId>3);
            foreach (var item in plist)
            {
                item.Maaş += 50;
            }
            repPersonel.Guncelle();
            Doldur();
            
        }
    }
}
