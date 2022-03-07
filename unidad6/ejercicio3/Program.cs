/* EJERCICIO 3:
Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. 
El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista. */

using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paso 0 declaro variables.
            int n, con = 0;

            // Paso 1 pido un número para ingresar al primer while(números positivos).
            n = int.Parse(Console.ReadLine());

            while (n >= 0)
            {
                con = 0;
                Console.WriteLine("ingresa un número");
                n = int.Parse(Console.ReadLine());

                // Paso 2 anido el while 2 para pedir lista de números positivos separado por 0.
                while (n != 0 && n >= 0)
                {
                    con++;
                    n = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Números de la lista son: " + con); // Paso 3 muestro en pantalla total de números de las listas.
            }
            Console.WriteLine("Fin de la carga ingreso un número negativo"); // Notificación de que ingreso un número negativo.
        }
    }
}