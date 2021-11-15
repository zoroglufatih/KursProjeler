using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsulleme
{
    public class Musteri
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad1 { get => Soyad; set => Soyad = value.ToUpper(); }
        public string KKNO1 { get => KKNO; set => KKNO = "*******" + value.Substring(value.Length-2,2); }

        private string Soyad;
        private string KKNO;
    }
}
