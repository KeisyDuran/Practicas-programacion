using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menu = true;
            string entrar = "";
            productos prop = new productos();

            while(menu)
            {
                Console.WriteLine("Maquina de PRODUCTOS");
                Console.WriteLine("1. Insertar monedas y billetes");
                Console.WriteLine("2. Comprar");
                Console.WriteLine("3. informe");
                Console.WriteLine("4. salir");
                Console.Write("Opcion: ");
                entrar = Console.ReadLine();

                switch(entrar)
                {

                    case "1":
                        prop.Dinero();



                        break;

                    case "2":

                        prop.products();

                        break;
                    case "3":
                     
                        prop.Existencia();
                       

                        break;

                    case "4":

                        menu = false;

                        break;

                }

            }

        }
    }


    class productos
    {

        int op, h = 0, p = 0, s = 0, sl = 0; double a, b, c, d, e, f, suma = 0;

        int arroz = 15;
        int Refresco = 15;
        int Pan = 15;
        int Aceite = 15;
        int Aguacate = 15;
        int Agua = 15;
        int Limon = 15;
        int Cocacola = 15;
        int Bizcocho = 15;
        int Chocolate = 15;

        public void Existencia()
        {

            Console.Clear();

            Console.WriteLine("---Cantidad maxima en almacen 15 unidades por productos---");
            Console.WriteLine("Quedan "+ arroz +" libras de arroz");
            Console.WriteLine("Quedan " + Refresco + " Refresco");
            Console.WriteLine("Quedan " + Pan + " Pan");
            Console.WriteLine("Quedan " + Aceite + " Aceite");
            Console.WriteLine("Quedan " + Aguacate + " Aguacate");
            Console.WriteLine("Quedan " + Agua + " botellas Agua");
            Console.WriteLine("Quedan " + Limon + " Limones");
            Console.WriteLine("Quedan " + Cocacola + " botellas Cocacola");
            Console.WriteLine("Quedan " + Bizcocho + " Bizcocho");
            Console.WriteLine("Quedan " + Chocolate + " Chocolate");
            Console.WriteLine("-----------Precione una tecla para volver----------------");
            Console.ReadKey();
            Console.Clear();
        }

        public void Dinero()
        {


            Console.Clear();
            Console.Write("Inserte la(s) moneda(s) de 5 pesos de no tener ponga 0: ");
            a = Convert.ToDouble(Console.ReadLine()); suma = suma + a * 5;
            Console.Write("Inserte la(s) moneda(s) de 10 pesos de no tener ponga 0: ");
            b = Convert.ToDouble(Console.ReadLine()); suma = suma + b * 10;
            Console.Write("Inserte la(s) moneda(s) de 25 pesos de no tener ponga 0: ");
            c = Convert.ToDouble(Console.ReadLine()); suma = suma + c * 25;
            Console.Write("Inserte la(s) billete(s) de 50 pesos de no tener ponga 0: ");
            d = Convert.ToDouble(Console.ReadLine()); suma = suma + d * 50;
            Console.Write("Inserte la(s) billete(s) de 100 pesos de no tener ponga 0: ");
            e = Convert.ToDouble(Console.ReadLine()); suma = suma + e * 100;
            Console.Write("Inserte la(s) billete(s) de 200 pesos de no tener ponga 0: ");
            f = Convert.ToDouble(Console.ReadLine()); suma = suma + f * 200;
            Console.Clear();



        }

        public void products()
        {

            if (suma >= 8)
            {
                Console.Clear();
                Console.WriteLine("Seleccione el PRODUCTO A COMPRAR");
                Console.WriteLine("1.- Arroz");
                Console.WriteLine("2.- Refresco");
                Console.WriteLine("3.- Pan");
                Console.WriteLine("4.- Aceite");
                Console.WriteLine("5.- Aguacate");
                Console.WriteLine("6.- Agua");
                Console.WriteLine("7.- Limon");
                Console.WriteLine("8.- Cocacola");
                Console.WriteLine("9.- Bizcocho");
                Console.WriteLine("10.- Chocolate");
                Console.Write("Inserte el # del producto: ");
                op = Convert.ToInt32(Console.ReadLine());
                if (op == 1)
                {
                    Console.Clear();
                   
                    Console.WriteLine("Compraste 1 libra de arroz");
                    suma = suma - 18; Console.WriteLine("Tu cambio es de " + suma);
                    arroz = arroz - 1;
                    
                    h++;
                    Console.WriteLine("-----------Precione una tecla para volver----------------");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (op == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Compraste 1 refresco");
                    suma = suma - 5;
                    Console.WriteLine("Tu cambio es de " + suma);
                    Refresco = Refresco - 1;
                    p++;
                    Console.WriteLine("-----------Precione una tecla para volver----------------");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (op == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Compraste 1 pan");
                    suma = suma - 4;
                    Console.WriteLine("Tu cambio es de " + suma);
                    Pan = Pan - 1;
                    s++;
                    Console.WriteLine("-----------Precione una tecla para volver----------------");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (op == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Compraste 1 aceite");
                    suma = suma - 30;
                    Console.WriteLine("Tu cambio es de " + suma);
                    Aceite = Aceite - 1;
                    sl++;
                    Console.WriteLine("-----------Precione una tecla para volver----------------");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (op == 5)
                {
                    Console.Clear();
                    Console.WriteLine("Compraste 1 aguacate");
                    suma = suma - 12; Console.WriteLine("Tu cambio es de " + suma);
                    Aguacate = Aguacate - 1;
                    h++;
                    Console.WriteLine("-----------Precione una tecla para volver----------------");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (op == 6)
                {
                    Console.Clear();
                    Console.WriteLine("Compraste 1 botella de agua");
                    suma = suma - 7;
                    Console.WriteLine("Tu cambio es de " + suma);
                    Agua = Agua - 1;
                    p++;
                    Console.WriteLine("-----------Precione una tecla para volver----------------");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (op == 7)
                {
                    Console.Clear();
                    Console.WriteLine("Compraste 1 limon");
                    suma = suma - 34;
                    Console.WriteLine("Tu cambio es de " + suma);
                    Limon = Limon - 1;
                    s++;
                    Console.WriteLine("-----------Precione una tecla para volver----------------");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (op == 8)
                {
                    Console.Clear();
                    suma = suma - 10;
                    Console.WriteLine("Compraste 1 cocacola");
                    Console.WriteLine("Tu cambio es de " + suma);
                    Cocacola = Cocacola - 1;
                    sl++;
                    Console.WriteLine("-----------Precione una tecla para volver----------------");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (op == 9)
                {
                    Console.Clear();
                    Console.WriteLine("Compraste 1 bizcocho");
                    suma = suma - 15;
                    Console.WriteLine("Tu cambio es de " + suma);
                    Bizcocho = Bizcocho - 1;
                    s++;
                    Console.WriteLine("-----------Precione una tecla para volver----------------");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (op == 10)
                {
                    Console.Clear();
                    Console.WriteLine("Compraste 1 chocolate");
                    suma = suma - 3;
                    Console.WriteLine("Tu cambio es de " + suma);
                    Chocolate = Chocolate - 1;
                    sl++;
                    Console.WriteLine("-----------Precione una tecla para volver----------------");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("inserte mas monedas o billetes");
                Console.WriteLine("El dinero que inserto es: " + suma);
            }

        }
    }
}
