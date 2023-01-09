using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            int x, resultado;

            x = int.Parse(Console.ReadLine());

            resultado = 0;

            for ( int i = 1; i <= 10; i++ )
            {
               resultado = x * i;
                Console.WriteLine( i + " x "+ x + " = " + resultado );

            }
        }
    }
}