using System;

namespace Ejercicio7.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int c1 = 90, c2 = 95, c3 = 77, c4 = 92, P;
            P = (c1 + c2 + c3 + c4) / 5;

            if (P >= 90)
            {
                Console.WriteLine("El promedio es A");
            }
            else if (P >= 80 )
            {
                Console.WriteLine("El promedio es B");
            }
            else if (P >= 70 )
            {
                Console.WriteLine("El promedio es C");
            }
            else 
            {
                Console.WriteLine("El promedio es F");
            }
           
           Console.WriteLine("Nota final es {0} ", P);
        }
    }
}
