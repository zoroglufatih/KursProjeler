using System;

namespace Scope2
{
    class Program
    {
        static int x = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("x ilk değeri: " + x);
            İkiyeKatla();
            Console.WriteLine("x'in metot sonrası değeri: " + x);
        }

        private static void İkiyeKatla()
        {
            x = x * 2;
            Console.WriteLine("x'in metot içi değeri: " + x);
        }
    }
}
