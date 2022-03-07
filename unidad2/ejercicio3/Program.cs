/* EJERCICIO 3:
Hacer un programa que permita ingresar los kilómetros existentes 
entre dos ciudades y la velocidad promedio de un vehículo. Calcular y emitir por pantalla 
el tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados. */


using System;

namespace ejercicios_unidad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paso 0 declarar variables.
            float distacia, velocidad, tiempo;

            // Paso 1 pedir numeros.
            Console.WriteLine("Ingresa los km de distancia de una ciudad a la otra: ");
            distacia = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la velocidad promedio del vehiculo: ");
            velocidad = float.Parse(Console.ReadLine());

            // Paso 2 hacer el calculo.
            tiempo = distacia / velocidad;

            // Paso 3 mostrar en pantalla.
            // toString para ajustar decimales largos los ajusta a la cantidad que requerimos.
            Console.WriteLine("El tiempo estimado que demandara en llegar de una ciudad a otra es: " + tiempo.ToString("0.00") + " horas..");
        }
    }
}
