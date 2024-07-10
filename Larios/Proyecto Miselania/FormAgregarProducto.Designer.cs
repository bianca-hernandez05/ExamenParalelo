using System;

namespace Proyecto_Miselania
{
	partial class FormAgregarProducto
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.comboBoxTipoProducto = new System.Windows.Forms.ComboBox();
            this.labelTipoProducto = new System.Windows.Forms.Label();
            this.textBoxVolumen = new System.Windows.Forms.TextBox();
            this.labelVolumen = new System.Windows.Forms.Label();
            this.labelTipoCarne = new System.Windows.Forms.Label();
            this.textBoxTipoCarne = new System.Windows.Forms.TextBox();
            this.textBoxTipoHigiene = new System.Windows.Forms.TextBox();
            this.labelTipoHigiene = new System.Windows.Forms.Label();
            this.dateTimePickerFechaCaducidad = new System.Windows.Forms.DateTimePicker();
            this.labelFechaCaducidad = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonPrueba = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvProductos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtTipoSnacks = new System.Windows.Forms.TextBox();
            this.labelTipoSnacks = new System.Windows.Forms.Label();
            this.TxtTipoLimpieza = new System.Windows.Forms.TextBox();
            this.labelTipoLimpieza = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtLimpiar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(31, 29);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(38, 83);
            this.labelPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(40, 13);
            this.labelPrecio.TabIndex = 1;
            this.labelPrecio.Text = "Precio:";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(278, 29);
            this.labelCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(52, 13);
            this.labelCantidad.TabIndex = 2;
            this.labelCantidad.Text = "Cantidad:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(88, 23);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(76, 20);
            this.textBoxNombre.TabIndex = 3;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(88, 77);
            this.textBoxPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(76, 20);
            this.textBoxPrecio.TabIndex = 4;
            this.textBoxPrecio.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBoxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrecio_KeyPress);
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(356, 23);
            this.textBoxCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(76, 20);
            this.textBoxCantidad.TabIndex = 5;
            this.textBoxCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCantidad_KeyPress);
            // 
            // comboBoxTipoProducto
            // 
            this.comboBoxTipoProducto.FormattingEnabled = true;
            this.comboBoxTipoProducto.Items.AddRange(new object[] {
            "Bebida",
            "Carne",
            "Higiene Personal",
            "Limpieza",
            "Snacks"});
            this.comboBoxTipoProducto.Location = new System.Drawing.Point(356, 75);
            this.comboBoxTipoProducto.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTipoProducto.Name = "comboBoxTipoProducto";
            this.comboBoxTipoProducto.Size = new System.Drawing.Size(92, 21);
            this.comboBoxTipoProducto.TabIndex = 6;
            this.comboBoxTipoProducto.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoProducto_SelectedIndexChanged);
            // 
            // labelTipoProducto
            // 
            this.labelTipoProducto.AutoSize = true;
            this.labelTipoProducto.Location = new System.Drawing.Point(253, 77);
            this.labelTipoProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTipoProducto.Name = "labelTipoProducto";
            this.labelTipoProducto.Size = new System.Drawing.Size(92, 13);
            this.labelTipoProducto.TabIndex = 7;
            this.labelTipoProducto.Text = "Tipo de Producto:";
            // 
            // textBoxVolumen
            // 
            this.textBoxVolumen.Location = new System.Drawing.Point(88, 130);
            this.textBoxVolumen.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxVolumen.Name = "textBoxVolumen";
            this.textBoxVolumen.Size = new System.Drawing.Size(76, 20);
            this.textBoxVolumen.TabIndex = 9;
            this.textBoxVolumen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVolumen_KeyPress);
            // 
            // labelVolumen
            // 
            this.labelVolumen.AutoSize = true;
            this.labelVolumen.Location = new System.Drawing.Point(28, 135);
            this.labelVolumen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVolumen.Name = "labelVolumen";
            this.labelVolumen.Size = new System.Drawing.Size(51, 13);
            this.labelVolumen.TabIndex = 10;
            this.labelVolumen.Text = "Volumen:";
            // 
            // labelTipoCarne
            // 
            this.labelTipoCarne.AutoSize = true;
            this.labelTipoCarne.Location = new System.Drawing.Point(4, 188);
            this.labelTipoCarne.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTipoCarne.Name = "labelTipoCarne";
            this.labelTipoCarne.Size = new System.Drawing.Size(77, 13);
            this.labelTipoCarne.TabIndex = 11;
            this.labelTipoCarne.Text = "Tipo de Carne:";
            // 
            // textBoxTipoCarne
            // 
            this.textBoxTipoCarne.Location = new System.Drawing.Point(88, 185);
            this.textBoxTipoCarne.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTipoCarne.Name = "textBoxTipoCarne";
            this.textBoxTipoCarne.Size = new System.Drawing.Size(76, 20);
            this.textBoxTipoCarne.TabIndex = 12;
            this.textBoxTipoCarne.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTipoCarne_KeyPress);
            // 
            // textBoxTipoHigiene
            // 
            this.textBoxTipoHigiene.Location = new System.Drawing.Point(363, 111);
            this.textBoxTipoHigiene.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTipoHigiene.Name = "textBoxTipoHigiene";
            this.textBoxTipoHigiene.Size = new System.Drawing.Size(76, 20);
            this.textBoxTipoHigiene.TabIndex = 13;
            this.textBoxTipoHigiene.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTipoHigiene_KeyPress);
            // 
            // labelTipoHigiene
            // 
            this.labelTipoHigiene.AutoSize = true;
            this.labelTipoHigiene.Location = new System.Drawing.Point(264, 114);
            this.labelTipoHigiene.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTipoHigiene.Name = "labelTipoHigiene";
            this.labelTipoHigiene.Size = new System.Drawing.Size(85, 13);
            this.labelTipoHigiene.TabIndex = 14;
            this.labelTipoHigiene.Text = "Tipo de Higiene:";
            // 
            // dateTimePickerFechaCaducidad
            // 
            this.dateTimePickerFechaCaducidad.Location = new System.Drawing.Point(356, 204);
            this.dateTimePickerFechaCaducidad.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerFechaCaducidad.Name = "dateTimePickerFechaCaducidad";
            this.dateTimePickerFechaCaducidad.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerFechaCaducidad.TabIndex = 15;
            // 
            // labelFechaCaducidad
            // 
            this.labelFechaCaducidad.AutoSize = true;
            this.labelFechaCaducidad.Location = new System.Drawing.Point(236, 209);
            this.labelFechaCaducidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFechaCaducidad.Name = "labelFechaCaducidad";
            this.labelFechaCaducidad.Size = new System.Drawing.Size(109, 13);
            this.labelFechaCaducidad.TabIndex = 16;
            this.labelFechaCaducidad.Text = "Fecha de Caducidad:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 348);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 17;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPrueba
            // 
            this.buttonPrueba.Location = new System.Drawing.Point(213, 348);
            this.buttonPrueba.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrueba.Name = "buttonPrueba";
            this.buttonPrueba.Size = new System.Drawing.Size(56, 19);
            this.buttonPrueba.TabIndex = 18;
            this.buttonPrueba.Text = "Agregar";
            this.buttonPrueba.UseVisualStyleBackColor = true;
            this.buttonPrueba.Click += new System.EventHandler(this.Prueba_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(295, 348);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(56, 19);
            this.buttonEditar.TabIndex = 20;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(133, 348);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(56, 19);
            this.buttonEliminar.TabIndex = 22;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "Miscelania \"Moncada\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Area de Inventario";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lvProductos
            // 
            this.lvProductos.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lvProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvProductos.HideSelection = false;
            this.lvProductos.LabelEdit = true;
            this.lvProductos.Location = new System.Drawing.Point(26, 392);
            this.lvProductos.Name = "lvProductos";
            this.lvProductos.Size = new System.Drawing.Size(447, 149);
            this.lvProductos.TabIndex = 27;
            this.lvProductos.UseCompatibleStateImageBehavior = false;
            this.lvProductos.View = System.Windows.Forms.View.Details;
            this.lvProductos.SelectedIndexChanged += new System.EventHandler(this.lvVentas_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 107;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Precio";
            this.columnHeader2.Width = 82;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Stock";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tipo";
            this.columnHeader4.Width = 85;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Detalles";
            this.columnHeader5.Width = 149;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.TxtTipoSnacks);
            this.groupBox1.Controls.Add(this.labelTipoSnacks);
            this.groupBox1.Controls.Add(this.TxtTipoLimpieza);
            this.groupBox1.Controls.Add(this.labelTipoLimpieza);
            this.groupBox1.Controls.Add(this.labelNombre);
            this.groupBox1.Controls.Add(this.labelCantidad);
            this.groupBox1.Controls.Add(this.textBoxCantidad);
            this.groupBox1.Controls.Add(this.textBoxTipoCarne);
            this.groupBox1.Controls.Add(this.comboBoxTipoProducto);
            this.groupBox1.Controls.Add(this.textBoxVolumen);
            this.groupBox1.Controls.Add(this.labelTipoProducto);
            this.groupBox1.Controls.Add(this.textBoxPrecio);
            this.groupBox1.Controls.Add(this.textBoxTipoHigiene);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.labelTipoHigiene);
            this.groupBox1.Controls.Add(this.labelTipoCarne);
            this.groupBox1.Controls.Add(this.dateTimePickerFechaCaducidad);
            this.groupBox1.Controls.Add(this.labelVolumen);
            this.groupBox1.Controls.Add(this.labelFechaCaducidad);
            this.groupBox1.Controls.Add(this.labelPrecio);
            this.groupBox1.Location = new System.Drawing.Point(34, 104);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(514, 228);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Producto";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TxtTipoSnacks
            // 
            this.TxtTipoSnacks.Location = new System.Drawing.Point(363, 171);
            this.TxtTipoSnacks.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTipoSnacks.Name = "TxtTipoSnacks";
            this.TxtTipoSnacks.Size = new System.Drawing.Size(76, 20);
            this.TxtTipoSnacks.TabIndex = 20;
            this.TxtTipoSnacks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTipoSnacks_KeyPress);
            // 
            // labelTipoSnacks
            // 
            this.labelTipoSnacks.AutoSize = true;
            this.labelTipoSnacks.Location = new System.Drawing.Point(258, 178);
            this.labelTipoSnacks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTipoSnacks.Name = "labelTipoSnacks";
            this.labelTipoSnacks.Size = new System.Drawing.Size(82, 13);
            this.labelTipoSnacks.TabIndex = 19;
            this.labelTipoSnacks.Text = "Tipo de Snacks";
            // 
            // TxtTipoLimpieza
            // 
            this.TxtTipoLimpieza.Location = new System.Drawing.Point(363, 147);
            this.TxtTipoLimpieza.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTipoLimpieza.Name = "TxtTipoLimpieza";
            this.TxtTipoLimpieza.Size = new System.Drawing.Size(76, 20);
            this.TxtTipoLimpieza.TabIndex = 18;
            this.TxtTipoLimpieza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTipoLimpieza_KeyPress);
            // 
            // labelTipoLimpieza
            // 
            this.labelTipoLimpieza.AutoSize = true;
            this.labelTipoLimpieza.Location = new System.Drawing.Point(260, 147);
            this.labelTipoLimpieza.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTipoLimpieza.Name = "labelTipoLimpieza";
            this.labelTipoLimpieza.Size = new System.Drawing.Size(87, 13);
            this.labelTipoLimpieza.TabIndex = 17;
            this.labelTipoLimpieza.Text = "Tipo de Limpieza";
            this.labelTipoLimpieza.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Miselania.Properties.Resources.venta_online;
            this.pictureBox1.Location = new System.Drawing.Point(26, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto_Miselania.Properties.Resources.R;
            this.pictureBox2.Location = new System.Drawing.Point(446, 10);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // BtLimpiar
            // 
            this.BtLimpiar.Location = new System.Drawing.Point(41, 348);
            this.BtLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.BtLimpiar.Name = "BtLimpiar";
            this.BtLimpiar.Size = new System.Drawing.Size(56, 19);
            this.BtLimpiar.TabIndex = 40;
            this.BtLimpiar.Text = "Limpiar";
            this.BtLimpiar.UseVisualStyleBackColor = true;
            this.BtLimpiar.Click += new System.EventHandler(this.BtLimpiar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(371, 579);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 19);
            this.button3.TabIndex = 42;
            this.button3.Text = "Control de venta";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(582, 609);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtLimpiar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvProductos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonPrueba);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAgregarProducto";
            this.Text = "FormAgregarProducto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAgregarProducto_FormClosing);
            this.Load += new System.EventHandler(this.FormAgregarProducto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private void lvVentas_SelectedIndexChanged(object sender, EventArgs e)
		{
		
		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		#endregion

		private System.Windows.Forms.Label labelNombre;
		private System.Windows.Forms.Label labelPrecio;
		private System.Windows.Forms.Label labelCantidad;
		private System.Windows.Forms.TextBox textBoxNombre;
		private System.Windows.Forms.TextBox textBoxPrecio;
		private System.Windows.Forms.TextBox textBoxCantidad;
		private System.Windows.Forms.ComboBox comboBoxTipoProducto;
		private System.Windows.Forms.Label labelTipoProducto;
		private System.Windows.Forms.TextBox textBoxVolumen;
		private System.Windows.Forms.Label labelVolumen;
		private System.Windows.Forms.Label labelTipoCarne;
		private System.Windows.Forms.TextBox textBoxTipoCarne;
		private System.Windows.Forms.TextBox textBoxTipoHigiene;
		private System.Windows.Forms.Label labelTipoHigiene;
		private System.Windows.Forms.DateTimePicker dateTimePickerFechaCaducidad;
		private System.Windows.Forms.Label labelFechaCaducidad;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button buttonPrueba;
		private System.Windows.Forms.Button buttonEditar;
		private System.Windows.Forms.Button buttonEliminar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvProductos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox TxtTipoLimpieza;
        private System.Windows.Forms.Label labelTipoLimpieza;
        private System.Windows.Forms.TextBox TxtTipoSnacks;
        private System.Windows.Forms.Label labelTipoSnacks;
        private System.Windows.Forms.Button BtLimpiar;
        private System.Windows.Forms.Button button3;
    }
}