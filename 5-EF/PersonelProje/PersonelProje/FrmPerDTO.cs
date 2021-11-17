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
                SehirAd = x.Sehir.SehirAd
            }).ToList();
            dataGridView1.DataSource = plist;
        }
    }
}
