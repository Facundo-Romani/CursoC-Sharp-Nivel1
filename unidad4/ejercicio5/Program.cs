/* EJERCICIO 5:
Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla 
si los mismos se encuentran ordenados de forma decreciente . */


using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paso 0 declaro variables.
            int n1, n2, n3, n4;

            // Paso 1 pido el ingreso de números.
            Console.WriteLine("Ingresa un numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa otro numero");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa otro numero");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa otro numero");
            n4 = int.Parse(Console.ReadLine());

            // Paso 2 preguntar condición.
            if ((n1 > n2) && (n2 > n3) && (n3 > n4))
                Console.WriteLine("Orden Decreciente");
            else
                Console.WriteLine("No Orden");

        }
    }
}