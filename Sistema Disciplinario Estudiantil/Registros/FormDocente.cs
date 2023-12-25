
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sistema_Disciplinario_Estudiantil.Registros
{
	public partial class FormDocente : Form
	{
		public FormDocente()
		{
			InitializeComponent();
			
		}
		
		void Label4Click(object sender, EventArgs e)
		{
			
		}
		void BtnIngresarClick(object sender, EventArgs e)
		{
			Sistema_Disciplinario_Estudiantil.RegistroEstudiantil.Curso curso = Sistema_Disciplinario_Estudiantil.RegistroEstudiantil.Curso.InstanciaCurso;
		
			Sistema_Disciplinario_Estudiantil.RegistroEstudiantil.Docente D = new Sistema_Disciplinario_Estudiantil.RegistroEstudiantil.Docente();
		
			D.Nombre = txtNombreD.Text;
			D.Apellido = txtApellidoD.Text;
			D.Ci = Convert.ToInt32(txtCID.Text);
			D.Item = txtItemD.Text;
			D.Materia = txtMateria.Text;
			curso.DOCENTES.Add(D);
			
            MessageBox.Show("Los datos del docente se ingresaron correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
			
			Paneles.PanelDocente I = new Paneles.PanelDocente();
			this.Hide();
			I.ShowDialog();
			this.Show();
		}
	}
}
