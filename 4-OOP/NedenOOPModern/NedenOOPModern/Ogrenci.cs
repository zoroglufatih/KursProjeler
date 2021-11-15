using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NedenOOPModern
{
    public class Ogrenci
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public bool Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string AdSoy()
        {
            return Ad + ' ' + Soyad.ToUpper();
        }
        public TextBox AdSoy(TextBox t)
        {
            t.Text = Ad + ' ' + Soyad.ToUpper();
            t.BackColor = System.Drawing.Color.Yellow;
            return t;
        }
        public int YasHesapla()
        {
            DateTime Bugun = DateTime.Now;
            int Yas = Bugun.Year - DogumTarihi.Year;
            DateTime dogumGun = DogumTarihi.AddYears(Yas);
            if (dogumGun > Bugun)
            {
                Yas -= 1;
            }

            return Yas;
        }
        public string DetayYaz()
        {
            return AdSoy() + "(" + YasHesapla() + ")";
        }

        
    }
}
