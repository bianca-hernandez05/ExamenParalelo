using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Miselania
{
	public class ProductoLimpieza : Producto
	{
		public string Tipo { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public ProductoLimpieza(string tipo, DateTime fechaCaducidad, string nombre, double precio, int stock) : base(nombre, precio, stock)
		{
			Tipo=tipo;
			FechaCaducidad=fechaCaducidad;
		}

		public override string MostrarDetalles()
		{
			base.MostrarDetalles();
			return $"Tipo: {Tipo}";
		}
	}
}
