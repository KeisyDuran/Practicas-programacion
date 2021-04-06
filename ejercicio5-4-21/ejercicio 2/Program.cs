using System;

namespace ConsoleApp1
{
    
    class Program
    {
        //Crear aplicacion recibir menor y mayor entero de un vector. Recibirlos en un solo metodo y retornar los valores.
        
        private int[] vect;

        public Program()
        {
            Console.Write("Tamaño del vectro: ");
            int tam = int.Parse(Console.ReadLine());
            vect = new int[tam];
        }

        public void Cargar()
        {
            for (int i = 0; i < vect.Length; i++)
            {
                Console.Write("Ingresar valor");
                vect[i] = int.Parse(Console.ReadLine());
            }
        }

        public void MenorMayor(out int mayor, out int menor)
        {
            mayor = vect[0];
            menor = vect[0];

            for (int i = 1; i < vect.Length; i++)
            {
                if (vect[i] > mayor)
                {
                    mayor = vect[i];
                }
                else
                {
                    if (vect[i] < menor)
                    {
                        menor = vect[i];
                    }
                }
                
            }
        }
        
        static void Main(string[] args)
        {
            Program p = new Program();
            
            p.Cargar();

            int may, men;
            
            p.MenorMayor(out may, out men);
            Console.WriteLine("El elemento mayor de la tabla es: {0}", may);
            Console.WriteLine("El elemento menor de la tabla es: {0}", men);
        }
    }
}