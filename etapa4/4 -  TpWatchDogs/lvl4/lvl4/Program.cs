using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lvl4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Nivel 4 – Cifrado +1 (LITE)");
            string msg = "ctOS";
            string enc = Level4.CaesarPlusOne(msg);
            bool ok = enc == "duPT"; // c->d, t->u, O->P, S->T
            Console.WriteLine(ok ? "✔ UNLOCK → Código final: CT-ACCESS-OK" : "🔒 LOCKED");
            Console.ReadKey();
        }
    }

    static class Level4
    {
        public static string CaesarPlusOne(string s)
        {
            string resultado = "";

            foreach (char c in s)
            {
                if (c >= 'a' && c <= 'z')
                {
                    if (c == 'z')
                        resultado += 'a';
                    else
                        resultado += (char)(c + 1);
                }
                else if (c >= 'A' && c <= 'Z')
                {
                    if (c == 'Z')
                        resultado += 'A';
                    else
                        resultado += (char)(c + 1);
                }
                else
                {
                    resultado += c;
                }
            }
            // TODO: implementar
            // Reglas: letras rotan (z→a, Z→A), mantener may/min; otros chars, igual.
            return resultado; // <- reemplazar por tu solución
        }
    }
}
