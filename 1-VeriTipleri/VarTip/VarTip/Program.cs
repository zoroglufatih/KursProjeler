using System;

namespace VarTip
{
    class Program
    {
        static void Main(string[] args)
        {
            var onRenk = ConsoleColor.White;
            ConsoleColor arkaRenk = ConsoleColor.Red;
            Console.BackgroundColor = arkaRenk;
            Console.ForegroundColor = onRenk;
            Console.Clear();

            var x = 100;
            decimal d1 = 50.25m;
            var EH = true;
            var ad = "Fatih";
            Console.WriteLine("Int Tip: " + x);
            Console.WriteLine("Dec Tip: " + d1);
            Console.WriteLine("Bool Tip: " + EH);
            Console.WriteLine("String Tip: " + ad);
        }
    }
}
