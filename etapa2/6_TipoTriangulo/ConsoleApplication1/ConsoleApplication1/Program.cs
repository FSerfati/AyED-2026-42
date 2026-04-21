using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double lado1, lado2, lado3;
            Console.Write("Ingrese la longitud del primer lado: ");
            if (!double.TryParse(Console.ReadLine(), out lado1) || lado1 <= 0)
            {
                Console.WriteLine("Lado inválido.");
            }
            Console.Write("Ingrese la longitud del segundo lado: ");
            if (!double.TryParse(Console.ReadLine(), out lado2) || lado2 <= 0)
            {
                Console.WriteLine("Lado inválido.");
            }
            Console.Write("Ingrese la longitud del tercer lado: ");
            if (!double.TryParse(Console.ReadLine(), out lado3) || lado3 <= 0)
            {
                Console.WriteLine("Lado inválido.");
            }
            if ((lado1 + lado2 > lado3) && (lado1 + lado3 > lado2) && (lado2 + lado3 > lado1))
            {
                Console.WriteLine("si se puede formar un triángulo.");
                if (lado1 == lado2 && lado2 == lado3)
                {
                    Console.WriteLine("Tipo: Equilátero (3 lados iguales)");
                }
                else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                {
                    Console.WriteLine("Tipo: Isósceles (2 lados iguales)");
                }
                else
                {
                    Console.WriteLine("Tipo: Escaleno (3 lados distintos)");
                }
            }
            else
            {
                Console.WriteLine("no se puede formar un triángulo con estas medida");
            }

            Console.ReadKey();
        }
    }
}
