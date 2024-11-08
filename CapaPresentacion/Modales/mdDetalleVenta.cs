using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Modales
{
    public partial class mdDetalleVenta : Form
    {
        public mdDetalleVenta(string codigo)
        {
            InitializeComponent();
            TxtBusqueda.Text = codigo;
        }

        private void IBBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = TxtBusqueda.Text;

            if (string.IsNullOrWhiteSpace(busqueda))
            {
                MessageBox.Show("Debe Completar el campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Venta oVenta = new CN_Venta().ObtenerVenta(TxtBusqueda.Text);
            if (oVenta.Id_venta != 0)
            {           
                dataGridDatos.Rows.Clear();

                foreach (Detalle_Venta dv in oVenta.objDetalleVenta)
                {
                    dataGridDatos.Rows.Add(new object[]
                    {
                       dv.objProducto.Nombre_producto ,dv.PrecioVenta ,dv.Cantidad , dv.SubTotal
                    });
                }              

            }
        }

        private void IBLimpiar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox  
            string busqueda = TxtBusqueda.Text;

            if (string.IsNullOrWhiteSpace(busqueda)
               )
            {
                MessageBox.Show("El campo está vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("¿Limpiar el campo de busqueda?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TxtBusqueda.Text = "";
                dataGridDatos.Rows.Clear();

            }
        }
    }
}
