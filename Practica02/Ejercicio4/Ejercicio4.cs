using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
          
           double  n, ars, afp, isr, a, b, c, d, e, f, sueldo;

           Console.WriteLine("Ingrese sueldo");
           n = Convert.ToInt32(Console.ReadLine());
           ars = 0.0304 * n;
           afp = 0.0287 * n;
           isr = 0.15 * n ;
           a = n - ars;
           b = n - afp;
           sueldo = a + b - n;          
            f = n * 12;
            c = f - 416220.01;
            d = f - 624329.01;
            e = f - 867123.01;
        
           if (f >= 416220.00 && f <= 624329.00)
            {
               Console.WriteLine("Su sueldo final es de {0}", sueldo - (c * 0.15 / 12));
            }
           else if (f >= 624329.01 && f <= 867123.00)
           {
              Console.WriteLine("Su sueldo final es de {0}", sueldo - (d * 0.20 + 31216.00) / 12);

            }
            else if (f >= 867123.01)
            {
             Console.WriteLine("Su sueldo final es de {0}", sueldo - (e * 0.25 + 79776.00 ) / 12);

            }
           else
           {
                Console.WriteLine("Su Sueldo final es de {0} pesos", sueldo);
           }           

        }
    }
}
