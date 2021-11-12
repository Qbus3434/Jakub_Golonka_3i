using System;

namespace zadanie3
{
    class zadanie3
    {
        static void Main(string[] args)
        {
            int liczba;

            Console.WriteLine("Podaj liczbę: ");
            liczba = int.Parse(Console.ReadLine());

            if (liczba % 2 == 0)
            {
                Console.WriteLine("Liczba {0} jest parzysta.", liczba);
            }
            else
            {
                Console.WriteLine("Liczba {0} nie jest parzysta.", liczba);
            }

            Console.ReadKey();
        }
    }
}
