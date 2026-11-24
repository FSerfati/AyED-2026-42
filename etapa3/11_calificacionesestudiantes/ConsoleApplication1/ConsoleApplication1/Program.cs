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
            int n = 0;
            
            while (true)
            {
                Console.Write("Ingrese la cantidad de estudiantes (N): ");
                if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                {
                    break;
                }
                Console.WriteLine("Error: Debe ingresar un número entero mayor a 0.\n");
            }
            
            string[,] estudiantes = new string[n, 3];

            Console.WriteLine("\n--- Carga de datos de estudiantes ---");
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nEstudiante #{i + 1}:");
                
                while (true)
                {
                    Console.Write("  Nombre: ");
                    string nombre = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(nombre))
                    {
                        estudiantes[i, 0] = nombre;
                        break;
                    }
                    Console.WriteLine("  Error: El nombre no puede estar vacío.");
                }
                
                int edad;
                while (true)
                {
                    Console.Write("  Edad: ");
                    if (int.TryParse(Console.ReadLine(), out edad) && edad > 0 && edad <= 120)
                    {
                        estudiantes[i, 1] = edad.ToString();
                        break;
                    }
                    Console.WriteLine("  Error: Ingrese una edad válida (1 a 120).");
                }
                
                double calificacion;
                while (true)
                {
                    Console.Write("  Calificación (0 a 10): ");
                    if (double.TryParse(Console.ReadLine(), out calificacion) && calificacion >= 0 && calificacion <= 10)
                    {
                        estudiantes[i, 2] = calificacion.ToString("F2");
                        break;
                    }
                    Console.WriteLine("  Error: Ingrese una calificación válida entre 0 y 10.");
                }
            }

            Console.WriteLine("           LISTADO DE ESTUDIANTES            ");
            Console.WriteLine($"{"Nombre",-20} | {"Edad",-6} | {"Calificación",-12}");
   

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{estudiantes[i, 0],-20} | {estudiantes[i, 1],-6} | {estudiantes[i, 2],-12}");
            }
            Console.ReadKey();
        }
    }
}