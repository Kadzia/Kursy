using System;

namespace Alternatywa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operator || jest warunkowy
            int x = 3;
            bool wynik;
            wynik = (x >= 2 || x++ >= 4);
            Console.WriteLine(wynik);
            Console.WriteLine(x);
            Console.WriteLine("");

            //Operator | jest bezwarunkowy
            int X = 3;
            bool Wynik;
            Wynik = (X >= 2 | X++ >= 4);
            Console.WriteLine(Wynik);
            Console.WriteLine(X);
            Console.ReadKey();
        }
    }
}
