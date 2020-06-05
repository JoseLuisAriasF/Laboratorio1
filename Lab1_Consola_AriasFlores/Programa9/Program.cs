using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa9
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma, numero;
            string otro;
            suma = 0;
            do
            {
                Console.WriteLine("Introduce el numero: ");
                numero = Convert.ToInt32(Console.ReadLine());
                suma = suma + numero;
                Console.WriteLine("?Desea ingresar otro numero?: ");
                otro = Console.ReadLine();
            } while (otro=="SI" || otro=="si");
            Console.WriteLine("La suma es: " + suma);
            Console.ReadLine();
        }
    }
}
