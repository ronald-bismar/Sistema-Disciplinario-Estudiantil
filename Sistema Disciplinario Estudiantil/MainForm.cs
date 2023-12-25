/*
 * Created by SharpDevelop.
 * User: Windows
 * Date: 18/11/2023
 * Time: 11:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Sistema_Disciplinario_Estudiantil
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		// Función para hacer el botón redondeado
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			// 
			Sistema_Disciplinario_Estudiantil.RegistroEstudiantil.Curso curso = Sistema_Disciplinario_Estudiantil.RegistroEstudiantil.Curso.InstanciaCurso;
			
			
			//Llenar datos de ejemplo
			 string[] nombres = { "Juan", "Ana", "Carlos", "Maria", "David", "Laura", "Luis", "Elena", "Pedro", "Sofia" };
            string[] apellidos = { "Gomez", "Rodriguez", "Martinez", "Perez", "Fernandez", "Lopez", "Diaz", "Torres", "Ramirez", "Hernandez" };
            int [] carnets = {12345, 15432, 56789, 23456, 98765, 34567, 67890, 45678, 78901, 12344};
            string [] fechas_de_nacimiento = {"1980-01-01","1990-02-02","2000-03-03","2010-04-04","2020-05-05","2030-06-06","2040-07-07","2050-08-08","2060-09-09","2060-09-09"};
			for (int i = 0; i < 10; i++) {
				Sistema_Disciplinario_Estudiantil.RegistroEstudiantil.Estudiante E = new Sistema_Disciplinario_Estudiantil.RegistroEstudiantil.Estudiante();
				E.Nombre = nombres[i];
				E.Apellido = apellidos[i];
				E.Ci = carnets[i];
				E.Fecha_Nac = fechas_de_nacimiento[i];
				curso.ESTUDIANTES.Add(E);
			}
			
			IngresarComo I = new IngresarComo();
			this.Hide();
			I.ShowDialog();
			this.Show();
		}
	}
}
