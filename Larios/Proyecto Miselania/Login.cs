using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Miselania
{
	public partial class Login : Form
	{
		Menu Inventario = new Menu();
		int contraseñaIncorrect = 3;
		int intentosF = 0;

		public Login()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		public void fn_prba_()
		{
			if (progressBar1.Value < 100)
			{
				progressBar1.Value += 1;
				lblcarga.Text = progressBar1.Value.ToString() + "%";
			}

			if (progressBar1.Value == 100)
			{
				timer1.Stop();
				// Aquí invocamos el nuevo formulario
				Inventario.ShowDialog();
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			fn_prba_();
		}

		private void label4_Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox2.Clear();
			textBox1.Focus();
		}

		private void label3_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Congelar()
		{
			intentosF++;

			if (intentosF == 1)
			{
				MessageBox.Show("FUE BLOQUEADO, espere  30 segundos");
				Thread.Sleep(30000);
				textBox2.Enabled = true;
				textBox1.Enabled = true;
				contraseñaIncorrect = 3;
			}
			else if (intentosF == 2)
			{
				MessageBox.Show("FUE BLOQUEADO, espere 40 segundos");
				Thread.Sleep(40000);
				textBox2.Enabled = true;
				textBox1.Enabled = true;
				contraseñaIncorrect = 3;
			}
			else if (intentosF > 2)
			{
				MessageBox.Show("FUE BLOQUEADO, espere 1 minuto");
				Thread.Sleep(60000);
				textBox2.Enabled = true;
				textBox1.Enabled = true;
				contraseñaIncorrect = 3;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "jacqueline" && textBox2.Text == "123")
			{
				timer1.Start();
			}
			else
			{
				contraseñaIncorrect--;
				MessageBox.Show("Contraseña incorrecta o usuario incorrecto");
				textBox1.Clear();
				textBox2.Clear();
			}

			if (contraseñaIncorrect == 0)
			{
				textBox1.Enabled = false;
				textBox2.Enabled = false;
				Congelar();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
		  
		}

		private void Login_Load(object sender, EventArgs e)
		{

		}
	}
}
