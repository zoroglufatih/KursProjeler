using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriRepository.Concrete
{
    public class Employees : BaseHuman
    {
        public int EducationId { get; set; }
        public int Salary { get; set; }
        [ForeignKey("CountyId")]
        public virtual County County { get; set; }
        [ForeignKey("EducationId")]
        public virtual Education Education { get; set; }
    }
}
