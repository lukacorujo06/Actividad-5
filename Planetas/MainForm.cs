using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Planetas
{
	public partial class MainForm : Form
	{
		string[] planetas ;
		string[] info;
		string[] nombres ;
		
		public MainForm()
		{
			
			InitializeComponent();
			
		}
		
		void PictureBox9Click(object sender, EventArgs e)
		{
			PictureBox pic = (PictureBox)sender;
			
			pic_planetas.Image = pic.Image;
			
			int i = Convert.ToInt32(pic.Tag);
			
			lbl_descripcion.Text = info[i];
			
			lbl_nombre.Text = nombres[i];			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
			planetas = new string  [8];
			string direccion  = "D:\\planetas\\";
			planetas[0] = direccion + "MERCURIO.jpg";
			planetas[1] = direccion + "VENUS.jpg";
			planetas[2] = direccion + "TIERRA.jpg";
			planetas[3] = direccion + "MARTE.jpg";
			planetas[4] = direccion + "JUPITER.jpg";
			planetas[5] = direccion + "SATURNO.jpg";
			planetas[6] = direccion + "URANO.jpg";
			planetas[7] = direccion + "NEPTUNO.jpg";
			
			info = new string [8];
			info[0] = "Mercurio es el planeta del sistema solar más cercano al Sol y el más pequeño.";
			info[1] = "Venus es el segundo planeta del sistema solar en orden de proximidad al Sol y el tercero en cuanto a tamaño en orden ascendente después de Mercurio y Marte.";
			info[2] = "La Tierra es un planeta del sistema solar que gira alrededor de su estrella el Sol en la tercera órbita más interna.";
			info[3] = "Marte es el cuarto planeta en orden de distancia al Sol y el segundo más pequeño del sistema solar, después de Mercurio.";
			info[4] = "Júpiter es el planeta más grande del sistema solar y el quinto en orden de lejanía al Sol.";
			info[5] = "Saturno es el sexto planeta del sistema solar contando desde el Sol, el segundo en tamaño y masa después de Júpiter y el único con un sistema de anillos visible desde la Tierra.";
			info[6] = "Urano es el séptimo planeta del sistema solar, el tercero de mayor tamaño, y el cuarto más masivo. ";
			info[7] = "Neptuno es el octavo planeta en distancia respecto al Sol y el más lejano del sistema solar.";
			
			nombres = new string [8];
			nombres[0] = "Mercurio";
			nombres[1] = "Venus";
			nombres[2] = "Tierra";
			nombres[3] = "Marte";
			nombres[4] = "Júpiter";
			nombres[5] = "Saturno";
			nombres[6] = "Urano";
			nombres[7] = "Neptuno";
			
			pic_mercurio.Image = Image.FromFile(planetas[0]);
			pic_venus.Image = Image.FromFile(planetas[1]);
			pic_tierra.Image = Image.FromFile(planetas[2]);
			pic_marte.Image = Image.FromFile(planetas[3]);
			pic_jupiter.Image = Image.FromFile(planetas[4]);
			pic_saturno.Image = Image.FromFile(planetas[5]);
			pic_urano.Image = Image.FromFile(planetas[6]);
			pic_neptuno.Image = Image.FromFile(planetas[7]);
			
			pic_planetas.Image = pic_mercurio.Image;
			lbl_nombre.Text = nombres[0];
			lbl_descripcion.Text = info[0];
		}
	}
}
