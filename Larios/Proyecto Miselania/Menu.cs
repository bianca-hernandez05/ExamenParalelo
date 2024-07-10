using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Miselania
{
    public partial class Menu : Form
    {
        private Inventario inventario;
        public Menu()
        {
            InitializeComponent();
            

        }
            private void inicioDeSesionToolStripMenuItem_Click(object sender, EventArgs e)
            {

            }

            private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
            {
                FormAgregarProducto formAgregarProducto = new FormAgregarProducto(inventario);
                formAgregarProducto.ShowDialog();
            }

        private void controlDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormControlVenta formControlVenta = new FormControlVenta(inventario);
            formControlVenta.ShowDialog();  
        }
    }
    }

