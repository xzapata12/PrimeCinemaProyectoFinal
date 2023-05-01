using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeCinemaProyecto
{

namespace Butacas 
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Matriz de butacas disponibles
                bool[,] butacasDisponibles = new bool[8, 5];

                // Inicializar butacas disponibles
                for (int i = 0; i < butacasDisponibles.GetLength(0); i++)
                {
                    for (int j = 0; j < butacasDisponibles.GetLength(1); j++)
                    {
                        butacasDisponibles[i, j] = true;
                    }
                }

                // Ciclo principal del programa
                while (true)
                {
                    // Mostrar butacas disponibles
                    Console.WriteLine("Butacas disponibles:");
                    for (int i = 0; i < butacasDisponibles.GetLength(0); i++)
                    {
                        for (int j = 0; j < butacasDisponibles.GetLength(1); j++)
                        {
                            if (butacasDisponibles[i, j])
                            {
                                Console.Write("O ");
                            }
                            else
                            {
                                Console.Write("X ");
                            }
                        }
                        Console.WriteLine();
                    }

                    // Preguntar al usuario por la fila y columna de la butaca deseada
                    Console.Write("Ingrese la fila de la butaca deseada (1-8): ");
                    int fila = int.Parse(Console.ReadLine()) - 1;  // Restar 1 para ajustar a la matriz
                    Console.Write("Ingrese la columna de la butaca deseada (1-5): ");
                    int columna = int.Parse(Console.ReadLine()) - 1;  // Restar 1 para ajustar a la matriz

                    // Verificar si la butaca está disponible y seleccionarla si es el caso
                    if (butacasDisponibles[fila, columna])
                    {
                        butacasDisponibles[fila, columna] = false;
                        Console.WriteLine("Butaca seleccionada correctamente.");
                    }
                    else
                    {
                        Console.WriteLine("La butaca ya está ocupada. Seleccione otra butaca.");
                    }

                    // Preguntar al usuario si desea continuar comprando
                    Console.Write("¿Desea continuar comprando? (si/no): ");
                    string continuar = Console.ReadLine().ToLower();
                    if (continuar == "n")
                    {
                        break;
                    }
                }

                // Reiniciar butacas disponibles
                for (int i = 0; i < butacasDisponibles.GetLength(0); i++)
                {
                    for (int j = 0; j < butacasDisponibles.GetLength(1); j++)
                    {
                        butacasDisponibles[i, j] = true;
                    }
                }

                Console.WriteLine("Todas las butacas han sido liberadas.");
                Console.WriteLine("Gracias por su compra.");
                Console.ReadLine();
            }
        }
    }

}
