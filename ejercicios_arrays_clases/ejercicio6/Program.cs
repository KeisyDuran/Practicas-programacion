using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
//Un programa que permita guardar datos de "imágenes" (ficheros de ordenador que contengan fotografías o cualquier otro tipo de información gráfica). 
//De cada imagen se debe guardar: nombre (texto), ancho en píxeles (por ejemplo 2000), alto en píxeles (por ejemplo, 3000), tamaño en Kb (por ejemplo 145,6). 
//El programa debe ser capaz de almacenar hasta 700 imágenes (deberá avisar cuando su capacidad esté llena). Debe permitir las opciones: añadir una ficha nueva, 
//ver todas las fichas (número y nombre de cada imagen), buscar la ficha que tenga un cierto nombre.
        {
            datosimagen [] imagen = new datosimagen[700]; // array..
          int i=0, cantidad=0, capacidad=700, contador=0, opcion; // declaramos variables...
          string buscar;

          do
          {
             Console.WriteLine(" INTRODUSCA UNA OPCION A REALIZAR ");
             Console.WriteLine("\n\n 1. Añadir");
             Console.WriteLine("\n\n 2. Ver Añadidas");
             Console.WriteLine("\n\n 3. Buscar añadidas");
             Console.WriteLine("\n\n 4. Salir");
             opcion = ConvertToInt32(Console.ReadLine());

              if (opcion!=1 && opcion!=2 && opcion!=3 && opcion!=4)
              {
                  Console.WriteLine("Opcion incorrecta elija otra !!");

                   if (opcion ==1)
                   {
                       if (cantidad < capacidad)
                       {
                           Console.WriteLine("introdusca el nombre de la imagen");
                           imagen[cantidad+1].nombre = Convert.ToString(Console.ReadLine());
                           Console.WriteLine("introdusca el ancho");
                           imagen[cantidad+1].ancho = Convert.ToString(Console.ReadLine());     // vamos convirtiendo y sumando la cantidad...
                           Console.WriteLine("teclee el alto");
                           imagen[cantidad+1].alto = Convert.ToString(Console.ReadLine());
                           Console.WriteLine("teclee el tamaño");
                           imagen[cantidad+1].tamaño = Convert.ToString(Console.ReadLine());
                           Console.ReadLine();
                        }

                       else
                       {
                           Console.WriteLine("Lista llena!!!");
                       }
                   }
                   
                   if (opcion ==2)
                   {
                       if (cantidad<capacidad)
                       {
                           Console.WriteLine("las imagenes ingresadas son...");

                           for (i=0; i<cantidad; i++)
                           {
                               Console.WriteLine("\n numero de imagen {0} \n nombre de la imagen {1}", i+1, imagen[i+1].nombre);
                           }

                           Console.ReadLine();                       
                       }
                       
                       else
                       {
                           Console.WriteLine("la lista esta vacia");
                       }
                   }

                   if (opcion ==3)
                   {
                       if (cantidad>0)
                       {
                           Console.WriteLine("teclee la imagen a buscar");
                           buscar = Convert.ToString(Console.ReadLine());
                           Console.WriteLine("Las imagenes encontradas son..;");
                            
                            for (i=0; i<cantidad; i++)
                            {
                                if (buscar == imagen[i].nombre)
                                {
                                    Console.WriteLine("{0} {1} {2} {3}", imagen[i].nombre, imagen[i].ancho, imagen[i].alto, imagen[i].tamaño);
                                    Console.ReadLine();
                                    contador++;
                                }
                            }
                        
                            if (contador<0)
                            {
                              Console.WriteLine("ninguna imagen encontrada!!");
                              Console.ReadLine();
                              contador=0;
                            }
                        }
                    }
               }
              
           } while (opcion== 4);
            Console.WriteLine("FIN !!");
            Console.ReadLine();
        }
    }

}
