using CapaPresentacion.Modales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Gerente_Comercial
{
    public partial class FormCompras : Form
    {
        public FormCompras()
        {
            InitializeComponent();
        }

        private void IBBuscarProveedor_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProveedor())
            {
                var result = modal.ShowDialog();
            }
        }

        private void IBBuscarProducto_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProducto())
            {
                var result = modal.ShowDialog();
            }
        }

        private void IBAgregar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox  

            string fecha = TxtFecha.Text;
            string nroDocumento = TxtNroDocProveedor.Text;
            string razonSocial = TxtRazonSocial.Text;

            if (string.IsNullOrWhiteSpace(fecha) || string.IsNullOrWhiteSpace(razonSocial) || string.IsNullOrWhiteSpace(nroDocumento))
            {
                MessageBox.Show("Debe Completar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        private void IBRegistrarCompra_Click(object sender, EventArgs e)
        {
            string producto = TxtProducto.Text;
            string precioCompra = TxtPrecioCompra.Text;
            string precioVenta = TxtPrecioVenta.Text;

            if (string.IsNullOrWhiteSpace(producto) || string.IsNullOrWhiteSpace(precioCompra) || string.IsNullOrWhiteSpace(precioVenta) )
            {
                MessageBox.Show("Debe Completar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}
