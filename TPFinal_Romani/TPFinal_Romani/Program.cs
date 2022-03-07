using System;

namespace TPFinal_Romani
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:

            // a. El mayor de los números pares.
            // b. La cantidad de números impares.
            // c. El menor de los números primos.

            // Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.

            /***************************** CÓDIGO TP **************************/

            // Declaro variables y contadores.
            int n, maxPar = 0, conImpares = 0, minPrimo = 0;
            bool esPrimo;
            bool banpar = false;
            bool bminPrimo = false;

            // Pedido del numero distinto de 0 para ingresar al while.
            Console.WriteLine("Ingrese un número. Para finalizar ingrese cero.");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                if (n % 2 == 0) // Condición preguntar si el numero es par.
                {
                    if (banpar == false) // Problema A buscar el mayor de los numeros pares.
                    {
                        maxPar = n;
                        banpar = true;
                    }
                    else
                        if (n > maxPar)
                    {
                        maxPar = n;
                    }
                }
                else  // Problema B contar la cantidad de Numeros Impares.
                    conImpares++;
                esPrimo = primo(n);

                if (esPrimo)
                {
                    if (!bminPrimo) // Problema C menor de los números primos.
                    {
                        minPrimo = n;
                        bminPrimo = true;
                    }
                    else
                    if (n < minPrimo)
                    {
                        minPrimo = n;
                    }
                }

                Console.WriteLine("Ingrese otro número. Para finalizar ingrese cero.");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("EL máximo par es: " + maxPar);
            Console.WriteLine("La cantidad de números impares es: " + conImpares);
            Console.WriteLine("El mínimo primo es: " + minPrimo);
        }

        // Función si un número dado es primo o no y que devuelva true o false.
        static bool primo(int a)
        {
            int con = 0;
            for (int x = 1; x <= a; x++)
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


