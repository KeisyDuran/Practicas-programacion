using System;

namespace primer_parcial
{
    class Program
    {
        static void Main(string[] args)
        {
//Cree una aplicación de cajero automático para el banco FDP INVERSMENTS. El cajero tendrá un límite de billetes descrito a continuación: 
//  18 billetes de 1,000
//  19 billetes de 500
//  23 billetes de 200
//  50 billetes de 100            

              int limiteRetiro = 20000, limiteTransaccion = 10000;
              int B1000, B500, B200, B100;

                Console.Write("Bienvenido al Cajero FDP Inversments. ");
                Console.WriteLine("Seleccione Entidad");
                Console.WriteLine("1- FDP Inversments \n" + 
                "2- Banco Banesco \n" + 
                "3- Banco Santa Cruz \n" + 
                "4- Salir");
                 int banco = Convert.ToInt32(Console.ReadLine()); 
                  switch (banco)
                 {
                  case 1:
                   Console.WriteLine("Bienvenido al Banco FDP Inversments \n" + 
                    "¿Qué va a realizar? \n" + 
                    "1- Retiro \n" + 
                    "2- Deposito \n" + 
                    "3- Salir");
                     
                    int opcion = Convert.ToInt32(Console.ReadLine());
                    if (opcion == 1)
                    {
                        Console.WriteLine("Digite Cantidad a retirar:  \n " +  $" El limite a retirar es de {limiteRetiro}"); 
                          int cantidadRetirar = Convert.ToInt32(Console.ReadLine());
                          if (cantidadRetirar <= limiteRetiro)
                          {
                           	if( (cantidadRetirar >= 1000) )
		                        {
                               B1000 = ((int) cantidadRetirar / 1000);
				                       cantidadRetirar = cantidadRetirar - (B1000 * 1000);
                               Console.WriteLine($"Billetes de 1000: {B1000}");
                               
                               	if( (cantidadRetirar >= 500) )
		                           {
                                  B500 = ((int) cantidadRetirar / 500);
				                          cantidadRetirar = cantidadRetirar - (B500 * 500);
                                  Console.WriteLine($"Billetes de 500: {B500}");
                                  
                                  	if( (cantidadRetirar >= 200) )
		                                 {
                                        B200 = ((int) cantidadRetirar / 200);
				                                cantidadRetirar = cantidadRetirar - (B200 * 200);
                                        Console.WriteLine($"Billetes de 200: {B200}");
                                         
                                          if( (cantidadRetirar >= 200) )
		                                      {
                                             B200 = ((int) cantidadRetirar / 200);
				                                     cantidadRetirar = cantidadRetirar - (B200 * 200);
                                             Console.WriteLine($"Billetes de 200: {B200}");
                               
                                              if( (cantidadRetirar >= 100) )
		                                           {
                                                  B100 = ((int) cantidadRetirar / 100);
				                                          cantidadRetirar = cantidadRetirar - (B100 * 100);
                                                  Console.WriteLine($"Billetes de 100: {B100}");
                              
			                                          }
			                                    }
			                                }
			                          }
			                      }
                                                  
                          }

                           else if (cantidadRetirar > limiteRetiro)
                          {
                              Console.WriteLine("Ha superado el limite de retiro, por favor ingresar monto valido");
                              break;
                          } 
                    } 

                    else if (opcion == 2)
                    {
                        Console.WriteLine("Ingrese cantidad a Depositar.\n" + $" El limite a transferir es de {limiteTransaccion}"); // Informe de Limite a Retirar.
                         int cantidadTransferir = Convert.ToInt32(Console.ReadLine());
                         if (cantidadTransferir <= limiteTransaccion)
                         {
                           Console.WriteLine("Transacion satisfactoria");
                           Console.WriteLine($"Su Nuevo Balance es de: {cantidadTransferir}");
                           break;
                         }
                         else
                         {
                            Console.WriteLine("Ha excedido limite de Transacion Diaria");
                            Console.WriteLine();
                            break;
                         }
                        
                    }

                    else if (opcion == 3)
                    {
                        Console.WriteLine("Gracias por utilizar el Cajero FDP Inversments");
                        break;
                    }

                    else
                    {
                       Console.WriteLine("Digite una Opción valida");
                       break; 
                    }
                  break;

                  case 2:
                  Console.WriteLine("Sistema no Disponible");
                  break;

                  case 3:
                  Console.WriteLine("Sistema no Disponible");
                  break;

                  case 4:
                  Console.WriteLine("Saliendo de la Aplicacion");
                  break;
                  
                  default:
                  Console.WriteLine("Digite una Opción valida");
                  break;
                 }
        }
    }
}
