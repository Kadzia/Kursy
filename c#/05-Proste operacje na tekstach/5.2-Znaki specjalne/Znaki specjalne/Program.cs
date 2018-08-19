using System;

namespace Znaki_specjalne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linia1\nLinia2");        // przejście do nowej linii
            Console.WriteLine("Kolumna1\tKolumna2");    // \t - tabulacja
            Console.WriteLine(@"Kolumna1\tKolumna2");   // @ - dosłowna interpretacja
            Console.WriteLine("C:\\Windows\\Temp");     // podwójny "\\" wstawia "\"
            Console.WriteLine("Tytuł filmu: \"Dom\"");  // znak \" wstawia znak"
            Console.ReadKey();

        }
    }
}

