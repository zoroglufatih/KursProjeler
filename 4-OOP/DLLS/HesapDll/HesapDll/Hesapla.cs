using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HesapDll
{
    public class Hesapla
    {
        public int Topla(int a, int b)
        {
            return a + b;
        }
        public int Cikar(int a, int b)
        {
            return a - b;
        }
        public int Bol(int a, int b)
        {
            return a/ b;
        }
        public int Carp(int a, int b)
        {
            return a * b;
        }
        public int Karekok(int a, int b = 0)
        {
            return (int)Math.Sqrt(a);
        }
        //public PropertyInfo [] GetProps()
        //{
        //    return typeof(Hesapla).GetProperties();
        //}
        public MethodInfo[] GetMethods()
        {
            return typeof(Hesapla).GetMethods();
        }
    }
}
