using System;

namespace Ejercicio6.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convertir grados Celsius a grados Fahrenheit");

            Console.Write("Ingrese numero: ");
            double Celsius = double.Parse(Console.ReadLine());

            double fahrenheit = (Celsius * 9 + (32 * 5)) / 5;

            Console.WriteLine($"Fahrenheit = {fahrenheit}");

            Console.ReadKey();

        }
    }
}
