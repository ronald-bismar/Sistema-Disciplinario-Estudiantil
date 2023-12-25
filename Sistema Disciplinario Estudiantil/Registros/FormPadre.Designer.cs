/*
 * Created by SharpDevelop.
 * User: Windows
 * Date: 18/11/2023
 * Time: 13:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Sistema_Disciplinario_Estudiantil.Registros
{
	partial class FormPadre
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Baloo Bhaijaan 2", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(278, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(298, 49);
			this.label1.TabIndex = 5;
			this.label1.Text = "PADRE DE FAMILIA";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Baloo Bhaijaan 2", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(308, 167);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(298, 49);
			this.label2.TabIndex = 6;
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Baloo Bhaijaan 2 Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(165, 167);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(237, 26);
			this.textBox1.TabIndex = 7;
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Linotte-Regular", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(165, 141);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 8;
			this.label3.Text = "Nombre";
			this.label3.Click += new System.EventHandler(this.Label3Click);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Linotte-Regular", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(469, 141);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 10;
			this.label4.Text = "Apellido";
			this.label4.Click += new System.EventHandler(this.Label4Click);
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Baloo Bhaijaan 2 Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(469, 167);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(237, 26);
			this.textBox2.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Linotte-Regular", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(165, 214);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(179, 23);
			this.label5.TabIndex = 12;
			this.label5.Text = "Cedula de Identidad";
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Baloo Bhaijaan 2 Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox3.Location = new System.Drawing.Point(165, 240);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(237, 26);
			this.textBox3.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Linotte-Regular", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(469, 214);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 14;
			this.label6.Text = "Telefono";
			// 
			// textBox4
			// 
			this.textBox4.Font = new System.Drawing.Font("Baloo Bhaijaan 2 Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox4.Location = new System.Drawing.Point(469, 240);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(237, 26);
			this.textBox4.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Linotte-Regular", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(165, 292);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 16;
			this.label7.Text = "Correo";
			// 
			// textBox5
			// 
			this.textBox5.Font = new System.Drawing.Font("Baloo Bhaijaan 2 Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox5.Location = new System.Drawing.Point(165, 318);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(237, 26);
			this.textBox5.TabIndex = 15;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Linotte-Regular", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(469, 292);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 18;
			this.label8.Text = "Cedula Hijo";
			// 
			// textBox6
			// 
			this.textBox6.Font = new System.Drawing.Font("Baloo Bhaijaan 2 Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox6.Location = new System.Drawing.Point(469, 318);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(237, 26);
			this.textBox6.TabIndex = 17;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Linotte-Regular", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.button1.Location = new System.Drawing.Point(308, 392);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(254, 51);
			this.button1.TabIndex = 19;
			this.button1.Text = "INGRESAR";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// FormPadre
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(863, 492);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FormPadre";
			this.Text = "FormPadre";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
