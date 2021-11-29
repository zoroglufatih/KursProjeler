using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriRepository.Concrete
{
    public class Lecturer : BaseHuman
    {
        public string AcedemicTitle { get; set; }
        public int Salary { get; set; }
        public string Branch { get; set; }
    }
}
