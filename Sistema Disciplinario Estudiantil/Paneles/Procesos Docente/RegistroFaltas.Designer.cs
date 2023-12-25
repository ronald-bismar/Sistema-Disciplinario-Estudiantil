/*
 * Created by SharpDevelop.
 * User: Windows
 * Date: 18/11/2023
 * Time: 23:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Sistema_Disciplinario_Estudiantil.Paneles.Procesos_Docente
{
	partial class RegistroFaltas
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.rjButton1 = new Sistema_Disciplinario_Estudiantil.ResourcesDesign.RJButton();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Codigo_de_Estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Faltas_Disciplinarias = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Atrasos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Inasistencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.No_Presentar_Tarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Otras = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rjButton3 = new Sistema_Disciplinario_Estudiantil.ResourcesDesign.RJButton();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// rjButton1
			// 
			this.rjButton1.AutoSize = true;
			this.rjButton1.BackColor = System.Drawing.Color.RoyalBlue;
			this.rjButton1.BackgroundColor = System.Drawing.Color.RoyalBlue;
			this.rjButton1.BorderColor = System.Drawing.Color.AliceBlue;
			this.rjButton1.BorderRadius = 10;
			this.rjButton1.BorderSize = 0;
			this.rjButton1.FlatAppearance.BorderSize = 0;
			this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rjButton1.Font = new System.Drawing.Font("Linotte-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rjButton1.ForeColor = System.Drawing.Color.White;
			this.rjButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.rjButton1.Location = new System.Drawing.Point(514, 441);
			this.rjButton1.Margin = new System.Windows.Forms.Padding(0);
			this.rjButton1.Name = "rjButton1";
			this.rjButton1.Padding = new System.Windows.Forms.Padding(4);
			this.rjButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.rjButton1.Size = new System.Drawing.Size(229, 41);
			this.rjButton1.TabIndex = 38;
			this.rjButton1.Text = "Salir";
			this.rjButton1.TextColor = System.Drawing.Color.White;
			this.rjButton1.UseVisualStyleBackColor = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.SystemColors.Highlight;
			this.label5.Font = new System.Drawing.Font("Linotte-Regular", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new System.Drawing.Point(185, 28);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(528, 35);
			this.label5.TabIndex = 37;
			this.label5.Text = "REGISTRO DE FALTAS DISCIPLINARIAS";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.Highlight;
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(874, 88);
			this.label1.TabIndex = 36;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Codigo_de_Estudiante,
			this.Nombre,
			this.Apellido,
			this.Faltas_Disciplinarias,
			this.Atrasos,
			this.Inasistencia,
			this.No_Presentar_Tarea,
			this.Otras});
			this.dataGridView1.Location = new System.Drawing.Point(12, 115);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(839, 298);
			this.dataGridView1.TabIndex = 41;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// Codigo_de_Estudiante
			// 
			this.Codigo_de_Estudiante.HeaderText = "Codigo de Estudiante";
			this.Codigo_de_Estudiante.Name = "Codigo_de_Estudiante";
			// 
			// Nombre
			// 
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			// 
			// Apellido
			// 
			this.Apellido.HeaderText = "Apellido";
			this.Apellido.Name = "Apellido";
			// 
			// Faltas_Disciplinarias
			// 
			this.Faltas_Disciplinarias.HeaderText = "Cantidad de Indisciplinas";
			this.Faltas_Disciplinarias.Name = "Faltas_Disciplinarias";
			// 
			// Atrasos
			// 
			this.Atrasos.HeaderText = "Atrasos";
			this.Atrasos.Name = "Atrasos";
			// 
			// Inasistencia
			// 
			this.Inasistencia.HeaderText = "Inasistencia";
			this.Inasistencia.Name = "Inasistencia";
			// 
			// No_Presentar_Tarea
			// 
			this.No_Presentar_Tarea.HeaderText = "No Presentar Tarea";
			this.No_Presentar_Tarea.Name = "No_Presentar_Tarea";
			// 
			// Otras
			// 
			this.Otras.HeaderText = "Otras";
			this.Otras.Name = "Otras";
			// 
			// rjButton3
			// 
			this.rjButton3.AutoSize = true;
			this.rjButton3.BackColor = System.Drawing.Color.RoyalBlue;
			this.rjButton3.BackgroundColor = System.Drawing.Color.RoyalBlue;
			this.rjButton3.BorderColor = System.Drawing.Color.AliceBlue;
			this.rjButton3.BorderRadius = 10;
			this.rjButton3.BorderSize = 0;
			this.rjButton3.FlatAppearance.BorderSize = 0;
			this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rjButton3.Font = new System.Drawing.Font("Linotte-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rjButton3.ForeColor = System.Drawing.Color.White;
			this.rjButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.rjButton3.Location = new System.Drawing.Point(142, 441);
			this.rjButton3.Margin = new System.Windows.Forms.Padding(0);
			this.rjButton3.Name = "rjButton3";
			this.rjButton3.Padding = new System.Windows.Forms.Padding(4);
			this.rjButton3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.rjButton3.Size = new System.Drawing.Size(223, 41);
			this.rjButton3.TabIndex = 43;
			this.rjButton3.Text = "Registrar falta";
			this.rjButton3.TextColor = System.Drawing.Color.White;
			this.rjButton3.UseVisualStyleBackColor = false;
			// 
			// RegistroFaltas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(863, 510);
			this.Controls.Add(this.rjButton3);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.rjButton1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.Name = "RegistroFaltas";
			this.Text = "RegistroFaltas";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private Sistema_Disciplinario_Estudiantil.ResourcesDesign.RJButton rjButton3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Otras;
		private System.Windows.Forms.DataGridViewTextBoxColumn No_Presentar_Tarea;
		private System.Windows.Forms.DataGridViewTextBoxColumn Inasistencia;
		private System.Windows.Forms.DataGridViewTextBoxColumn Atrasos;
		private System.Windows.Forms.DataGridViewTextBoxColumn Faltas_Disciplinarias;
		private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_de_Estudiante;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private Sistema_Disciplinario_Estudiantil.ResourcesDesign.RJButton rjButton1;
	}
}
