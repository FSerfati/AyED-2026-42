using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_MatriZaleatoria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el número de filas (n): ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el número de columnas (m): ");
            int m = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, m];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matriz[i, j] = rnd.Next(1, 101);
                }
            }
            Console.WriteLine("\nMatriz generada:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
