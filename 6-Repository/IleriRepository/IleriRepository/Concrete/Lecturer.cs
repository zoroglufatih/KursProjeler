using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriRepository.Concrete
{
    public class Lecturer : BaseHuman
    {
        public Lecturer()
        {
            Students = new HashSet<Student>();
        }
        public int EducationId { get; set; }
        public string AcedemicTitle { get; set; }
        public int Salary { get; set; }
        public string Branch { get; set; }
        [ForeignKey("CountyId")]
        public virtual County County { get; set; }
        [ForeignKey("EducationId")]
        public virtual Education Education { get; set; }
        public virtual ICollection<Student> Students { get; set; }

        public override string GetTitle()
        {
            return "Sn. " + AcedemicTitle + " " + Name + " " + Surname;
        }
    }
}
