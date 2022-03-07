/* EJERCICIO 5:
Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100. */

using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paso 0 declaro variables.
            int n1, n2, n3, n4;

            // Paso 1 pedir ingreso de datos.
            Console.WriteLine("Ingresa un numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa otro numero");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa otro numero");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa otro numero");
            n4 = int.Parse(Console.ReadLine());

            // Paso 2 preguntar condiciones.
            if (n1 > 100)
                Console.WriteLine("\n" + n1); ;

            if (n2 > 100)
                Console.WriteLine("\n" + n2); ;

            if (n3 > 100)
                Console.WriteLine("\n" + n3); ;

            if (n4 > 100)
                Console.WriteLine("\n" + n4);
        }
    }
}
