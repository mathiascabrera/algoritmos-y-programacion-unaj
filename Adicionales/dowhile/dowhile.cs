using System;

namespace Do_While
{
	class Program
	{
		public static void Main(string[] args)
		{
			int numero;
			numero=95;
			
			do{
				/*el do si o si se ejecutara una vez y luego se ejecutara el while si la condicion se cumple.*/
				
				Console.WriteLine("El valor de numero es "+numero);
				numero++;
	
			}while (numero<99);
			
			Console.ReadKey(true);
		}
	}
}