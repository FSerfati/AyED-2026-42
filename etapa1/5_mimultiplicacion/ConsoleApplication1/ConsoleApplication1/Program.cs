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
            Console.WriteLine("ingrese dos digitos:");
            int numero1 = int.Parse(Console.ReadLine());
            int numero2 = int.Parse(Console.ReadLine());
            int multiplicacion = numero1 * numero2;
            Console.WriteLine("el resultado es: " + multiplicacion);
            Console.ReadLine();
        }
    }
}
