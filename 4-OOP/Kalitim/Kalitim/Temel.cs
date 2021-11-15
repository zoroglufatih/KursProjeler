using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    public class Temel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Cadde { get; set; }
        public string Sokak { get; set; }
        public int No { get; set; }
        public string Ilce { get; set; }
        public string Sehir { get; set; }
        public string Bolum { get; set; }
        public string Fullname()
        {
            return Ad + " " + Soyad;
        }
    }
}
