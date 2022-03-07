/* EJERCICIO 1:
 Hacer un programa que solicite el ingreso de dos números y luego calcular:

        La resta si el primero es mayor que el segundo.
        La suma si son iguales.
        El producto si el primero es menor.

Se deberá emitir un cartel por pantalla con el resultado correspondiente */


using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paso 0 declaro variables.
            int n1, n2, r;

            // Paso 1 pedir datos.
            Console.WriteLine("Ingresa un numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa otro numero");
            n2 = int.Parse(Console.ReadLine());

            // Paso 2 preguntar condiciones.
            if (n1 > n2)
            {
                r = n1 - n2;
                Console.WriteLine("El resultado de la resta es: " + r);
            }
            if (n1 == n2)
            {
                r = n1 + n2;
                Console.WriteLine("El resultado de la suma es: " + r);
            }
            if (n1 < n2)
            {
                r = n1 * n2;
                Console.WriteLine("El resultado del producto es: " + r);
            }

            // Segunda forma de resolver mi problema.

            /* if (n1 == n2)
                r = n1 + n2;
            else if (n1 < n2)
                r = n1 * n2;
            else
                r = n1 - n2;


            Console.WriteLine("El resultado es: " + r); */
        }
    }
}
