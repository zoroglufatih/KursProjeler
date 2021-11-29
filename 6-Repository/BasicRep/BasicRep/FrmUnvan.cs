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
    public partial class FrmUnvan : Form
    {
        public FrmUnvan()
        {
            InitializeComponent();
        }
        Repository<Unvan> repUnvan = new Repository<Unvan>();
        Unvan secUnvan;
        private void FrmUnvan_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void Doldur()
        {
            dataGridView1.DataSource = repUnvan.Set().Select(x => new
            {
                x.UnvanId,
                x.UnvanAd
            }).ToList();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            secUnvan = repUnvan.Bul((int)dataGridView1.CurrentRow.Cells[0].Value);
            //secUnvan = (Unvan)dataGridView1.CurrentRow.DataBoundItem;
            txUnvan.Text = secUnvan.UnvanAd;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Unvan unvan = new Unvan();
            unvan.UnvanAd = txUnvan.Text;
            repUnvan.Ekle(unvan);
            repUnvan.Kaydet();
            Doldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            repUnvan.Sil(secUnvan);
            repUnvan.Kaydet();
            Doldur();
        }

        private void btnGuncel_Click(object sender, EventArgs e)
        {
            secUnvan.UnvanAd = txUnvan.Text;
            repUnvan.Guncelle();
            Doldur();
        }

        private void txAra_TextChanged(object sender, EventArgs e)
        {
            if (txAra.Text != "")
            {
                dataGridView1.DataSource =
                repUnvan.Set().Where(x => x.UnvanAd.ToUpper().Contains(txAra.Text.ToUpper())).Select(x => new
                {
                    x.UnvanId,
                    x.UnvanAd
                }).ToList();
            }
            else
            {
                Doldur();
            }
        }
    }
}
