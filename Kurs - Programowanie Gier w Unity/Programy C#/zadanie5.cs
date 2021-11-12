using System;

namespace zadanie5
{
    class zadanie5
    {
        static void Main(string[] args)
        {
            //Pętla for
            int suma=0;

            for (int i=1; i<=1000; i++)
            {
                suma += i;
            }
            Console.WriteLine("Suma liczb 1-1000 (za pomcą pętli FOR)  wynosi: " + suma);

            //Pętla while
            suma = 0;
            int j = 1;
            while (j <= 1000)
            {
                suma += j;
                j++;
            }
            Console.WriteLine();
            Console.WriteLine("Suma liczb 1-1000 (za pomcą pętli WHILE) wynosi: " + suma);

            //Pętla dowhile
            suma = 0;
            int l = 1;
            do
            {
                suma += l;
                l++;
            } while (l <= 1000);
            Console.WriteLine();
            Console.WriteLine("Suma liczb 1-1000 (za pomcą pętli DOWHILE) wynosi: " + suma);

            Console.ReadKey();
        }
    }
}
