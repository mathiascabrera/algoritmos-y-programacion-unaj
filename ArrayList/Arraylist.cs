using System;
using System.Collections;

namespace Aprendiendo_ArrayList
{
	class Program
	{
		public static void Main(string[] args)
		{
			ArrayList palabras = new ArrayList(5){1,2,"Hola",4};
			Console.WriteLine(palabras.Count);//Imprime la cantidad de elementos que tiene el ArrayList
			
			Console.WriteLine("Estamos aqui");
			
			double a=46;
			palabras.Add(a);//Agrega el contenido de la variable a en el Arraylist
			Console.WriteLine(palabras.Count);
			
			Console.WriteLine("Imprimo el contenido de la variable A en el Arraylist: "+palabras[4]);
			
			int [ ] vec = new int [ ] {1,2,3,4,5,6,7};
			palabras.AddRange(vec);// agrega todos los elementos de vec
			palabras.Insert(4, "Desplazado");// desplaza elementos
			Console.WriteLine("Reemplazo el contenido de la variable a por 'Desplazado:   '"+palabras[4]);
			
			Console.WriteLine("A continuacion imprimiremos todos los elementos del Arraylist: ");
			
			int b = palabras.Count;
			for (int i = 0; i < b; i++) {
				Console.WriteLine(palabras[i]);
			}
			
			Console.ReadKey(true);
		}
	}
}