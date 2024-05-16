using System;

namespace Crear_metodos
{
	class Program
	{
		public static void Main(string[] args)
		{
			agregarDatos();//activamos el metodo que hemos creado abajo.
			
			
			Console.ReadKey(true);
		}
		//Desde este punto vamos a crear metodos adicionales.
		public static void agregarDatos(){
			string nombre, apellido;
			Console.Write("Ingresa tu nombre: ");
			nombre=Console.ReadLine();
			
			Console.Write("Ingresa tu apellido: ");
			apellido=Console.ReadLine();
			
			Console.WriteLine("Tu nombre y apellido son: "+nombre+" "+apellido);
		}
	}
}