using System;

namespace manejo_de_funciones
{
    class Program
    {
        static float AreaCirculo(float r, float pi = 3.141592f)
        {
            return r * r * pi;
        }

        static void Main(string[] args)
        {
            byte opcion = 0;
            int numero = 0, potencia = 0, respuesta = 0;
            float n1 = 0, n2 = 0, n3 = 0;

            // Console.WriteLine($"valor de la varible opcion {opcion}");

            Menu(ref opcion);

            // Console.WriteLine($"valor de la varible opcion despues de llamar a funncion menu {opcion}");
            switch (opcion)
            {
                case 1:
                    Suma();
                    break;
                case 2:
                    PedirDatos(ref numero, ref potencia);
                    respuesta = FunPontencia(numero, potencia);

                    Console.WriteLine($"El resultado de {numero}^{potencia} es {respuesta}");

                    break;
                case 3:
                    n1 = Pedir(ref n1);
                    n2 = Pedir(ref n2);
                    n3 = Pedir(ref n3);
                    Mayor(n1, n2, n3);

                    break;
                case 4:
                    n1 = Pedir(ref n1);
                    n2 = Pedir(ref n2);
                    n3 = Division(n1, n2);

                    Console.WriteLine($"El resultado de {n1}/{n2} es {n3}");

                    break;

                default:
                    Console.WriteLine("Ingrese el radio de un circulo: ");
                    n1 = Pedir(ref n1);
                    //area =r*r*pi
                    n2 = AreaCirculo(n1);
                    Console.WriteLine($"El area del circulo es {n2}");

                    break;
            }

        }
        static float Division(float num1, float num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("La division entre cero no se puede efectuar");
                return 0.0f;
            }
            else
            {
                return num1 / num2;
            }
        }
        static void Menu(ref byte opc)
        {
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. suma de dos digitos. ");
                Console.WriteLine("2. Elevar un numero a una potencia. ");
                Console.WriteLine("3. Encontrar el maximo de 3 valores. ");
                Console.WriteLine("4. Dividir dos numeros. ");
                Console.WriteLine("5. Area de un circulo. ");
                Console.WriteLine("INGRESE LA OPCION QUE DESEA REALIZAR. ");
                opc = byte.Parse(Console.ReadLine());

            } while (opc <= 0 || opc >= 6);
        }
        static void Suma()
        {
            float num1 = 0, num2 = 0;
            //int num1 = 0, num2 = 0;

            //Console.WriteLine("Ingrese un numero: ");
            //num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese el segundo numero: ");
            //num2 = int.Parse(Console.ReadLine());
            num1 = Pedir(ref num1);
            num2 = Pedir(ref num2);

            Console.WriteLine($"El resultado de la suma de {num1} + {num2} es {num1 + num2}");
        }
        static void PedirDatos(ref int num, ref int n)
        {
            Console.WriteLine("Ingrese el numero que desea elevar: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la potencia a la que desea elevar un numero: ");
            n = int.Parse(Console.ReadLine());
        }
        static int FunPontencia(int num, int n)
        {
            int resultado = 1;
            for (int i = 0; i < n; i++)
            {
                resultado *= num;
            }
            return resultado;
        }
        static float Pedir(ref float num)
        {
            Console.WriteLine("Ingrese un numero");
            num = float.Parse(Console.ReadLine());
            return num;
        }
        static void Mayor(float x, float y, float z)
        {
            float max = 0.0f;

            if ((x > y) && (x > z))
            {
                max = x;
            }
            else if ((y > x) && (y > z))
            {
                max = y;
            }
            else
            {
                max = z;
            }
            Console.WriteLine($"El numero mayor de {x}, {y}, {z} es {max}");
        }
    }
}
