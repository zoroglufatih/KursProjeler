using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeDataTT
{
    public static class NumberData
    {
        static Random rnd = new Random();
        public static int GetNumber()
        {
            return rnd.Next();
        }
        public static int GetNumber(int max)
        {
            return rnd.Next(max);
        }
        public static int GetNumber(int min, int max)
        {
            return rnd.Next(min, max);
        }
        public static double GetNumber(bool d = true)
        {
            return rnd.NextDouble();
        }
        
    }
}
