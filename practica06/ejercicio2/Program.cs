using System;

namespace ejercicio2
{
    class Contacto
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public void setContacto()
        {
            Console.WriteLine( Nombre +" "+ Apellido );
          
        }
        public void saludar()
        {
            Console.WriteLine("hola, soy "+ Nombre+" "+ Apellido+" Mi Numero de telefono es "+ Telefono+" Direccion "+ Direccion);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Contacto con = new Contacto();

            Console.WriteLine("Escriba Su Nombre");
            con.Nombre = Console.ReadLine();
            Console.WriteLine("Escriba Su Apellido");
            con.Apellido = Console.ReadLine();
            Console.WriteLine("Escriba Su Telefono");
            con.Telefono = Console.ReadLine();
            Console.WriteLine("Escriba Su Direccion");
            con.Direccion = Console.ReadLine();

            Console.Clear();
            con.setContacto();

            con.saludar();
            Console.ReadKey();
        }
    }
}
