using CapaPresentacion.Modales;
using CapaPresentacion.Utilidades;
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
        
        private void IBAgregar_Click_1(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            string fecha = TxtFechaVenta.Text;
            string nroDocumento = TxtNroDocCliente.Text;
            string apellido = TxtApellido.Text;

            if (string.IsNullOrWhiteSpace(fecha) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(nroDocumento))
            {
                MessageBox.Show("Debe completar todos los campos necesarios para agregar un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Debe completar todos los campos antes de concretar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        private void FormVentas_Load(object sender, EventArgs e)
        {

            CBTipoDocVenta.Items.Add(new Opcion_combo() { Valor = "Boleta", Texto = "Boleta" });
            CBTipoDocVenta.Items.Add(new Opcion_combo() { Valor = "Fectura", Texto = "Fectura" });
            CBTipoDocVenta.DisplayMember = "Texto";
            CBTipoDocVenta.ValueMember = "Valor";
            CBTipoDocVenta.SelectedIndex = 0;

            TxtFechaVenta.Text = DateTime.Now.ToString("dd/MM/yyyy");

            TextIdProducto.Text = "0";
            TxtPagacon.Text = "";
            TxtCambio.Text = "";
            TxtTotalPagar.Text = "0";
        }

        private void IBBuscarCliente_Click(object sender, EventArgs e)
        {
            using (var modal = new mdCliente())
            {
                var result = modal.ShowDialog();
            }
        }
    }
}
