using System;

namespace zadanie12
{
    class Program
    {
        static void Main(string[] args)
        {
            Sprzedaz bulka = new Sprzedaz("bułka", 10, 0.99m);
            Sprzedaz mleko = new Sprzedaz("łaciate", 3, 2.60m);

            Zamowienie zamowienie1 = new Zamowienie(new DateTime(2021, 11, 12), "Pan Jacek");
            zamowienie1.dodajPozycje(bulka, 1);
            zamowienie1.dodajPozycje(mleko, 3);

            zamowienie1.daneZamowienia();


            Zamowienie zamowienie2 = new Zamowienie(new DateTime(2021, 11, 12), "Pan Marek");
            zamowienie2.dodajPozycje(bulka, 3);
            zamowienie2.dodajPozycje(mleko, 6);
            zamowienie2.dodajPozycje("szynka", 5, 38.22m);

            zamowienie2.daneZamowienia();


            Console.ReadKey();
        }
    }
}
