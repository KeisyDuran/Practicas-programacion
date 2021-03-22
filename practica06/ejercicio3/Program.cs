using System;

namespace ejercicio3
{   class claseA
    {
        public string nombre { get; set; }
        public string apellido { get; set; }

        public void infoA()
        {
            Console.WriteLine("Su Nombre es " + nombre);
            Console.WriteLine("Su Apellido es " + apellido);
        }
    }
    class ClaseB:claseA
    {
        public int edad { get; set; }
        public int sueldo { get; set; }

        public void infoB()
        {
            Console.WriteLine("Su edad es: " + edad);
            Console.WriteLine("Su sueldo es: " + sueldo);

        }
    }
    class ClaseC:ClaseB
    {
        public string NombrePapa { get; set; }
        public string NombreMama { get; set; }

        public void infoC()
        {
            Console.WriteLine("El Nombre del Padre es: " + NombrePapa);
            Console.WriteLine("El Nombre de la Madre es: " + NombreMama);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ClaseC C = new ClaseC();

            Console.WriteLine("Escriba su Nombre: ");
            C.nombre = Console.ReadLine();
            Console.WriteLine("Escriba su Apellido: ");
            C.apellido = Console.ReadLine();
            Console.WriteLine("Escriba su Edad: ");
            C.edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba su Sueldo: ");
            C.sueldo = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el Nombre del Padre: ");
            C.NombrePapa = Console.ReadLine();
            Console.WriteLine("Escriba el Nombre de la Madre: ");
            C.NombreMama = Console.ReadLine();
            
            Console.Clear();
            C.infoA();
            C.infoB();
            C.infoC();
            Console.ReadKey();
        }
    }
}
