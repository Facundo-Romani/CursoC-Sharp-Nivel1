
/* EJERCICIO 2:
 Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:

            Si vende menos de 100 litros, no hay descuento. 
            Si vende entre 101 y 300 litros, el descuento es del 10%.
            Si vende entre 301 y 500 litros, el descuento es del 15%.
            Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.

Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad 
de litros vendidos y calcule y emita el importe con el descuento  aplicado.. */


using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paso 0 declarar variables.
            float tVenta, importeF, lVendidos;

            // Paso 1 pedir datos.
            Console.WriteLine("Ingresa el importe total de la venta");
            tVenta = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la cantidad de litros vendidos");
            lVendidos = float.Parse(Console.ReadLine());

            // Paso 2 evaluar condiciones.
            if (lVendidos > 101 && lVendidos <= 300)
                importeF = tVenta * 0.90F;
            else if (lVendidos > 301 && lVendidos <= 500)
                importeF = tVenta * 0.85F;
            else if (lVendidos > 500)
                importeF = tVenta * 0.75F;
            else
                importeF = tVenta;

            // Paso 3 mostrar resultados en pantalla.
            Console.WriteLine("El impote total es: " + importeF);
            Console.WriteLine("La cantidad de litros venidos es: " + lVendidos);


            // Otra manera de encarar el problema.
            /* if (lVendidos > 500)
                importeF *= 0.75F;
            else if (lVendidos > 300)
                importeF *= 0.85F;
            else if (lVendidos > 100)
                importeF *= 0.90F; */

        }
    }
}
