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
    public partial class mdDetalleCompra : Form
    {
        public mdDetalleCompra(string codigoCompra)
        {
            InitializeComponent();
            TxtBusqueda.Text = codigoCompra;
        }

        private void IBBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = TxtBusqueda.Text;

            if (string.IsNullOrWhiteSpace(busqueda))
            {
                MessageBox.Show("Debe Completar el campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Compra oCompra = new CN_Compra().ObtenerCompra(TxtBusqueda.Text);
            if (oCompra.Id_compra != 0)
            {
                dataGridDatos.Rows.Clear();
                foreach (Detalle_Compra dc in oCompra.objDetalleCompra)
                {
                    dataGridDatos.Rows.Add(new object[]
                    {
                        dc.oProducto.Nombre_producto, dc.PrecioCompra, dc.Cantidad, dc.MontoTotal
                    });
                }
            }
            else
            {
                MessageBox.Show("No existe el numero de compra solicitada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
