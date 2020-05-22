using System;

namespace Ciclos_de_repeticion_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char calificacion;
            int ContadorA = 0;
            int ContadorB = 0;
            int ContadorC = 0;
            int ContadorD = 0;
            int ContadorF = 0;

            Console.WriteLine("Introduzca la calificacion con letra.");
            Console.WriteLine("Escriba la letra N para terminar la entrada de datos");

            calificacion = Convert.ToChar(Console.ReadLine());

            while (calificacion != 'N')
            {
                switch (calificacion)
                {
                    case 'A':
                    case 'a':
                        ContadorA++;
                        break;

                    case 'B':
                    case 'b':
                        ContadorB++;
                        break;

                    case 'C':
                    case 'c':
                        ContadorC++;
                        break;

                    case 'd':
                    case 'D':
                        ContadorD++;
                        break;

                    case 'F':
                    case 'f':
                        ContadorF++;
                        break;

                    case '\n':
                    case '\t':
                    case ' ':
                        break;

                    default:
                        Console.WriteLine("Se entroduzco una letra incorrecta.");
                        Console.WriteLine("Introduzca una nueva letra.");
                        break;

                }
                calificacion = Convert.ToChar(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Los totales de las calificaciones son:");
            Console.WriteLine($"A: {ContadorA}");
            Console.WriteLine();
            Console.WriteLine($"B: {ContadorB}");
            Console.WriteLine();
            Console.WriteLine($"C: {ContadorC}");
            Console.WriteLine();
            Console.WriteLine($"D: {ContadorD}");
            Console.WriteLine();
            Console.WriteLine($"F: {ContadorF}");
            Console.WriteLine();
        }
    }
}
