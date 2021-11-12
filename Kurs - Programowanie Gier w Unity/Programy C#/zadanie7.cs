using System;

namespace zadanie7
{
    class zadanie7
    {
        static void Main(string[] args)
        {
            /*
            int[] oceny = new int[10];
            oceny[0] = 3;
            oceny[1] = 5;
            oceny[2] = 6;
            oceny[3] = 3;
            oceny[4] = 4;
            oceny[5] = 4;
            oceny[6] = 4;
            oceny[7] = 5;
            oceny[8] = 6;
            oceny[9] = 2;
            */

            int[] oceny = {3, 5, 6, 3, 4, 4, 4, 5, 6, 2};

            int suma = 0, srednia = 0;
            int najlepszaOcena = oceny[0];
            int najslabszaOcena = oceny[0];

            for(int i=0; i<oceny.Length; i++)
            {
                suma += oceny[i];
                if (najlepszaOcena < oceny[i]) najlepszaOcena = oceny[i];
                if (najslabszaOcena > oceny[i]) najslabszaOcena = oceny[i];
            }

            srednia = suma / oceny.Length;

            Console.WriteLine("Średnia ocen uczniów z kursu: " + srednia);
            Console.WriteLine("Najlepsza ocena z kursu: " + najlepszaOcena);
            Console.WriteLine("Najsłabsza ocena z kursu: " + najslabszaOcena);
            Console.ReadKey();

        }
    }
}
