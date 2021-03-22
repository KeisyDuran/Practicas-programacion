using System;

namespace ejercicio1
{   public class persona 
    {
      private int Cedula;
      private string Nombre;
      private string Apellido;
      private int Edad;

      public int cedula 
      {
          get { return cedula; }
          set { cedula = value; }
      }
      public string Nombre 
      {
          get { return Nombre; }
          set { Nombre = value; }
      }
      public string Apellido 
      {
          get { return Apellido; }
          set { Apellido = value; }
      }
      public int Edad 
      {
          get { return Edad; }
          set { Edad = value; }
      }
      public persona (int pcedula, string pnombre, string papellido, int pedad)
      {
        Cedula = pcedula;
        Nombre = pnombre;
        Apellido = papellido;
        Edad = pedad;   
      }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
