using System;

namespace TipDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            object arkaRenk = 0; //(0 - 15 arası deger alabilir)
            object onRenk = ConsoleColor.Red;
            // 1. donusum şekli Casting
            Console.ForegroundColor = (ConsoleColor) onRenk;
            Console.BackgroundColor = (ConsoleColor)arkaRenk;
            string ad = "Fatih";
            string soyad = "Zoroğlu";
            var fullName = ad + " " + soyad;
            Console.WriteLine($"Ad Soyad: {fullName}");
            string a = "100";
            string b = "200";
            var toplam = a + b;
            Console.WriteLine($"Toplam: {toplam}");

            // 2. donusum yontemi 
            int toplam1 = Convert.ToInt32(a)+Convert.ToInt32(b);
            Console.WriteLine($"Toplam: {toplam1}");

            // 3. donusum yontemi
            long TcNo = 121135544;
            string fullname2 = ad + soyad + TcNo.ToString();
            Console.WriteLine(fullname2);
        }
    }
}
