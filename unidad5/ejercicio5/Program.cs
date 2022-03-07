/* EJERCICIO 5:
Hacer un programa que solicite 20 números y luego emitir por pantalla 
el máximo de los números pares y el mínimo de los números impares. */

using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paso 0 declarar variables.
            int n, maxP = 0, minI = 0;
            int conP = 0, conI = 0; // Contadores para buscar un minimo.

            for (int x = 0; x < 10; x++)
            {
                // Paso 1 Pedir números.
                Console.WriteLine("Ingresa un numero");
                n = int.Parse(Console.ReadLine());

                // Paso 2 Condición.
                if (n % 2 == 0) // Pares
                {
                    conP++;
                    if (conP == 1)
                        maxP = n;
                    else
                        if (n > maxP)
                        maxP = n;
                }
                else // Impares
                {
                    conI++;
                    if (conI == 1)
                        minI = n;
                    else
                        if (n < minI)
                        minI = n;
                }
            }
            Console.WriteLine("max par: " + maxP);
            Console.WriteLine("min impar: " + minI);
        }
    }
}


