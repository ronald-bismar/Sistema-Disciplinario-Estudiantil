using System;

namespace Sistema_Disciplinario_Estudiantil.RegistroEstudiantil
{

	public class Persona
	{
		protected int ci;
		protected string nombre;
		protected string apellido;
		protected string fecha_nac;
		protected short edad;
		protected char genero;
		protected string correo;
		protected Persona()
		{
			ci = 111;
			nombre = "Zenon";
			apellido = "Tarqui";
			fecha_nac = "23/03/2010";
			edad = 14;
			genero = 'm';
			correo = "zenontarqui@gmail.com";
			
		}
		public int Ci{
			get{return ci;}
			set{
				try{
					ci = value;
				}catch (Exception){
					//Console.WriteLine("El valor ingtresado no es valido");
				}	
			}
		}
		public string Nombre{
			get{return nombre;}
			set{try{
					nombre = value;
				}catch (Exception){
					//Console.WriteLine("El valor ingresado no es valido");
				}
			}
		}
		public string Apellido{
			get{return apellido;}
			set{try {
					apellido = value;
			} catch (Exception) {
					//Console.WriteLine("El valor ingresado no es valudo");
				}		
			}
		}
		public string Fecha_Nac{
			get{return fecha_nac;}
			set{try {
					fecha_nac = value;
			} catch (Exception) {
					//Console.WriteLine("El valor ingresado no es valido");
				}
			}
		}
		public short Edad{
			get{return edad;}
			set{try {
					edad = value;
				}catch (Exception){
					//Console.WriteLine("El valor ingresado no es valido");
				}
			}
		}
		public char Genero{
			get{return genero;}
			set{try {
					genero = value;
				}catch (Exception){
					//Console.WriteLine("el valor ingresado no es valido");
				}
			}
		}
	}
}
