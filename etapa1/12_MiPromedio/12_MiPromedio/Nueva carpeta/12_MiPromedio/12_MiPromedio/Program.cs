using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_MiPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese 3 numeros");
            int numero1 = int.Parse(Console.ReadLine());
            int numero2 = int.Parse(Console.ReadLine());
            int numero3 = int.Parse(Console.ReadLine());
            int suma = (numero1 + numero2 + numero3) / 3;
            Console.WriteLine("el promedio es " + suma);
            Console.ReadKey();
        }
    }
}
