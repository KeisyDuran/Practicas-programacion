using System;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
//Un programa que te pida tu nombre y lo muestre en pantalla separando cada letra de la siguiente con un espacio. 
//Por ejemplo, si tu nombre es "Juan", debería aparecer en pantalla "J u a n".
        {
          string nombre;

              Console.Write("Escribe tu nombre: ");
              nombre = Console.ReadLine();

              foreach (var sub in nombre)
              {
                  Console.Write($" {sub}");
              }

              Console.ReadKey();
              
        }
    }
}
