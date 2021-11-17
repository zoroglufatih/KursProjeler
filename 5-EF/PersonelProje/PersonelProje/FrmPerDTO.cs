using PersonelProje.Context;
using PersonelProje.DTO;
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
    public partial class FrmPerDTO : Form
    {
        public FrmPerDTO()
        {
            InitializeComponent();
        }
        PersonelContext db = new PersonelContext();
        private void FrmPerDTO_Load(object sender, EventArgs e)
        {
            Doldur();
            
        }

        private void Doldur()
        {
            List<PersonelDTO> plist = db.Set<Personel>().Select(x => new PersonelDTO
            {
                Id = x.Id,
                Ad = x.Ad,
                Soyad = x.Soyad,
                Maas = x.Maas,
                Cins = x.Cins,
                SehirAd = x.Sehir.SehirAd
            }).ToList();
            dataGridView1.DataSource = plist;

            //decimal tmaas = plist.Sum(x => x.Maas);
            txToplam.Text = plist.Sum(x => x.Maas).ToString();
            //decimal omaas = plist.Average(x => x.Maas);
            txOrt.Text = plist.Average(x => x.Maas).ToString();
            txPer.Text = plist.Count.ToString();
            txToplamE.Text = plist.Where(x => x.Cins == "E").Sum(x => x.Maas).ToString();
            txToplamK.Text = plist.Where(x => x.Cins == "K").Sum(x => x.Maas).ToString();
            txOrtEr.Text = plist.Where(x => x.Cins == "E").Average(x => x.Maas).ToString();
            txOrtKd.Text = plist.Where(x => x.Cins == "K").Average(x => x.Maas).ToString();
        }
    }
}
