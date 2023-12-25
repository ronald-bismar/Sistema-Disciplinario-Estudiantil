/*
 * Created by SharpDevelop.
 * User: Windows
 * Date: 18/11/2023
 * Time: 22:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Sistema_Disciplinario_Estudiantil.Registros.ProcesosPadre
{
	partial class Historial
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historial));
			this.rjButton2 = new Sistema_Disciplinario_Estudiantil.ResourcesDesign.RJButton();
			this.rjButton1 = new Sistema_Disciplinario_Estudiantil.ResourcesDesign.RJButton();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
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
			this.rjButton2.Location = new System.Drawing.Point(170, 418);
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
			this.rjButton2.Click += new System.EventHandler(this.RjButton2Click);
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
			this.rjButton1.Location = new System.Drawing.Point(505, 419);
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
			this.label1.Location = new System.Drawing.Point(-7, -1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(874, 84);
			this.label1.TabIndex = 30;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.SystemColors.Highlight;
			this.label5.Font = new System.Drawing.Font("Linotte-Regular", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new System.Drawing.Point(366, 24);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(161, 35);
			this.label5.TabIndex = 31;
			this.label5.Text = "HISTORIAL";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label5.Click += new System.EventHandler(this.Label5Click);
			// 
			// Historial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(866, 482);
			this.Controls.Add(this.rjButton2);
			this.Controls.Add(this.rjButton1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.Name = "Historial";
			this.Text = "Historial";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private Sistema_Disciplinario_Estudiantil.ResourcesDesign.RJButton rjButton1;
		private Sistema_Disciplinario_Estudiantil.ResourcesDesign.RJButton rjButton2;
	}
}
