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
            string contrareal = "felipio";
            Console.WriteLine("cual es su contraseña");
            string contraseña = (Console.ReadLine());
            if (contraseña ==  contrareal)
            {
                Console.WriteLine("su contraseña es correcta ");
            }
            else
            {
                Console.WriteLine("su contraseña es incorrecta");
            }
            Console.ReadKey();
        }
    }
}
