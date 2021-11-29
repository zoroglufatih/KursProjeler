using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriRepository.Concrete
{
    public class BaseHuman
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthofDate { get; set; }
        public string Street { get; set; }
        public string Avenue { get; set; }
        public string HouseNumber { get; set; }
        public int CountyId { get; set; }

        public List<string> GetAddress()
        {
            List<string> alist = new List<string>();
            alist.Add(GetTitle());
            alist.Add(Street);
            alist.Add(Avenue);
            alist.Add(HouseNumber);
            return alist;
        }

        public int GetAge()
        {
            var today = DateTime.Now;
            int age = today.Year - BirthofDate.Year;
            var BirthDay = BirthofDate.AddYears(age);
            if (BirthDay < today)
            {
                return age;
            }
            else
            {
                return age - 1;
            }
        }

        public virtual string GetTitle()
        {
            return "Sn. " + Name + " " + Surname;
        }
    }
}
