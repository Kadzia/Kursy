using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyrażenia_algebraiczne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Przykładowe wyrażenie: y=2ab-4 w języku C# zapiszemy:
            int a = 2, b = 3, y;
            y = 2 * a * b - 4;
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
