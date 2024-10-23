using CapaEntidades;
using CapaNegocio;
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

        private Usuario _Usuario;
        public FormVentas(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }

        private void IBBuscarProducto_Click(object sender, EventArgs e)
        {

            using (var modal = new mdProducto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    TextIdProducto.Text = modal._Producto.Id_producto.ToString();
                    TextCodProducto.Text = modal._Producto.Codigo_producto;
                    TxtProducto.Text = modal._Producto.Nombre_producto;
                    TxtPrecio.Text = modal._Producto.PrecioVenta_producto.ToString("0.00");
                    TxtStock.Text = modal._Producto.Stock_producto.ToString();
                    TxtCantidad.Select();
                }
                else
                {
                    TextCodProducto.Select();
                }
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

            decimal precio = 0;
            bool producto_existe = false;

            if (int.Parse(TextIdProducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(TxtPrecio.Text, out precio))
            {
                MessageBox.Show("Precio compra - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtPrecio.Select();
                return;
            }

            if (Convert.ToInt32(TxtStock.Text)< Convert.ToInt32(TxtCantidad.Value.ToString())) {
                MessageBox.Show("La cantidad no puede ser mayor al stock", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (DataGridViewRow fila in dataGridDatos.Rows)
            {
                if (fila.Cells["IdProducto"].Value.ToString() == TextIdProducto.Text)
                {
                    producto_existe = true;
                    break;
                }
            }

            if (!producto_existe)
            {
                dataGridDatos.Rows.Add(new object[]
                {
                    TextIdProducto.Text,
                    TxtProducto.Text,
                    precio.ToString("0.00"),
                    TxtCantidad.Value.ToString(),
                    (TxtCantidad.Value * precio).ToString("0.00")
                });
                calcularTotal();
                limpiarProducto();
                TextCodProducto.Select();
            }

        }

        private void calcularTotal()
        {
            decimal total = 0;
            if (dataGridDatos.Rows.Count >= 0)
            {
                foreach (DataGridViewRow row in dataGridDatos.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
                }
                TxtTotalPagar.Text = total.ToString("0.00");
            }
        }

        private void limpiarProducto()
        {
            TextIdProducto.Text = "0";
            TextCodProducto.Text = "";
            TextCodProducto.BackColor = Color.White;
            TxtProducto.Text = "";
            TxtPrecio.Text = "";
            TxtCantidad.Value = 1;
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

                if (result == DialogResult.OK)
                {
                    TxtNroDocCliente.Text = modal._Cliente.Documento_cliente.ToString();
                    TxtApellido.Text = modal._Cliente.Apellido_cliente;
                    TextCodProducto.Select();
                }
                else
                {
                    TxtNroDocCliente.Select();
                }
            }


        }

        private void TextCodProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Producto oProducto = new CN_Producto().Listar().Where(p => p.Codigo_producto == TextCodProducto.Text && p.Estado_producto == true).FirstOrDefault();

                if (oProducto != null)
                {
                    TextCodProducto.BackColor = Color.Honeydew;
                    TextIdProducto.Text = oProducto.Id_producto.ToString();
                    TxtProducto.Text = oProducto.Nombre_producto;
                    TxtPrecio.Text = oProducto.PrecioVenta_producto.ToString("0.00");
                    TxtStock.Text = oProducto.Stock_producto.ToString();
                    TxtCantidad.Select();
                }
                else
                {
                    TextCodProducto.BackColor = Color.MistyRose;
                    TextIdProducto.Text = "0";
                    TxtProducto.Text = "";
                }
            }
        }

        private void dataGridDatos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.iconBorrar.Width;
                var h = Properties.Resources.iconBorrar.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.iconBorrar, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dataGridDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridDatos.Columns[e.ColumnIndex].Name == "BEliminar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    dataGridDatos.Rows.RemoveAt(indice);
                    calcularTotal();
                }
            }
        }

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (TxtPrecio.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void TxtPagacon_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (TxtPagacon.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }

        }

        private void calcularcambio()
        {
            if (TxtTotalPagar.Text.Trim() == "")
            {
                MessageBox.Show("No existen productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            decimal pagacon;
            decimal total = Convert.ToDecimal(TxtTotalPagar.Text);

            if (TxtPagacon.Text.Trim() == "")
            {
                TxtPagacon.Text = "0";
            }

            if (decimal.TryParse(TxtPagacon.Text.Trim(), out pagacon)){
                if (pagacon < total)
                {
                    TxtCambio.Text = "0.00";
                }
                else
                {
                    decimal cambio = pagacon - total;
                    TxtCambio.Text = cambio.ToString();
                }
            }


        }

        private void TxtPagacon_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                calcularcambio();
            }

        }
    }
}
