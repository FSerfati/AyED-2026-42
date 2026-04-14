using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_NombreCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese un nombre y un apellido");
            Console.WriteLine ();
            string nombre = Console.ReadLine();
            string apellido = Console.ReadLine();
            Console.Write("su nombre y apellido es " + nombre +  apellido);
            Console.ReadKey();
        }
    }
}
