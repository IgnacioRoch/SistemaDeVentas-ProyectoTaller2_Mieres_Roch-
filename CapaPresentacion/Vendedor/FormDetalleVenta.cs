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


            Venta oVenta = new CN_Venta().ObtenerVenta(TxtBusqueda.Text);
            if (oVenta.Id_venta !=0)
            {
                TxtNroDocumento.Text = oVenta.NumeroDocumento;
                TxtFecha.Text = oVenta.FechaRegistro;
                TxtTipoDocumento.Text = oVenta.TipoDocumento;
                TxtUsuario.Text = oVenta.objUsuario.Nombre_usuario + " " + oVenta.objUsuario.Apellido_usuario;
                TxtNroDocCliente.Text = oVenta.DocumentoCliente;
                TxtNombreCliente.Text = oVenta.NombreCliente;
                dataGridDatos.Rows.Clear();

                foreach (Detalle_Venta dv in oVenta.objDetalleVenta)
                {
                    dataGridDatos.Rows.Add(new object[]
                    {
                        dv.objProducto.n ,dv.PrecioVenta ,dv.Cantidad , dv.SubTotal
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
                TxtBusqueda.Clear();
            }
        }

        private void BDescaergarPdf_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            string fecha = TxtFecha.Text;
            string tipoDocumento = TxtTipoDocumento.Text;
            string usuario = TxtUsuario.Text;
            string nroDocumento = TxtNroDocCliente.Text;
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
