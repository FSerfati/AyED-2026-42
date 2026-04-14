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
            Console.Write("ingrese su nombre su edad y su ciudad");
            Console.WriteLine();
            string nombre = Console.ReadLine();
            string edad = Console.ReadLine();
            string ciudad = Console.ReadLine();
            Console.WriteLine("su nombre es " + nombre + ", su edad es " + edad +  " y su ciudad es " + ciudad);
            Console.ReadKey();
        }
    }
}
