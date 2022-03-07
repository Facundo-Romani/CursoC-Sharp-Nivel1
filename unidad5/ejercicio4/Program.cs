/* EJERCICIO 4:
Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo.
Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo. */

using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paso 0 declarar variables.
            int n, d = 0;

            // Paso 1 pedir datos.
            Console.WriteLine("Ingresa un numero");
            n = int.Parse(Console.ReadLine());

            // Paso 2 bucle.
            for (int x = 1; x <= n; x++)
            {
                if (n % x == 0)
                {
                    d++; // Divisor.
                }
            }
            // Paso 3 mostrar en pantalla por fuera de while.
            if (d == 2)
            {

                Console.WriteLine("Numero es primo");
            }
            else
                Console.WriteLine("Numero no es primo");

        }
    }
}
