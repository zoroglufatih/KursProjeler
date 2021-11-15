using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitimm
{
    abstract public class Temel
    {
        public Temel()
        {
            Adres = new Adres();
        }
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Bolum { get; set; }
        public Adres Adres { get; set; }
        public string FullName()
        {
            return "Sn. " + Ad + " " + Soyad;
        }
        
    }
}
