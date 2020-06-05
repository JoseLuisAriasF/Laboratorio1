using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellido;
            int edad;
            string sexo;
            string probando;

            Console.WriteLine("Ingrese nombre:");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese apellido:");
            apellido = Console.ReadLine();

            Console.WriteLine("Ingrese edad:");
            edad =Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Ingrese sexo:");
            sexo = (Console.ReadLine());

           
            Console.Clear();

            Console.WriteLine("================================");
            Console.WriteLine("     Datos Personales       ");
            Console.WriteLine("================================");
            Console.WriteLine("Tu nombre es: " + nombre);
            Console.WriteLine("Tu apellido es: " + apellido);
            Console.WriteLine("Tu edad es: " + edad);
            Console.WriteLine("Tu sexo es: " + sexo);
            Console.ReadKey();


        }
    }
}
