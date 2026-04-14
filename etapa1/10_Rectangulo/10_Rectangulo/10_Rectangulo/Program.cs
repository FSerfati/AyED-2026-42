using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Rectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("inserte un ancho");
            int ancho = int.Parse(Console.ReadLine());
            Console.Write("inserte una altura");
            int altura = int.Parse(Console.ReadLine());
            double perimetro = (ancho + altura) * 2;
            Console.WriteLine("perimetro: " + perimetro);
            double area = (ancho * altura) / 2;
            Console.WriteLine("area: " + area);
            Console.ReadKey();
        }
    }
}
