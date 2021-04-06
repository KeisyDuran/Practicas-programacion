using System;

namespace ejercicio5_4_21
{
    namespace productos
  {
    class Producto
    {
        public string Nombre;
        public string Descripcion;
        public int Cantidad;
        public Producto(string nom, string desc, int cant)
   {
     this.Nombre = nom;
     this.Descripcion = desc;
     this.Cantidad = cant;
    }
        public void MonstrarProducto()
   {
    Console.WriteLine("Nombre producto: {0}" , this.Nombre);
    Console.WriteLine("Descripcion: {0}" , this.Descripcion);

   }

   }
     class Program
    {
        static void Main(string[] args)
        {
            Producto prod = new Producto (nom:"Cerveza Corona", desc:"Cerveza Mexicana", cant:12);
            prod.MonstrarProducto();
        }
    }
}
  
 }
