using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] sayilar = { 10, 12, 51, 35, 20 };
            int sayac = 0;
            int toplam = 0;

            BaslikYaz("For");
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
                toplam += sayilar[i];
            }
            Console.WriteLine("***************");
            Console.WriteLine("Toplam: " + toplam);
            Console.WriteLine("***************");



            BaslikYaz("While");

            toplam = 0;
            while (sayac < sayilar.Length)
            {
                Console.WriteLine(sayilar[sayac]);
                toplam += sayilar[sayac];
                sayac++;
                
            }
            Console.WriteLine("***************");
            Console.WriteLine("Toplam: " + toplam);
            Console.WriteLine("***************");



            BaslikYaz("Do While");
            toplam = 0;
            sayac = 0;
            do
            {
                Console.WriteLine(sayilar[sayac]);
                toplam += sayilar[sayac];
                sayac++;
            } while (sayac < sayilar.Length);
            Console.WriteLine("***************");
            Console.WriteLine("Toplam: " + toplam);
            Console.WriteLine("***************");



            BaslikYaz("Foreach");
            toplam = 0;
            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
                toplam += sayi;
            }
            Console.WriteLine("***************");
            Console.WriteLine("Toplam: " + toplam);
            Console.WriteLine("***************");


        }
        public static void BaslikYaz(string baslik)
        {
            Console.WriteLine("***************");
            Console.WriteLine($"{baslik} Döngüsü");
            Console.WriteLine("***************");
        }
    }
}
