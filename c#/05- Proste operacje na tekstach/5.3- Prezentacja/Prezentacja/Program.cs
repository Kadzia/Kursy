using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prezentacja
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 4, b = 6, suma = a + b;
            //Console.WriteLine("a=" + a + " b=" + b + " Suma=" + suma);
            //Console.WriteLine("a={0} b={1} Suma={2}", a, b, suma);



            //Schemat elemrntu formatującego; {indeks, wyrównanie: specyfikator formatu}
            double x = 12.34567, wskaznik = 0.45;
            int suma = 10;
            string imie = "Jan", nazwisko = "Nowak";
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("1. Imię: {0,8} Nazwisko: {1,10}", imie, nazwisko);
            Console.WriteLine("2. Imię: {0,-8} Nazwisko: {1,-10}", imie, nazwisko);
            Console.WriteLine("3. Wartość {0,10} to suma", suma);
            Console.WriteLine("4. Wskaźnik: {0,8:P}", wskaznik);
            Console.WriteLine("5. Waga: {0,8} kg Waga: {0,8:F2} kg", x);
            Console.ReadKey();
        }
    }
}
