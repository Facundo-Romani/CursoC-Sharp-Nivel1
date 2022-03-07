using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paso 0 Declaro Variables.
            int n1, n2, resultado;

            // Paso 1 ingreso de datos.
            Console.WriteLine("Ingrese Un Numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Otro Numero: ");
            n2 = int.Parse(Console.ReadLine());

            // Paso 2 resolver calculo.
            resultado = n1 + n2;

            // Paso 3 mostrar el resultado en pantalla.
            // Concatenamos con +.
            Console.WriteLine("El Resultado es: " + resultado);

        }
    }
}
