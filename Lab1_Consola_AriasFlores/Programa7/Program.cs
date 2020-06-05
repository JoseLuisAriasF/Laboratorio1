using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa7
{
    class Program
    {
        static void Main(string[] args)
        {
            string categoria;

            Console.WriteLine("Consulta de sueldo por Categoria ");
            Console.WriteLine("Introduce la categoria a Consultar (A,B,C,D): ");
            categoria = Console.ReadLine();

            switch (categoria.ToUpper())
            {
                case "A":
                    Console.WriteLine("1000 soles ");
                    break;
                case "B":
                    Console.WriteLine("2000 soles ");
                    break;
                case "C":
                    Console.WriteLine("3000 soles ");
                    break;
                default:
                    Console.WriteLine("Categoria equivocada");
                    break;
            }
            System.Console.ReadLine();
        }
    }
}
