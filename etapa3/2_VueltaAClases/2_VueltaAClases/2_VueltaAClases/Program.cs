using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_VueltaAClases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de trabajos prácticos de Phineas:");
            int cantidad = int.Parse(Console.ReadLine());

            int[] tp = new int[cantidad];

            for (int i = 0; i < tp.Length; i++)
            {
                Console.WriteLine("¿Cuánto te sacaste en este trabajo práctico?: " + (i + 1));
                tp[i] = int.Parse(Console.ReadLine());
            }

            int suma = 0;

            for (int i = 0; i < tp.Length; i++)
            {
                suma += tp[i];
            }

            double promedio = (double)suma / tp.Length;

            Console.WriteLine("El promedio de TPs es: " + promedio);

            int aprobados = 0;

            for (int i = 0; i < tp.Length; i++)
            {
                if (tp[i] >= 6)
                {
                    aprobados++;
                }
            }

            double porcentaje = (double)aprobados / tp.Length * 100;

            if (porcentaje >= 75)
            {
                Console.WriteLine("estas aprobado");
            }
            else
            {
                Console.WriteLine("estas desaprobado");
            }


            Console.WriteLine("----------------");


            Console.WriteLine("Ingrese la cantidad de examenes de Phineas:");
            int cantidad1 = int.Parse(Console.ReadLine());

            int[] examenes = new int[cantidad1];

            for (int i = 0; i < examenes.Length; i++)
            {
                Console.WriteLine("¿Cuánto te sacaste en este examen?: " + (i + 1));
                examenes[i] = int.Parse(Console.ReadLine());
            }

            suma = 0;

            for (int i = 0; i < examenes.Length; i++)
            {

                suma += tp[i];
            }

            double promedio1 = (double)suma / examenes.Length;

            Console.WriteLine("El promedio de examenes es: " + promedio1);

            aprobados = 0;

            for (int i = 0; i < examenes.Length; i++)
            {
                if (examenes[i] >= 6)
                {
                    aprobados++;
                }
            }

            double porcentaje1 = (double)aprobados / examenes.Length * 100;

            if (porcentaje1 >= 75)
            {
                Console.WriteLine("estas aprobado");
            }
            else
            {
                Console.WriteLine("estas desaprobado");
            }


            Console.WriteLine("--------------");


            Console.WriteLine("Ingrese la cantidad de trabajos prácticos de Ferb:");
            int cantidad2 = int.Parse(Console.ReadLine());

            int[] tp1 = new int[cantidad];

            for (int i = 0; i < tp1.Length; i++)
            {
                Console.WriteLine("¿Cuánto te sacaste en este trabajo práctico?: " + (i + 1));
                tp1[i] = int.Parse(Console.ReadLine());
            }

            suma = 0;

            for (int i = 0; i < tp1.Length; i++)
            {
                suma += tp1[i];
            }

            double promedio2 = (double)suma / tp1.Length;

            Console.WriteLine("El promedio de TPs es: " + promedio2);

            aprobados = 0;

            for (int i = 0; i < tp1.Length; i++)
            {
                if (tp1[i] >= 6)
                {
                    aprobados++;
                }
            }

            double porcentaje2 = (double)aprobados / tp1.Length * 100;

            if (porcentaje1 >= 75)
            {
                Console.WriteLine("estas aprobado");
            }
            else
            {
                Console.WriteLine("estas desaprobado");
            }


            Console.WriteLine("----------------");


            Console.WriteLine("Ingrese la cantidad de examenes de Ferb:");
            int cantidad3 = int.Parse(Console.ReadLine());

            int[] examenes1 = new int[cantidad3];

            for (int i = 0; i < examenes1.Length; i++)
            {
                Console.WriteLine("¿Cuánto te sacaste en este examen?: " + (i + 1));
                examenes1[i] = int.Parse(Console.ReadLine());
            }

            suma = 0;

            for (int i = 0; i < examenes1.Length; i++)
            {
                suma += examenes1[i];
            }

            double promedio3 = (double)suma / examenes1.Length;

            Console.WriteLine("El promedio de examenes es: " + promedio3);

            aprobados = 0;

            for (int i = 0; i < examenes1.Length; i++)
            {
                if (examenes1[i] >= 6)
                {
                    aprobados++;
                }
            }

            double porcentaje3 = (double)aprobados / examenes1.Length * 100;

            if (porcentaje3 >= 75)
            {
                Console.WriteLine("estas aprobado");
            }
            else
            {
                Console.WriteLine("estas desaprobado");
            }
            Console.ReadKey();
        }
    }
}
