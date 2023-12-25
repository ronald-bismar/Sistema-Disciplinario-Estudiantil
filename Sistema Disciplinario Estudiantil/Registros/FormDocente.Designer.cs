/*
 * Created by SharpDevelop.
 * User: Windows
 * Date: 18/11/2023
 * Time: 13:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Sistema_Disciplinario_Estudiantil.Registros
{
	partial class FormDocente
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
			this.label8 = new System.Windows.Forms.Label();
			this.txtMateria = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtCorreoD = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtItemD = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCID = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtApellidoD = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNombreD = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnIngresar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Linotte-Regular", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(465, 301);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 32;
			this.label8.Text = "Materia";
			// 
			// txtMateria
			// 
			this.txtMateria.Font = new System.Drawing.Font("Baloo Bhaijaan 2 Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMateria.Location = new System.Drawing.Point(465, 327);
			this.txtMateria.Name = "txtMateria";
			this.txtMateria.Size = new System.Drawing.Size(237, 26);
			this.txtMateria.TabIndex = 31;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Linotte-Regular", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(161, 301);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 30;
			this.label7.Text = "Correo";
			// 
			// txtCorreoD
			// 
			this.txtCorreoD.Font = new System.Drawing.Font("Baloo Bhaijaan 2 Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCorreoD.Location = new System.Drawing.Point(161, 327);
			this.txtCorreoD.Name = "txtCorreoD";
			this.txtCorreoD.Size = new System.Drawing.Size(237, 26);
			this.txtCorreoD.TabIndex = 29;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Linotte-Regular", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(465, 223);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(129, 19);
			this.label6.TabIndex = 28;
			this.label6.Text = "Numero de Item";
			// 
			// txtItemD
			// 
			this.txtItemD.Font = new System.Drawing.Font("Baloo Bhaijaan 2 Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtItemD.Location = new System.Drawing.Point(465, 249);
			this.txtItemD.Name = "txtItemD";
			this.txtItemD.Size = new System.Drawing.Size(237, 26);
			this.txtItemD.TabIndex = 27;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Linotte-Regular", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(161, 223);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(179, 23);
			this.label5.TabIndex = 26;
			this.label5.Text = "Cedula de Identidad";
			// 
			// txtCID
			// 
			this.txtCID.Font = new System.Drawing.Font("Baloo Bhaijaan 2 Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCID.Location = new System.Drawing.Point(161, 249);
			this.txtCID.Name = "txtCID";
			this.txtCID.Size = new System.Drawing.Size(237, 26);
			this.txtCID.TabIndex = 25;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Linotte-Regular", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(465, 150);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 24;
			this.label4.Text = "Apellido";
			this.label4.Click += new System.EventHandler(this.Label4Click);
			// 
			// txtApellidoD
			// 
			this.txtApellidoD.Font = new System.Drawing.Font("Baloo Bhaijaan 2 Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtApellidoD.Location = new System.Drawing.Point(465, 176);
			this.txtApellidoD.Name = "txtApellidoD";
			this.txtApellidoD.Size = new System.Drawing.Size(237, 26);
			this.txtApellidoD.TabIndex = 23;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Linotte-Regular", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(161, 150);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 22;
			this.label3.Text = "Nombre";
			// 
			// txtNombreD
			// 
			this.txtNombreD.Font = new System.Drawing.Font("Baloo Bhaijaan 2 Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombreD.Location = new System.Drawing.Point(161, 176);
			this.txtNombreD.Name = "txtNombreD";
			this.txtNombreD.Size = new System.Drawing.Size(237, 26);
			this.txtNombreD.TabIndex = 21;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Baloo Bhaijaan 2", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(304, 176);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(298, 49);
			this.label2.TabIndex = 20;
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Baloo Bhaijaan 2", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(281, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(298, 49);
			this.label1.TabIndex = 19;
			this.label1.Text = "DOCENTE";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnIngresar
			// 
			this.btnIngresar.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.btnIngresar.FlatAppearance.BorderSize = 0;
			this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIngresar.Font = new System.Drawing.Font("Linotte-Regular", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIngresar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnIngresar.Location = new System.Drawing.Point(304, 393);
			this.btnIngresar.Name = "btnIngresar";
			this.btnIngresar.Size = new System.Drawing.Size(254, 51);
			this.btnIngresar.TabIndex = 33;
			this.btnIngresar.Text = "INGRESAR";
			this.btnIngresar.UseVisualStyleBackColor = false;
			this.btnIngresar.Click += new System.EventHandler(this.BtnIngresarClick);
			// 
			// FormDocente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(863, 490);
			this.Controls.Add(this.btnIngresar);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtMateria);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtCorreoD);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtItemD);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtCID);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtApellidoD);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtNombreD);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FormDocente";
			this.Text = "FormDocente";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Button btnIngresar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNombreD;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtApellidoD;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtCID;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtItemD;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtCorreoD;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtMateria;
		private System.Windows.Forms.Label label8;
	}
}
