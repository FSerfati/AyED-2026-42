using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_CelciusFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("inserte una temperatura: ");
            int radio = int.Parse(Console.ReadLine());
            double Fahrenheit = (radio * 1.8) + 32;
            double kelvin = radio + 273;
            Console.WriteLine("valor de fahrenheit: " + Fahrenheit);
            Console.WriteLine("valor de kelvin: " + kelvin);
            Console.ReadKey();
        }
    }
}
