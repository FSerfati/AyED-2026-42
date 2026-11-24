using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_centroPM
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vidasPokemones = new int[6];
            int cantidadRegistrados = 0;
            int opcion = 0;
            Random random = new Random();

            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("       CENTRO POKÉ-REMEDIO - VILLA PIXELMON   ");
                Console.WriteLine("==============================================");
                Console.WriteLine($"Capacidad actual: {cantidadRegistrados} / 6 pokemones");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("1  - Registrar un nuevo pokémon");
                Console.WriteLine("2  - Mostrar la vida de todos los pokemones");
                Console.WriteLine("3  - Curar un pokémon");
                Console.WriteLine("4  - Dañar un pokémon");
                Console.WriteLine("5  - Curar a todos los pokemones");
                Console.WriteLine("6  - Mostrar pokemones debilitados");
                Console.WriteLine("7  - Mostrar el pokémon con mayor vida");
                Console.WriteLine("8  - Mostrar el pokémon con menor vida");
                Console.WriteLine("9  - Calcular promedio de vida del equipo");
                Console.WriteLine("10 - Ordenar pokemones por vida de menor a mayor");
                Console.WriteLine("11 - Ordenar pokemones por vida de mayor a menor");
                Console.WriteLine("12 - Simular ataque enemigo a todo el equipo");
                Console.WriteLine("13 - Salir");
                Console.WriteLine("14 - [Extra] Usar Poción Máxima (Cura todo al 100)");
                Console.WriteLine("==============================================");
                Console.Write("Seleccione una opción: ");
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    opcion = -1; 
                }

                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        if (cantidadRegistrados >= 6)
                        {
                            Console.WriteLine("No se pueden registrar más pokemones. El centro está lleno.");
                        }
                        else
                        {
                            int nuevaVida;
                            while (true)
                            {
                                Console.Write("Ingrese la vida del pokémon (0 a 100): ");
                                if (int.TryParse(Console.ReadLine(), out nuevaVida) && nuevaVida >= 0 && nuevaVida <= 100)
                                {
                                    break;
                                }
                                Console.WriteLine("Error: La vida debe ser un número entre 0 y 100.\n");
                            }

                            vidasPokemones[cantidadRegistrados] = nuevaVida;
                            Console.WriteLine($"Pokémon registrado correctamente en la posición {cantidadRegistrados}.");
                            cantidadRegistrados++;
                        }
                        break;

                    case 2: 
                        if (cantidadRegistrados == 0)
                        {
                            Console.WriteLine("No hay pokemones registrados en el centro.");
                        }
                        else
                        {
                            for (int i = 0; i < cantidadRegistrados; i++)
                            {
                                string estado = ObtenerEstado(vidasPokemones[i]);
                                Console.WriteLine($"Pokémon {i + 1} (Posición {i}) - Vida: {vidasPokemones[i]} - Estado: {estado}");
                            }
                        }
                        break;

                    case 3:
                        if (cantidadRegistrados == 0)
                        {
                            Console.WriteLine("No hay pokemones registrados para curar.");
                        }
                        else
                        {
                            int posCurar = PedirPosicionValida("Ingrese la posición del pokémon a curar", cantidadRegistrados);
                            int puntosCurar = PedirCantidadPositiva("Ingrese puntos de vida a recuperar");

                            vidasPokemones[posCurar] += puntosCurar;
                            if (vidasPokemones[posCurar] > 100)
                            {
                                vidasPokemones[posCurar] = 100;
                            }

                            Console.WriteLine("El pokémon fue curado.");
                            Console.WriteLine($"Vida actual: {vidasPokemones[posCurar]}");
                        }
                        break;

                    case 4: 
                        if (cantidadRegistrados == 0)
                        {
                            Console.WriteLine("No hay pokemones registrados para dañar.");
                        }
                        else
                        {
                            int posDanar = PedirPosicionValida("Ingrese la posición del pokémon atacado", cantidadRegistrados);
                            int danio = PedirCantidadPositiva("Ingrese daño recibido");

                            vidasPokemones[posDanar] -= danio;
                            if (vidasPokemones[posDanar] < 0)
                            {
                                vidasPokemones[posDanar] = 0;
                            }

                            Console.WriteLine("El pokémon recibió daño.");
                            Console.WriteLine($"Vida actual: {vidasPokemones[posDanar]}");
                        }
                        break;

                    case 5:
                        if (cantidadRegistrados == 0)
                        {
                            Console.WriteLine("No hay pokemones registrados en el equipo.");
                        }
                        else
                        {
                            int curaGeneral = PedirCantidadPositiva("Ingrese puntos de curación general");

                            for (int i = 0; i < cantidadRegistrados; i++)
                            {
                                vidasPokemones[i] += curaGeneral;
                                if (vidasPokemones[i] > 100)
                                {
                                    vidasPokemones[i] = 100;
                                }
                            }
                            Console.WriteLine("Todos los pokemones fueron curados.");
                        }
                        break;

                    case 6: 
                        if (cantidadRegistrados == 0)
                        {
                            Console.WriteLine("No hay pokemones registrados en el centro.");
                        }
                        else
                        {
                            int contadorDebilitados = 0;
                            Console.WriteLine("Pokemones debilitados:");

                            for (int i = 0; i < cantidadRegistrados; i++)
                            {
                                if (vidasPokemones[i] == 0)
                                {
                                    Console.WriteLine($"Pokémon en posición {i}");
                                    contadorDebilitados++;
                                }
                            }

                            if (contadorDebilitados == 0)
                            {
                                Console.WriteLine("No hay pokemones debilitados.");
                            }
                            else
                            {
                                Console.WriteLine($"Cantidad total de debilitados: {contadorDebilitados}");
                            }
                        }
                        break;

                    case 7:
                        if (cantidadRegistrados == 0)
                        {
                            Console.WriteLine("No hay pokemones registrados.");
                        }
                        else
                        {
                            int mayorVida = vidasPokemones[0];
                            int posMayor = 0;

                            for (int i = 1; i < cantidadRegistrados; i++)
                            {
                                if (vidasPokemones[i] > mayorVida)
                                {
                                    mayorVida = vidasPokemones[i];
                                    posMayor = i;
                                }
                            }

                            Console.WriteLine($"El pokémon con mayor vida está en la posición {posMayor}.");
                            Console.WriteLine($"Vida: {mayorVida}");
                        }
                        break;

                    case 8: 
                        if (cantidadRegistrados == 0)
                        {
                            Console.WriteLine("No hay pokemones registrados.");
                        }
                        else
                        {
                            int menorVida = vidasPokemones[0];
                            int posMenor = 0;
                            for (int i = 1; i < cantidadRegistrados; i++)
                            {
                                if (vidasPokemones[i] < menorVida)
                                {
                                    menorVida = vidasPokemones[i];
                                    posMenor = i;
                                }
                            }
                            Console.WriteLine($"El pokémon con menor vida está en la posición {posMenor}.");
                            Console.WriteLine($"Vida: {menorVida}");
                        }
                        break;
                    case 9:
                        if (cantidadRegistrados == 0)
                        {
                            Console.WriteLine("No hay pokemones registrados para calcular el promedio.");
                        }
                        else
                        {
                            int sumaVidas = 0;
                            for (int i = 0; i < cantidadRegistrados; i++)
                            {
                                sumaVidas += vidasPokemones[i];
                            }
                            double promedio = (double)sumaVidas / cantidadRegistrados;
                            Console.WriteLine($"Promedio de vida del equipo: {promedio:F2}");
                            if (promedio >= 70)
                            {
                                Console.WriteLine("El equipo está en buen estado.");
                            }
                            else if (promedio >= 31 && promedio <= 69)
                            {
                                Console.WriteLine("El equipo necesita curación.");
                            }
                            else
                            {
                                Console.WriteLine("El equipo está en peligro.");
                            }
                        }
                        break;
                    case 10:
                        if (cantidadRegistrados == 0)
                        {
                            Console.WriteLine("No hay pokemones registrados para ordenar.");
                        }
                        else
                        {
                            for (int i = 0; i < cantidadRegistrados - 1; i++)
                            {
                                for (int j = 0; j < cantidadRegistrados - 1 - i; j++)
                                {
                                    if (vidasPokemones[j] > vidasPokemones[j + 1])
                                    {
                                        int aux = vidasPokemones[j];
                                        vidasPokemones[j] = vidasPokemones[j + 1];
                                        vidasPokemones[j + 1] = aux;
                                    }
                                }
                            }
                            Console.WriteLine("Vidas ordenadas de menor a mayor:");
                            for (int i = 0; i < cantidadRegistrados; i++)
                            {
                                Console.WriteLine(vidasPokemones[i]);
                            }
                        }
                        break;
                    case 11: 
                        if (cantidadRegistrados == 0)
                        {
                            Console.WriteLine("No hay pokemones registrados para ordenar.");
                        }
                        else
                        {
                            for (int i = 0; i < cantidadRegistrados - 1; i++)
                            {
                                for (int j = 0; j < cantidadRegistrados - 1 - i; j++)
                                {
                                    if (vidasPokemones[j] < vidasPokemones[j + 1])
                                    {
                                        int aux = vidasPokemones[j];
                                        vidasPokemones[j] = vidasPokemones[j + 1];
                                        vidasPokemones[j + 1] = aux;
                                    }
                                }
                            }
                            Console.WriteLine("Vidas ordenadas de mayor a menor:");
                            for (int i = 0; i < cantidadRegistrados; i++)
                            {
                                Console.WriteLine(vidasPokemones[i]);
                            }
                        }
                        break;
                    case 12: 
                        if (cantidadRegistrados == 0)
                        {
                            Console.WriteLine("No hay pokemones en el equipo para recibir el ataque.");
                        }
                        else
                        {
                            int danioSalvaje = random.Next(5, 26);
                            for (int i = 0; i < cantidadRegistrados; i++)
                            {
                                vidasPokemones[i] -= danioSalvaje;
                                if (vidasPokemones[i] < 0)
                                {
                                    vidasPokemones[i] = 0;
                                }
                            }
                            Console.WriteLine("¡Un pokémon salvaje atacó al equipo!");
                            Console.WriteLine($"Daño recibido por todos: {danioSalvaje}");
                            Console.WriteLine("Las vidas fueron actualizadas.");
                        }
                        break;
                    case 13: 
                        Console.WriteLine("Gracias por utilizar el sistema del Centro Poké-Remedio.");
                        break;
                    case 14:
                        if (cantidadRegistrados == 0)
                        {
                            Console.WriteLine("No hay pokemones registrados en el equipo.");
                        }
                        else
                        {
                            for (int i = 0; i < cantidadRegistrados; i++)
                            {
                                vidasPokemones[i] = 100;
                            }
                            Console.WriteLine("¡Usaste una Poción Máxima! Todos los pokemones recuperaron el 100% de su vida.");
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, ingrese un número del menú.");
                        break;
                }
                if (opcion != 13)
                {
                    Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
                    Console.ReadKey();
                }
            } while (opcion != 13);
        }
        static string ObtenerEstado(int vida)
        {
            if (vida == 0) return "Debilitado";
            if (vida <= 30) return "Crítico";
            if (vida <= 70) return "Herido";
            return "Buen estado";
        }
        static int PedirPosicionValida(string mensaje, int limiteRegistrados)
        {
            int pos;
            while (true)
            {
                Console.Write($"{mensaje} (0 a {limiteRegistrados - 1}): ");
                if (int.TryParse(Console.ReadLine(), out pos) && pos >= 0 && pos < limiteRegistrados)
                {
                    return pos;
                }
                Console.WriteLine($"Error: Posición inválida. Debe estar entre 0 y {limiteRegistrados - 1}.\n");
            }
        }

        static int PedirCantidadPositiva(string mensaje)
        {
            int cantidad;
            while (true)
            {
                Console.Write($"{mensaje}: ");
                if (int.TryParse(Console.ReadLine(), out cantidad) && cantidad >= 0)
                {
                    return cantidad;
                }
                Console.WriteLine("Error: Debe ingresar un número entero mayor o igual a 0.\n");
            }
        }
    }
}
