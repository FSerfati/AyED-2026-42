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
            Console.WriteLine("ingrese un numero");
            int numero = int.par(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.WriteLine("es par");
            }
            else
            {
                Console.WriteLine("es impar");
            }
            Console.ReadKey();
        }
    }
}
