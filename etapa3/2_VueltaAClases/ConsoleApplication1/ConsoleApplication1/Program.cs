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
            string[][] tabla;
            
            string confirmar = "nada";
            
            tabla = new string[7][];
            Console.WriteLine("ingrese datos para crear una tabla (empieza en registro(6 cada uno), teniendo 7 campos");
            for(int num = 0;num < 7;num ++)
            {
                tabla[num] = new string[7];
                
            }
            tabla[0][0] = "       ";
            tabla[1][0] = "primer desarrollador";
            tabla[2][0] = "desarrollador actual";
            tabla[3][0] = "primera version";
            tabla[4][0] = "modelos de datos";
            tabla[5][0] = "lenguaje de datos";
            tabla[6][0] = "S O soporta";
            tabla[0][1] = "sql sercer";
            tabla[0][2] = "mysql";
            tabla[0][3] = "postgre sql";
            tabla[0][4] = "oracle";
            tabla[0][5] = "mongo db";
            Console.WriteLine("asi es la tabla inicial");  
            Console.WriteLine("              " + tabla[0][0] + "   " + tabla[0][1] + "   "+ tabla[0][2] + "   " +tabla[0][3] + "   " +tabla[0][4] + "   " +tabla[0][5]);
            Console.WriteLine(tabla[1][0]);
            Console.WriteLine(tabla[2][0]);
            Console.WriteLine(tabla[3][0]);
            Console.WriteLine(tabla[4][0]);
            Console.WriteLine(tabla[5][0]);
            Console.WriteLine(tabla[6][0]);

            for (int registro = 1; registro < 6; registro++)
            {
                if(registro == 0)
                {
                    Console.WriteLine("ingrese al desarrollador");
                }
                
                while (confirmar.ToLower() != "si")
                {
                    for (int columna = 1; columna < 6; columna++)
                    {
                        tabla[registro][columna] = Console.ReadLine();
                        
                    }
                    Console.WriteLine("el registro se ve asi" + " "  + tabla[registro][0] + " " + tabla[registro][1] + " " + tabla[registro][2] + " " + tabla[registro][3] + " " + tabla[registro][4] + " " + tabla[registro][5] + " " + "quiere continuar");

                    confirmar = Console.ReadLine();
                }
                confirmar = "ott";
            }

            for (int p = 0; p < 7; p++)
            {
                for (int columna = 0; columna < 6; columna++)
                {
                    Console.Write(tabla[p][columna] + " ");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
