using System;

namespace Matrices
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			//Primer ejemplo
			
			string [,] matriz1=new string[3,2];
			//3 columnas y 2 filas
			
			matriz1[0,0]="Mathias";
			//Esto es para añadir contenido en la columna 0 y en la fila 0 del vector.
			
			Console.WriteLine("Imprimimos columna 0, fila 0 del vector: "+matriz1[0,0]);
			
			matriz1[0,1]="Cabrera";
			
			Console.WriteLine("Imprimimos columna 0, fila 1 del vector: "+matriz1[0,1]);
			
			
			Console.ReadKey();
			Console.Clear();
			
			
			//Segundo ejemplo
			
			int filas, columnas;
			
			Console.Write("indicar cantidad de filas de matriz: ");
			filas=int.Parse(Console.ReadLine());
			
			Console.Write("indicar cantidad de columnas de matriz: ");
			columnas=int.Parse(Console.ReadLine());
			
			string [,] matriz1=new string[filas,columnas];
			
			Console.WriteLine("Mantenimiento de datos para la matriz..");
			
			for (int x = 0; x < filas; x++) {
				
				for (int y = 0; y < columnas; y++) {
					
					Console.Write("introduce el dato ["+x+","+y+"] :");
					matriz1[x,y]=Console.ReadLine();
				}
			}
			
			Console.ReadKey(true);
		}
	}
}