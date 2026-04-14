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
            Console.WriteLine("ingrese una edad ");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un sueldo ");
            double sueldo = int.Parse(Console.ReadLine());
                if (edad > 19 && sueldo <= 100000 || edad < 19 && sueldo == 0 || edad == 19 && sueldo <= 50000)
            {
                Console.WriteLine("puede cobrar la beca");
            }
          
            else
                Console.WriteLine("no puede cobrar la beca");
            Console.ReadKey();
        }
    }
}
