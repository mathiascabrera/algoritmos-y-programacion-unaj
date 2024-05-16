using System;

namespace Vectores
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Primer Ejemplo:
			
			int [] sueldo={900,1000,1500,1800,2000,3500};
			
			Console.WriteLine("La cantidad de indices en el vector Sueldo es "+sueldo.Length);
			
			for (int x = 0; x < sueldo.Length ; x++) {
				Console.WriteLine("El sueldo es: "+sueldo[x]);
			}
			
			
			Console.ReadKey();
			Console.Clear();
			
			
			//Segundo ejemplo:
			
			int cant;
			
			Console.Write("Indicar cantidad de sueldos a ingresar: ");
			
			cant=int.Parse(Console.ReadLine());
			
			double [] sueldos= new double[cant];
			
			for (int i = 0; i < cant; i++) {
				
				Console.Write("Ingrese el sueldo numero "+(i+1)+": ");
				sueldos[i]=double.Parse(Console.ReadLine());
				
			}
			
			for(int y=0;y<cant;y++){
				
				Console.WriteLine("El sueldo numero "+(y+1)+": "+sueldos[y]);
			}
			
			
			Console.ReadKey(true);
		}
	}
}