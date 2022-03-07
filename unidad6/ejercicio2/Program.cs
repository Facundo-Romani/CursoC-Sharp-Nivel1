/* EJERCICIO 2: 
Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:

El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
Informar cuántos grupos están formados por todos números ordenados de mayor a menor. */


using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            /* // Paso 0 declaro variables
            int n, numM, conImpar = 0, conT = 0, contadorGrupos = 0, grupoMaximo = 0, conGrupoOrdenado = 0;
            double porcentajeDeImpares, maximoPorcentajeimpar = 0;
            bool band1 = true, banderaOrdenados = true;

            // Paso 1 lista de números.
            for (int x = 0; x < 5; x++)
            {
                // Contadores.
                conImpar = 0;
                conT = 0;
                numM = 0;
                banderaOrdenados = true;

                n = int.Parse(Console.ReadLine());
                numM = n; // Guardo el primer numero minimo.

                while (n != 0)
                {
                    conT++;
                    // Paso 2 preguntar si numero es par o impar.
                    if (n % 2 != 0)
                        conImpar++;

                    // Problema B.
                    if (n <= numM)
                        numM = n;
                    else
                        banderaOrdenados = false;

                    n = int.Parse(Console.ReadLine());
                }


                // Paso 3 Calcular porcentaje de los grupos.
                porcentajeDeImpares = conImpar * 100 / conT;
                contadorGrupos++;

                // Paso 4 almacenar el mayor grupo de porcentaje impar.
                if (band1 == true)
                {
                    grupoMaximo = contadorGrupos;
                    maximoPorcentajeimpar = porcentajeDeImpares;
                    band1 = false;
                }
                else if (porcentajeDeImpares > maximoPorcentajeimpar)
                {
                    maximoPorcentajeimpar = porcentajeDeImpares;
                    grupoMaximo = contadorGrupos;
                }

                if (banderaOrdenados)
                    conGrupoOrdenado++;

            }

            Console.WriteLine(+grupoMaximo);
            Console.WriteLine(+conGrupoOrdenado); */


            /*****************************************************************************************/

            // Paso 0 declaro variables
            int n, numM, conImpar = 0, conT = 0, grupoMaximoImpares = 0, conGrupoOrdenado = 0;
            double porcentajeDeImpares, maximoPorcentajeimpar = -1;
            bool banderaOrdenados = true;

            // Paso 1 lista de números.
            for (int x = 0; x < 5; x++)
            {
                // Contadores.
                conImpar = 0;
                conT = 0;
                numM = 0;
                banderaOrdenados = true;

                n = int.Parse(Console.ReadLine());
                numM = n; // Guardo el primer numero minimo.

                while (n != 0)
                {
                    conT++;
                    // Paso 2 preguntar si numero es par o impar.
                    if (n % 2 != 0)
                        conImpar++;

                    // Problema B orden de mayor a menor.
                    if (n <= numM)
                        numM = n;
                    else
                        banderaOrdenados = false;

                    n = int.Parse(Console.ReadLine());
                }


                // Paso 3 Calcular porcentaje de los grupos.
                porcentajeDeImpares = conImpar * 100 / conT;
                // Paso 4 determinar el mayor grupo con porcentje de numeros impares.
                if (porcentajeDeImpares > maximoPorcentajeimpar)
                {
                    maximoPorcentajeimpar = porcentajeDeImpares;
                    grupoMaximoImpares = x + 1;
                }

                if (banderaOrdenados)
                    conGrupoOrdenado++;
            }

            Console.WriteLine(+grupoMaximoImpares);
            Console.WriteLine(+conGrupoOrdenado);
        }

    }
}


