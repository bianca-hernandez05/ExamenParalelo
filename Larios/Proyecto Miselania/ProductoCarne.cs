using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Miselania
{
	public class ProductoCarne : Producto
	{

		public DateTime FechaCaducidad { get; set; }
		public string TipoCarne { get; set; }  // Res, Pollo, Cerdo, etc.

		public ProductoCarne(string tipoCarne,DateTime fechaCaducidad,string nombre, double precio, int stock) : base(nombre, precio, stock)
		{
			TipoCarne = tipoCarne;
            FechaCaducidad = fechaCaducidad;
		}

		public override string MostrarDetalles()
		{
            base.MostrarDetalles();
			return $"Tipo de Carne: {TipoCarne}, Fecha Caducidad: {FechaCaducidad.ToShortDateString()}";
		}

	}
}
