using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Miselania
{
	public class Venta
	{
		public IProducto Producto { get; set; }
		public int CantidadVendida { get; set; }
		public DateTime Fecha { get; set; }

		public double CalcularTotal()
		{
			return Producto.Precio * CantidadVendida;
		}

		public void MostrarDetalles()
		{
			Console.WriteLine($"Producto: {Producto.Nombre}, Cantidad Vendida: {CantidadVendida}, Fecha: {Fecha}, Total: {CalcularTotal()}");
		}
	}
}
