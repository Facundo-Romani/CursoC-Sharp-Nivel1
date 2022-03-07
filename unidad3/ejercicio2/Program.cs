/* EJERCICIO 2: Hacer un programa para ingresar un número y luego se emita un cartel
 por pantalla “Positivo” si el número es mayor a cero, “Negativo” 
 si el número es menor a cero o “Cero” si el número es igual a cero. */


using System;

namespace ejercicio2
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
            if (n > 0)
                Console.WriteLine("Positivo");
            else if (n <= 0)
                Console.WriteLine("Negativo");

        }
    }
}
