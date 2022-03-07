/* EJERCICIO 3: Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada 
según los siguientes valores:

    Si el importe es menor a ARS 1000, no hay descuento.
    Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
    Si el importe es ARS 5000 o más, aplica un descuento del 18%.

Hacer un programa para ingresar un importe de venta y luego muestre por pantalla 
el importe final con el descuento que corresponda. */


using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paso 0 declaro variables.

            float importe;

            // Paso 1 pedir datos.
            Console.WriteLine("Ingrese el importe a abonar");
            importe = int.Parse(Console.ReadLine());

            // Paso 2 evaluar condiciónes.

            if (importe > 1000)
            {
                if (importe > 5000)
                    importe = importe * 0.82F; // Aplica el 18%.
                else
                    importe = importe * 0.90F; // Aplica el 10%.
            }

            Console.WriteLine("El importe Final a abonar es $" + importe);
        }

    }
}

