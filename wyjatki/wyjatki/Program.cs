using System;
using wyjatki.klasy;

namespace MyApp
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            ZwierzakDomowy Rzak = new ZwierzakDomowy("Kacper", "Pasozyt", new DateTime(2006, 4, 3));
            Console.WriteLine(Rzak);
            */

            RownanieKwadratowe zm1 = new RownanieKwadratowe(4, 5, 8);
            double[] w = zm1.rozwiazrownanie();
            Console.WriteLine(w[0]);
            Console.WriteLine(w[1]);

        }
    }
}