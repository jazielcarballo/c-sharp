using System;

namespace edad
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//Declaro e inicializo variables 
			string anio = "";
			float anioNac = 0;
			float edadFinal = 0;

			Console.WriteLine("Calcular edad");
			//Pregunto año de nacimiento
			Console.WriteLine("Año de nacimiento");
			anio = Console.ReadLine();
			anioNac = Convert.ToSingle(anio);

			//Llamo al método
			edadFinal = calcularEdad(anioNac);
			//Imprimir resultado
			Console.WriteLine("Tu edad es {0}", edadFinal);
		}

		static float calcularEdad(float anioNac)
		{
			float edad = 0;
			float anioActual = 2016;
			edad = anioActual - anioNac;
			return edad;
		}
	}
}
