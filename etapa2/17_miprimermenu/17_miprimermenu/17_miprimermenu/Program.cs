using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_miprimermenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bienvenido al menu");
            Console.WriteLine("selecciona una opcion entre 1, 2, 3 y 4");
            Console.WriteLine("hola profe");
            Console.WriteLine("tengo 16 años");
            Console.WriteLine("me secuestran");
            Console.WriteLine("salir del programa");
            int opcion = int.Parse(Console.ReadLine());
            while (opcion != 4)
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("hola profe");
                        break;
                    case 2:
                        Console.WriteLine("tengoo 16 años");
                        break;
                    case 3:
                        Console.WriteLine("me secuestran");
                        break;
                    case 4:
                        Console.WriteLine("salir del programa");
                            break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
                opcion = int.Parse(Console.ReadLine());
            }
        }
    }
}