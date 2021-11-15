using Kalitimm.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitimm.Concrete
{
    public class TemelInsan : IAdres, IInsan
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Bolum { get; set; }
        public string Cadde { get; set; }
        public string Sokak { get; set; }
        public int No { get; set; }
        public string Ilce { get; set; }
        public string Sehir { get; set; }

        public List<string> AdresAl()
        {
            List<String> alist = new List<string>();
            alist.Add(FullName());
            alist.Add(Cadde);
            alist.Add(Sokak);
            alist.Add(No.ToString());
            alist.Add(Ilce + "/" + Sehir);
            return alist;
        }

        public virtual string FullName()
        {
            return "Sn " + Ad + " " + Soyad;
        }
    }
}
