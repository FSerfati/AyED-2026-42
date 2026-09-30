using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_balatrito
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== MINI BALATRO ===");
            Console.WriteLine();
            // Generar una mano aleatoria de 5 cartas
            string[] mano = GenerarManoAleatoria();
            // Analizar que tipo de mano se obtuvo
            string tipo = TipoDeMano(mano);
            // Calcular el valor de las cartas
            int basePts = PuntajeBase(mano);
            // Obtener el multiplicador de la jugada
            double mult = Multiplicador(tipo);
            // Calcular puntaje antes de Jokers
            double total = basePts * mult;
            // Jokers disponibles
            bool jokerX2 = true;
            bool jokerMas10 = true;
            // Aplicar los efectos de los Jokers
            total = AplicarJokers(total, jokerX2, jokerMas10);
            // Mostrar el resultado
            MostrarResumen(mano, tipo, basePts, mult, total);
        }
        // ====================================================
        // CREAR TODAS LAS FUNCIONES NECESARIAS DEBAJO DEL MAIN
        // ====================================================
        static string[] GenerarManoAleatoria()
        {
            {
                string[] rangos = { "A", "K", "Q", "J", "T", "9", "8", "7", "6", "5", "4", "3", "2" };
                string[] palos = { "H", "D", "C", "S" };

                string[] mano = new string[5];
                Random random = new Random();

                for (int i = 0; i < 5; i++)
                {
                    string rangoAleatorio = rangos[random.Next(rangos.Length)];
                    string paloAleatorio = palos[random.Next(palos.Length)];
                    mano[i] = rangoAleatorio + paloAleatorio;
                }

                return mano;
            }

        }
        static string TipoDeMano(string[] mano)
        {
            string[] rangosUnicos = new string[5];
            int[] frecuencias = new int[5];
            int unicosCount = 0;
            foreach (string carta in mano)
            {
                string rango = carta[0].ToString();
                int indice = Array.IndexOf(rangosUnicos, rango, 0, unicosCount);

                if (indice == -1)
                {
                    rangosUnicos[unicosCount] = rango;
                    frecuencias[unicosCount] = 1;
                    unicosCount++;
                }
                else
                {
                    frecuencias[indice]++;
                }
            }

            int maxRepeticiones = 0;
            int cantidadPares = 0;
            bool tieneTrio = false;

            for (int i = 0; i < unicosCount; i++)
            {
                if (frecuencias[i] > maxRepeticiones) maxRepeticiones = frecuencias[i];
                if (frecuencias[i] == 3) tieneTrio = true;
                if (frecuencias[i] == 2) cantidadPares++;
            }
            {
                if (maxRepeticiones == 4) { return "Poker"; }
                if (tieneTrio && cantidadPares == 1) { return "Full"; }
                if (tieneTrio) { return "Trio"; }
                if (cantidadPares >= 1) { return "Par"; }

                else { return "Nada"; }
            }
        }
        static int PuntajeBase(string[] mano)
        {
            int sumaTotal = 0;

            foreach (string carta in mano)
            {
                char rango = carta[0];

                switch (rango)
                {
                    case 'A': sumaTotal += 14; break;
                    case 'K': sumaTotal += 13; break;
                    case 'Q': sumaTotal += 12; break;
                    case 'J': sumaTotal += 11; break;
                    case 'T': sumaTotal += 10; break;
                    default:
                        sumaTotal += (int)Char.GetNumericValue(rango);
                        break;
                }
            }

            return sumaTotal;
        }
        static double Multiplicador(string tipo)
        {
            switch (tipo)
            {
                case "Poker": return 4.0;
                case "Full": return 3.5;
                case "Trio": return 2.5;
                case "Par": return 1.5;
                default: return 1.0;
            }
        }
        static double AplicarJokers(double puntaje, bool x2, bool mas10)
        {
            if (x2)
            {
                puntaje *= 2;
            }

            if (mas10)
            {
                puntaje += 10;
            }

            return puntaje;
        }
        static void MostrarResumen(string[] mano, string tipo, int basePts, double mult, double total)
        {
            Console.Write("Mano: ");
            foreach (string carta in mano)
            {
                Console.Write($"[{carta}] ");
            }
            Console.WriteLine();

            Console.WriteLine($"Tipo de mano: {tipo}");
            Console.WriteLine($"Puntaje base: {basePts}");
            Console.WriteLine($"Multiplicador: x{mult:0.0}");
            Console.WriteLine($"Puntaje final: {total}");
            Console.ReadKey();

        }
    }
}


