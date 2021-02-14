using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
//Crea un programa que escriba en pantalla los números del 1 al 10, usando "do..while".           
            int a, b;
            b = 1;
           do
           {
            a = b++;
            Console.Write( "\n" + a);   
           } while (a!=10);

        }
    }
}
