/* EJERCICIO 2:
Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla.
Solo se debe emitir UN valor por pantalla. */

using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paso 0 declarar variables.
            int n = 0, nM = 0;

            // Paso 1 pedir numeros. 
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingresa un numero");
                n = int.Parse(Console.ReadLine());

                // Paso 2 pregunto condición n es mayor a nM que vale 0.
                if (n > nM)
                    nM = n;
            }
            Console.WriteLine("El numero mayor es: " + nM);
        }
    }
}

