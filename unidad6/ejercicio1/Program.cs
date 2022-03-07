/* EJERCICIO 1:
Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos. */

using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paso 0 definir variables.
            int n, con = 0, d;

            // Paso 1 pedir ingresos de numeros.
            for (int y = 0; y < 10; y++)
            {
                Console.WriteLine("Ingresa un numero");
                n = int.Parse(Console.ReadLine());

                d = 0; // Asigno divisores en 0.
                // Paso 2 condicion para primo.
                for (int x = 1; x <= n; x++)
                {
                    if (n % x == 0)
                        d++; // Divisor.
                }
                if (d == 2)
                {
                    con++;
                }
            }
            Console.WriteLine("Total primos: " + con);
        }
    }
}