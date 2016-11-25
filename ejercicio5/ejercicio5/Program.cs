using System;

namespace ejercicio5
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// Variables necesarias
			string libros = "";
			float cantLibros = 0;
			double resultado = 0.0f;

			Console.WriteLine("<<<<<Librería>>>>>");
			Console.WriteLine("¿Cuántos libros?");
			libros = Console.ReadLine();
			cantLibros = Convert.ToSingle(libros);

			resultado = operacion(cantLibros);

			Console.WriteLine("El resultado es {0}",resultado);
		}

		static double operacion(float libros)
		{
			//Variables total
			float totalParcial = 0;
			double total = 0;

			//Variable descuento
			double descuento = 0;

			//Constante precio libro
			float precio = 80;

			//Multiplicamos el costo de cada libro por su total
			totalParcial = precio * libros;
			//Verificamos si son más de 10 libros

			if (libros > 10)
			{
				descuento = totalParcial * .10;
				total = totalParcial - descuento;
			}

			else 
			{
				total = totalParcial;
			}

			return total;

		}
	}
}
