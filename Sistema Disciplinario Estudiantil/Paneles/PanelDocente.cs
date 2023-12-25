/*
 * Created by SharpDevelop.
 * User: Windows
 * Date: 18/11/2023
 * Time: 14:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sistema_Disciplinario_Estudiantil.Paneles
{
	/// <summary>
	/// Description of PanelDocente.
	/// </summary>
	public partial class PanelDocente : Form
	{
		public PanelDocente()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Label3Click(object sender, EventArgs e)
		{
			
		}
		
		void RjButton4Click(object sender, EventArgs e)
		{
			
		}
		void RjButton2Click(object sender, EventArgs e)
		{
		Procesos_Docente.RegistroFaltas I = new Procesos_Docente.RegistroFaltas();
			this.Hide();
			I.ShowDialog();
			this.Show();
		}
		void RjButton1Click(object sender, EventArgs e)
		{
		Procesos_Docente.NotificacionesEnviadas I = new Procesos_Docente.NotificacionesEnviadas ();
			this.Hide();
			I.ShowDialog();
			this.Show();
		}
		void RjButton6Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
