using System;

namespace Ejercicio3.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            float num;
            float num2;
            Console.WriteLine("introdusca el primer numero");
            num = float.Parse(Console.ReadLine());
            Console.WriteLine("Instrodusca el segundo numero");
            num2= float.Parse(Console.ReadLine());
            if (num > num2)
            {
                Console.WriteLine("El primer numero es mayor " + num);
            }

            if (num2 < num)
            {
                Console.WriteLine("El Segundo numero es menor " + num2);
            }

            else if (num == num2)
            {
                Console.WriteLine("Ambos numeros son iguales");
            }

            Console.ReadKey();
        }
    }
}
