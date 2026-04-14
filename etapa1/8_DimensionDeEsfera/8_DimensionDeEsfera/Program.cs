using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_DimensionDeEsfera
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserte un radio: ");
            int radio = int.Parse(Console.ReadLine());
            float superficie = 4 * 3.14f * radio * radio;
            double volumen = 1.33f * 3.14f * Math.Pow(radio,3);
            Console.WriteLine("valor de superficie: " + superficie);
            Console.WriteLine("valor de volumen: " + volumen);
            Console.ReadKey();
        }
    }
}
