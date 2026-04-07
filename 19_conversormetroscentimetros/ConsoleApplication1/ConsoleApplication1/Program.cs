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
            Console.WriteLine("ingrese una cantidad de metros");
            float metros = int.Parse(Console.ReadLine());
            float centimetros = metros / 100;
            float milimetros = metros / 1000;
            Console.WriteLine("los cenimetros son " + metros / 100);
            Console.WriteLine("los milimetros son " + metros / 1000);
            Console.ReadKey();
        }
    }
}
