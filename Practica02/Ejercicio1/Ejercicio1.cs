using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=1, cont=0;
            float suma=0;

            while (num!=0)
            {
                Console.Write("Introduzca un numero: ");
                num = int.Parse (Console.ReadLine());
                suma=suma+num;
                if (num!=0)
                {
                  cont=cont+1;                   
                }
            }
                 Console.WriteLine("La sumatoria es: {0}", suma);
                 Console.WriteLine("La cantidad de numeros ingresados es: {0}", cont);

                 
        }
    }
}
