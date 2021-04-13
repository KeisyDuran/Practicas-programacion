using System;

namespace ejercicio_3
{
    class Program
    {
        public void ValoresAleatorios(out int v1, out int v2, out int v3, out int v4, out int v5)
        {
            Random r = new Random();
            v1 = r.Next(1, 30);
            v2 = r.Next(1, 30); 
            v3 = r.Next(1, 30);
            v4 = r.Next(1, 30);
            v5 = r.Next(1, 30);           
        }
        static void Main(string[] args)
        {
            int ale1, ale2, ale3, ale4, ale5;
            Program K = new Program();
            K.ValoresAleatorios(out ale1, out ale2, out ale3, out ale4, out ale5);
            Console.WriteLine("Primer valor aleatorio:" + ale1);
            Console.WriteLine("Segundo valor aleatorio:" + ale2);
            Console.WriteLine("Tercer valor aleatorio:" + ale3);
            Console.WriteLine("Cuarto valor aleatorio:" + ale4);
            Console.WriteLine("Quinto valor aleatorio:" + ale5);  
            Console.ReadKey();
        }
    }
}
