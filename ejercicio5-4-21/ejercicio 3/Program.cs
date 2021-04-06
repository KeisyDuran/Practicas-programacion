using System;

namespace ejercicio_3
{
    class Program
    {
        private int[] vec;
        public void ValoresAleatorios(out int v1, out int v2, out int v3, out int v4, out int v5)
        {
            Random r = new Random();
            v1 = r.Next(1, 30);
            v2 = r.Next(1, 30); 
            v3 = r.Next(1, 30);
            v4 = r.Next(1, 30);
            v5 = r.Next(1, 30);           
        }
        public void Cargar()
        {
            for (var f = 0; f < vec.Length; f++)
            {
                vec[f] = ValoresAleatorios;
            }
        }
         public void MayorMenor(out int may,out int men)
        {
            may=vec[0];
            men=vec[0];
            for (var f = 1; f < vec.Length; f++)
            {
                if (vec[f] > may)
                {
                    may = vec[f];
                }
                else
                {
                    if (vec[f] < men)
                    {
                        men = vec[f];
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int ale1, ale2, ale3, ale4, ale5, ma, me;
            Program K = new Program();
            K.ValoresAleatorios(out ale1, out ale2, out ale3, out ale4, out ale5);
            K.MayorMenor(out ma, out me);
            K.Cargar();
            Console.WriteLine("Primer valor aleatorio:" + ale1);
            Console.WriteLine("Segundo valor aleatorio:" + ale2);
            Console.WriteLine("Tercer valor aleatorio:" + ale3);
            Console.WriteLine("Cuarto valor aleatorio:" + ale4);
            Console.WriteLine("Quinto valor aleatorio:" + ale5);  
            Console.WriteLine("El mayor elemento del vector es:" + ma);
            Console.WriteLine("El menor elemento del vector es:" + me); 
            Console.ReadKey();
        }
    }
}
