using System;

class CarteleraDeCine
{
    static void Main(string[] args)
    {
        // Creamos una matriz para almacenar los detalles de la película
        string[,] peliculas = new string[3, 3]
        {
            {"Matrix", "Ciencia Ficción", "2:00 PM"},
            {"Jurassic Park", "Acción / Aventura", "5:00 PM"},
            {"El Rey León", "Animación / Aventura", "8:00 PM"}
        };

        // Mostramos los detalles de la película en una tabla
        Console.WriteLine("Cartelera de Cine\n");
        Console.WriteLine("Película\tGénero\t\tHora\n");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("{0}\t{1}\t{2}", peliculas[i, 0], peliculas[i, 1], peliculas[i, 2]);
        }
        Console.ReadLine();
    }
}
