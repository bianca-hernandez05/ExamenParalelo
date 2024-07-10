using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Miselania
{
    public class ProductoSnacks : Producto
    {
        public DateTime FechaCaducidad { get; set; }
        public string TipoSnacks { get; set; }

        public ProductoSnacks(string tipoSnacks, DateTime fechaCaducidad, string nombre, double precio, int stock) : base(nombre, precio, stock)
        {
            TipoSnacks = tipoSnacks;
            FechaCaducidad = fechaCaducidad;
        }
    }
}
