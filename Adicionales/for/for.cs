using System;

namespace For
{
	class Program
	{
		public static void Main(string[] args)
		{
			//conteo del 0 al 20 inclusive
			int conteo;
			Console.WriteLine("Primer for: ");
			for (conteo=0; conteo<=20; conteo++) {
				/* primero definimos la variable a evaluar
				 * luego va la condicion
				 * y el incremento o decremento de la variable a evaluar.
				 */ 
				Console.WriteLine("El valor de la variable conteo es "+conteo);
			}
			Console.ReadKey(true);
			Console.Clear();
			Console.WriteLine("Segundo for: ");
			
			for (int i = 0; i < 10; i++) {
				Console.WriteLine(i);
			}
			Console.ReadKey(true);
		}
	}
}