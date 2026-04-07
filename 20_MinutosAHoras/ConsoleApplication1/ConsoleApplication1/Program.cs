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
            Console.WriteLine("ingrese una cantidad de tiempo");
            int cantidaddetiempo = int.Parse(Console.ReadLine());
            int horas = cantidaddetiempo / 60;
            int minutos = cantidaddetiempo % 60;
            Console.WriteLine("la cantidad en horas es y minutos es " + cantidaddetiempo / 60 + (" horas ") + cantidaddetiempo % 60 + (" minutos"));
            Console.ReadKey();
        }
    }
}
