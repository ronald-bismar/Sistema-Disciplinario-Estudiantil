using System;

namespace Sistema_Disciplinario_Estudiantil.RegistroEstudiantil
{
	public class Trabajador: Persona
	{
		protected string item;
		protected double sueldo;
		protected string turno;
		
		public Trabajador(): base()
		{
			item = "123";
			sueldo = 2000;
			turno = "tarde";
		}
		public string Item{
			get{return item;}
			set{
				try{
					item = value;
				}catch(Exception){
					//Console.WriteLine("El valor ingresado no es valido");
				}
			}
		}
		public double Sueldo{
			get{return sueldo;}
			set{
				try{
					sueldo = value;
				}catch (Exception){
					//Console.WriteLine("El valor ingresado no es valido");
				}
			}
		}
		public string Turno{
			get{return turno;}
			set{
				try{
					turno = value;
				}catch(Exception){
					//Console.WriteLine("El valor ingresado no es valido");
				}
			}
		}
	}
}
