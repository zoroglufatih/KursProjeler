using IleriPersonel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriPersonel.Classes
{
    abstract public class TemelInsan : IInsan, IAdres
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int IlceId { get; set; }
        public int EgitimId { get; set; }
        public int KapiNo { get; set; }
        public string Cadde { get; set; }
        public string Sokak { get; set; }
        public List<string> AdresAl()
        {
            List<string> adres = new List<string>();
            adres.Add(UnvanYaz());
            adres.Add(Cadde);
            adres.Add(Sokak);
            adres.Add("No " + KapiNo);
            return adres;
        }

        public virtual string UnvanYaz()
        {
            return "Sn. " + Ad + " " + Soyad;
        }
    }
}
