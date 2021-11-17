using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaProje
{
    public class Insan
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        private string KKNO { get; set; }
        protected string AnneSoyad { get; set; }
        public string GetKKNo()
        {
            return this.KKNO.Substring(0, 2) + "***********";
        }
        public string GetAnneSoyad()
        {
            return AnneSoyad.Substring(0, 2) + "*****";
        }
    }
}
