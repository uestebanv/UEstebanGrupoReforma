using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class SumaMatriz
    {
        public static void MatrizSuma()
        {
            int numero = 0;
            int[,] sumaA = new int[3, 3];
            int[,] sumaB = new int[3, 3];
            int[,] sumaC = new int[3, 3];
            int columna=0, fila=0;
            Console.WriteLine("Cada matris cuenta de tres filas y tres columnas");
            Console.WriteLine("Ingrese los datos de la primra matris: ");
            
            for (fila = 0; fila < 3; fila++)
            {
                for (columna = 0; columna < 3; columna++)
                {

                    Console.Write("Ingrese numero: ");
                    numero = int.Parse(Console.ReadLine());
                    sumaA[columna, fila] = numero;
                }
            }


            for (fila = 0; fila < 3; fila++)
            {
                for (columna = 0; columna < 3; columna++)
                {
                    Console.Write(sumaA[fila, columna] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Ingrese los datos de la Segunda matris: ");
            for (fila = 0; fila < 3; fila++)
            {
                for (columna = 0; columna < 3; columna++)
                {

                    Console.Write("Ingrese numero: ");
                    numero = int.Parse(Console.ReadLine());
                    sumaB[fila, columna] = numero;
                }
            }

            for (fila = 0; fila < 3; fila++)
            {
                for (columna = 0; columna < 3; columna++)
                {
                    Console.Write(sumaB[fila, columna] + " ");
                }
                Console.WriteLine();
            }

            for (fila = 0; fila < 3; fila++)
            {
                for (columna = 0; columna < 3; columna++)
                {
                    sumaC[fila, columna] = sumaA[fila, columna] + sumaB[fila, columna]; 
                }
            }


            Console.WriteLine("La suma de las matrices es:");
            for ( fila = 0; fila < 3; fila++)
            {
                for ( columna = 0; columna < 3; columna++)
                {
                    Console.Write(sumaC[fila,columna] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }

    }
}
