using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_HastaN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());
            int contador = 0;
            while (numero >= contador)
            {
                  Console.WriteLine(contador);
                contador += 2;
            }
            Console.ReadKey();
        }
    }
}
