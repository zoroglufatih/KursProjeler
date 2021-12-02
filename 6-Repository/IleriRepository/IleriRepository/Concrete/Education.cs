﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriRepository.Concrete
{
    public class Education : BaseTable
    {
        public Education()
        {
            Students = new HashSet<Student>();
            Lecturers = new HashSet<Lecturer>();
            Employees = new HashSet<Employees>();
        }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Lecturer> Lecturers { get; set; }
        public virtual ICollection<Employees> Employees { get; set; }
    }
}
