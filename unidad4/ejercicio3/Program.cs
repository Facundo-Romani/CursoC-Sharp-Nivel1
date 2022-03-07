/* EJERCICIO 3:
 Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar. 
Para ello existe la siguiente escala de precios:
	
             i5 (1)      i7 (2) 	  i9 (3)
8 RAM  (1) 	USD 800 	USD 900 	USD 1200
16 RAM (2) 	USD 900 	USD 1000 	USD 1400
32 RAM (3) 	USD 1000 	USD 1400 	USD 2000

Además, el equipo viene con un disco que permite almacenar 500 GB de información y que se 
puede ampliar a 1 TB si así lo desea, lo cual tiene un costo  adicional de USD 300. 
Hacer un programa que solicite la opción de procesador, la opción de memoria  RAM, y si extiende el
disco o no (ingresa 1 para extender y 0 para no extender) y calcule y emita por pantalla el monto de la máquina seleccionada. */


using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paso 0 declaro variables.
            int dext;
            int procesador, ram, tde;

            // Paso 1 pedir ingreso de datos.
            // PROCESADOR.
            Console.WriteLine("Ingresa opcion del procesador que desea: ");
            Console.WriteLine("opcion  i5 (1) ");
            Console.WriteLine("opcion  i7 (2) ");
            Console.WriteLine("opcion  i9 (3) ");
            procesador = int.Parse(Console.ReadLine());
            // RAM.
            Console.WriteLine("Ingresa opcion de memoria RAM que desea: ");
            Console.WriteLine("opcion  8 RAM  (1) ");
            Console.WriteLine("opcion  16 RAM (2) ");
            Console.WriteLine("opcion  32 RAM (3) ");
            ram = int.Parse(Console.ReadLine());
            // Extender DISCO.
            Console.WriteLine("Si desea extender el disco presione 1 de lo contrario 0: ");
            dext = int.Parse(Console.ReadLine());

            // Paso 2 SWITCH.
            switch (procesador)
            {
                case 1:

                    if (procesador == 1)
                    {
                        procesador = 800;
                        if (dext == 1) // Condición de extender disco.
                        {
                            tde = procesador + 300;
                            Console.WriteLine("i5 " + tde);
                        }
                        else
                        {
                            Console.WriteLine("i5 " + procesador);
                        }
                    }

                    switch (ram)
                    {
                        case 1:
                            if (ram == 1)
                            {
                                ram = 8;
                                Console.WriteLine("****" + ram);
                            }
                            break;
                        case 2:
                            if (ram == 2)
                            {
                                ram = 16;
                                Console.WriteLine("****" + ram);
                            }
                            break;
                        case 3:
                            if (ram == 3)
                            {
                                ram = 32;
                                Console.WriteLine("****" + ram);
                            }
                            break;

                    }
                    break;

                case 2:
                    if (procesador == 2)
                    {
                        procesador = 900;
                        if (dext == 1) // Condición de extender disco.
                        {
                            tde = procesador + 300;
                            Console.WriteLine("i7 " + tde);
                        }
                        else
                        {
                            Console.WriteLine("i7 " + procesador);
                        }
                    }
                    switch (ram)
                    {
                        case 1:
                            if (ram == 1)
                            {
                                ram = 8;
                                Console.WriteLine("* " + ram);
                            }
                            break;
                        case 2:
                            if (ram == 2)
                            {
                                ram = 16;
                                Console.WriteLine("* " + ram);
                            }
                            break;
                        case 3:
                            if (ram == 3)
                            {
                                ram = 32;
                                Console.WriteLine("* " + ram);
                            }
                            break;

                    }
                    break;

                case 3:
                    if (procesador == 2)
                    {
                        procesador = 900;
                        if (dext == 1) // Condición de extender disco.
                        {
                            tde = procesador + 300;
                            Console.WriteLine("i9 " + tde);
                        }
                        else
                        {
                            Console.WriteLine("i9 " + procesador);
                        }
                    }
                    switch (ram)
                    {
                        case 1:
                            if (ram == 1)
                            {
                                ram = 8;
                                Console.WriteLine("* " + ram);
                            }
                            break;
                        case 2:
                            if (ram == 2)
                            {
                                ram = 16;
                                Console.WriteLine("* " + ram);
                            }
                            break;
                        case 3:
                            if (ram == 3)
                            {
                                ram = 32;
                                Console.WriteLine("* " + ram);
                            }
                            break;
                    }
                    break;
                default:
                    break;

            }

        }

    }
}
