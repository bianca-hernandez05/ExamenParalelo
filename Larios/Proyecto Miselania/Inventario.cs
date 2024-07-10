using System;
using System.Collections.Generic;

namespace Proyecto_Miselania
{
	public class Inventario
	{
		private List<IProducto> productos;
		private List<Venta> ventas;

		public Inventario()
		{
			productos = new List<IProducto>();
			ventas = new List<Venta>();
		}

		public void AgregarProducto(IProducto producto)
		{
			productos.Add(producto);
		}

		public List<IProducto> ObtenerProductos()
		{
            Inventario inventario = new Inventario(); 
            return productos;
		}

		public void EliminarProducto(IProducto producto)
		{
			productos.Remove(producto);
		}

		public void AgregarVenta(Venta venta)
		{
			ventas.Add(venta);
		}

		public List<Venta> ObtenerVentas()
		{
			return ventas;
		}

		
	}

}

