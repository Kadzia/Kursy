using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konwersja_typów__samochody_
{
    class Program
    {
        static void Main(string[] args)
        {
            const int liczbaMiesiecy = 12;  //stałe należy inicjalizować w trakcie deklaracji
            int liczbaSamochodow;
            double sredniaSprzedaz;
            Console.WriteLine("Podaj roczną sprzedaż samochodów: ");
            //liczbaSamochodow = Convert.ToInt32(Console.ReadLine());
            liczbaSamochodow = int.Parse(Console.ReadLine());
            sredniaSprzedaz = liczbaSamochodow / (double)liczbaMiesiecy;
            Console.WriteLine(sredniaSprzedaz);
            Console.ReadKey();
        }
    }
}
