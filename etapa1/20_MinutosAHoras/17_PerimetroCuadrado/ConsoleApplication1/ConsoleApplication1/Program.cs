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
            Console.WriteLine("ingrese una longitud ");
            int longitud = int.Parse(Console.ReadLine());
            int perimetro = (longitud * 4);
            int superficie = (longitud * 2);
            Console.WriteLine("su perimetro es " + longitud * 4);
            Console.WriteLine("su superficie es " +  longitud * 2);
            Console.ReadKey();
        }
    }
}
