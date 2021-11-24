using Fatura.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fatura.Forms
{
    public partial class FrmSehir : Form
    {
        
        public FrmSehir()
        {
            InitializeComponent();

        }
        FaturaDbEntities db = new FaturaDbEntities();
        Sehir secSehir = new Sehir();
        private void FrmSehir_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void CbIlceDoldur()
        {
            throw new NotImplementedException();
        }

        private void Doldur()
        {
            dataGridView1.DataSource = db.Set<Sehir>().Select(x => new
            {
                Id = x.SehirId,
                Ad = x.SehirAd
            }).ToList();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            secSehir = db.Set<Sehir>().Find(secId);
            
        }
    }
}
