using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lehenariketak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Juego: Adivina el número");
            var rnd = new Random();
            bool jugarOtra = true;

            while (jugarOtra)
            {
                int objetivo = rnd.Next(1, 101); // 1..100
                int intentos = 0;
                Console.WriteLine("He elegido un número entre 1 y 100. ¡Adivina!");

                while (true)
                {
                    Console.Write("Tu intento: ");
                    string entrada = Console.ReadLine();
                    int intento;
                    if (!int.TryParse(entrada, out intento))
                    {
                        Console.WriteLine("Entrada inválida. Introduce un número.");
                        continue;
                    }

                    intentos++;

                    if (intento < objetivo)
                    {
                        Console.WriteLine("Más alto.");
                    }
                    else if (intento > objetivo)
                    {
                        Console.WriteLine("Más bajo.");
                    }
                    else
                    {
                        Console.WriteLine($"¡Correcto! Lo has adivinado en {intentos} intentos.");
                        break;
                    }
                }

                Console.Write("¿Quieres jugar otra vez? (s/n): ");
                string resp = Console.ReadLine();
                if (string.IsNullOrEmpty(resp) || resp.ToLower()[0] != 's')
                {
                    jugarOtra = false;
                }
            }

            Console.WriteLine("Gracias por jugar. Pulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}

