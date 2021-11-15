using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalıtımPolymorphism2.Concrete
{
    public class SilindirProfil : TemelUrun
    {
        public decimal YariCap { get; set; }
        public override decimal TabanAlan()
        {
            return 3.14m * YariCap * YariCap;
        }
    }
}
