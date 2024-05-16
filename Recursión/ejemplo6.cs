using System;
using System.Collections;

namespace Four_4
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Implemente una función recursiva que reciba una colección  de nombres y retorne el porcentaje de nombre con longitud menor a 5
			
			ArrayList Nombres = new ArrayList() {"Mathias","Alan","Rocio","Ricardo","Jossie","Giselle","Ramon","Sebastian","Mathias","Ronald"};
			
//			Console.WriteLine(Nombres.Count);
			
			int s = Contador(Nombres);
			
			Console.WriteLine("El porcentaje de nombres con longitud menor a 5 es el {0}%",s);

			Console.ReadKey(true);
		}
		
		public static int Contador(ArrayList a, int posicion = 0, int vuelta = 0, int numero = 0){
			
			if (vuelta < a.Count) {
				if (Convert.ToString(a[posicion]).Length < 5) {
					return Contador(a,posicion=posicion+1,vuelta=vuelta+1,numero=numero+1);
				}else{
					return Contador(a,posicion=posicion+1,vuelta=vuelta+1,numero);
				}
				
			}else{
				return (numero * 100 / a.Count);
			}
		}
	}
}