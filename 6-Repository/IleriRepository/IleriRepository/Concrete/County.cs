using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriRepository.Concrete
{
    public class County : BaseTable
    {
        public County()
        {
            Students = new HashSet<Student>();
            Lecturers = new HashSet<Lecturer>();
            Employees = new HashSet<Employees>();
        }
        public int CityId { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Lecturer> Lecturers { get; set; }
        public virtual ICollection<Employees> Employees { get; set; }
        [ForeignKey("CityId")]
        public virtual City City { get; set; }
    }
}
