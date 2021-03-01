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
          datosimagen[] imagen = new datosimagen[700]; // array..
          int i=0, cantidad=0, capacidad=700, contador=0, opcion; // declaramos variables...
          string buscar;

             Console.WriteLine(" Introduzca la opcion a realizar ");
             Console.WriteLine(" 1. Añadir");
             Console.WriteLine(" 2. Ver Añadidas");
             Console.WriteLine(" 3. Buscar añadidas");
             Console.WriteLine(" 4. Salir");
             opcion = Convert.ToInt32(Console.ReadLine());

              switch (opcion)
              {
                  case 1:
                    if (cantidad < capacidad)
                       {
                           Console.WriteLine("introdusca el nombre de la imagen");
                           imagen[cantidad+1].nombre = Convert.ToString(Console.ReadLine());
                           Console.WriteLine("introdusca el ancho");
                           imagen[cantidad+1].ancho = int.Parse(Console.ReadLine());     // vamos convirtiendo y sumando la cantidad...
                           Console.WriteLine("teclee el alto");
                           imagen[cantidad+1].alto = int.Parse(Console.ReadLine());
                           Console.WriteLine("teclee el tamaño");
                           imagen[cantidad+1].tamaño = int.Parse(Console.ReadLine());
                           Console.ReadLine();
                        }

                       else
                       {
                           Console.WriteLine("Lista llena!!!");
                       }
                  break;

                  case 2:
                       if (cantidad<capacidad)
                       {
                           Console.WriteLine("las imagenes ingresadas son...");

                           for (i=0; i<cantidad; i++)
                           {
                               Console.WriteLine("\n numero de imagen {0} \n nombre de la imagen {1}", i+1, imagen[i+1].nombre);
                           }                     
                       }
                       
                       else
                       {
                           Console.WriteLine("la lista esta vacia");
                       }
                  break;

                  case 3:
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
                  break;

                  case 4:
                    Console.WriteLine("Saliendo de la aplicacion");
                  break;

                  default: Console.WriteLine("Seleccione opcion valida");
                  break;
              }
              
           
        }
    }

    class datosimagen
    {
        public string nombre;
        public float ancho, alto, tamaño;
    }
}
