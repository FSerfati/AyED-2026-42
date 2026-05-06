using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_SimuladorJuego__DESAFIO_
{
    class Program
    {
        static void Main(string[] args)
        {
            int vida = 10;
            int hambre = 10;
            int dia_inicial = 1;
            int comida_cruda = 0;
            int algo_util = 0;
            int comida_cocinada = 0;
            int opciones = 0;
            bool descansar = false;
            bool refugio = false;
            bool fogata = false;

            Console.WriteLine("=== SUPERVIVENCIA EN LA ISLA ===");
            Console.WriteLine("");

            while (opciones != 8)
            {
                Console.WriteLine("estas en el dia igual a = " + dia_inicial);
                Console.WriteLine("tu hambre es igual a = " + hambre);
                Console.WriteLine("tu vida es igual a = " + vida);
                Console.WriteLine("tu comida cruda es igual a = " + comida_cruda);
                Console.WriteLine("tu comida cocinada es igual a = " + comida_cocinada);
                Console.WriteLine("refuigio es igual a = " + (refugio ? "si" : "no"));
                Console.WriteLine("fogata es igual a = " + (fogata ? "si" : "no"));
                Console.WriteLine("");
                Console.WriteLine("1. Buscar comida");
                Console.WriteLine("2. Explorar la isla");
                Console.WriteLine("3. Construir refugio");
                Console.WriteLine("4. Encender fogata");
                Console.WriteLine("5. Cocinar comida");
                Console.WriteLine("6. Comer comida cocida");
                Console.WriteLine("7. Descansar");
                Console.WriteLine("8. Salir del programa");
                opciones = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opciones)
                {
                    case 1:
                        Console.WriteLine("Buscar comida");
                        Random comida = new Random();
                        int buscar_comida = comida.Next(0, 100);
                        if (comida_cruda < 61)
                        {
                            Console.WriteLine("Has encontrado 2 unidades de comida");
                            comida_cruda += 2;
                            dia_inicial++;
                            hambre -= 2;
                        }
                        else
                        {
                            Console.WriteLine("Nos has encontrado nada de comida");
                            vida -= 1;
                            dia_inicial++;
                            hambre -= 2;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Explorar la isla");
                        Random busca_recursos = new Random();
                        algo_util = busca_recursos.Next(0, 100);
                        if (algo_util < 51)
                        {
                            Console.WriteLine("Has encontrado algo útil");
                            algo_util += 2;
                            dia_inicial++;
                            hambre -= 2;
                        }
                        else if (algo_util < 81)
                        {
                            Console.WriteLine("No has encontrado nada");
                            dia_inicial++;
                            hambre -= 2;
                        }
                        else
                        {
                            Console.WriteLine("Has sufrido un accidente");
                            vida -= 2;
                            dia_inicial++;
                            hambre -= 2;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Construir refugio");
                        if (refugio == true)
                        {
                            Console.WriteLine("Ya tienes refugio");
                        }
                        else if (algo_util > 0)
                        {
                            refugio = true;
                            Console.WriteLine("Construiste un refugio.");
                            algo_util--;
                            dia_inicial++;
                            hambre -= 2;
                        }
                        else
                        {
                            Console.WriteLine("no tenes materiales para construir un refugio");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Encender fogata");
                        if (fogata == true)
                        {
                            Console.WriteLine("Ya tienes fogata");
                        }
                        else if (algo_util > 1)
                        {
                            fogata = true;
                            Console.WriteLine("Construiste una fogata.");
                            algo_util--;
                            dia_inicial++;
                            hambre -= 2;
                        }
                        else
                        {
                            Console.WriteLine("no tenes materiales para construir una fogata");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Cocinar comida");
                        if (comida_cruda > 0 && fogata)
                        {
                            comida_cruda--;
                            comida_cocinada++;
                            Console.WriteLine("Haz cocinado tu comida.");
                            dia_inicial++;
                            hambre -= 2;
                        }
                        else
                        {
                            Console.WriteLine("Necesitas comida cruda y fogata.");
                        }
                        break;
                    case 6:
                        Console.WriteLine("Comer comida cocida");
                        if (comida_cocinada > 0)
                        {
                            comida_cocinada--;
                            Console.WriteLine("comiste + 4 puntos de hambre");
                            dia_inicial++;
                            hambre -= 2;
                        }
                        else
                        {
                            comida_cocinada = 0;
                            Console.WriteLine("no tienes comida debes cocinar la comida cruda");
                        }
                        break;
                    case 7:
                        Console.WriteLine("Descansar");
                        if (refugio == true)
                        {
                            vida += 3;
                            Console.WriteLine("estas descansando y tienes refugio + 3 puntos de vida");
                            dia_inicial++;
                            hambre -= 2;
                        }
                        else
                        {
                            vida += 1;
                            Console.WriteLine("estas descansando pero no tienes refugio + 1 puntos de vida");
                            dia_inicial++;
                            hambre -= 2;
                        }
                        break;

                    case 8:
                        break;

                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
                if (vida > 10)
                {
                    vida = 10;
                }
                if (hambre > 10)
                {
                    hambre = 10;
                }
                if (vida < 0)
                {
                    vida = 0;
                }
                if (hambre < 0)
                {
                    hambre = 0;
                }
                if (hambre == 0)
                {
                    vida -= 2;
                }
                if (vida == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Moriste");
                    opciones = 8;
                }
                if (dia_inicial == 10)
                {
                    Console.WriteLine("ganaste");
                    opciones = 8;
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Gracias por jugar");
            Console.WriteLine("presione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}