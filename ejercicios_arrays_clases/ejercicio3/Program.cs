using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
//Un programa que almacene en un array el número de días que tiene cada mes (supondremos que es un año no bisiesto), 
//pida al usuario que le indique un mes (1=enero, 12=diciembre) y muestre en pantalla el número de días que tiene ese mes.
        {
          int mes;
          int [] dias = {31, 30 , 28};
           Console.WriteLine("introduzca un mes");
           mes = Convert.ToInt32(Console.ReadLine());

             if ((mes == 1)) 
              Console.WriteLine("Enero tiene {0} dias", dias[0]);

             else if ((mes == 3))
              Console.WriteLine("Marzo tiene {0} dias", dias[0]); 

             else if ((mes == 4))
              Console.WriteLine("Abril tiene {0} dias", dias[1]);

             else if ((mes == 5))
              Console.WriteLine("Mayo tiene {0} dias", dias[0]);

             else if ((mes == 6))
              Console.WriteLine("Junio tiene {0} dias", dias[1]);

             else if ((mes == 7))
              Console.WriteLine("Julio tiene {0} dias", dias[0]);

             else if ((mes == 8))
              Console.WriteLine("Agosto tiene {0} dias", dias[0]);

             else if ((mes == 9))
              Console.WriteLine("Septiembre tiene {0} dias", dias[1]);

             else if ((mes == 10))
              Console.WriteLine("Octubre tiene {0} dias", dias[0]);

             else if ((mes == 11))
              Console.WriteLine("Noviembre tiene {0} dias", dias[1]);

             else if ((mes == 12))
              Console.WriteLine("Diciembre tiene {0} dias", dias[0]);

             else
              Console.WriteLine("Febrero tiene 28 dias");
 
           Console.ReadLine();
        }
    }
}
