using KalıtımPolymorphism2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalıtımPolymorphism2.Concrete
{
    abstract public class TemelUrun : IUrun
    {
        public int Id { get; set; }
        public string UrunAd { get; set; }
        public decimal Yukseklik { get; set; }
        public decimal FireOran { get; set; }
        public decimal Fire()
        {
            return Hacim() * FireOran;
        }

        public decimal Hacim()
        {
            return TabanAlan() * Yukseklik;
        }

        public virtual decimal TabanAlan()
        {
            return Yukseklik * Yukseklik;
        }
    }
}
