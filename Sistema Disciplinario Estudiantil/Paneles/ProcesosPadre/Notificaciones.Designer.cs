/*
 * Created by SharpDevelop.
 * User: Windows
 * Date: 18/11/2023
 * Time: 22:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Sistema_Disciplinario_Estudiantil.Registros.ProcesosPadre
{
	partial class Notificaciones
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notificaciones));
			this.rjButton1 = new Sistema_Disciplinario_Estudiantil.ResourcesDesign.RJButton();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.rjButton2 = new Sistema_Disciplinario_Estudiantil.ResourcesDesign.RJButton();
			this.CodigoFalta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CABECERA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
			this.rjButton1.Location = new System.Drawing.Point(510, 414);
			this.rjButton1.Margin = new System.Windows.Forms.Padding(0);
			this.rjButton1.Name = "rjButton1";
			this.rjButton1.Padding = new System.Windows.Forms.Padding(4);
			this.rjButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.rjButton1.Size = new System.Drawing.Size(229, 41);
			this.rjButton1.TabIndex = 27;
			this.rjButton1.Text = "Salir";
			this.rjButton1.TextColor = System.Drawing.Color.White;
			this.rjButton1.UseVisualStyleBackColor = false;
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
			this.dataGridView1.Location = new System.Drawing.Point(12, 153);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(851, 226);
			this.dataGridView1.TabIndex = 20;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.SystemColors.Highlight;
			this.label5.Font = new System.Drawing.Font("Linotte-Regular", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new System.Drawing.Point(295, 44);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(337, 35);
			this.label5.TabIndex = 26;
			this.label5.Text = "Notificaciones recibidas";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.Highlight;
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(-2, -14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(874, 131);
			this.label1.TabIndex = 21;
			// 
			// rjButton2
			// 
			this.rjButton2.AutoSize = true;
			this.rjButton2.BackColor = System.Drawing.Color.RoyalBlue;
			this.rjButton2.BackgroundColor = System.Drawing.Color.RoyalBlue;
			this.rjButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.rjButton2.BorderColor = System.Drawing.Color.AliceBlue;
			this.rjButton2.BorderRadius = 15;
			this.rjButton2.BorderSize = 0;
			this.rjButton2.FlatAppearance.BorderSize = 0;
			this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rjButton2.Font = new System.Drawing.Font("Linotte-Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rjButton2.ForeColor = System.Drawing.Color.White;
			this.rjButton2.Image = ((System.Drawing.Image)(resources.GetObject("rjButton2.Image")));
			this.rjButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.rjButton2.Location = new System.Drawing.Point(182, 414);
			this.rjButton2.Margin = new System.Windows.Forms.Padding(0);
			this.rjButton2.Name = "rjButton2";
			this.rjButton2.Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
			this.rjButton2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.rjButton2.Size = new System.Drawing.Size(229, 42);
			this.rjButton2.TabIndex = 28;
			this.rjButton2.Text = "Contactar Docente";
			this.rjButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.rjButton2.TextColor = System.Drawing.Color.White;
			this.rjButton2.UseVisualStyleBackColor = false;
			// 
			// CodigoFalta
			// 
			this.CodigoFalta.HeaderText = "ENVIADO POR";
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
			// Notificaciones
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(875, 484);
			this.Controls.Add(this.rjButton2);
			this.Controls.Add(this.rjButton1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Notificaciones";
			this.Text = "Notificaciones";
			this.Load += new System.EventHandler(this.NotificacionesLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn CABECERA;
		private Sistema_Disciplinario_Estudiantil.ResourcesDesign.RJButton rjButton2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn CodigoFalta;
		private System.Windows.Forms.DataGridView dataGridView1;
		private Sistema_Disciplinario_Estudiantil.ResourcesDesign.RJButton rjButton1;
	}
}
