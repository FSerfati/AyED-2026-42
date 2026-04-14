using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_AlReves
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa 3 letras");
            string letras = Console.ReadLine();
            Console.WriteLine("las 3 letras ingresadas al reves son: " + letras[2] + letras[1] + letras[0]);
            Console.ReadKey();
        }
    }
}
