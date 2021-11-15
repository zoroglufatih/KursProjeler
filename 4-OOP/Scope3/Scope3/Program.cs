using System;

namespace Scope3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            Console.WriteLine("x ilk değeri: " + x);
            x = İkiyeKatla(x);
            //x = x * 2;
            Console.WriteLine("x'in metot sonrası değeri: " + x);
        }

        private static int İkiyeKatla(int x)
        {
            return x * 2;
            //x = x * 2;
            //return x;
            //Console.WriteLine("x'in metot içi değeri: " + x);
        }
    }
}
