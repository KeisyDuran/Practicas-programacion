using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
// Un programa que prepare espacio para un máximo de 100 nombres. El usuario deberá ir introduciendo un nombre cada vez, hasta que se pulse Intro sin teclear nada, 
//momento en el que dejarán de pedirse más nombres y se mostrará en pantalla la lista de los nombres que se han introducido.
        {
          string[] nombres; 
          ushort num = 0;
            do
            {
               try
                {
                  Console.Write("¿Cuántos nombres va a introducir? ");
                  num = UInt16.Parse(Console.ReadLine());
                }
                  catch
                  {
                   continue;
                  }

            } while (num == 0);

            nombres = new string[num];
         
            for (int i = 0; i < num; i++)
            {
              Console.Write("Introduce el nombre numero {0}: ", i);
              nombres[i] = Console.ReadLine();
            }

            Console.WriteLine("Introducidos los {0} nombres", num);
            Console.WriteLine("Pulsa INTRO para listarlos");

            string a = Console.ReadLine();
 
            for (int i = 0; i < num; i++)
            {
             Console.WriteLine("Nombre numero {0}: {1}", i, nombres[i]);
            }
            a = Console.ReadLine();
        }
    }
}
