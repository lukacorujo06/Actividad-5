/*
 * Created by SharpDevelop.
 * User: LAB-09
 * Date: 4/10/2021
 * Time: 8:37 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Planetas
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pic_mercurio = new System.Windows.Forms.PictureBox();
			this.pic_neptuno = new System.Windows.Forms.PictureBox();
			this.pic_saturno = new System.Windows.Forms.PictureBox();
			this.pic_marte = new System.Windows.Forms.PictureBox();
			this.pic_venus = new System.Windows.Forms.PictureBox();
			this.pic_urano = new System.Windows.Forms.PictureBox();
			this.pic_jupiter = new System.Windows.Forms.PictureBox();
			this.pic_tierra = new System.Windows.Forms.PictureBox();
			this.pic_planetas = new System.Windows.Forms.PictureBox();
			this.lbl_nombre = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.lbl_descripcion = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pic_mercurio)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_neptuno)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_saturno)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_marte)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_venus)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_urano)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_jupiter)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_tierra)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_planetas)).BeginInit();
			this.SuspendLayout();
			// 
			// pic_mercurio
			// 
			this.pic_mercurio.InitialImage = ((System.Drawing.Image)(resources.GetObject("pic_mercurio.InitialImage")));
			this.pic_mercurio.Location = new System.Drawing.Point(25, 21);
			this.pic_mercurio.Name = "pic_mercurio";
			this.pic_mercurio.Size = new System.Drawing.Size(89, 77);
			this.pic_mercurio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_mercurio.TabIndex = 0;
			this.pic_mercurio.TabStop = false;
			this.pic_mercurio.Tag = "0";
			this.pic_mercurio.Click += new System.EventHandler(this.PictureBox9Click);
			// 
			// pic_neptuno
			// 
			this.pic_neptuno.Location = new System.Drawing.Point(145, 382);
			this.pic_neptuno.Name = "pic_neptuno";
			this.pic_neptuno.Size = new System.Drawing.Size(89, 77);
			this.pic_neptuno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_neptuno.TabIndex = 1;
			this.pic_neptuno.TabStop = false;
			this.pic_neptuno.Tag = "7";
			this.pic_neptuno.Click += new System.EventHandler(this.PictureBox9Click);
			// 
			// pic_saturno
			// 
			this.pic_saturno.Location = new System.Drawing.Point(145, 262);
			this.pic_saturno.Name = "pic_saturno";
			this.pic_saturno.Size = new System.Drawing.Size(89, 77);
			this.pic_saturno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_saturno.TabIndex = 2;
			this.pic_saturno.TabStop = false;
			this.pic_saturno.Tag = "5";
			this.pic_saturno.Click += new System.EventHandler(this.PictureBox9Click);
			// 
			// pic_marte
			// 
			this.pic_marte.Location = new System.Drawing.Point(145, 138);
			this.pic_marte.Name = "pic_marte";
			this.pic_marte.Size = new System.Drawing.Size(89, 77);
			this.pic_marte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_marte.TabIndex = 3;
			this.pic_marte.TabStop = false;
			this.pic_marte.Tag = "3";
			this.pic_marte.Click += new System.EventHandler(this.PictureBox9Click);
			// 
			// pic_venus
			// 
			this.pic_venus.Location = new System.Drawing.Point(145, 21);
			this.pic_venus.Name = "pic_venus";
			this.pic_venus.Size = new System.Drawing.Size(89, 77);
			this.pic_venus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_venus.TabIndex = 4;
			this.pic_venus.TabStop = false;
			this.pic_venus.Tag = "1";
			this.pic_venus.Click += new System.EventHandler(this.PictureBox9Click);
			// 
			// pic_urano
			// 
			this.pic_urano.Location = new System.Drawing.Point(25, 382);
			this.pic_urano.Name = "pic_urano";
			this.pic_urano.Size = new System.Drawing.Size(89, 77);
			this.pic_urano.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_urano.TabIndex = 5;
			this.pic_urano.TabStop = false;
			this.pic_urano.Tag = "6";
			this.pic_urano.Click += new System.EventHandler(this.PictureBox9Click);
			// 
			// pic_jupiter
			// 
			this.pic_jupiter.Location = new System.Drawing.Point(25, 262);
			this.pic_jupiter.Name = "pic_jupiter";
			this.pic_jupiter.Size = new System.Drawing.Size(89, 77);
			this.pic_jupiter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_jupiter.TabIndex = 6;
			this.pic_jupiter.TabStop = false;
			this.pic_jupiter.Tag = "4";
			this.pic_jupiter.Click += new System.EventHandler(this.PictureBox9Click);
			// 
			// pic_tierra
			// 
			this.pic_tierra.Location = new System.Drawing.Point(25, 138);
			this.pic_tierra.Name = "pic_tierra";
			this.pic_tierra.Size = new System.Drawing.Size(89, 77);
			this.pic_tierra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_tierra.TabIndex = 7;
			this.pic_tierra.TabStop = false;
			this.pic_tierra.Tag = "2";
			this.pic_tierra.Click += new System.EventHandler(this.PictureBox9Click);
			// 
			// pic_planetas
			// 
			this.pic_planetas.Location = new System.Drawing.Point(447, 33);
			this.pic_planetas.Name = "pic_planetas";
			this.pic_planetas.Size = new System.Drawing.Size(303, 253);
			this.pic_planetas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_planetas.TabIndex = 8;
			this.pic_planetas.TabStop = false;
			// 
			// lbl_nombre
			// 
			this.lbl_nombre.Location = new System.Drawing.Point(447, 312);
			this.lbl_nombre.Name = "lbl_nombre";
			this.lbl_nombre.Size = new System.Drawing.Size(303, 27);
			this.lbl_nombre.TabIndex = 9;
			this.lbl_nombre.Text = "label1";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(145, 105);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 11;
			this.label3.Text = "Venus";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(25, 222);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 12;
			this.label4.Text = "Tierra";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(145, 222);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 13;
			this.label5.Text = "Marte";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(25, 346);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 14;
			this.label6.Text = "Jupiter";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(145, 346);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 15;
			this.label7.Text = "Saturno";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(25, 462);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 16;
			this.label8.Text = "Urano";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(145, 462);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 17;
			this.label9.Text = "Neptuno";
			// 
			// lbl_descripcion
			// 
			this.lbl_descripcion.Location = new System.Drawing.Point(447, 356);
			this.lbl_descripcion.Name = "lbl_descripcion";
			this.lbl_descripcion.Size = new System.Drawing.Size(303, 60);
			this.lbl_descripcion.TabIndex = 18;
			this.lbl_descripcion.Text = "label10";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(25, 105);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 10;
			this.label2.Text = "Mercurio";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(990, 502);
			this.Controls.Add(this.lbl_descripcion);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lbl_nombre);
			this.Controls.Add(this.pic_planetas);
			this.Controls.Add(this.pic_tierra);
			this.Controls.Add(this.pic_jupiter);
			this.Controls.Add(this.pic_urano);
			this.Controls.Add(this.pic_venus);
			this.Controls.Add(this.pic_marte);
			this.Controls.Add(this.pic_saturno);
			this.Controls.Add(this.pic_neptuno);
			this.Controls.Add(this.pic_mercurio);
			this.Name = "MainForm";
			this.Text = "Planetas";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pic_mercurio)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_neptuno)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_saturno)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_marte)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_venus)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_urano)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_jupiter)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_tierra)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_planetas)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lbl_descripcion;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbl_nombre;
		private System.Windows.Forms.PictureBox pic_planetas;
		private System.Windows.Forms.PictureBox pic_tierra;
		private System.Windows.Forms.PictureBox pic_jupiter;
		private System.Windows.Forms.PictureBox pic_urano;
		private System.Windows.Forms.PictureBox pic_venus;
		private System.Windows.Forms.PictureBox pic_marte;
		private System.Windows.Forms.PictureBox pic_saturno;
		private System.Windows.Forms.PictureBox pic_neptuno;
		private System.Windows.Forms.PictureBox pic_mercurio;
	}
}
