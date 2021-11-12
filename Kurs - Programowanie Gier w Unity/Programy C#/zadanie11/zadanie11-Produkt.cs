using System;

namespace zadanie11
{
    public class Produkt
    {
        //pola klasy
        public string nazwaProduktu;
        public decimal cenaProduktu;
        public string jednostkaMiary;
        public DateTime dataZakupu;

        #region Konstruktory
        //Konstruktor
        public Produkt(string nazwaProduktu, decimal cenaProduktu, string jednostkaMiary, DateTime dataZakupu)
        {
            this.nazwaProduktu = nazwaProduktu;
            this.cenaProduktu = cenaProduktu;
            this.jednostkaMiary = jednostkaMiary;
            this.dataZakupu = dataZakupu;
        }

        public Produkt()
        {
            Console.WriteLine("Podaj nazwę produktu: ");
            nazwaProduktu = Console.ReadLine();
            Console.WriteLine("Podaj cenę produktu: ");
            cenaProduktu = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Podaj jednostkę miary: ");
            jednostkaMiary = Console.ReadLine();
            Console.WriteLine("Podaj datę zakupu w formacie rok.miesiąc.dzień: ");
            dataZakupu = DateTime.Parse(Console.ReadLine());
        }
        #endregion

        //Metoda
        public void daneProduktu()
        {
            Console.WriteLine("Dane produktu:");
            Console.WriteLine("Nazwa produktu: " + nazwaProduktu);
            Console.WriteLine("Cena produktu: " + cenaProduktu);
            Console.WriteLine("Jednostka miary: " + jednostkaMiary);
            Console.WriteLine("Data zakupu: " + dataZakupu.ToString("yyyy.MM.dd"));
        }
    }
}
