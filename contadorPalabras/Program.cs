using System;
using System.Collections.Generic;

class Progra
{
    static void Main()
    {
        Console.Write("Ingresa un texto: ");
        string texto = Console.ReadLine();

        // Dividir el texto en palabras usando espacios como delimitador
        string[] palabras = texto.Split(' ');

        // Crear un diccionario para almacenar las palabras y sus frecuencias
        Dictionary<string, int> frecuencias = new Dictionary<string, int>();

        foreach (string palabra in palabras)
        {
            // Limpiar la palabra (eliminar signos de puntuación, etc.)
            string palabraLimpia = palabra.Trim('.', ',', ';', ':', '?', '!', '(', ')');

            // Convertir a minúsculas para evitar duplicados (por ejemplo, "Hola" y "hola")
            string palabraMinuscula = palabraLimpia.ToLower();

            if (frecuencias.ContainsKey(palabraMinuscula))
            {
                // Si la palabra ya existe en el diccionario, incrementar su frecuencia
                frecuencias[palabraMinuscula]++;
            }
            else
            {
                // Si es una palabra nueva, agregarla al diccionario con frecuencia 1
                frecuencias[palabraMinuscula] = 1;
            }
        }

        // Mostrar los resultados
        Console.WriteLine("Palabra\tFrecuencia");
        foreach (var kvp in frecuencias)
        {
            Console.WriteLine($"{kvp.Key}\t{kvp.Value}");
        }
    }
}
