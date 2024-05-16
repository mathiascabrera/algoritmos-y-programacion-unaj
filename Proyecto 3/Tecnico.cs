using System;

namespace Proyecto_3
{
	public class Tecnico:Persona
	{
		private int area;
		private int legajo;
		public Tecnico(string nom, string ape, int doc, int area, int legajo):base(nom, ape, doc){
			this.area=area;
			this.legajo=legajo;
		}
		public Tecnico(){}
		public int AreaSetGet{
			set{area=value;}
			get{return area;}
		}
		public int LegajoSetGet{
			set{legajo=value;}
			get{return legajo;}
		}
	}
}





