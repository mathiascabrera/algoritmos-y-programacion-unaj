using System;

namespace Three_3
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Ejemplo 1 : Recorrer un arreglo
			
			int[] arregloEnteros = new int[] {1,2,3,4,5};
			
			Console.WriteLine("Recorrido de Array: ");
			
			Recorrer(arregloEnteros);
			
			
			//Ejemplo 2 : Sumatoria de un arreglo
			
			Console.WriteLine("Suma de los elementos del Array: ");
			
			int total=Sumar(arregloEnteros);
			
			Console.WriteLine(total);
			
			
			Console.ReadKey(true);
		}
		
		
		public static void Recorrer(int [] arreglo, int posicion = 0){
			
			
			if (posicion == arreglo.Length) {
				return;
			}else{
				Console.WriteLine(arreglo[posicion]);
				Recorrer(arreglo,posicion+1);
			}
		}
		
		public static int Sumar(int [] arreglo, int posicion = 0){
			if (posicion == arreglo.Length) {
				return 0;
			}
			
			return arreglo[posicion] + Sumar(arreglo,posicion+1);
		}
		
	}
}