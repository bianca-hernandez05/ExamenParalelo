using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Miselania
{
	public interface IProducto
	{
		string Nombre { get; set; }
		double Precio { get; set; }
		int Stock { get; set; }
		string TipoProducto { get; }

		string MostrarDetalles();
	}
}
