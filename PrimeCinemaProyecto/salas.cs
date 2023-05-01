using System;
using System.Collections.Generic;

class SalaDeCine
{
    static void Main(string[] args)
    {
        // Creamos una lista para almacenar las salas
        List<string> salas = new List<string>();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Administrador de Salas de Cine\n");
            Console.WriteLine("1. Agregar sala");
            Console.WriteLine("2. Eliminar sala");
            Console.WriteLine("3. Ver salas");
            Console.WriteLine("4. Salir");
            Console.Write("\nSelecciona una opción: ");

            // Leemos la opción del usuario
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("\nIngresa el nombre de la sala: ");
                    string nombreSala = Console.ReadLine();
                    salas.Add(nombreSala);
                    Console.WriteLine("\nSala agregada correctamente.");
                    Console.ReadLine();
                    break;

                case "2":
                    Console.Write("\nIngresa el nombre de la sala que quieres eliminar: ");
                    string nombreSalaEliminar = Console.ReadLine();
                    if (salas.Contains(nombreSalaEliminar))
                    {
                        salas.Remove(nombreSalaEliminar);
                        Console.WriteLine("\nSala eliminada correctamente.");
                    }
                    else
                    {
                        Console.WriteLine("\nLa sala no existe en la lista.");
                    }
                    Console.ReadLine();
                    break;

                case "3":
                    Console.WriteLine("\nSalas Disponibles:\n");
                    if (salas.Count > 0)
                    {
                        foreach (string sala in salas)
                        {
                            Console.WriteLine("- " + sala);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No hay salas disponibles.");
                    }
                    Console.ReadLine();
                    break;

                case "4":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("\nOpción inválida. Intente de nuevo.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
