using System;

namespace Ejercicio14.cs
{
    class Program
    {
        static void Main(string[] args)
        {
             double a = 0;
            double b = 0;
            double c = 0;
           double d = 0;
           double e = 0;
           double f = 0;

           Console.WriteLine("Ingrese un numero");
           a = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Ingrese un numero");
           b = Convert.ToInt32(Console.ReadLine());

            c = a + b;
            d = a - b;
            e = a * b;
            f = a / b;

            Console.WriteLine("El resultado de la suma es: {0} ", + c );
            Console.WriteLine("El resultado de la resta es: {0} ", + d );
            Console.WriteLine("El resultado de la divicion es: {0} ", + f );
            Console.WriteLine("El resultado de la multiplicacion es: {0} ", + e );
        }

    }
}
