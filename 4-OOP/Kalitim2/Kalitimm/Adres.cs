using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitimm
{
    public class Adres
    {
        public string Cadde { get; set; }
        public string Sokak { get; set; }
        public int No { get; set; }
        public string Ilce { get; set; }
        public string Sehir { get; set; }
        public List<String> AdresAl()
        {
            List<String> alist = new List<string>();
            alist.Add(Cadde);
            alist.Add(Sokak);
            alist.Add(No.ToString());
            alist.Add(Ilce + " " + Sehir);
            return alist;
        }
    }
    
}
