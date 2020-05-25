using System;
using System.Dynamic;

namespace Eliminacion_Gaussiana_max_columna
{
    class Program
    {
        static void Main(string[] args)
        {
            byte orden;

            Console.WriteLine("METODO DE ELIMINACION GAUSSIANA MAXIMO DE COLUMNAS O PIVOTEO PARCIAL");
            Console.WriteLine();

            do
            {
                Console.WriteLine("Ingrese el orden de la matriz");
                orden = byte.Parse(Console.ReadLine());

            } while (orden <= 0);

            float[,] MatrizAumentada = new float[orden, orden + 1];

            PedirMatriz(ref MatrizAumentada, ref orden);

            EliminacionGauus(ref MatrizAumentada, orden);
        }
        static void PedirMatriz(ref float[,] Matriz, ref byte n)
        {
            Console.WriteLine("INGRESE LA MATRIZ AUMENTADA");
            Console.WriteLine();
            for (byte i = 0; i < n; i++)
            {
                for (byte j = 0; j < n + 1; j++)
                {
                    if (j == n)
                    {
                        Console.Write("Ingrese el termino independiente: ");
                        Matriz[i, j] = float.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.Write($"ELEMENTO [{i + 1}][{j + 1}]: ");
                        Matriz[i, j] = float.Parse(Console.ReadLine());

                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("LA MATRIZ AUMENTADA ES :");
            ImprimeMatriz(Matriz, n);
        }
        static void ImprimeMatriz(float[,] Matriz1, byte n1)
        {
            Console.WriteLine();
            for (byte i = 0; i < n1; i++)
            {
                for (byte j = 0; j < n1 + 1; j++)
                {
                    Console.Write(Matriz1[i, j] + "    ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void EliminacionGauus(ref float[,] Matriz3, byte n3)
        {
            float Aux;
            int max, i, j, k;

            for (i = 0; i < n3; i++)
            {
                max = i;
                for (j = i; j < n3; j++)
                {
                    if (Math.Abs(Matriz3[j, i]) > Math.Abs(Matriz3[max, i]))
                    {
                        max = j;

                        for (k = 0; k < n3 + 1; k++)
                        {
                            Aux = Matriz3[i, k];
                            Matriz3[i, k] = Matriz3[max, k];
                            Matriz3[max, k] = Aux;
                        }
                    }
                    Console.WriteLine("Despues de ordenar");
                    ImprimeMatriz(Matriz3, n3);

                    if (Matriz3[j, i] == 0)
                    {
                        Console.WriteLine("El sistema no tiene solucion unicas.");
                    }
                    else
                    {
                        for (j = i + 1; j < n3; j++)
                        {
                            for (k = n3; k >= i; k--)
                            {
                                Matriz3[j, k] -= Matriz3[i, k] * Matriz3[j, i] / Matriz3[i, i];
                            }
                        }
                    }
                }
            }

            if (Matriz3[n3 - 1, n3 - 1] == 0)
            {
                Console.WriteLine("El sistema no tiene solucion unica.");
            }
            else
            {
                SustitucionAtras(Matriz3, n3);
            }

        }

        static void SustitucionAtras(float[,] Matriz4, byte n4)
        {

            double[] resultado = new double[n4];

            resultado[n4 - 1] = Matriz4[n4 - 1, n4] / Matriz4[n4 - 1, n4 - 1];

            for (int f = n4 - 2; f >= 0; f--)
            {
                double sum = 0;

                for (int i = n4 - 1; i > f; i--)
                {
                    sum += Matriz4[f, i] * resultado[i];
                }

                resultado[f] = (Matriz4[f, n4] - sum) / Matriz4[f, f];
            }

            Console.WriteLine("LAS SOLUCIONES DE LA MATRIZ AUMENTADA SON");
            for (byte r = 0; r < n4; r++)
            {
                Console.WriteLine($"x{r + 1} = {resultado[r]}");
            }
        }
    }
}