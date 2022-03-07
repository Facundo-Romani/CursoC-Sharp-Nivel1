/* EJERCICIO 5:
Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno
y luego calcule y emita por pantalla el promedio final. */

using System;

namespace ejercicios_unidad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paso 0 declarar variables.
            float nota1, nota2, nota3, promedioF;

            // Paso 1 pedir numeros.
            Console.WriteLine("Ingresa un numero: ");
            nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa un numero: ");
            nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa un numero: ");
            nota3 = float.Parse(Console.ReadLine());

            // Paso 2 hacer el calculo.
            promedioF = (nota1 + nota2 + nota3) / 3;

            // Paso 3 mostrar en pantalla.
            Console.WriteLine("El promedio final de los tres examenes es: " + promedioF);
        }
    }
}
