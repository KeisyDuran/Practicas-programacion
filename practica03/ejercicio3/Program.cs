using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
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
