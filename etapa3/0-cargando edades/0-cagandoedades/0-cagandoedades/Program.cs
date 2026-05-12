using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_cagandoedades
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] edades = new int[5];
            Console.WriteLine("Ingrese una edad para cada estudiante");
            for (int i = 0; i < edades.Length; i++)
            {
                Console.WriteLine("ingrese valor " + (i+1));
                edades[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Las edades de los estudiantes son: ");
            for (int i = 0; i < edades.Length; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("La edad es: " + edades[i]);
            }
            Console.ReadKey();
        }
    }
}