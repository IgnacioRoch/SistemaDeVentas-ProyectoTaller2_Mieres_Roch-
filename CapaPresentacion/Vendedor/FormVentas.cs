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
            string apellido = TxtCliente.Text;

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

                bool respuesta = new CN_Venta().RestarStock(
                    Convert.ToInt32(TextIdProducto.Text),
                    Convert.ToInt32(TxtCantidad.Value.ToString())
                    );

                if (respuesta)
                {
                    dataGridDatos.Rows.Add(new object[] {
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
            TxtStock.Text = "";
            TxtCantidad.Value = 1;
        }



        private void IBCrearVenta_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            string fecha = TxtFechaVenta.Text;
            string nroDocumento = TxtNroDocCliente.Text;
            string apellido = TxtCliente.Text;

            if (string.IsNullOrWhiteSpace(fecha) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(nroDocumento))
            {
                MessageBox.Show("Debe completar todos los campos necesarios para agregar un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dataGridDatos.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos a la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            DialogResult ask = MessageBox.Show("¿Seguro que desea registrar la vanta?", "Confirmar Inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (ask == DialogResult.Yes)
            {

                DataTable detalle_venta = new DataTable();
                detalle_venta.Columns.Add("Id_Producto", typeof(int));
                detalle_venta.Columns.Add("PrecioVenta", typeof(decimal));
                detalle_venta.Columns.Add("Cantidad", typeof(int));
                detalle_venta.Columns.Add("SubTotal", typeof(decimal));


                foreach (DataGridViewRow row in dataGridDatos.Rows)
                {
                    detalle_venta.Rows.Add(new object[] {
                    row.Cells["IdProducto"].Value.ToString(),
                    row.Cells["Precio"].Value.ToString(),
                    row.Cells["Cantidad"].Value.ToString(),
                    row.Cells["SubTotal"].Value.ToString(),
                });

                }

                int idcorrelativo = new CN_Venta().ObtenerCorrelativo();
                string numeroDocumento = string.Format("{0:000000}", idcorrelativo);
                calcularcambio();

                Venta OVenta = new Venta()
                {

                    objUsuario = new Usuario() { Id_usuario = _Usuario.Id_usuario },
                    TipoDocumento = ((Opcion_combo)CBTipoDocVenta.SelectedItem).Texto,
                    NumeroDocumento = numeroDocumento,
                    DocumentoCliente = TxtNroDocCliente.Text,
                    NombreCliente = TxtCliente.Text,
                    MontoPago = Convert.ToDecimal(TxtPagacon.Text),
                    MontoCambio = Convert.ToDecimal(TxtCambio.Text),
                    MontoTotal = Convert.ToDecimal(TxtTotalPagar.Text),
                };


                string mensaje = string.Empty;
                bool respuesta = new CN_Venta().Registrar_Venta(OVenta, detalle_venta, out mensaje);

                if (respuesta)
                {
                    var result = MessageBox.Show("Numero de venta generada:\n" + numeroDocumento + "\n\n¿Desea copiar el portapapeles?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                        Clipboard.SetText(numeroDocumento);

                    TxtNroDocCliente.Text = "";
                    TxtCliente.Text = "";
                    dataGridDatos.Rows.Clear();
                    calcularTotal();
                    TxtPagacon.Text = "";
                    TxtCambio.Text = "";
                }
                else
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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
                    TxtCliente.Text = modal._Cliente.Nombre_cliente + " " + modal._Cliente.Apellido_cliente;
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
                    bool respuesta = new CN_Venta().SumarStock(
                        Convert.ToInt32(dataGridDatos.Rows[indice].Cells["IdProducto"].Value.ToString()),
                        Convert.ToInt32(dataGridDatos.Rows[indice].Cells["Cantidad"].Value.ToString()));

                    if (respuesta)
                    {
                        dataGridDatos.Rows.RemoveAt(indice);
                        calcularTotal();
                    }
                    
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
