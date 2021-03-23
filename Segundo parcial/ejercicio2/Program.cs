using System;

namespace ejercicio2
{
   class Program
    {
        static void Main(string[] args)
        {
            empleado prop = new empleado();

            prop.cargar();
            prop.SalarioMayor();
        }

    }

    class empleado
    {
        public string nombre1;
        public string nombre2;
        public string nombre3;
        public string nombre4;
        public string nombre5;
        public int mayor1;
        public int mayor2;
        public int mayor3;
        public int mayor4;
        public int mayor5;
        public void cargar()
        {
            Console.WriteLine("Escriba el nombre del empleado #1: ");
            nombre1 = Console.ReadLine();
            Console.WriteLine("Escriba su salario: ");
            mayor1 = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Escriba el nombre del empleado #2: ");
            nombre2 = Console.ReadLine();
            Console.WriteLine("Escriba su salario: ");
            mayor2 = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Escriba el nombre del empleado #3: ");
            nombre3 = Console.ReadLine();
            Console.WriteLine("Escriba su salario: ");
            mayor3 = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Escriba el nombre del empleado #4: ");
            nombre4 = Console.ReadLine();
            Console.WriteLine("Escriba su salario: ");
            mayor4 = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Escriba el nombre del empleado #5: ");
            nombre5 = Console.ReadLine();
            Console.WriteLine("Escriba su salario: ");
            mayor5 = int.Parse(Console.ReadLine());
            Console.Clear();

        }


        public void  SalarioMayor()
        {
            if(mayor1 > mayor2 && mayor1 > mayor3 && mayor1 > mayor4 && mayor1 > mayor5)
            {
                Console.WriteLine("El empleado con el salario mayor es "+nombre1);
                Console.WriteLine($"Tiene un salario "+mayor1);
            }
            else if (mayor2 > mayor1 && mayor2 > mayor3 && mayor2 > mayor4 && mayor2 > mayor5)
            {
                Console.WriteLine($"El empleado con el salario mayor es "+nombre2);
                Console.WriteLine($"Tiene un salario "+mayor2);
            }
            else if (mayor3 > mayor1 && mayor3 > mayor2 && mayor3 > mayor4 && mayor3 > mayor5)
            {
                Console.WriteLine($"El empleado con el salario mayor es "+nombre3);
                Console.WriteLine($"Tiene un salario "+mayor3);
            }

            else if (mayor4 > mayor1 && mayor4 > mayor2 && mayor4 > mayor3 && mayor4 > mayor5)
            {
                Console.WriteLine($"El empleado con el salario mayor es {0}", nombre4);
                Console.WriteLine($"Tiene un salario "+mayor4);
            }
            else if (mayor5 > mayor1 && mayor5 > mayor2 && mayor5 > mayor3 && mayor5 > mayor4)
            {
                Console.WriteLine($"El empleado con el salario mayor es "+nombre5);
                Console.WriteLine($"Tiene un salario "+mayor5);
            }

        }

    }

}
