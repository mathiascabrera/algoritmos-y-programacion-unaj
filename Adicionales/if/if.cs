using System;

namespace IF
{
	class Program
	{
		public static void Main(string[] args)
		{
			int edad;
			Console.Write("Ingrese su edad: ");
			edad=int.Parse(Console.ReadLine());
			
			if (edad<=10){
				Console.WriteLine("Sos un niño.");	
				
			}else if (edad<=17){
				Console.WriteLine("Sos un joven");
				
			}else if (edad<=50){
				Console.WriteLine("Sos un adulto");
				
			}else{
				Console.WriteLine("Sos un adulto mayor");
			}
			Console.ReadKey(true);
		}
	}
}