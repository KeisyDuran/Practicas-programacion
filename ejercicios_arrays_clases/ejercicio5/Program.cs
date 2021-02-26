using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
          string[] nombre = new string[100];
          int i=0;
          do
          { 
            Console.WriteLine("teclee un nombre");
            nombre[i] = Console.ReadLine();
          }
          while (nombre[i] != "");
          Console.WriteLine("fin");
          for (i = 0; i < 99; i++) ;
           Console.WriteLine("los nombres tecleados son {0}", nombre[i]);
        }
    }
}
