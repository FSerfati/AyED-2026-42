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
            Console.WriteLine("ingrese una temperatura ");
            int grados = int.Parse(Console.ReadLine());
            if (grados <= 0)
            {
                Console.WriteLine("esta congelado");
            }

            if (grados >= 1 && grados < 100)
            {
                Console.WriteLine("esta en estado liquido");
            }

            if (grados >= 100)
            {
                Console.WriteLine("hierve");
            }
            Console.ReadKey();
        }
    }
}
