/* EJERCICIO 4:
Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% 
sobre el total facturado por cada empleado. Hacer un programa para ingresar el total facturado por un empleado 
y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo. */

using System;

namespace ejercicios_unidad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paso 0 declarar variables.
            const float sueldo = 15000;
            float comision, totalFacturado, sueldoFinal;

            // Paso 1 pedir numeros.
            Console.WriteLine("Ingresar el total facturado: ");
            totalFacturado = float.Parse(Console.ReadLine());

            // Paso 2 hacer el calculo.
            comision = (5 * totalFacturado) / 100; // TotalFacturado *  0.05F (La F lo transforama a float)
            sueldoFinal = sueldo + comision;

            // Paso 3 mostrar en pantalla.
            Console.WriteLine("El sueldo total a cobrar es: " + sueldoFinal + " pesos");
        }
    }
}