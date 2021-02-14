using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            
         int a, b, c, e;

         Console.Write("Introduzca un numero positivo: ");
         a = int.Parse(Console.ReadLine());
         Console.Write("Introduzca un numero positivo: ");
         b = int.Parse(Console.ReadLine());
            c=a+b;
         if ((a<0) | (b<0)) Console.Write("Numero Invalido");
         
             else
             {
                 Console.Write("Su suma es: {0}\n ", + c);

                  do
                  {
                    Console.Write("Introduzca un numero positivo: ");
                    e = int.Parse(Console.ReadLine());
                    c=c+e;

                      if (e>0) Console.Write("Su suma es: {0}\n ", + c);
                      
                        else
                        {
                            Console.Write("No Valido!\n");
                        }                         
                      
                  } while (e>0);

              Console.Write("Adios.\n");      
             }

            Console.ReadLine(); 
            
         
        }
    }
}
