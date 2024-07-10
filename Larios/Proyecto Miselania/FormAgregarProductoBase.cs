using System;
using System.Windows.Forms;

namespace Proyecto_Miselania
{
	public class FormAgregarProductoBase
	{
		public Inventario inventario;
		private System.Windows.Forms.Button buttonAgregar;
		private System.Windows.Forms.ComboBox comboBoxTipoProducto;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DateTimePicker dateTimePickerFechaCaducidad;


		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBoxCantidad;
		private System.Windows.Forms.TextBox textBoxModelo;
		private System.Windows.Forms.TextBox textBoxNombre;
		private System.Windows.Forms.TextBox textBoxPrecio;
		private System.Windows.Forms.TextBox textBoxTipoLimpieza;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void buttonAgregar_Click(object sender, EventArgs e)
		{
			string nombre = textBoxNombre.Text;
			double precio = Convert.ToDouble(textBoxPrecio.Text);
			int cantidad = Convert.ToInt32(textBoxCantidad.Text);
			string tipoProducto = comboBoxTipoProducto.Text;

			switch (tipoProducto)
			{
				case "Electrónico":
					string modelo = textBoxModelo.Text;
					ProductoElectronico productoElectronico = new ProductoElectronico
					{
						Nombre = nombre,
						Precio = precio,
						Cantidad = cantidad,
						Modelo = modelo
					};
					inventario.AgregarProducto(productoElectronico);
					break;
				case "Alimenticio":
					DateTime fechaCaducidad = dateTimePickerFechaCaducidad.Value;
					ProductoAlimenticio productoAlimenticio = new ProductoAlimenticio
					{
						Nombre = nombre,
						Precio = precio,
						Cantidad = cantidad,
						FechaCaducidad = fechaCaducidad
					};
					inventario.AgregarProducto(productoAlimenticio);
					break;
				case "Limpieza":
					string tipoLimpieza = textBoxTipoLimpieza.Text;
					ProductoLimpieza productoLimpieza = new ProductoLimpieza
					{
						Nombre = nombre,
						Precio = precio,
						Cantidad = cantidad,
						Tipo = tipoLimpieza
					};
					inventario.AgregarProducto(productoLimpieza);
					break;
				default:
					MessageBox.Show("Seleccione un tipo de producto válido.");
					return;
			}

			MessageBox.Show("Producto agregado correctamente.");

			// Limpiar campos después de agregar
			LimpiarCampos();
		}


