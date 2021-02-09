using System;

namespace Ejercicio5.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolares, pesos;
            Console.Write("Dolares: ");
            dolares = double.Parse(Console.ReadLine());
            pesos = dolares*57;
            Console.WriteLine("dolares{0} equivale a {1} pesos", dolares, pesos);
            Console.ReadKey();
        }
    }
}
