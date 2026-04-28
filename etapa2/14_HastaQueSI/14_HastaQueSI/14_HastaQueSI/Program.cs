using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_HastaQueSI
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta;
            do
            {
                Console.Write("¿Desea terminar el programa? (Escriba SI para salir): ");
                respuesta = Console.ReadLine();
            } while (respuesta != "SI");
            Console.WriteLine("Programa terminado.");
        }
    }
}
