using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Vuelto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese el monto de la compra: ");
            double valorCompra = double.Parse(Console.ReadLine());

            Console.Write("Dinero entregado: ");
            double valorPagado = double.Parse(Console.ReadLine());
            if (valorPagado < valorCompra)
            {
                Console.WriteLine("Error: El dinero entregado no alcanza.");
            }
            else
            {
                double vueltoRestante = valorPagado - valorCompra;
                Console.WriteLine("\nVuelto total: $" + vueltoRestante);
                int parteEntera = (int)vueltoRestante;
                double centavos = vueltoRestante - parteEntera;
                int denominacion = 10000;
                while (parteEntera > 0)
                {
                    int cantidad = 0;
                    while (parteEntera >= denominacion)
                    {
                        parteEntera -= denominacion;
                        cantidad++;
                    }
                    if (cantidad > 0)
                    {
                        Console.WriteLine(cantidad + " de $" + denominacion);
                    }
                    switch (denominacion)
                    {
                        case 10000: denominacion = 2000; break;
                        case 2000: denominacion = 1000; break;
                        case 1000: denominacion = 500; break;
                        case 500: denominacion = 200; break;
                        case 200: denominacion = 100; break;
                        case 100: denominacion = 50; break;
                        case 50: denominacion = 20; break;
                        case 20: denominacion = 10; break;
                        case 10: denominacion = 5; break;
                        case 5: denominacion = 2; break;
                        case 2: denominacion = 1; break;
                        case 1: denominacion = 0; break;
                    }
                    if (denominacion == 0) break;
                }
                if (centavos > 0.001)
                {
                    Console.WriteLine("\naviso: Se necesitan monedas más chicas para completar $" + Math.Round(centavos, 2));
                }
            }
            Console.ReadKey();
        }
    }
}


