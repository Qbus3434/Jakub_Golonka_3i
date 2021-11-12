using System;

namespace zadanie13
{
    public class Klasa
    {
        public string NazwaKlasy { get; set; }
        public Osoba[] Uczniowie { get; set; }

        public Klasa(string nazwaKlasy)
        {
            NazwaKlasy = nazwaKlasy;
            Uczniowie = new Osoba[30];
        }

        public void dodajUcznia(Osoba uczen)
        {
            for(int i = 0; i < Uczniowie.Length; i++)
            {
                if(Uczniowie[i] == null)
                {
                    Uczniowie[i] = uczen;
                    return;
                }
            }
        }

        public void wypiszUczniow()
        {
            foreach (Osoba uczen in Uczniowie)
            {
                if(uczen != null)
                    Console.WriteLine($"Uczeń: {uczen.Imie}{uczen.Nazwisko}");
            }
        }
    }
}
