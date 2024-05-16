using System;

namespace One_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Ejercicios planteados:
			// 1 - Recorrer un array de forma recursiva
			// 2 - Buscar un elemento de un array de forma recursiva. Este lo Haremos en el proyecto TWO 2
			
			// 1 -
			
			int[] Array={1,2,3,4,5};
			
			Console.WriteLine("Longitud del array {0}",Array.Length);
			
			Console.WriteLine("Recursion 1");
			
			MostrarArrayRecursivo(Array,0);
			
			
			Console.WriteLine("Recursion 2");
			
			MostrarArrayRecursivo_2(Array,0);
			
			Console.ReadKey(true);
		}
		
		//Una de las formas de realizar el primer ejercicio es de la siguiente manera :
		
		public static void MostrarArrayRecursivo (int[] Array , int indice){
			
			if (indice == (Array.Length - 1)) {
				Console.WriteLine(Array[indice]);
			}else{
				Console.WriteLine(Array[indice]);
				MostrarArrayRecursivo(Array, indice +1);
			}
		}
		
		//Otra seria:
		
		public static void MostrarArrayRecursivo_2 (int[] Array , int indice){
			
			if (indice != Array.Length) {
				Console.WriteLine(Array[indice]);
				MostrarArrayRecursivo_2(Array, indice +1);
			}
		}
	}
}