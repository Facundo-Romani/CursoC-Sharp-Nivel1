
/* EJERCICIO 3: 
Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años. */

using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paso 0 declaro variables.
            int edad, m18 = 0, con = 0, promedio;

            // Paso 1 pedir datos.
            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingresa Edad");
                edad = int.Parse(Console.ReadLine());

                // Paso 2 plantear condición.
                if (edad > 18)
                {
                    m18 += edad;
                    con++;
                }
            }
            // Paso 3 hacer calculo.
            promedio = m18 / con;

            // Paso 4 Mostrar en pantalla.
            Console.WriteLine("El promedio de alumnos mayores a 18 años es: " + promedio);
        }
    }
}
