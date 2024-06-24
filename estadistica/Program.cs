using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<double> calificaciones = new List<double>();

        // Ingresar calificaciones
        Console.WriteLine("Ingresa las calificaciones (escribe 'fin' para terminar):");
        string input;
        while ((input = Console.ReadLine()) != "fin")
        {
            if (double.TryParse(input, out double calificacion))
            {
                calificaciones.Add(calificacion);
            }
            else
            {
                Console.WriteLine("Ingresa una calificación válida (número decimal).");
            }
        }

        // Calcular estadísticas
        if (calificaciones.Count > 0)
        {
            double calificacionMaxima = calificaciones.Max();
            double calificacionMinima = calificaciones.Min();
            double promedio = calificaciones.Average();

            Console.WriteLine($"Calificación más alta: {calificacionMaxima}");
            Console.WriteLine($"Calificación más baja: {calificacionMinima}");
            Console.WriteLine($"Promedio de calificaciones: {promedio}");
        }
        else
        {
            Console.WriteLine("No se ingresaron calificaciones.");
        }

        Console.ReadKey();
    }
}
