using System;

namespace Koniunkcja
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operator & jest koniunkcją bezwarunkową
            double wiek = 19, kwota = 25;
            bool kino;
            kino = (wiek >= 18 & kwota++ >= 20);
            Console.WriteLine(kino);
            Console.WriteLine(kwota);
            Console.WriteLine("");

            //Operator && jest koniunkcją warunkową
            double Wiek = 15, Kwota = 25;
            bool Kino;
            Kino = (Wiek >= 18 && Kwota++ >= 20);
            Console.WriteLine(Kino);
            Console.WriteLine(Kwota);
            Console.ReadKey();
        }
    }
}
