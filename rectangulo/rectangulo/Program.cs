using System;

namespace ejercicio7
{
	

	class rectangulo
	{
		public int b;
		public int h;
		public int area;

		public void CalcularAreaRect()
		{
			area = b * h;
		}

	}


	class MainClass
	{
		public static void Main(string[] args)
		{
			
			//Instanciar a la clase rectangulo
			rectangulo miRectangulo = new rectangulo();

			//Asignar valor a base y altura

			miRectangulo.b = 8;
			miRectangulo.h = 4;

	
			//Invocar el metodo
			miRectangulo.CalcularAreaRect();

			// Desplegamos los datos
		
			Console.WriteLine("El área del rectángulo es ={0}", miRectangulo.area);




		}
	}
}
