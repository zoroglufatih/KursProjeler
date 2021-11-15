using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitimm.Concrete
{
    public class Egitmen:TemelInsan
    {
        public int Maas { get; set; }
        public string Brans { get; set; }
        public string Unvan { get; set; }
        public int NetHesapla()
        {
            return 0;
        }
        public override string FullName()
        {
            return "Sn. " + Unvan + " " + Ad + " " + Soyad;
        }
    }
}
