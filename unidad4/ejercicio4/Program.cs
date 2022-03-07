/* EJERCICIO 4:
Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma 
de los dos primeros es mayor al producto del segundo con el tercero. */

using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {

            // Paso 0 declaro variables.
            int n1, n2, n3, r, r2;

            // Paso 1 pido el ingreso de números.
            Console.WriteLine("Ingresa un numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa otro numero");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa otro numero");
            n3 = int.Parse(Console.ReadLine());

            // Paso 2 hacer calculo para validar condicion. 
            r = n1 + n2;

            r2 = n2 * n3;

            // Paso 3 condiciones.
            if (r > r2)
                // Paso 4 mostrar el pantalla.
                Console.WriteLine("La suma es mayor");
        }
    }
}
