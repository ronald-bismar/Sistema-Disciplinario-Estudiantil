/*
 * Created by SharpDevelop.
 * User: HP VICTUS
 * Date: 18/11/2023
 * Time: 09:46 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Sistema_Disciplinario_Estudiantil.RegistroEstudiantil
{
	/// <summary>
	/// Description of Padre_Familia.
	/// </summary>
	public class Padre_Familia
	{
		protected string nombre;
		protected int telefono;
		protected string correo;
		protected Consulta Con;
		protected List<Mensaje> Mensajeria;
		
		public Padre_Familia()
		{
			nombre = "Jose Mamani";
			telefono = 1122;
			correo = "jose123@gmail.com";
		}
		
		public string Nombre{
			get{return nombre;}
			set{
				try{
					nombre = value;
				}catch(Exception){
					//Console.WriteLine("El valor ingresado nones valido");
				}
			}
		}
		public int Telefono{
			get{return telefono;}
			set{
				try{
					telefono = value;
				}catch(Exception){
					//Console.WriteLine("el valor ingresao no es valido");
				}
			}
		}
		public string Correo{
			get{return correo;}
			set{
				try{
					correo = value;
				}catch(Exception){
					//Console.WriteLine("El valor ingresap no es valido");
				}
			}
		}
	}
}
