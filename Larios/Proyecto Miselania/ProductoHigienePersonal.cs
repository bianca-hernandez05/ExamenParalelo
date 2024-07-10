using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Miselania
{
	public class ProductoHigienePersonal : Producto
	{

		public string Tipo { get; set; }  // Ej. Jabón, Shampoo, etc.
		public ProductoHigienePersonal(string tipo,string nombre, double precio, int stock) : base(nombre, precio, stock)
		{
           Tipo = tipo;
		}

		public override string MostrarDetalles()
		{
			base.MostrarDetalles();
		
			return $"Tipo: {Tipo}";
	
	     }
	}
}
