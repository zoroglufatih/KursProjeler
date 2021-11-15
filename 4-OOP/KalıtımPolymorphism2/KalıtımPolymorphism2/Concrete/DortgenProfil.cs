using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalıtımPolymorphism2.Concrete
{
    public class DortgenProfil : TemelUrun
    {
        public decimal KKenar { get; set; }
        public decimal UKenar { get; set; }
        public override decimal TabanAlan()
        {
            return KKenar * UKenar;
        }
    }
}
