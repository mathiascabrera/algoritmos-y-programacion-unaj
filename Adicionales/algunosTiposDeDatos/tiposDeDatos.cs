using System;

namespace Parte_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			byte edad;
			int sueldo;
			/*Esta es la forma en que se declara una variable.
			 * forma: "Tipo de dato" + Nombre de la variable.
			 * En este caso "byte" va de 0 hasta 255.
			 * Existe una tabla donde podemos buscar estos valores.
			 */ 
			
			edad=36;
			sueldo=2500;
			
			Console.WriteLine("Mi sueldo es "+sueldo);
			Console.WriteLine("Yo tengo "+edad+" años.");
			
			/*Otra forma que resulta ser mucho mas sencillo es la siguiente */
			
			byte años = 4; int curso = 5;
			
			Console.WriteLine(años);
			Console.WriteLine(curso);
			
			/* Double es para introducir numeros con coma */
			double altura = 65.9; double peso = 67.9;
			
			
			Console.WriteLine("MI altura es "+altura+" y mi peso es "+peso);
			
			string nombre = "Mathias" ; string apellido="Cabrera";
			
			Console.WriteLine("Mi nombre es "+nombre+" y mi apellido es "+apellido);
			
			bool Estudia;
			
			/* BOOL ES EL LOGICO QUE TIRA TRUE O FALSE */
			
			Estudia= true;
			
			Console.WriteLine("ESTUDIAS? "+Estudia);
			
			
			
			dynamic variable_dinamica;
			
			/*Dynamic sirve para darle el tipo de dato a la variable segun sea la informacion que se ingrese en dicha variable.*/
			
			
			variable_dinamica=250;
			Console.WriteLine("Variable dinamica: "+variable_dinamica);
			
			
			const double doc = 123456;
			
			/*El CONST sirve para que una variable no cambie la informacion que contenga*/
			
			Console.WriteLine("Mi numero de documento es "+doc);
			
			Console.ReadKey(true);
		}
	}
}