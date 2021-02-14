using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
//Crear un programa que muestre los primeros 10 números pares a partir del producto de (10 x 10)
           int contador = 10*10;
            while (contador <= 120)
           {
             if (contador % 2 == 0)
             {
                Console.WriteLine(contador);
             }
             contador += 1;
            }
        }
    }
}
