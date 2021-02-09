using System;

namespace Ejercicio2.cs
{
    class Program
    {
        static void Main(string[] args)
        {
             int num = 0;
         Console.Write ("escribe un numero");
         num = int.Parse (Console.ReadLine());
         if (num % 2==0)
         {
             Console.WriteLine("El numero es par");
         }
        
         else
         {
             Console.WriteLine("El numero es impar");
         }
           
        Console.ReadKey();

        }
    }
}
