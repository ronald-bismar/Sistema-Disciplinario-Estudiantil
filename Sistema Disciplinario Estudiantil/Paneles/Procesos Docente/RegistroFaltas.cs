using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sistema_Disciplinario_Estudiantil.Paneles.Procesos_Docente
{
	public partial class RegistroFaltas : Form
	{
		public RegistroFaltas()
		{
			InitializeComponent();
			
			llenarDatos();
			
		}
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
		public void llenarDatos(){
			Sistema_Disciplinario_Estudiantil.RegistroEstudiantil.Curso curso = Sistema_Disciplinario_Estudiantil.RegistroEstudiantil.Curso.InstanciaCurso;
			for (int i = 0; i < 8; i++) {
				dataGridView1.Rows.Add(i,curso.ESTUDIANTES[i].Nombre,curso.ESTUDIANTES[i].Apellido,curso.ESTUDIANTES[i].Fd.Count,i+2,i+3,i+2 );
			}
		}
	}
	
}
