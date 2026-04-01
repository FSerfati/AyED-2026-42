using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class publicProgram
    {
        static void Main(string[] args)
        {
        Console.WriteLine("ingrese un monto total para que se reparta en 3 personas de forma igual");
        Console.WriteLine("ingrese el monto ");
        double monto = Convert.ToDouble(Console.ReadLine());
        double equitativo = monto / 3 ;
        Console.WriteLine("este es el monto:" + " " + equitativo);
        
        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();




        }
    }
}
