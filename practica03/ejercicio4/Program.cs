using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
//Crear un programa que muestre las letras de la Z (mayúscula) a la A (mayúscula, descendiendo).
           int i;
           Console.Write("ABECEDARIO DESCENDENTE");
           Console.WriteLine();
            for(i = 90; i >= 65 ; i--)
            {
               Console.WriteLine(Convert.ToString((char)i));
            }
            Console.ReadLine();
        }
    }
}
