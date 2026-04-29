using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_WhileYWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("los numeros Impares son");
            numero = 0;
            while (numero <= 100)
            {
                if (numero % 2 != 0) Console.Write(numero + ", ");
                numero++;
            }
            Console.WriteLine("");
            Console.WriteLine("los numeros Pares son");
            numero = 0;
            while (numero <= 100)
            {
                if (numero % 2 == 0) Console.Write(numero + ", ");
                numero++;
            }
            Console.WriteLine("");
            Console.WriteLine("los numeros del 0 al 100 son");
            numero = 0;
            while (numero <= 100)
            {
                Console.Write(numero + " ");
                numero++;
            }
            Console.WriteLine("");
            Console.WriteLine("los numeros del 100 al 0 son");
            numero = 100;
            while (numero >= 0)
            {
                Console.Write(numero + ", ");
                numero--;
            }
            Console.WriteLine("");
            Console.WriteLine("los multiplos de 3 son");
            numero = 0;
            while (numero <= 100)
            {
                if (numero > 0)
                {
                    if (numero % 3 == 0) Console.Write(numero + ", ");
                }
                numero++;
            }
            Console.WriteLine("");
            Console.WriteLine("los multiplos de 3 y 2 son");
            numero = 0;
            while (numero <= 100)
            {
                if (numero > 0)
                {
                    if (numero % 3 == 0)
                    {
                        if (numero % 2 == 0) Console.Write(numero + ", ");
                    }
                }
                numero++;
            }
            Console.ReadKey();
        }
    }
}
