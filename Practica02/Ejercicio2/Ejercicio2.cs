using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
          double opcion = 0;
            double n;
            double r;  
            
            do
            {
                Console.WriteLine("MENU DE OPCIONES");
                Console.WriteLine("\n 1.- Convertir de Grados Celsius a Grados Fahrenheit" +
                "\n 2.- Convertir de Dolar a Peso" +
                "\n 3.- Convertir de Metro a Pies" +
                "\n 4.- Salir \n");
                Console.WriteLine("Digite una opción :");
                opcion = Convert.ToInt32(Console.ReadLine());
                 
                  switch (opcion)
                  {
                      case 1: 
                     Console.Write("Ingrese numero: ");
                     double Celsius = double.Parse(Console.ReadLine());
                     double Fahrenheit = (Celsius * 9 + (32 * 5)) / 5;
                     Console.WriteLine($"Fahrenheit = {Fahrenheit}");
                     break;

                     case 2:
                     double dolares, pesos;
                     Console.Write("Dolares: ");
                     dolares = double.Parse(Console.ReadLine());
                     pesos = dolares*58;
                     Console.WriteLine("dolares {0} equivale a {1} pesos", dolares, pesos);
                     break;

                     case 3: 
                      Console.WriteLine("Introduzca los metros a calcular: ");
                      n = Convert.ToInt32(Console.ReadLine());
                      r = n * 3.28;
                      Console.WriteLine("El total es de {0} pies", + r);
                     break;

                     case 4: 
                       Console.WriteLine("Saliendo de la Aplicacion");
                     break;

                      default:
                       Console.WriteLine("Digite una Opción valida");
                      break; 

                    }               
                  Console.ReadKey();
            } while (opcion != 4);
        }
    }
}
