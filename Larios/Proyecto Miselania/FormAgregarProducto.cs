using System;
using System.IO;
using System.Windows.Forms;
using System.Globalization;
using System.Collections.Generic;
using System.Collections;

namespace Proyecto_Miselania
{
	public partial class FormAgregarProducto : Form
	{
		private Inventario inventario;
		private IProducto productoSeleccionado;
      
        CultureInfo nicaragua = new CultureInfo("es-NI");
		private const string filePath = "Productos.txt";
		private List<ListViewItem> listaOriginal = new List<ListViewItem>();
		private List<ListViewItem> listaActual = new List<ListViewItem>();

		public FormAgregarProducto()
		{
			InitializeComponent();
		}

		public FormAgregarProducto(Inventario inventario)
		{
			InitializeComponent();
     
		}

		
		private void lvVenta_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lvProductos.SelectedItems.Count > 0)
			{
				// Obtener el elemento seleccionado
				ListViewItem selectedItem = lvProductos.SelectedItems[0];

				// Mostrar detalles o realizar alguna acción en función del elemento seleccionado
				// Por ejemplo, mostrar los detalles en los controles de edición TextBox, ComboBox, etc.
				textBoxNombre.Text = selectedItem.SubItems[0].Text;
				textBoxPrecio.Text = selectedItem.SubItems[1].Text;
				textBoxCantidad.Text = selectedItem.SubItems[2].Text;
				comboBoxTipoProducto.Text = selectedItem.SubItems[3].Text;
			
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
			TxtTipoLimpieza.Enabled = false;
			TxtTipoSnacks.Enabled = false;
			labelTipoLimpieza.Enabled=false;
			labelTipoSnacks.Enabled =false;
			CargarProductos();
		}

		private void FormAgregarProducto_FormClosing(object sender, FormClosingEventArgs e)
		{
			GuardarProducto();
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

		private void CargarProductos()
		{
			lvProductos.Items.Clear();
			listaOriginal.Clear();
			listaActual.Clear();

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
						listaOriginal.Add(item.Clone() as ListViewItem);
						listaActual.Add(item.Clone() as ListViewItem);
					}
				}
			}
		}
		private void Editar_Click(object sender, EventArgs e)
		{
			if (lvProductos.SelectedItems.Count > 0)
			{
				ListViewItem selectedItem = lvProductos.SelectedItems[0];
				selectedItem.SubItems[0].Text = textBoxNombre.Text;
				selectedItem.SubItems[1].Text = textBoxPrecio.Text;
				selectedItem.SubItems[2].Text = textBoxCantidad.Text;
				selectedItem.SubItems[3].Text = comboBoxTipoProducto.Text;
			

                GuardarProducto();
				MessageBox.Show("Producto editado y guardado correctamente.");
			}
			else
			{
				MessageBox.Show("Seleccione un producto para editar.");
			}
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
            labelTipoLimpieza.Enabled = false;
            labelTipoSnacks.Enabled = false;
            labelFechaCaducidad.Enabled = false;
			TxtTipoSnacks.Enabled = false;
			TxtTipoLimpieza.Enabled = false;
			

			if (comboBoxTipoProducto.SelectedItem != null)
			{

				switch (comboBoxTipoProducto.SelectedItem.ToString())
				{
					case "Bebida":
						textBoxVolumen.Enabled = true;
						labelVolumen.Enabled = true;
						dateTimePickerFechaCaducidad.Enabled = true;
						labelFechaCaducidad.Enabled=true;
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
						dateTimePickerFechaCaducidad.Enabled = true;
						labelFechaCaducidad.Enabled = true;
						break;
					case "Limpieza":
						TxtTipoLimpieza.Enabled = true;
						labelTipoLimpieza.Enabled=true;
						dateTimePickerFechaCaducidad.Enabled= true;
						labelFechaCaducidad.Enabled = true;

						break;
					case "Snacks":
						TxtTipoSnacks.Enabled = true;
						labelTipoSnacks.Enabled = true;
						dateTimePickerFechaCaducidad.Enabled = true;
						labelFechaCaducidad.Enabled = true;

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
		private void buttonEliminar_Click(object sender, EventArgs e)
		{
			try
			{
				if (lvProductos.SelectedItems.Count > 0)
				{
					// Eliminar el elemento seleccionado en lvVentas
					var selectedItem = lvProductos.SelectedItems[0];
					lvProductos.Items.Remove(selectedItem);

					// Eliminar de listaActual
					listaActual.RemoveAll(item => item.SubItems[0].Text == selectedItem.SubItems[0].Text &&
												   item.SubItems[1].Text == selectedItem.SubItems[1].Text &&
												   item.SubItems[2].Text == selectedItem.SubItems[2].Text &&
												   item.SubItems[3].Text == selectedItem.SubItems[3].Text &&
												   item.SubItems[4].Text == selectedItem.SubItems[4].Text &&
												   item.SubItems[5].Text == selectedItem.SubItems[5].Text &&
												   item.SubItems[6].Text == selectedItem.SubItems[6].Text);
				}
				else
				{
					MessageBox.Show("Seleccione un producto para eliminar.");
				}
			}
			catch (ArgumentOutOfRangeException ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
				
			}
			LimpiarCampos();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
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
                    case "Limpieza":
						DateTime fechacaducidadLimpieza = dateTimePickerFechaCaducidad.Value;
                        string tipolimpieza = TxtTipoLimpieza.Text;
						producto = new ProductoLimpieza(tipolimpieza,fechacaducidadLimpieza, nombre, precio, cantidad);
                        break;
                    case "Snacks":
						DateTime fechacaducidadSnack = dateTimePickerFechaCaducidad.Value;
						string tipoSnacks = TxtTipoSnacks.Text;
                        producto = new ProductoSnacks(tipoSnacks, fechacaducidadSnack, nombre, precio , cantidad);
						break;
                    default:
                        MessageBox.Show("Seleccione un tipo de producto válido.");
                        return;
                }

                if (producto != null)
                {
                    if (inventario != null)
                    {
                        inventario.AgregarProducto(producto);

                        // Crear el ListViewItem y agregarlo al ListView
                        ListViewItem item = new ListViewItem(new string[]
                        {
                           producto.Nombre,
                           producto.Precio.ToString("C", nicaragua),
                           producto.Stock.ToString(),
						   tipoProducto
						   
                        });
                        lvProductos.Items.Add(item); // Agregar el nuevo item a lvProductos
                        GuardarProducto(); // Guardar en el archivo
                        MessageBox.Show("Producto agregado y guardado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("El inventario no ha sido inicializado correctamente.");
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo crear el producto. Verifique los datos ingresados.");
                }
            }
            catch (FormatException)
			{
				MessageBox.Show("Ingrese valores válidos para precio y stock.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ocurrió un error: " + ex.Message);
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
			TxtTipoLimpieza.Clear();

			comboBoxTipoProducto.SelectedIndex = -1;

        }
		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			// Aquí puedes agregar cualquier lógica que necesites
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

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtLimpiar_Click(object sender, EventArgs e)
        {
			LimpiarCampos();
        }

        private void TxtTipoLimpieza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtTipoSnacks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
			try
			{
				FormControlVenta formControlVenta = new FormControlVenta(inventario);
				formControlVenta.Show();
			}
			catch (Exception ex)
			{

				MessageBox.Show("Error: "+ ex);
			}
        }
    }
    


}

