
using System;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ExcelDataReader;
using System.Collections.Generic;
using System.Globalization;


namespace Proyecto_Miselania
{
	public partial class FormAgregarProducto : Form
	{
		private Inventario inventario;
		private IProducto productoSeleccionado;
		CultureInfo nicaragua = new CultureInfo("es-NI");
		private const string filePath = "ventas.txt";
		private List<ListViewItem> listaOriginal = new List<ListViewItem>();
		private List<ListViewItem> listaActual = new List<ListViewItem>(); // Lista para los elementos actualmente visibles


		public FormAgregarProducto()
		{
			InitializeComponent();
			/*
			this.inventario = new Inventario();
			this.buttonPrueba.Click += new System.EventHandler(this.Prueba_Click);
			this.buttonEditar.Click += new System.EventHandler(this.Editar_Click);
			this.dgv_Inventario.SelectionChanged += new EventHandler(this.dataGridViewProductos_SelectionChanged);
			this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click); 
			*/
			this.Load += new EventHandler(FormAgregarProducto_Load);
			this.FormClosing += new FormClosingEventHandler(FormAgregarProducto_FormClosing);
			lvProductos.SelectedIndexChanged += new EventHandler(lvVentas_SelectedIndexChanged);
		}



		public FormAgregarProducto(Inventario inventario)
		{
			InitializeComponent();
			this.inventario = inventario ?? throw new ArgumentNullException(nameof(inventario), "El inventario no puede ser nulo.");
			this.buttonPrueba.Click += new System.EventHandler(this.Prueba_Click);
			this.buttonEditar.Click += new System.EventHandler(this.Editar_Click);
			this.dgv_Inventario.SelectionChanged += new EventHandler(this.dataGridViewProductos_SelectionChanged);
			this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);

		}

		private void Prueba_Click(object sender, EventArgs e)
		{
			try
			{
				string nombre = textBoxNombre.Text;
				double precio = Convert.ToDouble(textBoxPrecio.Text);
				int cantidad = Convert.ToInt32(textBoxCantidad.Text);
				string tipoProducto = comboBoxTipoProducto.Text;

				IProducto producto = null;

				switch (tipoProducto)
				{
					case "Bebida":
						double volumen = Convert.ToDouble(textBoxVolumen.Text);
						producto = new ProductoBebida(nombre, volumen, precio, cantidad);
						break;
					case "Carne":
						DateTime fechaCaducidadCarne = dateTimePickerFechaCaducidad.Value;
						string tipoCarne = textBoxTipoCarne.Text;
						producto = new ProductoCarne(nombre, fechaCaducidadCarne, tipoCarne, precio, cantidad);
						break;
					case "Higiene Personal":
						string tipoHigiene = textBoxTipoHigiene.Text;
						producto = new ProductoHigienePersonal(nombre, tipoHigiene, precio, cantidad);
						break;
					default:
						MessageBox.Show("Seleccione un tipo de producto válido.");
						return;
				}

				inventario.AgregarProducto(producto);

				// Guardar el producto en el archivo de texto
				GuardarProductoEnArchivo(producto, "productos.txt");

				LimpiarCampos();
				ActualizarDataGridView();
				MessageBox.Show("Producto agregado correctamente.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ocurrió un error al agregar el producto: " + ex.Message);
			}
		}

