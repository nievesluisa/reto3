using System;
using System.Collections.Generic;

namespace LoteriaNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generar números ganadores
            List<int> numerosGanadores = GenerarNumerosGanadores();

            // Solicitar números al usuario
            List<int> numerosUsuario = SolicitarNumerosUsuario();

            // Comparar y contar aciertos
            int aciertos = ContarAciertos(numerosGanadores, numerosUsuario);

            // Mostrar resultados
            Console.WriteLine("Números ganadores: " + string.Join(", ", numerosGanadores));
            Console.WriteLine("Tus números elegidos: " + string.Join(", ", numerosUsuario));
            Console.WriteLine("Aciertos: " + aciertos);

            if (aciertos == 6)
            {
                Console.WriteLine("¡Felicidades! Has acertado todos los números.");
            }
        }

        static List<int> GenerarNumerosGanadores()
        {
            List<int> numerosGanadores = new List<int>();
            Random random = new Random();

            while (numerosGanadores.Count < 6)
            {
                int numeroAleatorio = random.Next(1, 50);
                if (!numerosGanadores.Contains(numeroAleatorio))
                {
                    numerosGanadores.Add(numeroAleatorio);
                }
            }

            return numerosGanadores;
        }

        static List<int> SolicitarNumerosUsuario()
        {
            List<int> numerosUsuario = new List<int>();

            Console.WriteLine("Ingresa 6 números diferentes entre 1 y 49:");
            while (numerosUsuario.Count < 6)
            {
                if (int.TryParse(Console.ReadLine(), out int numeroIngresado))
                {
                    if (numeroIngresado >= 1 && numeroIngresado <= 49 && !numerosUsuario.Contains(numeroIngresado))
                    {
                        numerosUsuario.Add(numeroIngresado);
                    }
                    else
                    {
                        Console.WriteLine("Número inválido. Debe ser diferente y estar entre 1 y 49.");
                    }
                }
                else
                {
                    Console.WriteLine("Ingresa un número válido.");
                }
            }

            return numerosUsuario;
        }

        static int ContarAciertos(List<int> numerosGanadores, List<int> numerosUsuario)
        {
            int aciertos = 0;
            foreach (int numeroGanador in numerosGanadores)
            {
                if (numerosUsuario.Contains(numeroGanador))
                {
                    aciertos++;
                }
            }
            return aciertos;
        }
    }
}
