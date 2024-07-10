using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Miselania
{
	public partial class FormControlVenta : Form
	{
		private Inventario inventario;
		CultureInfo nicaragua = new CultureInfo("es-NI");
		private const string filePath = "Productos.txt";
		private readonly FormClosingEventHandler FormControlVenta_FormClosing;
		private List<ListViewItem> listaOriginal = new List<ListViewItem>();
		private List<ListViewItem> listaActual = new List<ListViewItem>(); // Lista para los elementos actualmente visibles
		int Posicion;

	
		public FormControlVenta(Inventario inventario)
		{
			InitializeComponent();
			this.inventario = inventario;
			this.Load += FormControlVenta_Load;
			CargarProductosEnListView();
		}

		public void cargarProducto()
		{
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] subItems = line.Split('|');
                        ListViewItem item = new ListViewItem(subItems);
                        listView1.Items.Add(item);
                        listaOriginal.Add(item.Clone() as ListViewItem);
                        listaActual.Add(item.Clone() as ListViewItem);
                    }
                }
            }
        }


		private void CargarProductosEnListView()
		{
			/*
			lvVentas.Items.Clear();
			List<IProducto> productos = inventario.ObtenerProductos();
			foreach (var producto in productos)
			{
				ListViewItem item = new ListViewItem(producto.Nombre);
				item.SubItems.Add(producto.Precio.ToString());
				item.SubItems.Add(producto.Stock.ToString());
				// Agregar más subítems según sea necesario
				lvVentas.Items.Add(item);
			}
			*/
			cargarProducto();
		}
		
		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void FormControlVenta_Load(object sender, EventArgs e)
		{
			
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnBuscar_Click_1(object sender, EventArgs e)
		{
			string textoBusqueda = txtBuscar.Text.Trim();

			listView1.Items.Clear(); // Limpiar elementos actuales en ListView
			listaActual.Clear(); // Limpiar la lista actual

			// Iterar sobre los elementos originales y filtrar según el texto de búsqueda
			foreach (ListViewItem item in listaOriginal)
			{
				bool coincide = false;
				foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
				{
					if (subItem.Text.IndexOf(textoBusqueda, StringComparison.OrdinalIgnoreCase) >= 0)
					{
						coincide = true;
						break;
					}
				}
				if (coincide)
				{
					ListViewItem clonedItem = (ListViewItem)item.Clone();
					listView1.Items.Add(clonedItem); // Clonar el elemento y agregarlo a lvVentas
					listaActual.Add(clonedItem); // Agregar el elemento a la lista actual
				}
			}
		}

        private void button1_Click(object sender, EventArgs e)
        {
			if (listView1.SelectedItems.Count > 0)
			{
				
				ListViewItem selectedItem = listView1.SelectedItems[0];

				/*
				selectedItem.SubItems[0].Text = textBoxNombre.Text;
				selectedItem.SubItems[1].Text = textBoxPrecio.Text;
				selectedItem.SubItems[2].Text = textBoxCantidad.Text;
				selectedItem.SubItems[3].Text = comboBoxTipoProducto.Text;
				*/

                string nombre = selectedItem.SubItems[0].Text;
                double precio = Convert.ToDouble(selectedItem.SubItems[1].Text);
                int cantidad = Convert.ToInt32(selectedItem.SubItems[2].Text);
                string tipoProducto = selectedItem.SubItems[3].Text;

				dataGridView1.Rows[0].Cells[1].Value = nombre;
                //dataGridView1.Rows[1].Cells[1].Value = precio;
                //dataGridView1.Rows[2].Cells[2].Value = cantidad.ToString();
                //dataGridView1.Rows[3].Cells[3].Value = tipoProducto;

                MessageBox.Show("Producto editado y guardado correctamente.");
			}
			else
			{
				MessageBox.Show("Seleccione un producto para editar.");
			}
        }

        private void GuardarProducto()
        {
            throw new NotImplementedException();
        }

        private void lvVentas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

		private void lblFecha_Click(object sender, EventArgs e)
		{

		}
    }
}
