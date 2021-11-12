using System;

namespace zadanie6
{
    class zadanie6
    {
        static void Main(string[] args)
        {
            int liczba1, liczba2, liczba3, najwieksza;

            Console.WriteLine("Podaj pierwszą liczbę: ");
            liczba1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            liczba2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            liczba3 = int.Parse(Console.ReadLine());

            najwieksza = liczba1;
            if (liczba2 > najwieksza) najwieksza = liczba2;
            if (liczba3 > najwieksza) najwieksza = liczba3;

            Console.WriteLine("Największą liczbą z liczb {0},{1},{2} to liczba: {3} ", liczba1, liczba2,liczba3,najwieksza);
            Console.ReadKey();
        }
    }
}
