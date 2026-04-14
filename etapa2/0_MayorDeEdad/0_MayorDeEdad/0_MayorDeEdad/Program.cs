using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_MayorDeEdad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa una edad");
            int edad = int.Parse(Console.ReadLine());
            if (edad >= 18)
                {
                Console.WriteLine("es mayor de edad ");
            }
            else
            {
                Console.WriteLine("no eres mayor de edad");
            }
            Console.ReadKey();
        }
    }
}
