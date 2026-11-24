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
            Console.Write("Por favor, ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Su edad es: " + edad);
            Console.ReadKey();
        }
    }
}
