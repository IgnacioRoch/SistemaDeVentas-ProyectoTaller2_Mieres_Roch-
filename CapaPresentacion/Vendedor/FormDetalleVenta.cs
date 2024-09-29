using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Vendedor
{
    public partial class FormDetalleVenta : Form
    {
        public FormDetalleVenta()
        {
            InitializeComponent();
        }

        private void IBBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = TxtBusqueda.Text;

            if (string.IsNullOrWhiteSpace(busqueda))
            {
                MessageBox.Show("Debe Completar el campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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
                TxtBusqueda.Clear();
            }
        }

        private void BDescaergarPdf_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            string fecha = TxtFecha.Text;
            string tipoDocumento = TxtTipoDocumento.Text;
            string usuario = TxtUsuario.Text;
            string nroDocumento = TxtNroDocumento.Text;
            string nombreCliente =  TxtNombreCliente.Text;
            string montoTotal = TxtMontoTotal.Text;

            if (string.IsNullOrWhiteSpace(fecha) || string.IsNullOrWhiteSpace(tipoDocumento) || string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(nroDocumento)
               || string.IsNullOrWhiteSpace(nombreCliente) || string.IsNullOrWhiteSpace(montoTotal))
            {
                MessageBox.Show("Los campos están vacios, no puede generar el pdf.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}
