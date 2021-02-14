using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            b = 1;

           do
           {
            a = b++;
            Console.Write( "\n" + a);   
           } while (a!=10);

        }
    }
}
