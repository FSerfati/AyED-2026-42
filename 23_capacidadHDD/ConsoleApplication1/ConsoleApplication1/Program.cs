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
            Console.WriteLine("ingrese la cantidad de cilindros, pistas por cilindro y sectores por pista de un disco duro");
            int cantidadcilindros = int.Parse(Console.ReadLine());
            int pistasporcilindro = int.Parse(Console.ReadLine());
            int sectoresporpista = int.Parse(Console.ReadLine());
            long bytes = (long)512 * sectoresporpista * pistasporcilindro * cantidadcilindros;
            long kb = bytes / 1024;
            long mb = kb / 1024;
            long gb = mb / 1024;
            Console.WriteLine("la cantidad de kb es " + bytes / 1024 + (", la cantidad de mb es ") + kb / 1024 + (" y la cantidad de gb es") + mb / 1024);
            Console.ReadKey();
        }
    }
}