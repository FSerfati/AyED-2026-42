using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_WhileYWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números Impares 0-100 ");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0) Console.Write(i + " ");
            }
            Console.WriteLine("\n\n Números Pares 0-100 ");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0) Console.Write(i + " ");
            }
            Console.WriteLine("\n\n Números del 0 al 100 ");
            for (int i = 0; i <= 100; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n\n Números del 100 al 0 ");
            for (int i = 100; i >= 0; i--)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n\n Múltiplos de 3 0-100 ");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0 && i != 0) Console.Write(i + " ");
            }
            Console.WriteLine("\n\n Múltiplos de 3 y 2 0-100");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 2 == 0 && i != 0) Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
