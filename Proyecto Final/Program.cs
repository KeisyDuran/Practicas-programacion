using System;

namespace Proyecto_Final
{
    class Program
    {
        static void Main(string[] args)
        {

            DatosPrestamos prestamos = new DatosPrestamos();

            string entrada = "";
            bool menu = true;

            while (menu)
            {
                Console.WriteLine("Bienvenido al simulador de prestamos \n");
                Console.WriteLine("1-Introducir datos del prestamo");
                Console.WriteLine("2-Generar tabla Amortizada");
                Console.WriteLine("3-Salir");
                entrada = Console.ReadLine();

                switch (entrada)
                {


                    case "1":
                        Console.Clear();
                        prestamos.datos();
                        break;

                    case "2":
                        Console.Clear();
                        prestamos.tabla();
                        break;

                    case "3":
                        menu = false;
                        break;

                }

            }

        }
    }
}


class DatosPrestamos
{


    public float pago, Interes_pagado, Capital_pagado, Monto_del_prestamo, tasa_interes_anual, tasa_interes_mensual;
    public int fila, Plazo, i;
    public string beneficiario;
    public void datos()
    {

        Console.Clear();
        beneficiario = leerbeneficiario("Intruduzca beneficiario: ");
        Monto_del_prestamo = LeerMonto ("Introduce el monto del prestamo: ");
        tasa_interes_anual = LeerInteres("Introduce la tasa de interes anual: ");
        Plazo = LeerPlazo("Introduce el plazo en meses: ");
         


        //Calculo del interes mensual
        tasa_interes_mensual = (tasa_interes_anual / 100) / 12;


        //Calculo de la cuota mensual
        Console.WriteLine("\n");
        pago = tasa_interes_mensual + 1;
        pago = (float)Math.Pow(pago, Plazo);
        pago = pago - 1;
        pago = tasa_interes_mensual / pago;
        pago = tasa_interes_mensual + pago;
        pago = Monto_del_prestamo * pago;

        Console.WriteLine("Este sera su pago mensual: " + Math.Round(pago));
        Console.WriteLine("Para Generar su tabla Amortizada seleccionar segunda opcion");
        Console.WriteLine("\n");
        Console.WriteLine("Precione una tecla para volver");
        Console.ReadKey();
        Console.Clear();

    }

    public static string leerbeneficiario(string msg)
    {
         var Nombre = "";


        Console.WriteLine(msg);

        try
        {
            Nombre =  Console.ReadLine();
        }
        catch (Exception)
        {

            Nombre = leerbeneficiario(msg);

        }

        return Nombre;
    }
    public static int LeerMonto(string msg)
    {
        var monto = 0;

        Console.WriteLine(msg);

        try
        {
            monto = int.Parse(Console.ReadLine());
        }
        catch(Exception )
        {

            monto = LeerMonto(msg);

        }

        return monto;
    }
    public static int LeerPlazo(string msg)
    {
        var plazos = 0;

        Console.WriteLine(msg);

        try
        {
            plazos = int.Parse(Console.ReadLine());
        }
        catch (Exception )
        {

            plazos = LeerMonto(msg);

        }

        return plazos;
    }
    public static int LeerInteres(string msg)
    {
        var Interes = 0;

        Console.WriteLine(msg);

        try
        {
            Interes = int.Parse(Console.ReadLine());
        }
        catch (Exception )
        {

            Interes = LeerMonto(msg);

        }

        return Interes;
    }
    public void tabla()
    {
        Console.Clear();
        Console.WriteLine("Beneficiario: " + beneficiario);
        Console.WriteLine("Monto: "+ Monto_del_prestamo);
        Console.WriteLine("Tasa: "+ tasa_interes_anual + " %");
        Console.WriteLine("Plazo: "+Plazo+" Meses");
        Console.WriteLine("Valor de cuota: " + Math.Round(pago));
        Console.WriteLine("--------------------------------------");
        fila = 1;
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(" Numero de pago \t");
        Console.Write("Pago \t\t");
        Console.Write("Intereses Pagados \t\t");
        Console.Write("Capital Pagado \t\t");
        Console.Write("Monto del prestamo \t");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("\t0");
        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t{0}", Math.Round(Monto_del_prestamo));


        for (i = 1; i <= Plazo; i++)
        {


            Console.Write("\t{0}\t\t", fila);


            Console.Write("{0}\t", pago);


            Interes_pagado = tasa_interes_mensual * Monto_del_prestamo;
            Console.Write("{0}\t\t", Interes_pagado);


            Capital_pagado = pago - Interes_pagado;
            Console.Write("\t{0}\t", Capital_pagado);


            Monto_del_prestamo = Monto_del_prestamo - Capital_pagado;
            Console.Write("\t{0}\t", Math.Round(Monto_del_prestamo));

            fila = fila + 1;
            Console.WriteLine();

        }

        Console.WriteLine("\n");
        Console.WriteLine("Precione una tecla para volver");
        Console.ReadKey();
        Console.Clear();

    }

}