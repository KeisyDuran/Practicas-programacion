using System;

namespace ejercicio9
{
    class Program
    {
        static void Main(string[] args)

//Crear una clase que permita ingresar valores enteros por teclado y nos muestre la tabla de multiplicar de dicho valor. 
//Finalizar el programa al ingresar el -1.
        {
            multiplicar v = new multiplicar();
            Console.WriteLine("Ingrese el numero");
            v.tabla = Console.ReadLine();

            v.num = int.Parse(v.tabla);

            for (v.i = 0; v.i < 13; v.i++)
            {
                Console.WriteLine(v.i + "x" + v.num + " = " + v.i * v.num );
            }

            Console.ReadKey();  
        }
    }
     class multiplicar
    {

        public int num;
        public int i;
        public string tabla;

    }
}
