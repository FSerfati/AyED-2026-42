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
            int cantidadInvitados = 0;
            double sumaComida = 0;
            double promedioComida = 0;

            Console.WriteLine("=== Calculadora de Comida para la Fiesta de Stitch ===");
            while (true)
            {
                Console.Write("Ingrese la cantidad de invitados (entre 1 y 100): ");
                if (int.TryParse(Console.ReadLine(), out cantidadInvitados) && cantidadInvitados >= 1 && cantidadInvitados <= 100)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error: Debe ingresar un número entero válido entre 1 y 100.\n");
                }
            }

            Console.WriteLine(); 
            for (int i = 1; i <= cantidadInvitados; i++)
            {
                double comidaInvitado = 0;
                while (true)
                {
                    Console.Write($"Ingrese la cantidad de comida para el invitado #{i} (entre 1 y 100): ");
                    if (double.TryParse(Console.ReadLine(), out comidaInvitado) && comidaInvitado >= 1 && comidaInvitado <= 100)
                    {
                        sumaComida += comidaInvitado; 
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Error: La cantidad de comida debe estar entre 1 y 100. Intente de nuevo.\n");
                    }
                }
            }
            promedioComida = sumaComida / cantidadInvitados;
            Console.WriteLine("\n==================================================");
            Console.WriteLine($"Total de invitados: {cantidadInvitados}");
            Console.WriteLine($"Total de comida necesaria: {sumaComida}");
            Console.WriteLine($"El promedio de comida por invitado es: {promedioComida:F2}");
            Console.WriteLine("==================================================");
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}