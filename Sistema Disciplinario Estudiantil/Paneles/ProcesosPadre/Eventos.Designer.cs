/*
 * Created by SharpDevelop.
 * User: Windows
 * Date: 18/11/2023
 * Time: 23:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Sistema_Disciplinario_Estudiantil.Registros.ProcesosPadre
{
	partial class Calendario
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendario));
			this.rjButton2 = new Sistema_Disciplinario_Estudiantil.ResourcesDesign.RJButton();
			this.rjButton1 = new Sistema_Disciplinario_Estudiantil.ResourcesDesign.RJButton();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label5 = new System.Windows.Forms.Label();
			this.CodigoFalta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rjButton3 = new Sistema_Disciplinario_Estudiantil.ResourcesDesign.RJButton();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
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
			this.rjButton2.Location = new System.Drawing.Point(70, 418);
			this.rjButton2.Margin = new System.Windows.Forms.Padding(0);
			this.rjButton2.Name = "rjButton2";
			this.rjButton2.Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
			this.rjButton2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.rjButton2.Size = new System.Drawing.Size(229, 42);
			this.rjButton2.TabIndex = 33;
			this.rjButton2.Text = "Contactar Docente";
			this.rjButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.rjButton2.TextColor = System.Drawing.Color.White;
			this.rjButton2.UseVisualStyleBackColor = false;
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
			this.rjButton1.Location = new System.Drawing.Point(586, 419);
			this.rjButton1.Margin = new System.Windows.Forms.Padding(0);
			this.rjButton1.Name = "rjButton1";
			this.rjButton1.Padding = new System.Windows.Forms.Padding(4);
			this.rjButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.rjButton1.Size = new System.Drawing.Size(229, 41);
			this.rjButton1.TabIndex = 32;
			this.rjButton1.Text = "Salir";
			this.rjButton1.TextColor = System.Drawing.Color.White;
			this.rjButton1.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.Highlight;
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(-6, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(874, 131);
			this.label1.TabIndex = 30;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.CodigoFalta,
									this.Descripcion,
									this.Fecha});
			this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridView1.Location = new System.Drawing.Point(70, 167);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(745, 226);
			this.dataGridView1.TabIndex = 29;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.SystemColors.Highlight;
			this.label5.Font = new System.Drawing.Font("Linotte-Regular", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new System.Drawing.Point(204, 57);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(497, 35);
			this.label5.TabIndex = 31;
			this.label5.Text = "Eventos Programados En La Unidad";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// CodigoFalta
			// 
			this.CodigoFalta.HeaderText = "NOMBRE";
			this.CodigoFalta.MinimumWidth = 20;
			this.CodigoFalta.Name = "CodigoFalta";
			this.CodigoFalta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.CodigoFalta.Width = 200;
			// 
			// Descripcion
			// 
			this.Descripcion.HeaderText = "DESCRIPCION EVENTO";
			this.Descripcion.Name = "Descripcion";
			this.Descripcion.Width = 300;
			// 
			// Fecha
			// 
			this.Fecha.HeaderText = "FECHA DE EVENTO";
			this.Fecha.Name = "Fecha";
			this.Fecha.Width = 200;
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
			this.rjButton3.Image = ((System.Drawing.Image)(resources.GetObject("rjButton3.Image")));
			this.rjButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.rjButton3.Location = new System.Drawing.Point(329, 419);
			this.rjButton3.Margin = new System.Windows.Forms.Padding(0);
			this.rjButton3.Name = "rjButton3";
			this.rjButton3.Padding = new System.Windows.Forms.Padding(40, 4, 40, 4);
			this.rjButton3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.rjButton3.Size = new System.Drawing.Size(229, 46);
			this.rjButton3.TabIndex = 34;
			this.rjButton3.Text = "Calendario";
			this.rjButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.rjButton3.TextColor = System.Drawing.Color.White;
			this.rjButton3.UseVisualStyleBackColor = false;
			// 
			// Calendario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(863, 479);
			this.Controls.Add(this.rjButton3);
			this.Controls.Add(this.rjButton2);
			this.Controls.Add(this.rjButton1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Calendario";
			this.Text = "Calendario";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private Sistema_Disciplinario_Estudiantil.ResourcesDesign.RJButton rjButton3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn CodigoFalta;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private Sistema_Disciplinario_Estudiantil.ResourcesDesign.RJButton rjButton1;
		private Sistema_Disciplinario_Estudiantil.ResourcesDesign.RJButton rjButton2;
	}
}
