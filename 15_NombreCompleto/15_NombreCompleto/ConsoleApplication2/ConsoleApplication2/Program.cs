using System;

namespace ConsoleApplication1
{
    public class ejercicio4
    {
        public static void Main()
        {
            Console.WriteLine("somos una fiambreria preguntenos por lo que quiere");
            string pedido = Console.ReadLine();
            switch (pedido)
            {

                case "jamon":
                    Console.WriteLine("tenemos jamon");
                    break;
                case "queso":
                    Console.WriteLine("tenemos queso");
                    break;
                case "matambre":
                    Console.WriteLine("tenemos matambre");
                    break;
                case "mortadela":
                    Console.WriteLine("tenemos mortadela");
                    break;
                case "salame":
                    Console.WriteLine("tenemos salame");
                    break;
                default:
                    Console.WriteLine("no tenemos" + " " + pedido);
                    break;
            }

            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}

