using System;

namespace Proyecto_3
{
	public class Cliente:Persona
	{
		private int num_cliente;
		private int plan_vigente, min_consumidos, costo, area;
		private string nom_tec;
		private DateTime fecha;//Fecha de alta
		private bool comboextra;
		public Cliente(string nom, string ape, int doc, int numcliente,int plan_vigente, int costo, int area, string nom_tec, DateTime fecha, bool comboextra):base(nom,ape, doc)
		{
			this.num_cliente=numcliente;
			this.plan_vigente=plan_vigente;
			this.min_consumidos=0;
			this.costo=costo;
			this.area=area;
			this.nom_tec=nom_tec;
			this.fecha=fecha;
			this.comboextra=comboextra;
		}
		public Cliente(){}
		public int NumClienteSetGet{
			set{num_cliente=value;}
			get{return num_cliente;}
		}
		public int PlanSetGet{
			set{plan_vigente=value;}
			get{return  plan_vigente;}
		}
		public int MinutosSetGet{
			set{min_consumidos=value;}
			get{return  min_consumidos;}
		}
		public int CostoSetGet{
			set{costo=value;}
			get{return costo;}
		}
		public int AreaSetGet{
			set{area=value;}
			get{return area;}
		}
		public string NomTecSetGet{
			set{nom_tec=value;}
			get{return  nom_tec;}
		}
		public DateTime FechaSetGet{
			set{fecha=value;}
			get{return  fecha;}
		}
		public bool ComboExtraSetGet{
			set{comboextra=value;}
			get{return  comboextra;}
		}
	}
}
