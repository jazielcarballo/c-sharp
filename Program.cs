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

			//Pregunto cuantos libros
			Console.WriteLine("¿Cuántos libros?");
			libros = Console.ReadLine();
			//Convierto mi cadena "libros" a número
			cantLibros = Convert.ToSingle(libros);

			//Invoco el valor que me devuelve la función "operacion"
			resultado = operacion(cantLibros);

			//Imprimo el resultado
			Console.WriteLine("El resultado es {0}",resultado);
		}


		//Función que realizará el descuento, saber si son más de 10 libros y el pago total
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
			//Si son igual o menos de 10 números
			else 
			{
				total = totalParcial;
			}

			//Devuelve la variable total
			return total;

		}
	}
}
