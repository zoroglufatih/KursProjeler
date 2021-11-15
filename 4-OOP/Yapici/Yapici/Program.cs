using System;

namespace Yapici
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel p = new Personel();
            p.Id = 1;
            p.AdSoy = "Ali Yılmaz";
            Console.WriteLine(p.AdSoy);
            Console.WriteLine(p.KayitTarihi);
        }
    }
}