		private void GuardarProductoEnArchivo(IProducto producto, string filePath)
		{
			try
			{
				using (StreamWriter writer = new StreamWriter(filePath, true))
				{
					string detallesProducto = ObtenerDetallesProducto(producto);
					writer.WriteLine($"{producto.Nombre}|{producto.Precio}|{producto.Stock}|{producto.GetType().Name}|{detallesProducto}");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ocurrió un error al guardar el producto: " + ex.Message);
			}
		}

		private void LimpiarCampos()
		{
			textBoxNombre.Clear();
			textBoxPrecio.Clear();
			textBoxCantidad.Clear();
			textBoxVolumen.Clear();
			textBoxTipoCarne.Clear();
			textBoxTipoHigiene.Clear();

			comboBoxTipoProducto.SelectedIndex = -1;
			dateTimePickerFechaCaducidad.Value = DateTime.Now;
		}

		private void comboBoxTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
		{
			textBoxTipoCarne.Enabled = false;
			textBoxTipoHigiene.Enabled = false;
			textBoxVolumen.Enabled = false;
			dateTimePickerFechaCaducidad.Enabled = false;
			labelTipoCarne.Enabled = false;
			labelTipoHigiene.Enabled = false;
			labelVolumen.Enabled = false;
			labelFechaCaducidad.Enabled = false;

			if (comboBoxTipoProducto.SelectedItem != null)
			{

				switch (comboBoxTipoProducto.SelectedItem.ToString())
				{
					case "Bebida":
						textBoxVolumen.Enabled = true;
						labelVolumen.Enabled = true;
						break;
					case "Carne":
						textBoxTipoCarne.Enabled = true;
						labelTipoCarne.Enabled = true;
						dateTimePickerFechaCaducidad.Enabled = true;
						labelFechaCaducidad.Enabled = true;
						break;
					case "Higiene Personal":
						textBoxTipoHigiene.Enabled = true;
						labelTipoHigiene.Enabled = true;
						break;
					default:
						MessageBox.Show("Seleccione un tipo de producto válido.");
						break;
				}
			}
			else
			{
				MessageBox.Show("Seleccione un tipo de producto.");
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void CargarVentas()
		{
			lvProductos.Items.Clear();
			listaOriginal.Clear();
			listaActual.Clear(); // Limpiar la lista actual

			if (File.Exists(filePath))
			{
				using (StreamReader reader = new StreamReader(filePath))
				{
					string line;
					while ((line = reader.ReadLine()) != null)
					{
						string[] subItems = line.Split('|');
						ListViewItem item = new ListViewItem(subItems);
						lvProductos.Items.Add(item);
						listaOriginal.Add(item.Clone() as ListViewItem); // Clonar y agregar a listaOriginal
						listaActual.Add(item.Clone() as ListViewItem); // Clonar y agregar a listaActual
					}
				}
			}
		}

		private void FormAgregarProducto_Load(object sender, EventArgs e)
		{
			textBoxTipoCarne.Enabled = false;
			textBoxTipoHigiene.Enabled = false;
			textBoxVolumen.Enabled = false;
			dateTimePickerFechaCaducidad.Enabled = false;
			labelTipoCarne.Enabled = false;
			labelTipoHigiene.Enabled = false;
			labelVolumen.Enabled = false;
			labelFechaCaducidad.Enabled = false;

			/*
			ConfigurarDataGridView();

			// Cargar productos desde el archivo
			CargarProductosDesdeArchivo("productos.txt");

			// Actualizar DataGridView
			ActualizarDataGridView();
			*/

			//lblFecha.Text = DateTime.Today.ToString("d", nicaragua);
			CargarVentas();
		}


		private void ConfigurarDataGridView()
		{
			// Configurar el data
			dgv_Inventario.ColumnCount = 5;
			dgv_Inventario.Columns[0].Name = "Nombre";
			dgv_Inventario.Columns[1].Name = "Precio";
			dgv_Inventario.Columns[2].Name = "Cantidad";
			dgv_Inventario.Columns[3].Name = "Tipo";
			dgv_Inventario.Columns[4].Name = "Detalles";
		}

		private void ActualizarDataGridView()
		{
			dgv_Inventario.Rows.Clear();
			foreach (var producto in inventario.ObtenerProductos())
			{
				string detalles = ObtenerDetallesProducto(producto);
				var row = new DataGridViewRow();
				row.CreateCells(dgv_Inventario,
								producto.Nombre,
								producto.Precio.ToString(),
								producto.Stock.ToString(),
								producto.GetType().Name,
								detalles);
				row.Tag = producto;
				dgv_Inventario.Rows.Add(row);
			}
		}

		private string ObtenerDetallesProducto(IProducto producto)
		{
			try
			{
				return producto.MostrarDetalles();
			}
			catch (NotImplementedException ex)
			{
				return $"Error al obtener detalles: {ex.Message}";
			}
			catch (Exception ex)
			{
				return $"Error desconocido al obtener detalles: {ex.Message}";
			}
		}

		private void dataGridViewProductos_SelectionChanged(object sender, EventArgs e)
		{
			if (dgv_Inventario.SelectedRows.Count > 0)
			{
				productoSeleccionado = (IProducto)dgv_Inventario.SelectedRows[0].Tag;
				CargarDatosProductoSeleccionado();
			}
			else
			{
				productoSeleccionado = null;
			}
		}

		private void CargarDatosProductoSeleccionado()
		{
			if (productoSeleccionado != null)
			{
				textBoxNombre.Text = productoSeleccionado.Nombre;
				textBoxPrecio.Text = productoSeleccionado.Precio.ToString();
				textBoxCantidad.Text = productoSeleccionado.Stock.ToString();
				comboBoxTipoProducto.Text = productoSeleccionado.GetType().Name;

				switch (productoSeleccionado)
				{
					case ProductoBebida bebida:
						textBoxVolumen.Text = bebida.VolumenLitros.ToString();
						break;
					case ProductoCarne carne:
						textBoxTipoCarne.Text = carne.TipoCarne;
						dateTimePickerFechaCaducidad.Value = carne.FechaCaducidad;
						break;
					case ProductoHigienePersonal higiene:
						textBoxTipoHigiene.Text = higiene.Tipo;
						break;
					default:
						LimpiarCampos();
						break;
				}
			}
			else
			{
				LimpiarCampos();
			}
		}
		private void CargarProductosDesdeArchivo(string filePath)
		{
			try
			{
				if (File.Exists(filePath))
				{
					using (StreamReader reader = new StreamReader(filePath))
					{
						string line;
						while ((line = reader.ReadLine()) != null)
						{
							string[] datos = line.Split('|');
							if (datos.Length >= 4)
							{
								string nombre = datos[0];
								double precio = Convert.ToDouble(datos[1]);
								int cantidad = Convert.ToInt32(datos[2]);
								string tipoProducto = datos[3];

								IProducto producto = null;
								switch (tipoProducto)
								{
									case "ProductoBebida":
										double volumen = Convert.ToDouble(datos[4]);
										producto = new ProductoBebida(nombre, volumen, precio, cantidad);
										break;
									case "ProductoCarne":
										string tipoCarne = datos[4];
										DateTime fechaCaducidad = DateTime.Parse(datos[5]);
										producto = new ProductoCarne(nombre, fechaCaducidad, tipoCarne, precio, cantidad);
										break;
									case "ProductoHigienePersonal":
										string tipoHigiene = datos[4];
										producto = new ProductoHigienePersonal(nombre, tipoHigiene, precio, cantidad);
										break;
								}

								if (producto != null)
								{
									inventario.AgregarProducto(producto);
								}
							}
						}
					}
				}
				else
				{
					MessageBox.Show("El archivo no existe en la ubicación especificada.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ocurrió un error al cargar los productos: " + ex.Message);
			}
		}


		private void Editar_Click(object sender, EventArgs e)
		{

			try
			{
				productoSeleccionado.Nombre = textBoxNombre.Text;
				productoSeleccionado.Precio = Convert.ToDouble(textBoxPrecio.Text);
				productoSeleccionado.Stock = Convert.ToInt32(textBoxCantidad.Text);

				switch (productoSeleccionado)
				{
					case ProductoBebida bebida:
						bebida.VolumenLitros = Convert.ToDouble(textBoxVolumen.Text);
						break;
					case ProductoCarne carne:
						carne.TipoCarne = textBoxTipoCarne.Text;
						carne.FechaCaducidad = dateTimePickerFechaCaducidad.Value;
						break;
					case ProductoHigienePersonal higiene:
						higiene.Tipo = textBoxTipoHigiene.Text;
						break;
				}
				if (productoSeleccionado == null)
				{
					MessageBox.Show("Seleccione un producto para editar.");

				}

				LimpiarCampos();
				ActualizarDataGridView();
				MessageBox.Show("Producto editado correctamente.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ocurrió un error al editar el producto: " + ex.Message);
			}
		}
		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void buttonEliminar_Click(object sender, EventArgs e)
		{
			if (productoSeleccionado == null)
			{
				MessageBox.Show("Seleccione un producto para eliminar.");
				return;
			}

			// confirmación
			DialogResult result = MessageBox.Show($"¿Está seguro de eliminar el producto {productoSeleccionado.Nombre}?",
												  "Confirmar Eliminación",
												  MessageBoxButtons.YesNo,
												  MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				try
				{
					inventario.EliminarProducto(productoSeleccionado);
					LimpiarCampos();
					ActualizarDataGridView();
					MessageBox.Show($"Producto {productoSeleccionado.Nombre} eliminado correctamente.");
					return;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Ocurrió un error al eliminar el producto: " + ex.Message);
				}
			}
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void textBoxNombre_TextChanged(object sender, EventArgs e)
		{
		}

		private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
		{

			if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
			{
				MessageBox.Show("Solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Handled = true;
				return;
			}
		}

		private void textBoxTipoCarne_KeyPress(object sender, KeyPressEventArgs e)
		{

			if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
			{
				MessageBox.Show("Solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Handled = true;
				return;
			}
		}

		private void textBoxTipoHigiene_KeyPress(object sender, KeyPressEventArgs e)
		{

			if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
			{
				MessageBox.Show("Solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Handled = true;
				return;
			}
		}

		private void textBoxCantidad_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
			{
				MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Handled = true;
				return;
			}
		}

		private void textBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
			{
				MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Handled = true;
				return;
			}
		}

		private void textBoxVolumen_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
			{
				MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Handled = true;
				return;
			}
		}

		private void GuardarProducto()
		{
			using (StreamWriter writer = new StreamWriter(filePath))
			{
				foreach (ListViewItem item in lvProductos.Items)
				{
					string[] subItems = new string[item.SubItems.Count];
					for (int i = 0; i < item.SubItems.Count; i++)
					{
						subItems[i] = item.SubItems[i].Text;
					}
					writer.WriteLine(string.Join("|", subItems));
				}
			}
		}

		private void FormAgregarProducto_FormClosing(object sender, FormClosingEventArgs e)
		{
			GuardarProducto();
		}

		private void ActualizarPrecio()
		{
			if (textBoxNombre.Text != "")
			{
				string producto = textBoxNombre.Text;
				double precio = Convert.ToDouble(textBoxPrecio.Text);

			}
		}

		private void lvVentas_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lvProductos.SelectedItems.Count > 0)
			{
				// Cargar datos del elemento seleccionado en los controles de edición
				ListViewItem selectedItem = lvProductos.SelectedItems[0];
				textBoxNombre.Text = selectedItem.SubItems[0].Text;
				textBoxPrecio.Text = selectedItem.SubItems[1].Text;
				textBoxCantidad.Text = selectedItem.SubItems[3].Text;
				comboBoxTipoProducto.Text = selectedItem.SubItems[4].Text;
				ActualizarPrecio(); // Actualizar el precio en lblPrecioDelProducto
			}
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			if (textBoxNombre.Text == "")
			{
				MessageBox.Show("Debe seleccionar un producto..!!!");
			}
			else if (string.IsNullOrWhiteSpace(textBoxCantidad.Text) || !int.TryParse(textBoxCantidad.Text, out int cantidad))
			{
				MessageBox.Show("Debe ingresar una cantidad válida..!!!");
			}
			else if (comboBoxTipoProducto.SelectedIndex == -1)
			{
				MessageBox.Show("Debe seleccionar un tipo..!!!");
			}
			else
			{
				string producto = textBoxNombre.Text;
				double precio = Convert.ToDouble(textBoxPrecio.Text);
				string tipo = comboBoxTipoProducto.Text;


				// Impresion
				ListViewItem fila = new ListViewItem(producto);
				fila.SubItems.Add(cantidad.ToString());
				fila.SubItems.Add(precio.ToString("C", nicaragua));
				fila.SubItems.Add(tipo);


				lvProductos.Items.Add(fila);
				listaOriginal.Add(fila.Clone() as ListViewItem); // Clonar y agregar a listaOriginal
				listaActual.Add(fila.Clone() as ListViewItem); // Clonar y agregar a listaActual
				LimpiarCampos();
			}
		}
	}
}