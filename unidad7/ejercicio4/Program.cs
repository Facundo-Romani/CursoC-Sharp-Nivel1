/* EJERCICIO 4:
Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera 
un registro con los siguientes datos:
- Número de Artículo (1 a 15)
- Cantidad Vendida 

Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
Se pide determinar e informar:
a) El número de artículo que más se vendió en total.
b) Los números de artículos que no registraron ventas.
c) Cuantas unidades se vendieron del número de artículo 10. */

using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {

            int articulo;
            int cantidadVendida;
            int[] totalDeVentas = new int[15]; // Vector para acumular.

            for (int x = 0; x < 15; x++) // El for es creado para los 15 acumuladores del punto A.
            {
                totalDeVentas[x] = 0;   // Inicializar el acumulador en 0 que va a contar todos los articulos venidos.
            }

            Console.WriteLine("Ingresa el artículo");
            articulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa cantidad vendida");
            cantidadVendida = int.Parse(Console.ReadLine());

            while (articulo != 0)
            {
                totalDeVentas[articulo - 1] += cantidadVendida;

                Console.WriteLine("Ingresa el artículo");
                articulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa cantidad vendida");
                cantidadVendida = int.Parse(Console.ReadLine());
            }

            // Punto A.
            int maxCantidad = totalDeVentas[0];
            //int numeroMax = 1;

            for (int x = 0; x < 15; x++)
            {
                if (totalDeVentas[x] > maxCantidad)
                {
                    maxCantidad = totalDeVentas[x];
                    articulo = x + 1;
                }
                Console.WriteLine("El artículo con mayor ventas es: " + articulo);
            }

            // Punto B.
            for (int x = 0; x < 15; x++)
            {
                if (totalDeVentas[x] == 0)
                {
                    Console.WriteLine("El artículo: " + (x + 1) + "no tiene ventas");
                }
            }

            // Punto C.
            Console.WriteLine("La cantidad vendida en el articulo 10 es: " + totalDeVentas[9]);
        }
    }
}
