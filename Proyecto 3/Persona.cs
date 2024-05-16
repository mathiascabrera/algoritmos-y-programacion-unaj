using System;

namespace Proyecto_3
{
	public class Persona
	{
		protected string nombre, apellido;
		protected int documento;
		public Persona(string nom, string ape, int doc)
		{
			this.nombre=nom;
			this.apellido=ape;
			this.documento=doc;
		}
		public Persona(){}
		public string NombreSetGet{
			set{nombre=value;}
			get{return nombre;}
		}
		public string ApellidoSetGet{
			set{apellido=value;}
			get{return apellido;}
		}
		public int DocumentoSetGet{
			set{documento=value;}
			get{return documento;}
		}
		public void Impresion(){
			Console.WriteLine("Los datos ingresados son los siguientes:" +
			                  "Nombre y Apellido: {0} {1}." +
			                  "Documento: {2}.",nombre,apellido,documento);
		}
	}
}
