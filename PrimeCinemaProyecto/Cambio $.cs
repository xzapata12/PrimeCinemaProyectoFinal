using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeCinemaProyecto
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            // Precio de las entradas
            const double precioAdulto = 5.00;
            const double precioTerceraEdad = 3.90;

            // Pedir al usuario la cantidad de entradas vendidas de cada tipo
            Console.WriteLine("Ingrese la cantidad de entradas vendidas para:");
            Console.Write("Adultos: ");
            int cantidadAdultos = int.Parse(Console.ReadLine());
            Console.Write("Tercera edad: ");
            int cantidadTerceraEdad = int.Parse(Console.ReadLine());

            // Calcular el total vendido y mostrarlo
            double totalVendido = cantidadAdultos * precioAdulto + cantidadTerceraEdad * precioTerceraEdad;
            Console.WriteLine($"Total vendido: ${totalVendido}");

            // Pedir al usuario la cantidad de dinero entregada
            Console.Write("Ingrese la cantidad de dinero entregada: ");
            double cantidadEntregada = double.Parse(Console.ReadLine());

            // Calcular el cambio y mostrarlo
            double cambio = cantidadEntregada - totalVendido;
            Console.WriteLine($"Cambio: ${cambio}");
        }
    }
}
