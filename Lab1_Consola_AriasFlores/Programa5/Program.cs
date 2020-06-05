using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa5
{
    class Program
    {
        static void Main(string[] args)
        {
            string estadocivil;
            int edad;
            double salario;

            Console.WriteLine("Estado Civil: ");
            estadocivil = Console.ReadLine();

            Console.WriteLine("Edad: ");
            edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Salario: ");
            salario = Convert.ToDouble(Console.ReadLine());

            if (estadocivil=="casado" && edad>=18 && salario > 2500)
            {
                Console.WriteLine("Credido Aprobado");
            }
            else
            {
                Console.WriteLine("Credido Negado");
            }

            Console.ReadLine();


        }
    }
}
