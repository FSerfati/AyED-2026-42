using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class ejercicio4
    {
        public static void Main()
        {   
            
            Console.WriteLine("ponga 3 letras para que esten al reves");
            string letras = Console.ReadLine();
            Array.Reverse(letras);


            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}