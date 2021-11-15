using System;

namespace Scope
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            Console.WriteLine("x ilk değeri: " + x);
            İkiyeKatla(x);
            Console.WriteLine("x'in metot sonrası değeri: " + x);
        }

        private static void İkiyeKatla(int x)
        {
            x = x * 2;
            Console.WriteLine("x'in metot içi değeri: " + x);
        }
    }
}
