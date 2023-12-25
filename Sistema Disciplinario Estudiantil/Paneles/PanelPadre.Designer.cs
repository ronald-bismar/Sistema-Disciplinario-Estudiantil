/*
 * Created by SharpDevelop.
 * User: Windows
 * Date: 18/11/2023
 * Time: 14:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Sistema_Disciplinario_Estudiantil.Paneles
{
	partial class PanelPadre
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelPadre));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.rjButton3 = new Sistema_Disciplinario_Estudiantil.ResourcesDesign.RJButton();
			this.label1 = new System.Windows.Forms.Label();
			this.rjButton1 = new Sistema_Disciplinario_Estudiantil.ResourcesDesign.RJButton();
			this.rjButton2 = new Sistema_Disciplinario_Estudiantil.ResourcesDesign.RJButton();
			this.rjButton4 = new Sistema_Disciplinario_Estudiantil.ResourcesDesign.RJButton();
			this.rjButton5 = new Sistema_Disciplinario_Estudiantil.ResourcesDesign.RJButton();
			this.rjButton6 = new Sistema_Disciplinario_Estudiantil.ResourcesDesign.RJButton();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(103, 41);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(155, 143);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.Highlight;
			this.label3.Font = new System.Drawing.Font("Linotte-Regular", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(335, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(123, 35);
			this.label3.TabIndex = 9;
			this.label3.Text = "Nombre";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label3.Click += new System.EventHandler(this.Label3Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.Highlight;
			this.label2.Font = new System.Drawing.Font("Linotte-Regular", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(599, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 35);
			this.label2.TabIndex = 10;
			this.label2.Text = "Curso";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.SystemColors.Highlight;
			this.label4.Font = new System.Drawing.Font("Linotte-Regular", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(335, 146);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(216, 32);
			this.label4.TabIndex = 11;
			this.label4.Text = "Comportamiento";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.SystemColors.Highlight;
			this.label5.Font = new System.Drawing.Font("Linotte-Regular", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new System.Drawing.Point(599, 146);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(145, 35);
			this.label5.TabIndex = 12;
			this.label5.Text = "Excelente";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// rjButton3
			// 
			this.rjButton3.AutoSize = true;
			this.rjButton3.BackColor = System.Drawing.Color.AliceBlue;
			this.rjButton3.BackgroundColor = System.Drawing.Color.AliceBlue;
			this.rjButton3.BorderColor = System.Drawing.Color.DarkBlue;
			this.rjButton3.BorderRadius = 15;
			this.rjButton3.BorderSize = 2;
			this.rjButton3.FlatAppearance.BorderSize = 0;
			this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rjButton3.Font = new System.Drawing.Font("Linotte-Regular", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rjButton3.ForeColor = System.Drawing.Color.Black;
			this.rjButton3.Image = ((System.Drawing.Image)(resources.GetObject("rjButton3.Image")));
			this.rjButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.rjButton3.Location = new System.Drawing.Point(599, 263);
			this.rjButton3.Margin = new System.Windows.Forms.Padding(0);
			this.rjButton3.Name = "rjButton3";
			this.rjButton3.Padding = new System.Windows.Forms.Padding(15, 4, 25, 4);
			this.rjButton3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.rjButton3.Size = new System.Drawing.Size(228, 78);
			this.rjButton3.TabIndex = 15;
			this.rjButton3.Text = "Historial";
			this.rjButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.rjButton3.TextColor = System.Drawing.Color.Black;
			this.rjButton3.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.Highlight;
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(-5, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(874, 219);
			this.label1.TabIndex = 0;
			// 
			// rjButton1
			// 
			this.rjButton1.AutoSize = true;
			this.rjButton1.BackColor = System.Drawing.Color.AliceBlue;
			this.rjButton1.BackgroundColor = System.Drawing.Color.AliceBlue;
			this.rjButton1.BorderColor = System.Drawing.Color.DarkBlue;
			this.rjButton1.BorderRadius = 15;
			this.rjButton1.BorderSize = 2;
			this.rjButton1.FlatAppearance.BorderSize = 0;
			this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rjButton1.Font = new System.Drawing.Font("Linotte-Regular", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rjButton1.ForeColor = System.Drawing.Color.Black;
			this.rjButton1.Image = ((System.Drawing.Image)(resources.GetObject("rjButton1.Image")));
			this.rjButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.rjButton1.Location = new System.Drawing.Point(323, 263);
			this.rjButton1.Margin = new System.Windows.Forms.Padding(0);
			this.rjButton1.Name = "rjButton1";
			this.rjButton1.Padding = new System.Windows.Forms.Padding(4);
			this.rjButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.rjButton1.Size = new System.Drawing.Size(228, 78);
			this.rjButton1.TabIndex = 16;
			this.rjButton1.Text = "Notificaciones";
			this.rjButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.rjButton1.TextColor = System.Drawing.Color.Black;
			this.rjButton1.UseVisualStyleBackColor = false;
			this.rjButton1.Click += new System.EventHandler(this.RjButton1Click);
			// 
			// rjButton2
			// 
			this.rjButton2.AutoSize = true;
			this.rjButton2.BackColor = System.Drawing.Color.AliceBlue;
			this.rjButton2.BackgroundColor = System.Drawing.Color.AliceBlue;
			this.rjButton2.BorderColor = System.Drawing.Color.DarkBlue;
			this.rjButton2.BorderRadius = 15;
			this.rjButton2.BorderSize = 2;
			this.rjButton2.FlatAppearance.BorderSize = 0;
			this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rjButton2.Font = new System.Drawing.Font("Linotte-Regular", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rjButton2.ForeColor = System.Drawing.Color.Black;
			this.rjButton2.Image = ((System.Drawing.Image)(resources.GetObject("rjButton2.Image")));
			this.rjButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.rjButton2.Location = new System.Drawing.Point(36, 263);
			this.rjButton2.Margin = new System.Windows.Forms.Padding(0);
			this.rjButton2.Name = "rjButton2";
			this.rjButton2.Padding = new System.Windows.Forms.Padding(4);
			this.rjButton2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.rjButton2.Size = new System.Drawing.Size(228, 78);
			this.rjButton2.TabIndex = 17;
			this.rjButton2.Text = "Tablero Principal";
			this.rjButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.rjButton2.TextColor = System.Drawing.Color.Black;
			this.rjButton2.UseVisualStyleBackColor = false;
			this.rjButton2.Click += new System.EventHandler(this.RjButton2Click);
			// 
			// rjButton4
			// 
			this.rjButton4.AutoSize = true;
			this.rjButton4.BackColor = System.Drawing.Color.AliceBlue;
			this.rjButton4.BackgroundColor = System.Drawing.Color.AliceBlue;
			this.rjButton4.BorderColor = System.Drawing.Color.DarkBlue;
			this.rjButton4.BorderRadius = 15;
			this.rjButton4.BorderSize = 2;
			this.rjButton4.FlatAppearance.BorderSize = 0;
			this.rjButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rjButton4.Font = new System.Drawing.Font("Linotte-Regular", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rjButton4.ForeColor = System.Drawing.Color.Black;
			this.rjButton4.Image = ((System.Drawing.Image)(resources.GetObject("rjButton4.Image")));
			this.rjButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.rjButton4.Location = new System.Drawing.Point(36, 392);
			this.rjButton4.Margin = new System.Windows.Forms.Padding(0);
			this.rjButton4.Name = "rjButton4";
			this.rjButton4.Padding = new System.Windows.Forms.Padding(15, 4, 25, 4);
			this.rjButton4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.rjButton4.Size = new System.Drawing.Size(228, 78);
			this.rjButton4.TabIndex = 18;
			this.rjButton4.Text = "Consultas";
			this.rjButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.rjButton4.TextColor = System.Drawing.Color.Black;
			this.rjButton4.UseVisualStyleBackColor = false;
			// 
			// rjButton5
			// 
			this.rjButton5.AutoSize = true;
			this.rjButton5.BackColor = System.Drawing.Color.AliceBlue;
			this.rjButton5.BackgroundColor = System.Drawing.Color.AliceBlue;
			this.rjButton5.BorderColor = System.Drawing.Color.DarkBlue;
			this.rjButton5.BorderRadius = 15;
			this.rjButton5.BorderSize = 2;
			this.rjButton5.FlatAppearance.BorderSize = 0;
			this.rjButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rjButton5.Font = new System.Drawing.Font("Linotte-Regular", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rjButton5.ForeColor = System.Drawing.Color.Black;
			this.rjButton5.Image = ((System.Drawing.Image)(resources.GetObject("rjButton5.Image")));
			this.rjButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.rjButton5.Location = new System.Drawing.Point(323, 392);
			this.rjButton5.Margin = new System.Windows.Forms.Padding(0);
			this.rjButton5.Name = "rjButton5";
			this.rjButton5.Padding = new System.Windows.Forms.Padding(15, 4, 25, 4);
			this.rjButton5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.rjButton5.Size = new System.Drawing.Size(228, 78);
			this.rjButton5.TabIndex = 19;
			this.rjButton5.Text = "Eventos";
			this.rjButton5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.rjButton5.TextColor = System.Drawing.Color.Black;
			this.rjButton5.UseVisualStyleBackColor = false;
			// 
			// rjButton6
			// 
			this.rjButton6.AutoSize = true;
			this.rjButton6.BackColor = System.Drawing.Color.AliceBlue;
			this.rjButton6.BackgroundColor = System.Drawing.Color.AliceBlue;
			this.rjButton6.BorderColor = System.Drawing.Color.DarkBlue;
			this.rjButton6.BorderRadius = 15;
			this.rjButton6.BorderSize = 2;
			this.rjButton6.FlatAppearance.BorderSize = 0;
			this.rjButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rjButton6.Font = new System.Drawing.Font("Linotte-Regular", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rjButton6.ForeColor = System.Drawing.Color.Black;
			this.rjButton6.Image = ((System.Drawing.Image)(resources.GetObject("rjButton6.Image")));
			this.rjButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.rjButton6.Location = new System.Drawing.Point(599, 392);
			this.rjButton6.Margin = new System.Windows.Forms.Padding(0);
			this.rjButton6.Name = "rjButton6";
			this.rjButton6.Padding = new System.Windows.Forms.Padding(15, 4, 45, 4);
			this.rjButton6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.rjButton6.Size = new System.Drawing.Size(228, 78);
			this.rjButton6.TabIndex = 20;
			this.rjButton6.Text = "Salir";
			this.rjButton6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.rjButton6.TextColor = System.Drawing.Color.Black;
			this.rjButton6.UseVisualStyleBackColor = false;
			// 
			// PanelPadre
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(861, 496);
			this.Controls.Add(this.rjButton6);
			this.Controls.Add(this.rjButton5);
			this.Controls.Add(this.rjButton4);
			this.Controls.Add(this.rjButton2);
			this.Controls.Add(this.rjButton1);
			this.Controls.Add(this.rjButton3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Name = "PanelPadre";
			this.Text = "PanelPadre";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private Sistema_Disciplinario_Estudiantil.ResourcesDesign.RJButton rjButton6;
		private Sistema_Disciplinario_Estudiantil.ResourcesDesign.RJButton rjButton5;
		private Sistema_Disciplinario_Estudiantil.ResourcesDesign.RJButton rjButton4;
		private Sistema_Disciplinario_Estudiantil.ResourcesDesign.RJButton rjButton3;
		private Sistema_Disciplinario_Estudiantil.ResourcesDesign.RJButton rjButton2;
		private Sistema_Disciplinario_Estudiantil.ResourcesDesign.RJButton rjButton1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
	}
}
