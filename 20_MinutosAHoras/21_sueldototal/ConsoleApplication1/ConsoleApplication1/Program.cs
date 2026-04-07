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
            Console.WriteLine("ingrese la cantidad de horas trabajadas y el valor por hora");
            int horastrabajadas = int.Parse(Console.ReadLine());
            int valorporhora = int.Parse(Console.ReadLine());
            int sueldototal = horastrabajadas * valorporhora;
            Console.WriteLine("el sueldo total es " + horastrabajadas * valorporhora + ("$"));
            Console.ReadKey();
        }
    }
}
