using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Miselania
{
	public class ProductoAlimenticio : Producto
	{
		public DateTime FechaCaducidad { get; set; }

		public ProductoAlimenticio(DateTime fechaCaducidad, string nombre, int precio, int stock) :base(nombre,precio, stock)
		{
			FechaCaducidad = fechaCaducidad;
		}

		public override string MostrarDetalles()
		{
			base.MostrarDetalles();
			
			return $"Fecha Caducidad: {FechaCaducidad.ToShortDateString()}";
		}
	}
}