		private void FormAgregarProducto_Load(object sender, EventArgs e)
		{

		}


		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dateTimePickerFechaCaducidad = new System.Windows.Forms.DateTimePicker();
			this.label9 = new System.Windows.Forms.Label();
			this.textBoxTipoLimpieza = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBoxTipoProducto = new System.Windows.Forms.ComboBox();
			this.textBoxModelo = new System.Windows.Forms.TextBox();
			this.textBoxCantidad = new System.Windows.Forms.TextBox();
			this.textBoxPrecio = new System.Windows.Forms.TextBox();
			this.textBoxNombre = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonAgregar = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dateTimePickerFechaCaducidad);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.textBoxTipoLimpieza);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.comboBoxTipoProducto);
			this.groupBox1.Controls.Add(this.textBoxModelo);
			this.groupBox1.Controls.Add(this.textBoxCantidad);
			this.groupBox1.Controls.Add(this.textBoxPrecio);
			this.groupBox1.Controls.Add(this.textBoxNombre);
			this.groupBox1.Location = new System.Drawing.Point(58, 125);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(687, 182);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Inf. Producto";
			// 
			// dateTimePickerFechaCaducidad
			// 
			this.dateTimePickerFechaCaducidad.Location = new System.Drawing.Point(418, 145);
			this.dateTimePickerFechaCaducidad.Name = "dateTimePickerFechaCaducidad";
			this.dateTimePickerFechaCaducidad.Size = new System.Drawing.Size(246, 22);
			this.dateTimePickerFechaCaducidad.TabIndex = 13;
			this.dateTimePickerFechaCaducidad.Value = DateTime.Now;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(265, 145);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(147, 18);
			this.label9.TabIndex = 12;
			this.label9.Text = "Fecha de Caducidad:";
			this.label9.Click += new System.EventHandler(this.label9_Click);
			// 
			// textBoxTipoLimpieza
			// 
			this.textBoxTipoLimpieza.Location = new System.Drawing.Point(485, 107);
			this.textBoxTipoLimpieza.Name = "textBoxTipoLimpieza";
			this.textBoxTipoLimpieza.Size = new System.Drawing.Size(100, 22);
			this.textBoxTipoLimpieza.TabIndex = 11;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(470, 79);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(124, 18);
			this.label8.TabIndex = 10;
			this.label8.Text = "Tipo de Limpieza:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(439, 36);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(62, 18);
			this.label7.TabIndex = 9;
			this.label7.Text = "Modelo:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(314, 36);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(70, 18);
			this.label6.TabIndex = 8;
			this.label6.Text = "Cantidad:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(25, 120);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 18);
			this.label5.TabIndex = 7;
			this.label5.Text = "Precio:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(25, 79);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 18);
			this.label4.TabIndex = 6;
			this.label4.Text = "Nombre:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(25, 18);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(203, 18);
			this.label3.TabIndex = 5;
			this.label3.Text = "Seleccione Tipo de Producto:";
			// 
			// comboBoxTipoProducto
			// 
			this.comboBoxTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxTipoProducto.FormattingEnabled = true;
			this.comboBoxTipoProducto.Items.AddRange(new object[] {
			"Electrónico",
			"Alimenticio",
			"Limpieza"});
			this.comboBoxTipoProducto.Location = new System.Drawing.Point(52, 42);
			this.comboBoxTipoProducto.Name = "comboBoxTipoProducto";
			this.comboBoxTipoProducto.Size = new System.Drawing.Size(146, 26);
			this.comboBoxTipoProducto.TabIndex = 4;
			// 
			// textBoxModelo
			// 
			this.textBoxModelo.Location = new System.Drawing.Point(507, 36);
			this.textBoxModelo.Name = "textBoxModelo";
			this.textBoxModelo.Size = new System.Drawing.Size(100, 22);
			this.textBoxModelo.TabIndex = 3;
			// 
			// textBoxCantidad
			// 
			this.textBoxCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxCantidad.Location = new System.Drawing.Point(300, 59);
			this.textBoxCantidad.Name = "textBoxCantidad";
			this.textBoxCantidad.Size = new System.Drawing.Size(100, 24);
			this.textBoxCantidad.TabIndex = 2;
			// 
			// textBoxPrecio
			// 
			this.textBoxPrecio.Location = new System.Drawing.Point(97, 119);
			this.textBoxPrecio.Name = "textBoxPrecio";
			this.textBoxPrecio.Size = new System.Drawing.Size(144, 22);
			this.textBoxPrecio.TabIndex = 1;
			// 
			// textBoxNombre
			// 
			this.textBoxNombre.Location = new System.Drawing.Point(97, 79);
			this.textBoxNombre.Name = "textBoxNombre";
			this.textBoxNombre.Size = new System.Drawing.Size(144, 22);
			this.textBoxNombre.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(282, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(227, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Registro De Productos";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(268, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size { 243, 29 };
			this.label2.TabIndex = 2;
			this.label2.Text = "Miscelánea Moncada";
			// 
			// buttonAgregar
			// 
			this.buttonAgregar.Location = new System.Drawing.Point(350, 330);
			this.buttonAgregar.Name = "buttonAgregar";
			this.buttonAgregar.Size = new System.Drawing.Size(120, 40);
			this.buttonAgregar.TabIndex = 3;
			this.buttonAgregar.Text = "Agregar Producto";
			this.buttonAgregar.UseVisualStyleBackColor = true;
			this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
			// 
			// FormAgregarProducto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(815, 478);
			this.Controls.Add(this.buttonAgregar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormAgregarProducto";
			this.Text = "FormRegistrarProducto";
			this.Load += new System.EventHandler(this.FormAgregarProducto_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private void LimpiarCampos()
		{
			textBoxNombre.Clear();
			textBoxPrecio.Clear();
			textBoxCantidad.Clear();
			textBoxModelo.Clear();
			textBoxTipoLimpieza.Clear();
		}
	}
}