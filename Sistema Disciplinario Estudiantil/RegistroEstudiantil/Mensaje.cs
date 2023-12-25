using System;

namespace Sistema_Disciplinario_Estudiantil.RegistroEstudiantil
{

	public class Mensaje
	{
		protected string nombre_emisor;
		protected string nombre_receptor;
		protected string titulo;
		protected string cuerpo_mensaje;
		
		public Mensaje()
		{
			nombre_emisor = "Jose";
			cuerpo_mensaje = "";
		}
		
		public string Nom_Emisor{
			get{return nombre_emisor;}
			set{
				try{
					nombre_emisor = value;
				}catch(Exception){
					//Console.WriteLine("El valor ingresado no es valido");
				}
			}
		}
		public string Cuerp_Mensaje{
			get{return cuerpo_mensaje;}
			set{
				try{
					cuerpo_mensaje = value;
				}catch(Exception){
					//Console.WriteLine("El valor ingresado no es valido");
				}
			}
		}
	}
}
