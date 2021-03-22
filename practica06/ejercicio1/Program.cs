using System;

namespace ejercicio1
{
     public class persona
    {
        public int cedula { get; set; }
         public string Nombre { get; set; }
         public string Apellido { get; set; }
         public int Edad { get; set; }
         public persona ()
        {   
            Console.WriteLine("Su Cedula es: " + cedula);
            Console.WriteLine("Su nombre es: " + Nombre);
            Console.WriteLine("Su Apellido es: " + Apellido);
            Console.WriteLine("Su Edad es: " + Edad);
        }
        public int metodo (int sueldo)  
        {
            return Console.Write("Su sueldo es de: ");
        } 
    }
   
    public class profesor : persona
    {
        public profesor ()
        {
            Console.WriteLine("Su Cedula es: "+ cedula);
            Console.WriteLine("Su nombre es: " + Nombre);
            Console.WriteLine("Su Apellido es: " + Apellido);
            Console.WriteLine("Su Edad es: " + Edad);
            Console.WriteLine("Su Sueldo es de: " + Sueldo);
        }
        public int metodo (int sueldo)  
        {
            return base.metodo (Console.Write("Su sueldo es de: ")) + 25000;
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
          profesor profesor = new profesor ();
          persona persona = new persona ();

          Console.WriteLine("Clase Persona"); 
          Console.Write("Escriba su Cedula: ");
          persona.cedula = int.Parse(Console.ReadLine());
          Console.Write("Esciba su Nombre: ");
          persona.Nombre = Console.ReadLine();
          Console.Write("Escriba su Apellido: ");
          persona.Apellido = Console.ReadLine();
          Console.Write("Escriba su Edad: ");
          persona.Edad = int.Parse(Console.ReadLine());
          Console.WriteLine("-----------------------------------------");   
          Console.WriteLine("Clase Profesor");   
          Console.Write("Escriba su Cedula: ");
          profesor.cedula = int.Parse(Console.ReadLine());
          Console.Write("Esciba su Nombre: ");
          profesor.Nombre = Console.ReadLine();
          Console.Write("Escriba su Apellido: ");
          profesor.Apellido = Console.ReadLine();
          Console.Write("Escriba su Edad: ");
          profesor.Edad = int.Parse(Console.ReadLine()); 
          Console.Write(profesor.metodo);  
           
           
           
          Console.ReadLine();     
        }
    }
   
}
