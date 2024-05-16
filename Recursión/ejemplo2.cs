/*
 * Creado por SharpDevelop.
 * Usuario: BANGHO
 * Fecha: 8/6/2021
 * Hora: 14:35
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Two_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			// 2 - Buscar un elemento de un array de forma recursiva.
			
			//La idea de este proyecto es buscar la posicion de un elemento dentro de un array
			
			
			int[] array = {1,2,3,4,5};
			
			int elementobuscar = 4;
			
			int pos = PosicionElementoRecursivo(array,elementobuscar,0);
			
			Console.WriteLine(pos);
			
			Console.ReadKey(true);
		}
		
		public static int PosicionElementoRecursivo(int[] array,int elementobuscar, int indice){
			if (indice == array.Length) {
				//el cuerpo de este if se va a ejecutar cuando indice se igual a la cantidad de elementos del array
				return -1;
				//Retornamos -1 porque el elemento buscado no se ha encontrado en el array.
			}else if (array[indice] == elementobuscar) {
				return indice;
			}else{
				return PosicionElementoRecursivo(array, elementobuscar,indice+1);
			}
		}
	}
}
			
		
	
