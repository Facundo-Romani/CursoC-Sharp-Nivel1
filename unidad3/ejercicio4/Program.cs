/* EJERCICIO 4:
 Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos. */

using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paso 0 declaro variables.
            int n1, n2, n3, n4, menor;

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
            if (n1 < n2)
                menor = n1;
            else
                menor = n2;

            if (n3 < menor)
                menor = n3;

            if (n4 < menor)
                menor = n4;

            // Paso 3 mostrar en pantalla el menor.
            Console.WriteLine("El numero menor es:" + menor);

        }
    }
}
