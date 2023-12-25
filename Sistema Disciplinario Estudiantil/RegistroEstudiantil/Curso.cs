using System;using System.Collections.Generic;
namespace Sistema_Disciplinario_Estudiantil.RegistroEstudiantil
{
	public class Curso
	{
		private short nivel;
		private string paralelo;
		private List <Estudiante>E;
		private List <Docente>D;
		private static Curso instanciaCurso;

        public static Curso InstanciaCurso
        {
            get
            {
                if (instanciaCurso == null)
                {
                    instanciaCurso = new Curso();
                }
                return instanciaCurso;
            }
        }

		public Curso()
		{
			E = new List<Estudiante>();
			D = new List<Docente>();
		}
		public short Nivel{
			get{return nivel;}
			set{
				try{
					nivel = value;
				}catch (Exception){
					//Console.WriteLine("El valor ingresado no es valido");
				}
			}
		}
		public string Paralelo{
			get{return paralelo;}
			set{
				try{
					paralelo = value;
				}catch (Exception){
					//Console.WriteLine("El valor ingresado no es valido");
				}
			}
		}
		public List<Estudiante>ESTUDIANTES{
			get{return E;}
			set{
				try{
					E = value;
				}catch (Exception){
					//Console.WriteLine("El valor ingresando no es valido");
				}
			}
		}
		public List<Docente>DOCENTES{
			get{return D;}
			set{
				try{
					D = value;
				}catch (Exception){
					//Console.WriteLine("El valor ingresando no es valiudo");
				}
			}
		}
	}
}
