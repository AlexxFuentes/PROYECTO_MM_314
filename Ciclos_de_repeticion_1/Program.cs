using System;

namespace Ciclos_de_repeticion_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 0;
            int n = 0;

            do
            {
                Console.WriteLine("Introduzca un numero positivo:");
                m = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese un numero positivo:");
                n = int.Parse(Console.ReadLine());
            } while (m < 1 || n < 1);

            Console.WriteLine();
            Console.WriteLine("La matriz es:");
            Console.WriteLine();

            int h = 0;
            int l = 0;

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    h = (i * i);
                    l = (2 * j);

                    if (i < j)
                    {
                        Console.Write(1);
                        Console.Write("   ");
                    }
                    else if (i < j)
                    {
                        Console.Write(h - l);
                        Console.Write("   ");
                    }
                    else
                    {
                        Console.Write(i + 2);
                        Console.Write("   ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
