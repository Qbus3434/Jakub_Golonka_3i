using System;

namespace zadanie9
{
    class zadanie9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę: ");
            int liczba1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            int liczba2 = int.Parse(Console.ReadLine());

            int zakres = liczba2 - liczba1;
            int[,] tabliczka = new int[zakres + 1, 10];

            for (int i = 0; i < zakres + 1; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    tabliczka[i, j] = liczba1 * (j + 1);
                    Console.Write(tabliczka[i, j] + "\t");
                }
                Console.WriteLine();
                liczba1++;
            }

            Console.ReadKey();

        }
    }
}
