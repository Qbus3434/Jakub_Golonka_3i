using System;

namespace zadanie11
{
    class Program
    {
        static void Main(string[] args)
        {
            Produkt maslo = new Produkt("masło", 3.99m, "kg", new DateTime(2021, 5, 23));
            maslo.daneProduktu();
            Console.WriteLine();

            Produkt chleb = new Produkt("chleb", 2.99m, "kg", new DateTime(2021, 5, 31));
            chleb.daneProduktu();
            Console.WriteLine();

            Produkt szynka = new Produkt();
            Console.WriteLine();
            chleb.daneProduktu();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
