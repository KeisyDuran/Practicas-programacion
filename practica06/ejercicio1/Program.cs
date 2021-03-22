using System;

namespace ejercicio1
{   
   public class Persona  
    {  
        public long cedula 
        { get; set; } 
        public string nombre 
        { get; set; } 
        public string apellido 
        { get; set; } 
        public int edad 
        { get; set; } 
        public Persona(long kCedula, string kNombre, string kApellido, int kEdad) 
        { 
            cedula = kCedula; 
            nombre = kNombre; 
            apellido = kApellido; 
            edad = kEdad; 
        } 
        public Persona() 
        { 
 
        }  
        public void MetodoPersona() 
        { 
            Console.WriteLine("metodo de la Clase Persona."); 
        } 
    } 
   public class Profesor : Persona 
    { 
        private int sueldo; 
        public int Sueldo 
        { 
            get { return sueldo; } 
            set { sueldo = value; } 
        } 
        public Profesor(int kSueldo) 
        { 
            sueldo = kSueldo; 
        } 
        public Profesor() 
        { 
 
        } 
    }
   
    class Program
    {
        static void Main(string[] args)
        {
          Persona keisy = new Persona(); 
          Profesor masseel = new Profesor(); 

          Console.WriteLine("Clase Persona"); 
          Console.Write("Escriba su Cedula: ");
          keisy.cedula = Convert.ToInt32(Console.ReadLine());
          Console.Write("Esciba su Nombre: ");
          keisy.nombre = Console.ReadLine();
          Console.Write("Escriba su Apellido: ");
          keisy.apellido = Console.ReadLine();
          Console.Write("Escriba su Edad: ");
          keisy.edad = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("-----------------------------------------");   
          Console.WriteLine("Clase Profesor");   
          Console.Write("Escriba su Cedula: ");
          masseel.cedula = Convert.ToInt32(Console.ReadLine());
          Console.Write("Esciba su Nombre: ");
          masseel.nombre = Console.ReadLine();
          Console.Write("Escriba su Apellido: ");
          masseel.apellido = Console.ReadLine();
          Console.Write("Escriba su Edad: ");
          masseel.edad = Convert.ToInt32(Console.ReadLine());
          Console.Write("Escriba su sueldo: ");
          masseel.Sueldo = Convert.ToInt32(Console.ReadLine()); 
           
          Console.WriteLine($"Clase Persona\n La cedula es {keisy.cedula}\n Su Nombre es {keisy.nombre}\n Su Apellido es: {keisy.apellido}\n Su Edad es {keisy.edad}\n");
          Console.WriteLine("-----------------------------------------");  
          Console.WriteLine($"Clase Profesor\n La cedula es {masseel.cedula}\n Su Nombre es {masseel.nombre}\n Su Apellido es: {masseel.apellido}\n Su Edad es {masseel.edad}\n El sueldo es {masseel.Sueldo} pesos.");
        }
    }
     
}


