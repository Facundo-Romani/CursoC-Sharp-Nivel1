/* EJERCICIO 1:
Hacer una función llamada “producto” que reciba dos números enteros y que devuelva 
el producto de ambos. Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre 
por pantalla el monto total a pagar. Usar la función. */

using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int precio, cantidadVendida;

            Console.WriteLine("Hola Ingresa el precio del articulo");
            precio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida");
            cantidadVendida = int.Parse(Console.ReadLine());

            int resultado = producto(precio, cantidadVendida);
            Console.WriteLine("El total a pagar es: " + resultado);
        }

        static int producto(int n1, int n2)
        {
            // int resultado = n1 * n2;
            return n1 * n2; // Manera de acortar mi función.
        }
    }
}
