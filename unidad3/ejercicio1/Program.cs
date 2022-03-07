/* EJERCICIO 1:
 Hacer un programa para ingresar un número y luego se emita por pantalla
 un cartel aclaratorio si “Es mayor a 10” o “No es mayor a 10”. */

using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paso 0 declaro variables.
            int n;

            // Paso 1 pedir datos.
            Console.WriteLine("Ingrese un numero");
            n = int.Parse(Console.ReadLine());

            // Paso 2 evaluar condición.
            if (n > 10)
                Console.WriteLine("Es mayor a 10");
            else
                Console.WriteLine("No es mayor a 10");

        }
    }
}
