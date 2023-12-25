/*
 * Created by SharpDevelop.
 * User: Windows
 * Date: 18/11/2023
 * Time: 13:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sistema_Disciplinario_Estudiantil
{
	public partial class IngresarComo : Form
	{
		public IngresarComo()
		{
			InitializeComponent();
			
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Registros.FormDocente Form = new Registros.FormDocente();
			this.Hide();
			Form.ShowDialog();
			this.Show();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Registros.FormPadre Form = new Registros.FormPadre();
			this.Hide();
			Form.ShowDialog();
			this.Show();
		}
	}
}
