using System;

namespace SistemaRefugios
{
    class Refugio
    { 
        public int Codigo { get; set; }
        public int CapacidadMaxima { get; set; }
        public int PersonasAlojadas { get; set; }

        public Refugio(int codigo, int capacidadMaxima, int personasAlojadas)
        {
            Codigo = codigo;
            CapacidadMaxima = capacidadMaxima;
            PersonasAlojadas = personasAlojadas;
        }

        public int CalcularDisponibles()
        {
            return CapacidadMaxima - PersonasAlojadas;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Refugio {Codigo}");
            Console.WriteLine($"Capacidad: {CapacidadMaxima}");
            Console.WriteLine($"Alojados: {PersonasAlojadas}");
            Console.WriteLine($"Disponibles: {CalcularDisponibles()}");
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Refugio refugio1 = new Refugio(101, 20, 12);
            Refugio refugio2 = new Refugio(102, 15, 10);
            Refugio refugio3 = new Refugio(103, 30, 25);

            Console.WriteLine("=== SISTEMA DE REFUGIOS ===");
            Console.WriteLine();

            refugio1.MostrarInformacion();
            refugio2.MostrarInformacion();
            refugio3.MostrarInformacion();

            int totalAlojados = refugio1.PersonasAlojadas + refugio2.PersonasAlojadas + refugio3.PersonasAlojadas;
            int totalDisponibles = refugio1.CalcularDisponibles() + refugio2.CalcularDisponibles() + refugio3.CalcularDisponibles();
            int mayorCapacidadCodigo = refugio1.Codigo;
            int mayorCapacidadMax = refugio1.CapacidadMaxima;

            if (refugio2.CapacidadMaxima > mayorCapacidadMax)
            {
                mayorCapacidadMax = refugio2.CapacidadMaxima;
                mayorCapacidadCodigo = refugio2.Codigo;
            }

            if (refugio3.CapacidadMaxima > mayorCapacidadMax)
            {
                mayorCapacidadMax = refugio3.CapacidadMaxima;
                mayorCapacidadCodigo = refugio3.Codigo;
            }

            Console.WriteLine("=== RESUMEN ===");
            Console.WriteLine($"Personas alojadas: {totalAlojados}");
            Console.WriteLine($"Lugares disponibles: {totalDisponibles}");
            Console.WriteLine($"Refugio de mayor capacidad: {mayorCapacidadCodigo}");

            Console.ReadLine();
            Console.ReadKey();
        }
    }
}