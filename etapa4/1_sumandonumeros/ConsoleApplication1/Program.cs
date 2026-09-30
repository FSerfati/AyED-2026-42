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
            Console.WriteLine(Sumar(3, 5));
            Console.ReadKey();
        }

        static int Sumar(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            return resultado;
        }
    }
}
