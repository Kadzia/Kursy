using System;

namespace Inkrementacja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inkremantacja:");
            int x = 3, wynik;
            wynik = ++x * 3;
            Console.WriteLine(x);
            Console.WriteLine(wynik);

            Console.WriteLine("");
            Console.WriteLine("dekrementacja:");
            int y = 0, z;
            z = --y * 4;
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.ReadKey(); 
        }
    }
}
