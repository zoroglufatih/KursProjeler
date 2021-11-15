using System;
using System.Collections.Generic;
using System.Text;

namespace Yapici
{
    public class Personel
    {
        public int Id { get; set; }
        public string AdSoy { get; set; }
        public DateTime KayitTarihi { get; set; }
        public Personel()
        {
            KayitTarihi = DateTime.Now;
        }
        
    }
}
