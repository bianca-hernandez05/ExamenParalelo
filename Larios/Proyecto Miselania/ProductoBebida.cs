using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Miselania
{
	public class ProductoBebida : Producto
	{
		
		public double VolumenLitros { get; set; }
		public double Volumen { get; }

		public ProductoBebida(double volumenLitros,string nombre, double precio, int stock) : base(nombre, precio, stock)
		{
			VolumenLitros = volumenLitros;
		}

		public ProductoBebida(string nombre, double volumen, double precio, int stock) : base(nombre, precio, stock)
		{
			Nombre = nombre;
			Volumen = volumen;
			Precio = precio;
			Stock = stock;
		}

		public override string MostrarDetalles()
		{
			base.MostrarDetalles();
			
         return $"Volumen: {VolumenLitros} litros";
		}
	}
}
