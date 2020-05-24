using System;

namespace Introduccion_a_C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* byte entero sin signo   0 255
             * int enteros con signo -2B a 2B
             * short con signo -32,000 + 32,000
             * long entero con signo 
             * float decimales    
             * char 1 o un caracter    
             * boal   
             * string oracion o palabra 
             */

            int Var1 = 19;//variable de tipo entero
            string Oracion = "Kevin Ponce";//string almacena una cadena de caracteres

            Console.WriteLine("Mi nombre es Kevin");/*WriteLine , sirve para desplegar en 
                                                     *consola con un salto de linea por defecto*/

            Console.WriteLine(Var1);/*se puede desplegar valores de variables
                                     o cualquier tipo de variable*/

            Console.WriteLine(Oracion);

            Console.WriteLine("Mi nombre es {0} y mi edad es {1},", Var1,Oracion) ;

            //otra forma de desplegar en consola :
            Console.WriteLine($"Mi nombre es {Oracion} y mi edad es {Var1}");


            String Nombre;
            float Numerox;
            //float Numeroy;

             Console.WriteLine("Digite su nombre");
             Nombre = Console.ReadLine();

             Console.WriteLine("Escriba un numero");
             Numerox = int.Parse(Console.ReadLine());

             Console.WriteLine(Nombre);
             Console.WriteLine(Numerox);

         /*---------------------------------------------------*/
            string datox;
            string datoy;
            int x;
            int y;
            float z;

            Console.WriteLine("Escriba el primer numero entero");
            datox = Console.ReadLine();
            x = Convert.ToInt16(datox);

            Console.WriteLine("Escriba el segundo numero entero");
            datoy = Console.ReadLine();
            y = Convert.ToInt16(datoy);

            z = x + y;

            Console.WriteLine("Resultado de la suma es " +z);//EL signo mas sirve para concatenar o sea unir


            z = x * y;
            Console.WriteLine("Resultado de la mutliplicacion es " +z);

            z = x - y;
            Console.WriteLine("Resultado de la resta es " +z);

            z = x / y;//no se pueden dividir dos numeros de tipo int
            Console.WriteLine("Resultado de la division es " +z);

            /*-------------------------------------------------*/
        
            float x1;
            float y1;

            Console.WriteLine("Escriba el primer numero de tipo float (Decimal)");
            x1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Escriba el segundo numero de tipo float (Decimal)");
            y1 = float.Parse(Console.ReadLine());


            Console.WriteLine("Resultado de la division es " + x/y);

            /*-------------------------------------------------*/

            string str = "Hello";
            char[] characters = str.ToCharArray();
            Console.WriteLine(characters);

            string var1 = "5.84";
            double d;
            d = Convert.ToDouble(var1);

            Console.WriteLine(d);

            //Parse y to int
            string var2 = "1932.662";
            double num12;
            int x2;

            num12 = Convert.ToDouble(var2);

            Console.WriteLine("Despues de convertir una cadena a un double" + var2);

            Console.WriteLine("Ingrese un numero entero");
            x2 = int.Parse(Console.ReadLine());
            Console.WriteLine(x);

        }
    }
}