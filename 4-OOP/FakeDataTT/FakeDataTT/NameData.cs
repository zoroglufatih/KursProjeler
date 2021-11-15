using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeDataTT
{
    public static class NameData
    {
        static string[] isimler = { "Fatih", "Hakan", "Yiğit", "Emre", "Resul", "Mert", "İrem" };
        static string[] soyadlar = { "Zoroğlu", "Taşıyan", "Koşar", "Bahar", "Yağ", "Vurgun", "Altıntaş" };
        static Random rnd = new Random();
        public static string GetFirstName()
        {
            return isimler[rnd.Next(0, isimler.Length)];
        }
        public static string GetSurname()
        {
            return soyadlar[rnd.Next(0, soyadlar.Length)];
        }
        public static string GetFullName()
        {
            return isimler[rnd.Next(0, isimler.Length)] + " " + soyadlar[rnd.Next(0, soyadlar.Length)];
        }
    }
}
