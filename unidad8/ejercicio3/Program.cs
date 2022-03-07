/* EJERCICIO 3:
Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es.
Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero. 
Informar el promedio teniendo en cuenta sólo los números primos. */

using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, acu = 0, con = 0, promedioPrimos;

            Console.WriteLine("Ingresa un numero");
            n = int.Parse(Console.ReadLine()); // Pido un n para ingresar al while.

            while (n != 0) // Lote.
            {
                if (primo(n)) // Llamamos a la función dentro del if.
                {
                    acu += n;
                    con++;
                }
                Console.WriteLine("Ingresa un numero");
                n = int.Parse(Console.ReadLine());
            }
            promedioPrimos = acu / con;
            Console.WriteLine("El promedio Final de primos es: " + promedioPrimos);
        }

        static bool primo(int a)
        {
            int con = 0;
            for (int x = 0; x <= a; x++)
            {
                if (a % x == 0)
                    con++;
            }
            if (con == 2)
                return true;
            else
                return false;
        }
    }
}
