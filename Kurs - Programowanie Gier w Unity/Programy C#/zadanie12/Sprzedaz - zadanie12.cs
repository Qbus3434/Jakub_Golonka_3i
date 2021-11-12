using System;

namespace zadanie12
{
    public class Sprzedaz
    {
        #region PolaKlasy
        public string nazwaProduktu;
        public int ilosc;
        public decimal cena;
        #endregion

        #region Konstruktor
        public Sprzedaz(string nazwaProduktu, int ilosc, decimal cena)
        {
            this.nazwaProduktu = nazwaProduktu;
            this.ilosc = ilosc;
            this.cena = cena;
        }


        public void wypisz()
        {
            Console.WriteLine($"Produkt o nazwie {nazwaProduktu} w ilości {ilosc} w cenie {cena} za sztukę.");
        }
        #endregion
    }
}