/*
 * Creado por SharpDevelop.
 * Usuario: BANGHO
 * Fecha: 5/6/2021
 * Hora: 16:01
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace dos
{
	class Program
	{
		public static void Main(string[] args)
		{
			DateTime fecha=DateTime.Today;
			
			Console.WriteLine(fecha.ToShortDateString());
			
			Console.WriteLine(fecha.Month);
			
			int mes = Convert.ToInt32(fecha.Month);
			
			Console.WriteLine("Mes {0}",mes);
			
			string fechastr = Convert.ToString(fecha.ToShortDateString());
			
			Console.WriteLine(fechastr);
			
			DateTime r= Convert.ToDateTime(fechastr);
			
			Console.WriteLine("r "+r);
			
			
			Console.ReadKey();
		}
	}
}