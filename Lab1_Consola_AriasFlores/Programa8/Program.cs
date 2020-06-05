using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa8
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, numero, suma;
            suma = 0;
            for (x = 1; x <=5; x++)
            {
                Console.WriteLine("Ingrese numero" + x + " : ");
                numero = Convert.ToInt32(Console.ReadLine());
                suma = suma + numero;
            }
            Console.WriteLine("La suma de los numeros es: " + suma);
            Console.ReadLine();

        }
    }
}
