using System;

namespace Sistema_Disciplinario_Estudiantil.RegistroEstudiantil
{
	public class Falta_Diciplinaria
	{
		protected string cod_falta;
		protected string descripcion;
		protected string fecha_falta;
		protected string gravedad_falta;
		protected Notificacion Not;
		
		public Falta_Diciplinaria()
		{
			cod_falta = "f-01";
			descripcion = "No ingreso a clases";
			fecha_falta = "05/03/2023";
			gravedad_falta = "Grave";
		}
		
		public string Cod_Falta{
			get{return cod_falta;}
			set{
				try{
					cod_falta = value;
				}catch(Exception){
					//Console.WriteLine("El valor ingresado no es valido");
				}
			}
		}
		public string Descripcion{
			get{return descripcion;}
			set{
				try{
					descripcion = value;
				}catch(Exception){
					//Console.WriteLine("el valor ingresado no es valido");
				}
			}
		}
		public string Fecha_Falta{
			get{return fecha_falta;}
			set{
				try{
					fecha_falta = value;
				}catch(Exception){
					Console.WriteLine("El valor ingresado no es valido");
				}
			}
		}
		public string Gravedad_Falta{
			get{return gravedad_falta;}
			set{
				try{
					gravedad_falta = value;
				}catch(Exception){
					Console.WriteLine("El valor ingresado no es valido");
				}
			}
		}
	}
}
