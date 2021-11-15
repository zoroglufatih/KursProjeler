using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeDataT
{
    public class RandomData
    {
        private readonly Random _random = new Random();
        public int RandomNumber (int min = 0, int max = 10)
        {
            return _random.Next(min, max);
        }
        public Random rnd = new Random();
        public int RndNmbr()
        {
            return rnd.Next(0, 10);
        }
        public string IsimGetir()
        {
            /*Random rastgele = new Random();
            int sayi = Convert.ToInt32(rastgele.Next(0, 10));*/

            string[] isimler =
            {
                "Fatih" , "Yiğit", "Emre","Mert", "Resul","İrem", "Mahmut", "Hüseyin", "Murat", "Gizem"
            };
            return isimler[RndNmbr()];
        }
        public string SoyGetir()
        {
            string[] soylar =
            {
                "Zoroğlu" , "Koşar", "Bahar","Vurgun", "Yağ","Altıntaş", "Bulut", "Mutlu", "Yücel", "Usta"
            };
            return soylar[RandomNumber()];
        }
        public string SehirGetir()
        {
            string[] sehirler =
            {
                "Zonguldak" , "İstanbul", "Erzincan","Kastamonu", "Düzce","Sivas", "Aydın", "Amasya", "Antalya", "Ankara"
            };
            return sehirler[RandomNumber()];
        }
    }
}
