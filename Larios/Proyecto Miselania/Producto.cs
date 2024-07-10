using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Miselania
{
	public class Producto : IProducto
	{
		public string Nombre { get; set; }
		public double Precio { get; set; }
		public int Stock { get; set; }

		public Producto(string nombre, double precio, int stock)
		{
			Nombre = nombre;
			Precio = precio;
			Stock = stock;
		}

		public virtual string MostrarDetalles()
		{
			
          return $"Nombre: {Nombre}, Precio: {Precio}, Stock: {Stock}";
		}
		public string TipoProducto
		{
			get { return "Producto Genérico"; } 
		}
	}
}
