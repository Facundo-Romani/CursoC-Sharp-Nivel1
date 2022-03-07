/* EJERCICIO 1:
Hacer un programa para mostrar los números del 1 al 10. No se debe realizar ningún pedido de datos. */

using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Paso 0 ciclo for.
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine(x + 1); // a X le sumo 1 para mostrar de 1 a 10.
            }
        }
    }
}
