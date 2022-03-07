/* EJERCICIO 2:
 Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo. */

using System;

namespace ejercicios_unidad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paso 0 declarar variables.
            int num1, rAlCubo;

            // Paso 1 pedir numeros.
            Console.WriteLine("Ingresa un numero: ");
            num1 = int.Parse(Console.ReadLine());

            // Paso 2 hacer el calculo para elevar al cubo.
            rAlCubo = num1 * num1 * num1;

            // Paso 3 mostrar en pantalla.
            Console.WriteLine("El resultado del" + num1 + "elevado al cubo: " + rAlCubo);
        }
    }
}
