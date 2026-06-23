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
            Console.Write("Ingrese el tamaño de la matriz (n): ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrizA = new int[n, n];
            int[,] matrizB = new int[n, n];
            int[,] suma = new int[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrizA[i, j] = rnd.Next(1, 11);
                    matrizB[i, j] = rnd.Next(1, 11);
                    suma[i, j] = matrizA[i, j] + matrizB[i, j];
                }
            }
            Console.WriteLine("\nMatriz A:");
            ImprimirMatriz(matrizA, n);
            Console.WriteLine("\nMatriz B:");
            ImprimirMatriz(matrizB, n);
            Console.WriteLine("\nMatriz Suma:");
            ImprimirMatriz(suma, n);
        }
        static void ImprimirMatriz(int[,] matriz, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
