using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_DobleYTriple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese 1 numero entero");
            int numero1 = int.Parse(Console.ReadLine());
            int multiplicacion = (numero1 * 2);
            Console.WriteLine("su doble es "+ numero1 * 2 );
            Console.WriteLine("su triple es " + numero1 * 3);
            Console.ReadKey();
        }
    }
}
