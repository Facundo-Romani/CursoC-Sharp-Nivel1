/* EJERCICIO 2:
Hacer un programa que solicite 10 números enteros y los guarde en un vector. Luego recorrer ese vector para calcular el promedio. 
Mostrar por pantalla los valores que son mayores al promedio. */

using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paso 0 declaro vector.
            int[] numero = new int[10];
            int acu = 0; // Acumulador para promedio
            int promedio;

            // Paso 1 pido el ingreso de numeros.
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingresa un numero");
                numero[x] = int.Parse(Console.ReadLine());
            }

            // Paso 2 recorrer el vector.
            for (int x = 0; x < 10; x++)
            {
                acu += numero[x];
            }

            // Paso 3 calcular promedio.
            promedio = acu / 10;

            // Paso 4 mostrar por pantalla valores mayores al promedio.
            for (int x = 0; x < 10; x++)
            {
                if (numero[x] > promedio)
                {
                    Console.WriteLine("Valores mayores al promedio: " + numero[x]);
                }
            }
        }
    }
}
