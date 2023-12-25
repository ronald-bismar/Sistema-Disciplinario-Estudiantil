using System;
using System.Collections.Generic;

namespace Sistema_Disciplinario_Estudiantil.RegistroEstudiantil
{

	public class Docente: Trabajador
	{
		private string materia;
		private List<Mensaje> Mensajeria = new List<Mensaje>();
		public Docente():base()
		{
			materia = "Matematicas";
			
		}
		public string Materia{
			get{return materia;}
			set{
				try{
					materia = value;
				}catch (Exception){
					//Console.WriteLine("El valor ingresado no es valido");
				}
			}
		}
		public List<Mensaje>  Men{
			get{return Mensajeria;}
			set{
				try{
					Mensajeria = value;
				}catch (Exception){
					//Console.WriteLine("El valor ingresado no es valido");
				}
			}
		}
	}
}
