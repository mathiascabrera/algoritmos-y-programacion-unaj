using System;
using System.Collections;
namespace Proyecto_3
{
	public class Empresa
	{
		private ArrayList ListaClientes;
		private ArrayList ListaTecnicos;
		public Empresa(){
			ListaClientes=new ArrayList();
			ListaTecnicos=new ArrayList();
		}
		public ArrayList GetClientes{
			get{return ListaClientes;}
		}
		public ArrayList GetTecnicos{
			get{return ListaTecnicos;}
		}
		public void AgregarCliente(Cliente a){ListaClientes.Add(a);}
		public void EliminarCliente(Cliente a){ListaClientes.Remove(a);}
		public int CantidadClientes(){return ListaClientes.Count;}
		public bool ExisteCliente(Cliente a){return ListaClientes.Contains(a);}
		public Cliente RecuperarCliente(int i){return (Cliente) ListaClientes[i];}	
		public void AgregarTecnico(Tecnico a){ListaTecnicos.Add(a);}
		public void EliminarTecnico(Tecnico a){ListaClientes.Remove(a);}
		public int CantidadTecnicos(){return ListaTecnicos.Count;}
		public bool ExisteTecnico(Tecnico a){return (bool) ListaTecnicos.Contains(a);}
		public Tecnico RecuperarTecnico(int i){return (Tecnico) ListaTecnicos[i];}
	}
}
