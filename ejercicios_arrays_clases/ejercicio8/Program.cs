using System;

namespace ejercicio8
{
    class Program
//Crear un programa que defina un array de 5 elementos de tipo float que representen las alturas de 5 personas.
//Obtener el promedio de las mismas. Contar cuántas personas son más altas que el promedio y cuántas más bajas.
    {
        static void Main(string[] args)
        {
            int f;
            int may;
            int men;
	       float[] alturas = new float[5];
	       float suma;
	       float promedio;

	       for (f = 0; f < 5; f++)
	       {
		     Console.Write("Ingrese la altura de la persona: ");
		     string tempVar = Console.ReadLine();
		      if (tempVar != null)
		       {
			     alturas[f] = float.Parse(tempVar);
		        }
	        }
	      suma = 0F;
	        for (f = 0; f < 5; f++)
	        {
		       suma = suma + alturas[f];
	        }
	      promedio = suma / 5;
	      Console.Write("Promedio de alturas: ");
          Console.Write("{0:f2}",promedio);
	      Console.Write("\n");

	     may = 0;
	     men = 0;
	      for (f = 0; f < 5; f++)
	      {
		    if (alturas[f] > promedio)
		    {
			 may++;
		    }
		    else
		    {
			   if (alturas[f] < promedio)
			   {
				 men++;
			   }
		    }
	       }

	      Console.Write("Cantidad de personas mayores al promedio: ");
	      Console.Write("{0:D}",may);
	      Console.Write("\n");
	      Console.Write("Cantidad de personas menores al promedio: ");
	      Console.Write("{0:D}",men);
	      Console.ReadKey(true);  
        }
    }
}
