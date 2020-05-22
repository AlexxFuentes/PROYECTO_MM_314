using System;

namespace Introducion_c_sharp
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

            int Var1 = 19;
            string Oracion = "Kevin Ponce";

            Console.WriteLine("Mi nombre es Kevin");
            Console.WriteLine(Var1);
            Console.WriteLine(Oracion);

            Console.WriteLine("Mi nombre es {0} y mi edad es {1},", Var1, Oracion);


            String Nombre;
            float Numerox;
            //float Numeroy;

            Console.WriteLine("DIgite su nombre");
            Nombre = Console.ReadLine();

            Console.WriteLine("Escriba un numero");
            Numerox = int.Parse(Console.ReadLine());

            Console.WriteLine(Nombre);
            Console.WriteLine(Numerox);

            string datox;
            string datoy;
            int x;
            int y;
            float z;

            Console.WriteLine("Escriba el primer numero");
            datox = Console.ReadLine();
            x = Convert.ToInt16(datox);

            Console.WriteLine("Escriba el segundo numero");
            datoy = Console.ReadLine();
            y = Convert.ToInt16(datoy);

            z = x + y;

            Console.WriteLine("Resultado de la suma es " + z);

            z = x * y;

            Console.WriteLine("Resultado de la mutliplicacion es " + z);

            z = x - y;

            Console.WriteLine("Resultado de la resta es " + z);

            z = x / y; 

            Console.WriteLine("Resultado de la division es " +z);
        
            float x1;
            float y2;
            Console.WriteLine("Escriba el primer numero");
            x1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Escriba el segundo numero");
            y2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Resultado de la division es " + x/y);

        }
    }
}
