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
            Console.WriteLine("ingrese una basa y una altura ");
            float basa = int.Parse(Console.ReadLine());
            float altura = int.Parse(Console.ReadLine());
            float area = ((basa * altura) / 2);
            Console.WriteLine("su area es " + (basa * altura) / 2);
            Console.ReadKey();
        }
    }
}
