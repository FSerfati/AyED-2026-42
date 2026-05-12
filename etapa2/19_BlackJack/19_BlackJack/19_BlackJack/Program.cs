using System;

namespace SimuladorBlackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            bool programaActivo = true;

            int partidasGanadas = 0;
            int partidasPerdidas = 0;
            int partidasEmpatadas = 0;

            Console.WriteLine("===== BLACKJACK SIMPLE =====");

            while (programaActivo)
            {
                int puntajeJugador = 0;
                int puntajeCrupier = 0;

                bool partidaActiva = true;
                bool jugadorSePlanto = false;

                while (partidaActiva)
                {
                    Console.WriteLine();
                    Console.WriteLine("Puntaje del jugador: " + puntajeJugador);
                    Console.WriteLine("Puntaje del crupier: oculto");

                    Console.WriteLine();
                    Console.WriteLine("1. Pedir carta");
                    Console.WriteLine("2. Plantarse");
                    Console.WriteLine("3. Ver reglas");
                    Console.WriteLine("4. Salir");

                    Console.Write("Ingrese una opción: ");

                    int opcion;

                    if (!int.TryParse(Console.ReadLine(), out opcion))
                    {
                        Console.WriteLine("Ingrese un número válido.");
                        continue;
                    }

                    switch (opcion)
                    {
                        case 1:

                            int cartaJugador = random.Next(1, 12);

                            puntajeJugador += cartaJugador;

                            Console.WriteLine();
                            Console.WriteLine("Carta obtenida: " + cartaJugador);
                            Console.WriteLine("Puntaje actual del jugador: " + puntajeJugador);

                            if (puntajeJugador > 21)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Te pasaste de 21.");
                                Console.WriteLine("Perdiste la partida.");

                                partidasPerdidas++;

                                partidaActiva = false;
                            }

                            break;

                        case 2:

                            jugadorSePlanto = true;

                            Console.WriteLine();
                            Console.WriteLine("Te plantaste.");
                            Console.WriteLine("Turno del crupier...");

                            while (puntajeCrupier < 17)
                            {
                                int cartaCrupier = random.Next(1, 12);

                                puntajeCrupier += cartaCrupier;

                                Console.WriteLine();
                                Console.WriteLine("El crupier obtuvo: " + cartaCrupier);
                                Console.WriteLine("Puntaje del crupier: " + puntajeCrupier);
                            }

                            Console.WriteLine();
                            Console.WriteLine("===== RESULTADO FINAL =====");
                            Console.WriteLine("Puntaje jugador: " + puntajeJugador);
                            Console.WriteLine("Puntaje crupier: " + puntajeCrupier);

                            if (puntajeCrupier > 21)
                            {
                                Console.WriteLine("El crupier se pasó de 21.");
                                Console.WriteLine("Ganaste la partida.");

                                partidasGanadas++;
                            }
                            else if (puntajeJugador > puntajeCrupier)
                            {
                                Console.WriteLine("Ganaste la partida.");

                                partidasGanadas++;
                            }
                            else if (puntajeCrupier > puntajeJugador)
                            {
                                Console.WriteLine("Perdiste la partida.");

                                partidasPerdidas++;
                            }
                            else
                            {
                                Console.WriteLine("La partida terminó en empate.");

                                partidasEmpatadas++;
                            }

                            partidaActiva = false;

                            break;

                        case 3:

                            Console.WriteLine();
                            Console.WriteLine("===== REGLAS =====");
                            Console.WriteLine("El objetivo es acercarse a 21 sin pasarse.");
                            Console.WriteLine("Cada carta vale entre 1 y 11.");
                            Console.WriteLine("Si superás 21, perdés automáticamente.");
                            Console.WriteLine("El crupier pide cartas hasta llegar a 17 o más.");

                            break;

                        case 4:

                            Console.WriteLine();
                            Console.WriteLine("Saliendo del programa...");

                            programaActivo = false;
                            partidaActiva = false;

                            break;

                        default:

                            Console.WriteLine("Opción inválida.");

                            break;
                    }
                }

                if (programaActivo)
                {
                    Console.WriteLine();
                    Console.WriteLine("===== ESTADÍSTICAS =====");
                    Console.WriteLine("Partidas ganadas: " + partidasGanadas);
                    Console.WriteLine("Partidas perdidas: " + partidasPerdidas);
                    Console.WriteLine("Partidas empatadas: " + partidasEmpatadas);

                    Console.WriteLine();
                    Console.Write("¿Querés jugar otra partida? (s/n): ");

                    string respuesta = Console.ReadLine().ToLower();

                    if (respuesta != "s")
                    {
                        programaActivo = false;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Gracias por jugar.");
            Console.ReadKey();
        }
    }
}



