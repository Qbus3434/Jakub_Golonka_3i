using System;

namespace zadanie2
{
    class zadanie2
    {
        static void Main(string[] args)
        {
            double bok, pole, obwod;

            Console.WriteLine("Podaj bok kwadratu: ");
            bok = double.Parse(Console.ReadLine());

            pole = bok * bok;
            obwod = 4 * bok;

            Console.WriteLine("Pole kwadratu o boku {0} wynosi: {1}", bok, pole);
            Console.WriteLine("Obwód kwadratu o boku {0} wynosi: {1}", bok, obwod);
            Console.ReadKey();
        }
    }
}
