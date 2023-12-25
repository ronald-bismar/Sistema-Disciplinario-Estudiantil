/*
 * Created by SharpDevelop.
 * User: Windows
 * Date: 19/11/2023
 * Time: 00:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Sistema_Disciplinario_Estudiantil.Paneles.Procesos_Docente
{
	partial class NotificacionesEnviadas
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
			this.rjButton3 = new Sistema_Disciplinario_Estudiantil.ResourcesDesign.RJButton();
			this.rjButton1 = new Sistema_Disciplinario_Estudiantil.ResourcesDesign.RJButton();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.CodigoFalta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CABECERA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
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
			this.rjButton3.Location = new System.Drawing.Point(143, 445);
			this.rjButton3.Margin = new System.Windows.Forms.Padding(0);
			this.rjButton3.Name = "rjButton3";
			this.rjButton3.Padding = new System.Windows.Forms.Padding(4);
			this.rjButton3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.rjButton3.Size = new System.Drawing.Size(223, 41);
			this.rjButton3.TabIndex = 60;
			this.rjButton3.Text = "Registrar falta";
			this.rjButton3.TextColor = System.Drawing.Color.White;
			this.rjButton3.UseVisualStyleBackColor = false;
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
			this.rjButton1.Location = new System.Drawing.Point(515, 445);
			this.rjButton1.Margin = new System.Windows.Forms.Padding(0);
			this.rjButton1.Name = "rjButton1";
			this.rjButton1.Padding = new System.Windows.Forms.Padding(4);
			this.rjButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.rjButton1.Size = new System.Drawing.Size(229, 41);
			this.rjButton1.TabIndex = 59;
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
			this.label5.Location = new System.Drawing.Point(243, 44);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(399, 35);
			this.label5.TabIndex = 58;
			this.label5.Text = "NOTIFICACIONES ENVIADAS";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.Highlight;
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(-5, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(874, 88);
			this.label1.TabIndex = 57;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.CodigoFalta,
									this.CABECERA,
									this.Descripcion,
									this.Fecha});
			this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridView1.Location = new System.Drawing.Point(7, 136);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(851, 226);
			this.dataGridView1.TabIndex = 61;
			// 
			// CodigoFalta
			// 
			this.CodigoFalta.HeaderText = "ENVIADO A";
			this.CodigoFalta.MinimumWidth = 20;
			this.CodigoFalta.Name = "CodigoFalta";
			this.CodigoFalta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.CodigoFalta.Width = 200;
			// 
			// CABECERA
			// 
			this.CABECERA.HeaderText = "CABECERA";
			this.CABECERA.Name = "CABECERA";
			// 
			// Descripcion
			// 
			this.Descripcion.HeaderText = "CUERPO DE MENSAJE";
			this.Descripcion.Name = "Descripcion";
			this.Descripcion.Width = 300;
			// 
			// Fecha
			// 
			this.Fecha.HeaderText = "FECHA DE NOTIFICACION";
			this.Fecha.Name = "Fecha";
			this.Fecha.Width = 200;
			// 
			// NotificacionesEnviadas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(865, 499);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.rjButton3);
			this.Controls.Add(this.rjButton1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.Name = "NotificacionesEnviadas";
			this.Text = "NotificacionesEnviadas";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn CABECERA;
		private System.Windows.Forms.DataGridViewTextBoxColumn CodigoFalta;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private Sistema_Disciplinario_Estudiantil.ResourcesDesign.RJButton rjButton1;
		private Sistema_Disciplinario_Estudiantil.ResourcesDesign.RJButton rjButton3;
	}
}
