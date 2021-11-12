using System;

namespace zadanie13
{
    public class Szkola
    {
        public string NazwaSzkoly { get; set; }
        public Osoba Dyrektor { get; set; }
        public Klasa[] Klasy { get; set; }

        public Szkola(string nazwaSzkoly, Osoba dyrektor, params Klasa[] klasa)
        {
            NazwaSzkoly = nazwaSzkoly;
            Dyrektor = dyrektor;
            Klasy = new Klasa[klasa.Length];
            for (int i = 0; i < klasa.Length; i++)
            {
                Klasy[i] = klasa[i];

            }
        }

        public void daneSzkoly()
        {
            Console.WriteLine("Nazwa szkoły: {0}", NazwaSzkoly);
            Console.WriteLine("Dyrektor: {0}{1}", Dyrektor.Imie, Dyrektor.Nazwisko);
            Console.WriteLine("Ilość klas: {0}", Klasy.Length);

            for (int i = 0; i < Klasy.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Uczniowie w klasie o nazwie {Klasy[i].NazwaKlasy}:");
                Klasy[i].wypiszUczniow();
            }
        }
    }
}