using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedenOOPModern
{
    public static class Kurum
    {
        public static string KurumAdi { get; set; }
        public static int Vno { get; set; }

        public static string KurumYaz()
        {
            Kurum.KurumAdi = "Bahçeşehir Üniversitesi";
            Kurum.Vno = 11111;
            return Kurum.KurumAdi + " Vd : " + Kurum.Vno;
        }
    }
}
