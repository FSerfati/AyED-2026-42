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
            Console.Write("Ingrese un año: ");
            int bisiesto = int.Parse(Console.ReadLine());
            if (bisiesto % 4 == 0 && bisiesto % 100 != 0)
            {
                Console.Write("El año es bisiesto");
            }
            else
            { 
                Console.Write("El año no es bisiesto");
            }
            Console.ReadKey();
        }
    }
}
