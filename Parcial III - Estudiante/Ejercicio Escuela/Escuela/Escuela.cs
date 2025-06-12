using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class Escuela
{
    static void Main()
    {
        string nombre;
        double calificacion;

        do
        {
            Console.Write("Ingrese el nombre del estudiante: ");
            nombre = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                Console.WriteLine("El nombre no puede estar vacío. Intente nuevamente.\n");
            }
        } while (string.IsNullOrWhiteSpace(nombre));

        while (true)
        {
            Console.Write("Ingrese la calificación del estudiante (0 a 10): ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out calificacion) && calificacion >= 0 && calificacion <= 10)
            {
                break;
            }
            else
            {
                Console.WriteLine("Calificación inválida. Debe ser un número entre 0 y 10.\n");
            }
        }

        if (calificacion >= 6)
        {
            Console.WriteLine($"\n{nombre} aprobó con una calificación de {calificacion}.");
        }
        else
        {
            Console.WriteLine($"\n{nombre} reprobó con una calificación de {calificacion}.");
        }

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}

