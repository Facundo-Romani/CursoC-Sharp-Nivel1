/* EJERCICIO 1:
Hacer un programa que solicite 10 números enteros y los guarde en un vector. 
Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector. */

using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paso 0 declarar el vector y variables.
            int[] numerosEnteros = new int[10];
            int max = numerosEnteros[0]; // Me guardo el máximo en Pos 0.
            int pos = 1; // Guardo posicion.

            // Paso 1 pedir los numeros.
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingresa 10 numeros enteros: ");
                numerosEnteros[x] = int.Parse(Console.ReadLine()); // Paso 2 Almacenar los numeros que pido al usuario en el vector.
            }

            // Paso 3 recorrer el vector y manipular.
            for (int x = 0; x < 10; x++)
            {
                if (numerosEnteros[x] > max)
                {
                    max = numerosEnteros[x];
                    pos = x + 1;
                }
            }
            Console.WriteLine("El max de los numeros es: " + max);
            Console.WriteLine("Su posicion es: " + pos);
        }
    }
}
