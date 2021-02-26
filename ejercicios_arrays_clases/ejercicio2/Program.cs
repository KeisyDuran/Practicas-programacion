using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
//Un programa que pida al usuario 5 números reales (pista: necesitarás un array de "float") 
//y luego los muestre en el orden contrario al que se introdujeron.
        {           
            float[] numero = new float[5];
 
           Console.Write("\nIngrese el primer número: ");
            numero[0] = Convert.ToSingle(Console.ReadLine());
           Console.Write("\nIngrese el segundo número: ");
            numero[1] = Convert.ToSingle(Console.ReadLine());
           Console.Write("\nIngrese el tercero número: ");
            numero[2] = Convert.ToSingle(Console.ReadLine());
           Console.Write("\nIngrese el cuarto número: ");
            numero[3] = Convert.ToSingle(Console.ReadLine());
           Console.Write("\nIngrese el quinto número: ");
            numero[4] = Convert.ToSingle(Console.ReadLine());
 
          Console.WriteLine("\n\nLos números Ingresados alrrevés son:  {4}, {3}, {2}, {1}, {0}", numero[0], numero[1], numero[2], numero[3], numero[4]);
          Console.ReadLine();
        }
    }
}
