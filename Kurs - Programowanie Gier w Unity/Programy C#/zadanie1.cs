using System;

namespace zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            string imie = "";
            string nazwisko = "";

            //string imie, nazwisko;

            Console.WriteLine("Podaj imię: ");
            imie = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko: ");
            nazwisko = Console.ReadLine();

            //Console.WriteLine("Imię: " + imie + " Nazwisko: " + nazwisko);
            //Console.WriteLine("Imię : {0} Nazwisko: {1}", imie, nazwisko);

            Console.WriteLine($"Imię: {imie}");
            Console.WriteLine($"Nazwisko: {nazwisko}");
            Console.ReadKey();
        }
    }
}
