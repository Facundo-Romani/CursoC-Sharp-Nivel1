/* EJERCICIO 2:
Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. 
Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares. */

using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con = 0;

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingresa un numero");
                n = int.Parse(Console.ReadLine());
                par(n);
                if (par(n) == true)
                {
                    con++;
                }
            }
            Console.WriteLine("La cantidad de numeros pares es: " + con);
        }
        static bool par(int n)
        {
            if (n % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
