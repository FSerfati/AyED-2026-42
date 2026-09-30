using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("ingrese 1 numero");
                int numero = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese otro numero");
                int numero3 = int.Parse(Console.ReadLine());
                Console.WriteLine("1. sumar");
                Console.WriteLine("2. restar");
                Console.WriteLine("3. multiplicar");
                Console.WriteLine("4. dividir");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("el resultado es " + Sumar(numero, numero3));
                        break;

                    case 2:
                        Console.WriteLine("el resultado es " + resta(numero, numero3));
                        break;

                    case 3:
                        Console.WriteLine("el resultado es " + multi(numero, numero3));
                        break;

                    case 4:
                        Console.WriteLine("el resultado es " + division(numero, numero3));
                        break;

                    default:
                        Console.WriteLine("No es una opcion valida");
                        break;
                }
                Console.WriteLine("presione una tecla para continuar");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static int Sumar(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            return resultado;
        }

        static int resta(int numero1, int numero2)
        {
            int resultado = numero1 - numero2;
            return resultado;
        }

        static int multi(int numero1, int numero2)
        {
            int resultado = numero1 * numero2;
            return resultado;
        }
        static int division(int numero1, int numero2)
        {
            int resultado = numero1 / numero2;
            return resultado;
        }
    }
}
