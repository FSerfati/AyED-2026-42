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
            Console.WriteLine("ingrese 1 numero ");
            int numero1 = int.Parse(Console.ReadLine());
            int multiplicacion = (numero1 * numero1);
            Console.WriteLine("su cuadrado es " + numero1 * numero1);
            Console.WriteLine("su cubo es " + numero1 * numero1 * numero1);
            Console.ReadKey();
        }
    }
}
