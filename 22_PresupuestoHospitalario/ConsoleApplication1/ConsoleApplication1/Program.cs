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
            Console.WriteLine("ingrese un presupuesto");
            int presupuesto = int.Parse(Console.ReadLine());
            int ginecologia = presupuesto % 40;
            int traumatologia = presupuesto % 30;
            int pediatria = presupuesto % 30;
            Console.WriteLine("el presupuesto hospitalario es, " + presupuesto % 40 + ("$ de ginecologia ") + presupuesto % 30 + ("$ de traumatologia y ") + presupuesto % 30 +("$ de peditria "));
            Console.ReadKey();
        }  
    }
}
