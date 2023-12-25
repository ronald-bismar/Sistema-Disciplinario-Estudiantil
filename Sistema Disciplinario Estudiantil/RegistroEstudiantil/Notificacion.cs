/*
 * Created by SharpDevelop.
 * User: HP VICTUS
 * Date: 18/11/2023
 * Time: 09:45 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Sistema_Disciplinario_Estudiantil.RegistroEstudiantil
{
	/// <summary>
	/// Description of Notificacion.
	/// </summary>
	public class Notificacion
	{
		protected int cod_notificacion;
		protected int num_remitente;
		protected string curso_estudiante;
		protected string titulo;
		protected string mensaje;
		
		public Notificacion()
		{
			
			cod_notificacion = 01;
			num_remitente = 001;
			curso_estudiante = "Secundaria";
			titulo = "Inasistencia";
			mensaje = "Hoy se falto a clases";
		}
		
		public int Cod_Notificacion{
			get{return cod_notificacion;}
			set{
				try{
					cod_notificacion = value;
				}catch(Exception){
					Console.WriteLine("El valor ingresado no es valido");
				}
			}
		}
		public int Num_Remitente{
			get{return num_remitente;}
			set{
				try{
					num_remitente = value;
				}catch(Exception){
					Console.WriteLine("El valor ingresado no es valido");
				}
			}
		}
		public string Curso_Estudiante{
			get{return curso_estudiante;}
			set{
				try{
					curso_estudiante = value;
				}catch(Exception){
					Console.WriteLine("El valor ingresado no es valido");
				}
			}
		}
		public string Mensaje{
			get{return mensaje;}
			set{
				try{
					mensaje = value;
				}catch(Exception){
					Console.WriteLine("El valor ingresado no es valido");
				}
			}
		}
	}
}
