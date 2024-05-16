using System;

namespace Parte_3
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*Veremos OPERADORES ARITMETICOS
			 * Suma +
			 * Resta -
			 * Multiplicacion *
			 * Division /
			 * Modulo residuo %
			 * incremento en 1  ++
			 * decremento en 1  --
			 */
			int a, b;
				a=5;
				b=15;
				Console.WriteLine("La suma de "+a+"+"+b+" es= "+(a+b));
				
				Console.WriteLine("La resta de "+a+"-"+b+" es= "+(a-b));
				
				Console.WriteLine("La multiplicacion de "+a+"x"+b+" es= "+(a*b));
				
				Console.WriteLine("La division de "+a+"/"+b+" es= "+(a/b));
				
				Console.WriteLine("El residuo de "+a+"/"+b+" es= "+(a%b));
				
				Console.WriteLine("El incremento de 1 ++ "+(++a));
				
				Console.WriteLine("El decremento de 1 ++ "+(--b));
				
				/*Ahora veremos los operadores relacionales
			 * < menor que
			 * >mayor que
			 * <= menor o igual que
			 * >= mayor o igual que
			 * == igual a 
			 * != distinto que
			 */
			
			int numa, numb, numcc;
			bool operacion;
			
			numa=15;
			
			numb=35;
			
			numcc=2;
			
			Console.WriteLine("El valor de a es mayor que b?  "+(numa>numb));
			
			/*Esto ultimo que imprime va a tirar TRUE o FALSE.*/
			
			operacion= numa<numb;
			
			Console.WriteLine("Resultado de la variable operacion: "+operacion);
			
			Console.ReadKey(true);
		}
	}
}