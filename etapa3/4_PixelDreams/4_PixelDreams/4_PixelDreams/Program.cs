using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_PixelDreams
{
    class Program
    {
        static void Main(string[] args)
        {
              int cantidad;
        Console.Write("Ingrese la cantidad de participantes: ");
        cantidad = int.Parse(Console.ReadLine());
        int[] puntajes = new int[cantidad];
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"Ingrese el puntaje del participante {i + 1}: ");
            puntajes[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < cantidad - 1; i++)
        {
            for (int j = i + 1; j < cantidad; j++)
            {
                if (puntajes[i] < puntajes[j])
                {
                    int aux = puntajes[i];
                    puntajes[i] = puntajes[j];
                    puntajes[j] = aux;
                }
            }
        }
        Console.WriteLine("Puntajes ordenados de mayor a menor:");
        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine($"{i + 1}° lugar: {puntajes[i]} puntos");
        }
        Console.WriteLine($"Mayor puntaje: {puntajes[0]}");
        Console.WriteLine($"Menor puntaje: {puntajes[cantidad - 1]}");
            Console.ReadKey();
        }
    }
}
