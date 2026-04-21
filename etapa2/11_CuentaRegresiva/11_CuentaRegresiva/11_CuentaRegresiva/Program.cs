using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CuentaRegresiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número entero positivo: ");
            int numero = int.Parse(Console.ReadLine());
            while (numero >= 0)
            {
                Console.WriteLine("Tu numero disminuye: " + numero);
                numero -=1;
            }
            Console.ReadKey();
        }
    }
}
