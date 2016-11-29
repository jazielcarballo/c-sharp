using System;

namespace ejercicio7
{
	class cubo
	{
		// Declaramos los datos
		public int lado;
		public int area;
		public int volumen;

		// Método para calcular el área
		public void CalculaArea()
		{
			area = (lado * lado) * 6;
		}

		// Método para calcular el volumen
		public void CalculaVolumen()
		{
			volumen = lado * lado * lado;
		}

	}


	class MainClass
	{
		public static void Main(string[] args)
		{
			// Instanciamos a la clase cubo
			cubo miCubo = new cubo();

			cubo tuCubo = new cubo();

			cubo Cubo3 = new cubo();

		
			// Asignamos el valor del lado
			miCubo.lado = 5;
			tuCubo.lado = 8;
			Cubo3.lado = 7;


			// Invocamos los métodos
			miCubo.CalculaArea();
			miCubo.CalculaVolumen();
			tuCubo.CalculaArea();
			tuCubo.CalculaVolumen();
			Cubo3.CalculaArea();
			Cubo3.CalculaVolumen();

			// Desplegamos los datos
			Console.WriteLine("Mi cubo Area ={0}, Volumen ={1}",miCubo.area, miCubo.volumen);
			Console.WriteLine("Tu cubo Area ={0}, Volumen ={1}",tuCubo.area, tuCubo.volumen);
			Console.WriteLine("Tu cubo Area ={0}, Volumen ={1}", Cubo3.area, Cubo3.volumen);

		
			
		}
	}
}
