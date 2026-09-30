using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel_3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Nivel 3 – Firewalls adyacentes (LITE)");
            int[,] g =
            {
            {0,1,0},
            {1,0,1},
            {0,1,0}
        };
            bool ok = Level3.CountAdjacent(g, 1, 1) == 4
                   && Level3.CountAdjacent(g, 0, 0) == 2;
            Console.WriteLine(ok ? "✔ UNLOCK → Fragmento: -OK" : "🔒 LOCKED");
            Console.ReadKey();
        }
    }

    static class Level3
    {
        public static int CountAdjacent(int[,] grid, int row, int col)
        {
            int cantidad1 = 0;
            if (row - 1 >= 0 && grid[row - 1, col] == 1)
                cantidad1++;

            if (row + 1 < grid.GetLength(0) && grid[row + 1, col] == 1)
                cantidad1++;

            if (col - 1 >= 0 && grid[row, col - 1] == 1)
                cantidad1++;

            if (col + 1 < grid.GetLength(1) && grid[row, col + 1] == 1)
                cantidad1++;
            // TODO: implementar
            // Considerar vecinos: (r-1,c), (r+1,c), (r,c-1), (r,c+1)
            // Devolver cuántos valen 1
            return cantidad1; // <- reemplazar por tu solución
        }
    }
}
