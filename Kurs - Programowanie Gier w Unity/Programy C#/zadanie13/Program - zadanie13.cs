using System;

namespace zadanie13
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba os1 = new Osoba("Zenon ", "Ćwik");
            Osoba os2 = new Osoba("Szymon ", "Sowa");
            Osoba os3 = new Osoba("Artur ", "Klatka");
            Osoba os4 = new Osoba("Adam ", "Moszycki");
            Osoba os5 = new Osoba("Dominik ", "Żuchowicz");
            Osoba os6 = new Osoba("Bartosz ", "Szczygieł");

            Klasa k1 = new Klasa("informatyk1");
            Klasa k2 = new Klasa("informatyk2");

            k1.dodajUcznia(os2);
            k1.dodajUcznia(os3);
            k1.dodajUcznia(os4);

            k2.dodajUcznia(os5);
            k2.dodajUcznia(os6);

            Szkola zs4 = new Szkola("Zespół Szkół nr 4", os1, k1, k2);
            zs4.daneSzkoly();

            Console.ReadKey();
        }
    }
}
