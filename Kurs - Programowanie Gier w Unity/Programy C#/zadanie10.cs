using System;

namespace zadanie10
{
    class zadanie10
    {
        static void Main(string[] args)
        {
            Random rand = new Random(); //Moduł losujący
            int[] liczby = new int[5];
            int[][] cyfry = new int[5][];
            //cyfry[0] - przechowuje cyfry pierwszej liczby
            //cyfry[1] - przechowuje cyfry drugiej liczby

            for (int i = 0; i < liczby.Length; i++)
            {
                liczby[i] = rand.Next(1001); //losujemy liczby 1-1000

                //ustalamy wielosc tablicy cyfry[0], cyfry[1], ...
                cyfry[i] = new int[(int)(Math.Log10(liczby[i]) + 1)];
            }

            foreach(var item in liczby)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            for (int i=0; i < liczby.Length; i++)
            {
                for(int j = 0; j < cyfry[i].GetLength(0); j++)
                {
                    if (j == 0) cyfry[i][j] = liczby[i] % 10; // w przypadku liczby jednocyfrowej
                    if (j == 1) //liczba dwucyfrowa
                    {
                        liczby[i] = liczby[i] / 10;
                        cyfry[i][j] = liczby[i] % 10;
                    }
                    if (j == 2) //liczba trzycyfrowa
                    {
                        liczby[i] = liczby[i] / 10;
                        cyfry[i][j] = liczby[i] % 10;
                    }
                    if (j == 3) //liczba czterocyfrowa
                    {
                        liczby[i] = liczby[i] / 10;
                        cyfry[i][j] = liczby[i] % 10;
                    }
                }
                Array.Reverse(cyfry[i]);
            }
            
            foreach(var item in cyfry) //wyświetlamy zawartość tablicy cyfry
            {
                foreach (int el in item)
                {
                    Console.Write(el + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
