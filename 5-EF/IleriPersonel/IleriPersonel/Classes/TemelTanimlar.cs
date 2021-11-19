using IleriPersonel.Context;
using IleriPersonel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IleriPersonel.Classes
{
    abstract public class TemelTanimlar : ITanim
    {
        PersonelContext db = new PersonelContext();
        public int Id { get; set; }
        public string Ad { get; set; }
    }
}
