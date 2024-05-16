using System;
using System.Collections;

namespace Two_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			//RECORREMOS UN ARRAYLIST
			
			ArrayList Nombres = new ArrayList() {"Mathias","Alan","Ricardo","Jossie","Giselle"};
			
			Recorrer(Nombres);
			
			Console.ReadKey(true);
		}
		
		static void Recorrer(ArrayList Nombres, int posicion = 0){
			if (posicion == Nombres.Count) {
				Console.WriteLine("Final del recorrido");
			}else{
				Console.WriteLine(Nombres[posicion]);
				Recorrer(Nombres, posicion=posicion+1);
			}
		}
	}
}