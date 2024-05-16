using System;

namespace One_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Tabla de multiplicar : 
			
			int numero1, numero2;
			
			Console.WriteLine("Ingrese el numero de la tabla de multiplicar a desear: ");
			
			numero1=int.Parse(Console.ReadLine());
			
			Console.WriteLine("Ingrese hasta que numero desea tener la tabla: ");
			
			numero2=int.Parse(Console.ReadLine());
			
			Tabla(numero1,numero2);
			
			Console.ReadKey(true);
		}
		public static void Tabla(int numero1, int numero2, int numero3 = 0){
			
			if (numero3 > numero2) {
				
				Console.WriteLine("Final de la tabla");
				
			}else{
				Console.WriteLine(numero1 * numero3);
				Tabla(numero1,numero2,numero3=numero3+1);
			}
		}
	}
}