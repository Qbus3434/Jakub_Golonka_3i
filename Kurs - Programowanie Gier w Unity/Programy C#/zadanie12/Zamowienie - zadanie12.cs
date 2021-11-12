using System;

namespace zadanie12
{
    class Zamowienie
    {
        #region PolaKlasy
        public DateTime data;
        public string klient;
        Sprzedaz[] pozycjeZamowienia;
        #endregion

        #region Konstruktor
        public Zamowienie(DateTime data, string klient)
        {
            this.data = data;
            this.klient = klient;
            pozycjeZamowienia = new Sprzedaz[20];
        }
        #endregion

        #region Metody
        public void dodajPozycje(Sprzedaz produkt, int pozycjaNaZamowieniu)
        {
            if(pozycjaNaZamowieniu < 20 && pozycjeZamowienia[pozycjaNaZamowieniu] == null)
                pozycjeZamowienia[pozycjaNaZamowieniu] = produkt;
            else
                Console.WriteLine("ERROR - Nie udało sie dodać produktu {0} do zamówienia na pozycję {1}",produkt.nazwaProduktu, pozycjaNaZamowieniu);
        }

        public void dodajPozycje(string nazwaProduktu, int ilosc, decimal cena)
        {
            Sprzedaz nowyProdukt = new Sprzedaz(nazwaProduktu, ilosc, cena);
            for (int i = 0; i < pozycjeZamowienia.Length; i++)
            {
                if(pozycjeZamowienia[i] == null)
                {
                    pozycjeZamowienia[i] = nowyProdukt;
                    break;
                }
            }
        }

        public void daneZamowienia()
        {
            Console.WriteLine($"Klient {klient} w dniu {data.ToString("yyyy.mm.dd")} zakupił: ");
            foreach (Sprzedaz item in pozycjeZamowienia)
            {
                if(item != null)
                    item.wypisz();
            }
            Console.WriteLine();
        }
        #endregion
    }
}
