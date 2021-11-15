using System;

namespace OzelVeriTipleri
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor onRenk = ConsoleColor.White;
            ConsoleColor arkaRenk = ConsoleColor.Red;
            Console.BackgroundColor = arkaRenk;
            Console.ForegroundColor = onRenk;
            Console.Clear();

            int x = 100;
            decimal d1 = 50.25m;
            bool EH = true;
            string ad = "Fatih";
            Console.WriteLine("Int Tip: " + x);
            Console.WriteLine("Dec Tip: " + d1);
            Console.WriteLine("Bool Tip: " + EH);
            Console.WriteLine("String Tip: " + ad);
        }
    }
}
