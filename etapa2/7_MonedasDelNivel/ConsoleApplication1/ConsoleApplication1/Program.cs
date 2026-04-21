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
            int monedasDoradas, monedasPlateadas;
            int totalPuntos;
            Console.Write("Ingrese la cantidad de monedas doradas (10 pts c/u): ");
            monedasDoradas = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de monedas plateadas (2 pts c/u): ");
            monedasPlateadas = int.Parse(Console.ReadLine());
            totalPuntos = (monedasDoradas * 10) + (monedasPlateadas * 2);
            Console.WriteLine($"\nPuntaje total: {totalPuntos} puntos.");
            if (totalPuntos < 50)
            {
                Console.WriteLine("Nivel insuficiente.");
            }
            else if (totalPuntos >= 50 && totalPuntos < 100)
            {
                Console.WriteLine("Nivel superado.");
            }
            else
            {
                Console.WriteLine("Nivel completado con bonus.");
            }
            Console.ReadKey();
        }
    }
}
