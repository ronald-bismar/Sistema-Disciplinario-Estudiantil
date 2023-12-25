using System;

namespace Sistema_Disciplinario_Estudiantil.RegistroEstudiantil
{
	/// <summary>
	/// Description of Consulta.
	/// </summary>
	public class Consulta
	{
		protected string materia;
		protected string desempenio;
		protected string comportamiento;
		
		public Consulta()
		{
			materia = "Matematicas";
			desempenio = "Regular";
			comportamiento = "Indiciplinado";
		}
		
		public string Materia{
			get{return materia;}
			set{
				try{
					materia = value;
				}catch(Exception){
					//Console.WriteLine("El valor ingresado no es valido");
				}
			}
		}
		public string Desempenio{
			get{return desempenio;}
			set{
				try{
					desempenio = value;
				}catch(Exception){
					//Console.WriteLine("El valor ingresado no es valido");
				}
			}
		}
		public string Comportamiento{
			get{return comportamiento;}
			set{
				try{
					desempenio = value;
				}catch(Exception){
					//Console.WriteLine("El valor ingresado no es valido");
				}
			}
		}
	}
}
