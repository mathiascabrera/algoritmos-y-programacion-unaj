using System;
using System.Collections.Generic;

namespace While
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Primer ejemplo:
			int numero;
			numero=0;
			while (numero<=10) {
				Console.WriteLine("Numero es igual a "+numero);
				numero++;
			}
			
			
			Console.ReadKey();
			Console.Clear();
			
			
			//Segundo ejemplo:
			
			List<int> numeros = new List<int>();
			
			string opciones = "Presione 1 para ingresar numeros o 0 para finalizar: ";
			
			Console.WriteLine(opciones);
			int valor = int.Parse(Console.ReadLine());
			
			 while (valor!=0) {
				Console.WriteLine("Ingrese un numero: ");
				numeros.Add(Convert.ToInt32(Console.ReadLine()));
				
				Console.WriteLine(opciones);
				valor = int.Parse(Console.ReadLine());
			}
			
			Console.ReadKey();
			Console.Clear();
			
			Console.WriteLine("Los valores ingresados son los siguientes: ");
			
			foreach (var elemento in numeros) {
				Console.WriteLine(elemento);
			}
			
			Console.ReadKey(true);
		}
	}
}