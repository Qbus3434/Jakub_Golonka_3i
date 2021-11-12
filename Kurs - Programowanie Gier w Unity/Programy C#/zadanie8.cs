using System;

namespace zadanie8
{
    class zadanie8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ile imion chcesz wpisać?");
            int ileImion = int.Parse(Console.ReadLine());
            string[] imiona = new string[ileImion];

            int i = 0;
            while (i < ileImion)
            {
                Console.WriteLine("Podaj {0} imie: ", i+1);
                imiona[i] = Console.ReadLine();
                i++;
            }
            Console.WriteLine();
            foreach(var imie in imiona)
            {
                Console.Write(imie + " ");
            }

            Console.ReadKey();
        }
    }
}
