using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
//Un programa que pida al usuario 10 números y luego calcule y muestre cuál es el mayor de todos ellos.
        {
              int i;
              int mayor = 0;
              int[] enteros = new int[10];

	          Console.Write("\n Escriba diez numeros enteros:\n");
	           for (i = 0; i < 10; i++)
	            {
		          string tempVar = Console.ReadLine();
		           if (tempVar != null)
		            {
			          enteros[i] = int.Parse(tempVar);
		            }
	            }
		        for (i = 0; i < 10; i++)
		        {
				  mayor = mayor > enteros[i]? mayor: enteros[i];
		        }
	          Console.Write("\n El mayor de los numeros es: {0:D}", mayor);
	          Console.Read();
        }
    }
}
