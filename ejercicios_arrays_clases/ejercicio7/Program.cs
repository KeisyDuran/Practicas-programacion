using System;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
          string palabra;
          Console.WriteLine("introduce una palabra");
          palabra = Console.ReadLine();
          Console.WriteLine("La longitud del texto es: {0}", palabra.Length);
          Console.ReadLine();
        }
    }
}
