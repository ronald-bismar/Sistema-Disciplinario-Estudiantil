using System.Collections.Generic;
namespace Sistema_Disciplinario_Estudiantil.RegistroEstudiantil
{
	public class Estudiante: Persona
	{
		protected string matricula;
		protected List<Falta_Diciplinaria> fd;
		protected Curso cu = new Curso();
		protected Padre_Familia pf = new Padre_Familia();
		
		public Estudiante(): base()
		{
			fd = new List<Falta_Diciplinaria>();
			matricula = "11-AA";
			int cant_faltas = 3;
			for(int i = 0; i < cant_faltas; i++){
				Falta_Diciplinaria fdi = new Falta_Diciplinaria();
				fd.Add(fdi);
			}
		}
		public string Matricula{
			get{return matricula;}
			set{matricula = value;}
		}
		public List<Falta_Diciplinaria> Fd {
			get{return fd;}
			set{
				fd = value;
			}
		}
	}
}
