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
            int n = 1;
            int[,] matriz = new int[n, n];
            int[] diagonal = new int[n];
            Random random = new Random();
            Console.WriteLine("--- Matriz Original ---");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = random.Next(1, 100);
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                diagonal[i] = matriz[i, i];
            }
            Console.WriteLine("\n--- Diagonal Principal ---");
            Console.WriteLine(string.Join(", ", diagonal));
            Console.ReadKey();
        }
    }
}
