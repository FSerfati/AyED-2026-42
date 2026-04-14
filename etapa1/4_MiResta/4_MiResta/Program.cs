using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_MiResta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            float numero1 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese un numero: ");
            float numero2 = float.Parse(Console.ReadLine());
            float resultado = numero1 / numero2;
            Console.Write("el resultado es: " + resultado);
            Console.ReadKey();
        }
    }
}