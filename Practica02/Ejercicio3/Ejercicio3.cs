using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
          for (int i = 1; i <= 500; i++)
			{
                if (i % 5 == 0)
                {
                    Console.WriteLine("\nTabla de multiplicar del {0}", i);
				    Console.WriteLine("------------------------------");
                }
				
				for (int j = 1; j <= 10; j++)
				{
                    if (i % 5 == 0)
                    {
                        Console.WriteLine("{0} * {1} = {2}", i, j, (i * j));
                    }
					
				}
			}
        }
    }
}
