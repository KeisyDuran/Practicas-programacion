using System;

namespace Proyecto_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            float pago, Interes_pagado, Capital_pagado, Monto_del_prestamo, tasa_interes_anual, tasa_interes_mensual;
            int  fila, Plazo, i, Beneficiario;
           

          Console.Write("\n Bienvenidos al Simulador de Préstamos\n");
          Console.Write("Favor Introduzca las siguientes informaciones\n");
          Console.Write("Introduce el Beneficiario: ");
          Beneficiario.ToString(Console.ReadLine());
          Console.Write("Introduce el monto del prestamo: ");
          float.TryParse(Console.ReadLine(), out Monto_del_prestamo);
          Console.Write("Introduce la tasa de interes anual: ");
          float.TryParse(Console.ReadLine(), out tasa_interes_anual);
          Console.Write("Introduce el plazo en meses: ");
          int.TryParse(Console.ReadLine(), out Plazo);



        }
    }
}
