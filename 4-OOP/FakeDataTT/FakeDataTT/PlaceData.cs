using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeDataTT
{
    public static class PlaceData
    {
        static string[] sehirler = { "Ankara", "İstanbul", "İzmir", "Eskişehir", "Adana", "Zonguldak" };
        static string[] caddeler = { "Atatürk Caddesi", "Acıbadem Caddesi", "4. Cadde", "İncivez", "Ankara Caddesi", "2. Cadde" };
        static Random rnd = new Random();
        public static string GetCity()
        {
            //int indis = 0;
            //indis = rnd.Next(0, sehirler.Length);
            //string sehir = sehirler[indis];
            return sehirler[rnd.Next(0,sehirler.Length)];
        }
        public static string GetStreetName()
        {
            return caddeler[rnd.Next(0, caddeler.Length)];
        }
    }
}
