using CapaPresentacion.Modales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Vendedor
{
    public partial class FormVentas : Form
    {
        public FormVentas()
        {
            InitializeComponent();
        }

        private void IBBuscarProducto_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProducto())
            {
                var result = modal.ShowDialog();
            }
        }

        private void IBBuscarProveedor_Click(object sender, EventArgs e)
        {
            using (var modal = new mdCliente())
            {
                var result = modal.ShowDialog();
            }
        }


        private void IBAgregar_Click_1(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            string fecha = TxtFechaVenta.Text;
            string nroDocumento = TxtNroDocCliente.Text;
            string apellido = TxtApellido.Text;

            if (string.IsNullOrWhiteSpace(fecha) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(nroDocumento))
            {
                MessageBox.Show("Debe Completar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void IBCrearVenta_Click(object sender, EventArgs e)
        {
           // Obtener los valores de los TextBox
           string producto = TxtProducto.Text;
           string precio = TxtProducto.Text;
           string stock = TxtStock.Text;
           string pagaCon = TxtPagacon.Text;
           string cambio = TxtCambio.Text;

            if (string.IsNullOrWhiteSpace(producto) || string.IsNullOrWhiteSpace(precio) || string.IsNullOrWhiteSpace(stock) || string.IsNullOrWhiteSpace(pagaCon) || string.IsNullOrWhiteSpace(cambio))
            {
                MessageBox.Show("Debe Completar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }
    }
}
