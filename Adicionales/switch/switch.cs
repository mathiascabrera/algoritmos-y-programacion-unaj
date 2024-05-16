using System;

namespace Switch
{
	class Program
	{
		public static void Main(string[] args)
		{
			int dia;
			
			Console.Write("indica el dia de la semana en numero: ");
			dia=int.Parse(Console.ReadLine());
			
			switch (dia){
				case 1:
					Console.WriteLine("Lunes");
					break;
					/*EL break ES PARA QUE SALGA DEL CUERPO DEL switch.*/
				case 2:
					Console.WriteLine("Martes");
					break;
				case 3:
					Console.WriteLine("Miercoles");
					break;
				case 4:
					Console.WriteLine("Jueves");
					break;
				case 5:
					Console.WriteLine("Viernes");
					break;
				case 6:
					Console.WriteLine("Sabado");
					break;
				case 7:
					Console.WriteLine("Domingo");
					break;
				default:
					Console.WriteLine("Valor ingresado no valido");
					break;
					/*El default SE EJECUTA CUANDO EL VALOR INGRESADO NO ESTA EN NUESTRA LISTA DE EVALUACION.*/
					
			}
			
			
			Console.ReadKey(true);
		}
	}
}