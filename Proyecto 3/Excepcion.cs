using System;

namespace Proyecto_3
{
	public class ExcepcionDocumento : Exception
	{
		public int documento;
		public ExcepcionDocumento(int documento){this.documento=documento;}
	}
	public class ExcepcionPlan : Exception{
		public int numero;
		public ExcepcionPlan (int valor){this.numero=valor;}
	}
	public class ExcepcionArea : Exception{
		public int numero;
		public ExcepcionArea (int numero){this.numero = numero;}
	}
	public class ExcepcionAreaTecnico : Exception{
		public string area;
		public ExcepcionAreaTecnico(string area){this.area = area;}
	}
	public class ExcepcionDia : Exception{
		public int numero;
		public ExcepcionDia (int numero){this.numero= numero;}	
	}
	public class ExcepcionMes : Exception{
		public int numero;
		public ExcepcionMes (int numero){this.numero= numero;}
	}
	
	public class ExcepcionAño : Exception{
		public int numero;
		public ExcepcionAño (int numero){this.numero= numero;}
	}
	public class ExcepcionFueraDeTiempo : Exception{}
	
	public class ExcepcionCupoInsuficiente : Exception{}	
	
	public class ExcepcionClienteExistente : Exception{
		public string nombre;
		public ExcepcionClienteExistente(string nombre){this.nombre = nombre;}
	}
	public class ExcepcionClienteInexistente : Exception{
		public int numero;
		public ExcepcionClienteInexistente(int numero){this.numero = numero;}
	}
	public class ExcepcionNumCliente : Exception{
		public int numero;
		public ExcepcionNumCliente (int numero){this.numero= numero;}
	}
	public class ExcepcionMinutos : Exception{
		public int numero;
		public ExcepcionMinutos (int numero){this.numero= numero;}
	}
	public class ExcepcionNumLegajo : Exception{
		public int numero;
		public ExcepcionNumLegajo (int numero){this.numero= numero;}
	}
	public class ExcepcionTecnicoExistente : Exception{
		public string nombre;
		public ExcepcionTecnicoExistente(string nombre){this.nombre = nombre;}
	}
	public class ExcepcionCosto : Exception{
		public int numero;
		public ExcepcionCosto(int numero){this.numero= numero;}
	}
}
