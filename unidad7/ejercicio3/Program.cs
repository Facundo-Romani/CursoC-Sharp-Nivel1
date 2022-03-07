/* EJERCICIO 3:
Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos).
El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo.
Mostrar el resultado en pantalla. Ejemplo:
CADENA FUENTE: “La mar estaba serena"
CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
CADENA RESULTADO: “Li mir estibi sereni" */

using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paso 0 declarar cadena y variables.
            char[] palabra = new char[15];
            char letraActual;
            char letraNueva;
            char letra;

            // Paso 1 pedir ingreso de caracter.
            letra = char.Parse(Console.ReadLine());

            // Paso 2 condición para ingresar al while.
            int indice = 0;
            while (letra != '0' && indice < 15)
            {
                palabra[indice] = letra;
                letra = char.Parse(Console.ReadLine());
                indice++;
            }
            palabra[indice] = '\0'; // Caracter para cortar la cadena.

            // Paso 3 pedir dartos a reemplazar.
            Console.WriteLine("Ingrese letra a reemplazar");
            letraActual = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la letra por la que desea reemplazarla");
            letraNueva = char.Parse(Console.ReadLine());

            // Paso 4 While para reemplazar letra.
            indice = 0;
            while (palabra[indice] != '\0')
            {
                if (palabra[indice] == letraActual)
                {
                    palabra[indice] = letraNueva;
                }
                indice++;
            }

            // Paso 5 mostrar en pantalla texto con letra reemplazada.
            indice = 0;
            while (palabra[indice] != '\0')
            {
                Console.WriteLine(palabra[indice]);
                indice++;
            }
        }
    }
}
