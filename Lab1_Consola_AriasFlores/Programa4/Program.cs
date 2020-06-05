using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            double c = 0;

            Console.WriteLine("Ingrese A: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese B: ");
            b = double.Parse(Console.ReadLine());

            c = (a + b);
            Console.Clear();
            Console.WriteLine("============================");
            Console.WriteLine("      Suma de 2 numeros     ");
            Console.WriteLine("============================");
            Console.WriteLine("A :" + a);
            Console.WriteLine("B :" + b);
            Console.WriteLine("La Suma es :" + c);
            Console.ReadKey();
        }
    }
}
