using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_banco
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string nombre1,nombre2, nombre3;
            Console.WriteLine("Escribre el primer cliente");
            nombre1 = Console.ReadLine();
            Console.WriteLine("Escribre el Segundo cliente");
            nombre2 = Console.ReadLine();
            Console.WriteLine("Escribre el Tercer cliente");
            nombre3 = Console.ReadLine();
            

            Console.WriteLine("1."+nombre1);
            Console.WriteLine("2."+nombre2);
            Console.WriteLine("3."+nombre3);
            string elegir = null;
            elegir = Console.ReadLine();
            switch (elegir)
            {
                case "1":
                    int Retirar, Depositar, resul ;
                    
                    
                    Console.WriteLine("Que quiere realizar \n" +
                        "\n 1. Retirar" +
                        "\n 2. Depositar");
                    string elegi = null;
                    elegi = Console.ReadLine();
                    switch (elegi)
                    {
                        case "1":
                            Console.WriteLine("Cuanto Desea Retirar");
                            Retirar = int.Parse(Console.ReadLine());
                            Console.WriteLine(nombre1 + " ha Retirado " + Retirar + " Con Exito!");
                            break;
                        case "2":
                            Console.WriteLine("Cuanto Desea Depositar");
                           Depositar =  int.Parse(Console.ReadLine());
                            Console.WriteLine(nombre1 + " ha Depositado " + Depositar + " Con Exito!");
                            string ele = null;
                           
                            ele = Console.ReadLine();
                            Console.WriteLine("Quieres hacer Otro deposito?" +
                                "\n si" +
                                "\n no");
                            string cual = Console.ReadLine();
                            if (cual == "si")
                            {
                                Console.WriteLine("Cuanto Desea Depositar");
                                Depositar = int.Parse(Console.ReadLine());
                                Console.WriteLine(nombre1 + " ha Depositado " + Depositar + " Con Exito!");
                                Console.WriteLine("Quieres hacer Otro deposito?" +
                               "\n si" +
                               "\n no");
                                string cuala = Console.ReadLine();
                                if (cuala == "si")
                                {
                                    Console.WriteLine("Cuanto Desea Depositar");
                                    Depositar = int.Parse(Console.ReadLine());
                                    Console.WriteLine(nombre1 + " ha Depositado " + Depositar + " Con Exito!");
                                }
                                else if(cuala == "no")
                                {
                                    Console.WriteLine("Muchas Gracias por usar este banco sus depositos del dia son: " + Depositar);
                                }
                            }
                            else if (cual == "no")
                            {
                                Console.WriteLine("Muchas Gracias por usar este banco sus depositos del dia son: " + Depositar);
                            }


                            break;


                    }
                    break;
                case "2":
                    int Retir, Deposit;
                    Console.WriteLine("Que quiere realizar \n" +
                       "\n 1. Retirar" +
                       "\n 2. Depositar");
                    string eleg = null;
                    switch (eleg)
                    {
                        case "1":
                            Console.WriteLine("Cuanto Desea Retirar");
                            Retir = int.Parse(Console.ReadLine());
                            Console.WriteLine(nombre2 + " ha Retirado " + Retir + " Con Exito!");
                            break;
                        case "2":
                            Console.WriteLine("Cuanto Desea Depositar");
                            Deposit = int.Parse(Console.ReadLine());
                            Console.WriteLine(nombre2 + " ha Depositado " + Deposit + " Con Exito!");
                            string ele = null;

                            ele = Console.ReadLine();
                            Console.WriteLine("Quieres hacer Otro deposito?" +
                                "\n si" +
                                "\n no");
                            string cuals = Console.ReadLine();
                            if (cuals == "si")
                            {
                                Console.WriteLine("Cuanto Desea Depositar");
                                Depositar = int.Parse(Console.ReadLine());
                                Console.WriteLine(nombre2 + " ha Depositado " + Deposit + " Con Exito!");
                                Console.WriteLine("Quieres hacer Otro deposito?" +
                               "\n si" +
                               "\n no");
                                string cualsa = Console.ReadLine();
                                if (cualsa == "si")
                                {
                                    Console.WriteLine("Cuanto Desea Depositar");
                                    Depositar = int.Parse(Console.ReadLine());
                                    Console.WriteLine(nombre1 + " ha Depositado " + Depositar + " Con Exito!");
                                }
                                else if (cualsa == "no")
                                {
                                    Console.WriteLine("Muchas Gracias por usar este banco sus depositos del dia son: " + Deposit);
                                }
                            }
                            else if (cuals == "no")
                            {
                                Console.WriteLine("Muchas Gracias por usar este banco sus depositos del dia son: " + Deposit);
                            }


                            break;
                    }
                    break;
                case "3":
                    int Reti, Deposi;
                    Console.WriteLine("Que quiere realizar \n" +
                       "\n 1. Retirar" +
                       "\n 2. Depositar");
                    string el = null;
                    switch (el)
                    {
                        case "1":
                            Console.WriteLine("Cuanto Desea Retirar");
                            Reti = int.Parse(Console.ReadLine());
                            Console.WriteLine(nombre3 + " ha Retirado " + Reti + " Con Exito!");
                            break;
                        case "2":
                            Console.WriteLine("Cuanto Desea Depositar");
                            Deposi = int.Parse(Console.ReadLine());
                            Console.WriteLine(nombre3 + " ha Depositado " + Deposi + " Con Exito!");
                            string ele = null;

                            ele = Console.ReadLine();
                            Console.WriteLine("Quieres hacer Otro deposito?" +
                                "\n si" +
                                "\n no");
                            string cuals = Console.ReadLine();
                            if (cuals == "si")
                            {
                                Console.WriteLine("Cuanto Desea Depositar");
                                Depositar = int.Parse(Console.ReadLine());
                                Console.WriteLine(nombre2 + " ha Depositado " + Deposi + " Con Exito!");
                                Console.WriteLine("Quieres hacer Otro deposito?" +
                               "\n si" +
                               "\n no");
                                string cualsa = Console.ReadLine();
                                if (cualsa == "si")
                                {
                                    Console.WriteLine("Cuanto Desea Depositar");
                                    Depositar = int.Parse(Console.ReadLine());
                                    Console.WriteLine(nombre1 + " ha Depositado " + Deposi + " Con Exito!");
                                }
                                else if (cualsa == "no")
                                {
                                    Console.WriteLine("Muchas Gracias por usar este banco sus depositos del dia son: " + Deposi);
                                }
                            }
                            else if (cuals == "no")
                            {
                                Console.WriteLine("Muchas Gracias por usar este banco sus depositos del dia son: " + Deposi);
                            }


                            break;
                    }
                    break;

            }
            Console.ReadKey();

        }
    }
}
