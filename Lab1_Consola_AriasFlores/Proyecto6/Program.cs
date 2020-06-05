using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            double r = 0;
            int opcion = 0;

            Console.WriteLine("==============================");
            Console.WriteLine("   Operaciones Aritmeticas    ");
            Console.WriteLine("Ingrese A:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese A:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("iNGRESE OPCION DEL (1-4): ");
            Console.WriteLine("1.-Suma");
            Console.WriteLine("2.-Resta");
            Console.WriteLine("3.-Multiplicacion");
            Console.WriteLine("4.-Division");
            opcion = int.Parse(Console.ReadLine());

            if (opcion > 0 & opcion <= 5)
                switch (opcion)
                {
                    case 1:
                        r = (a + b);
                        Console.WriteLine("La suma es: " + r);
                        Console.ReadKey();
                        break;
                    case 2:
                        r = (a - b);
                        Console.WriteLine("La resta es: " + r);
                        Console.ReadKey();
                        break;
                    case 3:
                        r = (a * b);
                        Console.WriteLine("La multiplicacion es: " + r);
                        Console.ReadKey();
                        break;
                    case 4:
                        if (b > 0)
                        {
                            r = (a / b);
                            Console.WriteLine("La division es: " + r);
                            Console.ReadKey();

                        }
                        else
                        {
                            Console.WriteLine("No se puede realizar la division");
                            Console.ReadKey();
                        }
                        break;


                }
            else
                Console.WriteLine("Opcion no valida....");
            Console.ReadKey();
        }
    }
}
