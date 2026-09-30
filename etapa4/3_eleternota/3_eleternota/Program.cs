using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_eleternota
{
    class Program
    {
        static void Main(string[] args)
        {

                int[,] refugios = new int[20, 5];
                int cantidadRefugios = 0;
                int opcion;
                do
                {
                    Console.Clear();
                    Console.WriteLine("==== MENÚ DEL ETERNOTA ====");
                    Console.WriteLine("1. Agregar refugio");
                    Console.WriteLine("2. Mostrar todos los refugios");
                    Console.WriteLine("3. Ocupar refugio");
                    Console.WriteLine("4. Mostrar ocupados");
                    Console.WriteLine("5. Refugio con más suministros");
                    Console.WriteLine("6. Promedio por zona");
                    Console.WriteLine("7. Filtrar por zona");
                    Console.WriteLine("8. Salir");
                    Console.Write("Opción: ");
                    opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            if (cantidadRefugios >= 20)
                            {
                                Console.WriteLine("\nNo hay refugios... ¡Vamos a morir!.");
                            }
                            else
                            {
                                Console.WriteLine("\n--- REGISTRO DE NUEVO REFUGIO ---");
                                int codigo = 0;
                                bool codigoValido = false;
                                while (!codigoValido)
                                {
                                    Console.Write("Ingrese Código de Refugio (número entero): ");
                                    codigo = int.Parse(Console.ReadLine());
                                    bool yaExiste = false;
                                    for (int i = 0; i < cantidadRefugios; i++)
                                    {
                                        if (refugios[i, 0] == codigo)
                                        {
                                            yaExiste = true;
                                            break;
                                        }
                                    }
                                    if (yaExiste)
                                    {
                                        Console.WriteLine("El código ya existe. Debe ser único.");
                                    }
                                    else
                                    {
                                        codigoValido = true;
                                    }
                                }
                                int capacidad = 0;
                                bool capacidadValida = false;
                                while (!capacidadValida)
                                {
                                    Console.Write("Ingrese Capacidad Máxima: ");
                                    capacidad = int.Parse(Console.ReadLine());
                                    if (capacidad <= 0)
                                    {
                                        Console.WriteLine("No se puede sobrevivir debiendo...");
                                    }
                                    else
                                    {
                                        capacidadValida = true;
                                    }
                                }
                                int suministros = 0;
                                bool suministrosValidos = false;
                                while (!suministrosValidos)
                                {
                                    Console.Write("Ingrese Suministros Disponibles: ");
                                    suministros = int.Parse(Console.ReadLine());

                                    if (suministros <= 0)
                                    {
                                        Console.WriteLine("No se puede sobrevivir debiendo...");
                                    }
                                    else
                                    {
                                        suministrosValidos = true;
                                    }
                                }
                                int zona = 0;
                                bool zonaValida = false;
                                while (!zonaValida)
                                {
                                    Console.WriteLine("Seleccione Zona:");
                                    Console.WriteLine("1 = NORTE (Congreso)\n2 = SUR (Constitución)\n3 = OESTE (Flores)\n4 = CENTRO (Microcentro)");
                                    Console.Write("Opción de zona: ");
                                    zona = int.Parse(Console.ReadLine());
                                    if (zona < 1 || zona > 4)
                                    {
                                        Console.WriteLine("Zona invàlida, esa parte ya està perdida");
                                    }
                                    else
                                    {
                                        zonaValida = true;
                                    }
                                }
                                refugios[cantidadRefugios, 0] = codigo;
                                refugios[cantidadRefugios, 1] = capacidad;
                                refugios[cantidadRefugios, 2] = suministros;
                                refugios[cantidadRefugios, 3] = zona;
                                refugios[cantidadRefugios, 4] = 0;
                                cantidadRefugios++;
                                Console.WriteLine("\n¡Refugio registrado exitosamente!");
                            }
                            break;
                        case 2:
                            if (cantidadRefugios == 0)
                            {
                                Console.WriteLine("\nNo hay refugios registrados en el sistema.");
                            }
                            else
                            {
                                Console.WriteLine("\n--- LISTA DE TODOS LOS REFUGIOS ---");
                                for (int i = 0; i < cantidadRefugios; i++)
                                {
                                    string nombreZona = "";
                                    if (refugios[i, 3] == 1) nombreZona = "NORTE (Congreso)";
                                    else if (refugios[i, 3] == 2) nombreZona = "SUR (Constitución)";
                                    else if (refugios[i, 3] == 3) nombreZona = "OESTE (Flores)";
                                    else if (refugios[i, 3] == 4) nombreZona = "CENTRO (Microcentro)";

                                    string estadoOcupado = refugios[i, 4] == 1 ? "SÍ" : "NO";

                                    Console.WriteLine($"Código: {refugios[i, 0]} | Capacidad: {refugios[i, 1]} | Suministros: {refugios[i, 2]} | Zona: {nombreZona} | Ocupado: {estadoOcupado}");
                                }
                            }
                            break;

                        case 3:

                            if (cantidadRefugios == 0)
                            {
                                Console.WriteLine("\nNo hay refugios registrados.");
                            }
                            else
                            {
                                int desocupados = 0;
                                Console.WriteLine("\n--- REFUGIOS DISPONIBLES (NO OCUPADOS) ---");
                                for (int i = 0; i < cantidadRefugios; i++)
                                {
                                    if (refugios[i, 4] == 0)
                                    {
                                        Console.WriteLine($"Código: {refugios[i, 0]} | Capacidad: {refugios[i, 1]} | Suministros: {refugios[i, 2]}");
                                        desocupados++;
                                    }
                                }

                                if (desocupados == 0)
                                {
                                    Console.WriteLine("No hay refugios libres para ocupar.");
                                }
                                else
                                {
                                    bool ocupacionExitosa = false;
                                    while (!ocupacionExitosa)
                                    {
                                        Console.Write("\nIngrese el Código del refugio que desea ocupar: ");
                                        int codBuscar = int.Parse(Console.ReadLine());

                                        int indiceEncontrado = -1;
                                        for (int i = 0; i < cantidadRefugios; i++)
                                        {
                                            if (refugios[i, 0] == codBuscar)
                                            {
                                                indiceEncontrado = i;
                                                break;
                                            }
                                        }

                                        if (indiceEncontrado == -1)
                                        {
                                            Console.WriteLine("El código ingresado no corresponde a ningún refugio registrado.");
                                        }
                                        else if (refugios[indiceEncontrado, 4] == 1)
                                        {
                                            Console.WriteLine("No somos Okupas, esto ya està ocupado");
                                        }
                                        else
                                        {
                                            refugios[indiceEncontrado, 4] = 1;
                                            Console.WriteLine($"\nEl refugio código {codBuscar} ha sido marcado como OCUPADO.");
                                            ocupacionExitosa = true;
                                        }
                                    }
                                }
                            }
                            break;

                        case 4:

                            int contadorOcupados = 0;
                            Console.WriteLine("\n--- REFUGIOS OCUPADOS ---");
                            for (int i = 0; i < cantidadRefugios; i++)
                            {
                                if (refugios[i, 4] == 1)
                                {
                                    string nombreZona = "";
                                    if (refugios[i, 3] == 1) nombreZona = "NORTE (Congreso)";
                                    else if (refugios[i, 3] == 2) nombreZona = "SUR (Constitución)";
                                    else if (refugios[i, 3] == 3) nombreZona = "OESTE (Flores)";
                                    else if (refugios[i, 3] == 4) nombreZona = "CENTRO (Microcentro)";

                                    Console.WriteLine($"Código: {refugios[i, 0]} | Capacidad: {refugios[i, 1]} | Suministros: {refugios[i, 2]} | Zona: {nombreZona}");
                                    contadorOcupados++;
                                }
                            }

                            if (contadorOcupados == 0)
                            {
                                Console.WriteLine("No hay ningún refugio ocupado actualmente.");
                            }
                            break;

                        case 5:

                            if (cantidadRefugios == 0)
                            {
                                Console.WriteLine("\nNo hay refugios registrados.");
                            }
                            else
                            {
                                int maxSuministros = refugios[0, 2];
                                for (int i = 1; i < cantidadRefugios; i++)
                                {
                                    if (refugios[i, 2] > maxSuministros)
                                    {
                                        maxSuministros = refugios[i, 2];
                                    }
                                }

                                int cantidadConMaximo = 0;
                                for (int i = 0; i < cantidadRefugios; i++)
                                {
                                    if (refugios[i, 2] == maxSuministros)
                                    {
                                        cantidadConMaximo++;
                                    }
                                }

                                Console.WriteLine($"\n--- REFUGIO(S) CON MÁS SUMINISTROS ({maxSuministros} unidades) ---");
                                if (cantidadConMaximo > 1)
                                {
                                    Console.WriteLine($"Aclaración: Se encontraron {cantidadConMaximo} refugios empatados con la máxima cantidad de suministros:");
                                }

                                for (int i = 0; i < cantidadRefugios; i++)
                                {
                                    if (refugios[i, 2] == maxSuministros)
                                    {
                                        Console.WriteLine($"Código: {refugios[i, 0]} | Capacidad: {refugios[i, 1]} | Zona: {refugios[i, 3]}");
                                    }
                                }
                            }
                            break;

                        case 6:
                            if (cantidadRefugios == 0)
                            {
                                Console.WriteLine("\nNo hay refugios registrados.");
                            }
                            else
                            {
                                Console.WriteLine("\n--- PROMEDIO DE CAPACIDAD MÁXIMA POR ZONA ---");
                                for (int z = 1; z <= 4; z++)
                                {
                                    int sumaCapacidad = 0;
                                    int cuentaZona = 0;

                                    for (int i = 0; i < cantidadRefugios; i++)
                                    {
                                        if (refugios[i, 3] == z)
                                        {
                                            sumaCapacidad += refugios[i, 1];
                                            cuentaZona++;
                                        }
                                    }

                                    string nombreZona = "";
                                    if (z == 1) nombreZona = "NORTE (Congreso)";
                                    else if (z == 2) nombreZona = "SUR (Constitución)";
                                    else if (z == 3) nombreZona = "OESTE (Flores)";
                                    else if (z == 4) nombreZona = "CENTRO (Microcentro)";

                                    if (cuentaZona > 0)
                                    {
                                        float promedio = (float)sumaCapacidad / cuentaZona;
                                        Console.WriteLine($"Zona {nombreZona}: Promedio = {promedio:F2} personas (Refugios en zona: {cuentaZona})");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Zona {nombreZona}: Sin refugios registrados.");
                                    }
                                }
                            }
                            break;

                        case 7:
                            if (cantidadRefugios == 0)
                            {
                                Console.WriteLine("\nNo hay refugios registrados.");
                            }
                            else
                            {
                                int zonaBuscar = 0;
                                bool zonaIngresadaValida = false;

                                while (!zonaIngresadaValida)
                                {
                                    Console.Write("\nIngrese Zona a consultar (1=NORTE, 2=SUR, 3=OESTE, 4=CENTRO): ");
                                    zonaBuscar = int.Parse(Console.ReadLine());

                                    if (zonaBuscar < 1 || zonaBuscar > 4)
                                    {
                                        Console.WriteLine("Zona invàlida, esa parte ya està perdida");
                                    }
                                    else
                                    {
                                        zonaIngresadaValida = true;
                                    }
                                }

                                int encontrados = 0;
                                Console.WriteLine($"\n--- REFUGIOS EN LA ZONA SELECCIONADA ---");
                                for (int i = 0; i < cantidadRefugios; i++)
                                {
                                    if (refugios[i, 3] == zonaBuscar)
                                    {
                                        string estadoOcupado = refugios[i, 4] == 1 ? "SÍ" : "NO";
                                        Console.WriteLine($"Código: {refugios[i, 0]} | Capacidad: {refugios[i, 1]} | Suministros: {refugios[i, 2]} | Ocupado: {estadoOcupado}");
                                        encontrados++;
                                    }
                                }

                                if (encontrados == 0)
                                {
                                    Console.WriteLine("No se encontraron refugios registrados en esta zona.");
                                }
                            }
                            break;

                        case 8:
                            Console.WriteLine("\nSaliendo del sistema... ¡Que la nevada no te atrape!");
                            break;

                        default:
                            Console.WriteLine("\nOpción no válida. Intente de nuevo.");
                            break;
                    }

                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();

                } while (opcion != 8);
            }
        }
    }
