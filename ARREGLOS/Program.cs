using System;

namespace ARREGLOS
{
    class Program
    {
        static void Main(string[] args)
        {
            // ARREGLO UNIDIMENSIONAL 
            Console.WriteLine("ARREGLO UNIDIMENSIONAL");
            int[] vector = new int[5];
            for (int i = 0; i < 5; i++)
            {
                vector[i] = 1;
            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0} ", vector[i]);
            }
            Console.WriteLine();

            Console.WriteLine("UTILIZANDO EL METODO Array.Clear");
            Array.Clear(vector, 2, 2); // Limpia el arreglo
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0} ", vector[i]);
            }
            Console.WriteLine();
            Console.WriteLine();

            // ARREGLO BIDIMENSIONAL
            Console.WriteLine("ARREGLO BIDIMENSIONAL");
            int[,] matriz = new int[2, 2];
            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < 2; i++)
                {
                    matriz[j, i] = 5;
                }
            }
            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.Write("{0}  ", matriz[j, i]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // ARREGLO TIPO JAGGED
            Console.WriteLine("ARREGLO TIPO JAGGED");
            int[][] jagged = new int[2][];
            jagged[0] = new int[] { 1, 2, 3 };
            jagged[1] = new int[] { 4, 5 };

            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine("COLUNMA {0}", j);
                for (int i = 0; i < jagged[j].GetLength(0); i++)
                {
                    Console.WriteLine("{0}", jagged[j][i]);
                }
            }
            Console.WriteLine();

            // SUMA DE MATRICES
            Console.WriteLine("SUMA DE MATRICES");
            int[,] A = new int[,] { { 1, 2 }, { 2, 4 } };
            int[,] B = new int[,] { { 5, 6 }, { 8, 9 } };
            int[,] C = new int[2, 2];

            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < 2; i++)
                {
                    C[j, i] = A[j, i] + B[j, i];
                }
            }

            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.Write("{0}  ", C[j, i]);
                }
                Console.WriteLine();
            }

        }
    }
}
