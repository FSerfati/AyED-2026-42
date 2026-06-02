using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_hotsale
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadProductos;
            double precio, mayor, menor;
            Console.Write("Ingrese la cantidad de productos vendidos: ");
            cantidadProductos = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el precio del producto 1: ");
            precio = double.Parse(Console.ReadLine());
            mayor = precio;
            menor = precio;
            for (int i = 2; i <= cantidadProductos; i++)
            {
                Console.Write($"Ingrese el precio del producto {i}: ");
                precio = double.Parse(Console.ReadLine());
                if (precio > mayor)
                {
                    mayor = precio;
                }
                if (precio < menor)
                {
                    menor = precio;
                }
            }
            Console.WriteLine("producto mas barato y caro:");
            Console.WriteLine("producto mas caro: $" + mayor);
            Console.WriteLine("producto mas barato: $" + menor);
            Console.ReadKey();
        }
    }
}
