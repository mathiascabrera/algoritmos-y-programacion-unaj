using System;

namespace Parte_4
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*Veremos los operadores logicos
			 * &&  significa y
			 * ||  significa ó
			 * !  significa no de negacion
			 */
			int a, b, c, d;
			a=10;
			b=25;
			c=45;
			d=42;
			
			Console.WriteLine("CONSULTA OPERADOR AND  a<b y c>d? "+((a<b) && (c>d)));
			
			Console.WriteLine("CONSULTA OPERADOR OR  a<b o c>d? "+((a<b) || (c>d)));
			
			Console.WriteLine("CONSULTA OPERADOR NEGACION  a<b?  "+(!(a<b)));
			
			
			
			/* Metodo de ENTRADA y SALIDA:			
			 * 
			 * AHORA VEREMOS COMO GUARDAR INFORMACION EN UNA VARIABLE VACIA.
			 */
			
			string nombre;
			
			Console.Write("Nombre: ");
			
			nombre= Console.ReadLine();
		
			Console.WriteLine("Su nombre es "+nombre);
			
			/* EL "console.ReadLine" SOLO SIRVE PARA INGRESAR CADENA DE TEXTO A UNA VARIABLE.
			 * POR LO QUE SI INTENTAMOS INGRESAR DE ESTA MANERA UN VALOR INT A UNA VARIABLE DARIA ERROR.
			 * A CONTINUACION VEREMOS DOS METODOS QUE RESUELVEN ESTE INCONVENIENTE.
			 */
			
			int edad;
			
			Console.Write("Ingrese su edad: ");
			
			edad=int.Parse(Console.ReadLine());
			/*ESTO DE AQUI ARRIBA ES EL PRIMER METODO PARA CONVERTIR DE STR A INT*/
			
			Console.WriteLine("Tu edad es "+edad);
			
			
			/*AHORA VEREMOS OTRO METODO PARA CONVERTIR DE STR A INT*/
			
			byte peso;
			
			Console.Write("Tu peso es: ");
			
			peso=Convert.ToByte(Console.ReadLine());
			/*ESTO DE AQUI ARRIBA ES EL SEGUNDO METODO PARA CONVERTIR. EN ESTE CASO CONVERTIMOS UN STR A BYTE.*/
			
			Console.WriteLine("tu peso es "+peso);
			
	
			Console.ReadKey(true);
		}
	}
}