using PersonelProje.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelProje
{
    public partial class FrmSehir : Form
    {
        public FrmSehir()
        {
            InitializeComponent();
        }
        PersonelContext db = new PersonelContext();
        Sehir SecSehir;
        private void FrmSehir_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void Doldur()
        {
            //List<Sehir> slist = db.Sehir.ToList();
            List<Sehir> slist = db.Set<Sehir>().ToList();
            dataGridView1.DataSource = slist;
            // select * from Sehir
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SecSehir = (Sehir)dataGridView1.CurrentRow.DataBoundItem;
            txtAd.Text = SecSehir.SehirAd;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sehir ySehir = new Sehir();
            ySehir.SehirAd = txtAd.Text;
            //db.Sehir.Add(ySehir);
            //db.Entry(ySehir).State = EntityState.Added;
            db.Set<Sehir>().Add(ySehir);
            //insert into ....
            db.SaveChanges();
            Doldur();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //db.Sehir.Remove(SecSehir);
            //db.Entry(SecSehir).State = EntityState.Deleted;
            db.Set<Sehir>().Remove(SecSehir);
            //delete from sehir
            db.SaveChanges();
            Doldur();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SecSehir.SehirAd = txtAd.Text;
            //db.Entry(SecSehir).State = EntityState.Modified;
            db.SaveChanges();
            Doldur();
        }
    }
}
