using System;

namespace zadanie4
{
    class zadanie4
    {
        static void Main(string[] args)
        {
            int liczba1, liczba2;

            Console.WriteLine("Podaj pierwszą liczbę: ");
            liczba1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            liczba2 = int.Parse(Console.ReadLine());

            if (liczba1 < liczba2)
            {
                Console.WriteLine("Liczba {0} jest mniejsza od {1}.", liczba1, liczba2);
            }
            else if (liczba1 == liczba2)
            {
                Console.WriteLine("Liczby są równe.");
            }
            else
            {
                Console.WriteLine("Liczba {0} jest większa od {1}.", liczba1, liczba2);
            }

            Console.ReadKey();
        }
    }
}
