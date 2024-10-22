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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Gerente_Comercial
{
    public partial class FormCompras : Form
    {
        private Usuario _Usuario;

        public FormCompras(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }

        private void IBBuscarProveedor_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProveedor())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    TxtIdProveedor.Text = modal._Proveedor.Id_proveedor.ToString();
                    TxtNroDocProveedor.Text = modal._Proveedor.Documento_proveedor;
                    TxtRazonSocial.Text = modal._Proveedor.RazonSocial_proveedor;
                }
                else
                {
                    TxtIdProveedor.Select();
                }
            }
        }

        private void IBBuscarProducto_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProducto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    TxtIdProducto.Text = modal._Producto.Id_producto.ToString();
                    TxtCodProducto.Text = modal._Producto.Codigo_producto;
                    TxtProducto.Text = modal._Producto.Nombre_producto;
                    TxtPrecioCompra.Select();
                }
                else
                {
                    TxtIdProveedor.Select();
                }
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
                MessageBox.Show("Debe completar todos los campos necesarios para agregar un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal precioCompra = 0;
            decimal precioVenta = 0;
            bool producto_existe = false;

            if (int.Parse(TxtIdProducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(TxtPrecioCompra.Text, out precioCompra))
            {
                MessageBox.Show("Precio compra - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtPrecioCompra.Select();
                return;
            }

            if (!decimal.TryParse(TxtPrecioVenta.Text, out precioVenta))
            {
                MessageBox.Show("Precio venta - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtPrecioVenta.Select();
                return;
            }

            foreach (DataGridViewRow fila in dataGridDatos.Rows)
            {
                if (fila.Cells["IdProducto"].Value.ToString() == TxtIdProducto.Text)
                {
                    producto_existe = true;
                    break;
                }
            }

            if (!producto_existe)
            {
                dataGridDatos.Rows.Add(new object[]
                {
                    TxtIdProducto.Text,
                    TxtProducto.Text,
                    precioCompra.ToString("0.00"),
                    precioVenta.ToString("0.00"),
                    TxtCantidad.Value.ToString(),
                    (TxtCantidad.Value * precioCompra).ToString("0.00")
                });
                calcularTotal();
                limpiarProducto();
                TxtCodProducto.Select();
            }
        }

        private void IBRegistrarCompra_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TxtIdProveedor.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dataGridDatos.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar un total de productos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult ask = MessageBox.Show("¿Seguro que desea registrar la compra?", "Confirmar Inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (ask == DialogResult.Yes)
            {
                DataTable detalle_compra = new DataTable();
                detalle_compra.Columns.Add("Id_producto", typeof(int));
                detalle_compra.Columns.Add("PrecioCompra", typeof(decimal));
                detalle_compra.Columns.Add("PrecioVenta", typeof(decimal));
                detalle_compra.Columns.Add("Cantidad", typeof(int));
                detalle_compra.Columns.Add("MontoTotal", typeof(decimal));

                foreach (DataGridViewRow row in dataGridDatos.Rows)
                {
                    detalle_compra.Rows.Add(
                        new object[]
                        {
                        Convert.ToUInt32(row.Cells["IdProducto"].Value.ToString()),
                        row.Cells["PrecioCompra"].Value.ToString(),
                        row.Cells["PrecioVenta"].Value.ToString(),
                        row.Cells["Cantidad"].Value.ToString(),
                        row.Cells["SubTotal"].Value.ToString()
                        });
                }

                int idCorrelativo = new CN_Compra().ObtenerCorrelativo();
                string numeroDocumento = string.Format("{0:00000}", idCorrelativo);

                Compra oCompra = new Compra()
                {
                    objUsuario = new Usuario() { Id_usuario = _Usuario.Id_usuario },
                    objProveedor = new Proveedor() { Id_proveedor = Convert.ToInt32(TxtIdProveedor.Text) },
                    TipoDocumento_compra = ((Opcion_combo)CBTipoDoc.SelectedItem).Texto,
                    NumeroDocumento_compra = numeroDocumento,
                    MontoTotal_compra = Convert.ToDecimal(TxtTotalAPagar.Text)
                };

                string mensaje = string.Empty;
                bool respuesta = new CN_Compra().Registrar_Compra(oCompra, detalle_compra, out mensaje);

                MessageBox.Show("La compra fue realizada con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (respuesta)
                {
                    var result = MessageBox.Show("Número de compra generada: \n" + numeroDocumento + "\n\n¿Desea copiar al portapapeles?"
                        , "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                        Clipboard.SetText(numeroDocumento);

                    TxtIdProveedor.Text = "0";
                    TxtNroDocProveedor.Text = "";
                    TxtRazonSocial.Text = "";
                    dataGridDatos.Rows.Clear();
                    calcularTotal();
                }
                else
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }

        private void FormCompras_Load(object sender, EventArgs e)
        {
            CBTipoDoc.Items.Add(new Opcion_combo() { Valor = "Boleta", Texto = "Boleta" });
            CBTipoDoc.Items.Add(new Opcion_combo() { Valor = "Fectura", Texto = "Fectura" });
            CBTipoDoc.DisplayMember = "Texto";
            CBTipoDoc.ValueMember = "Valor";
            CBTipoDoc.SelectedIndex = 0;

            TxtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            TxtIdProveedor.Text = "0";
            TxtIdProducto.Text = "0";
        }

        private void TxtCodProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Producto oProducto = new CN_Producto().Listar().Where(p => p.Codigo_producto == TxtCodProducto.Text && p.Estado_producto == true).FirstOrDefault();

                if(oProducto != null)
                {
                    TxtCodProducto.BackColor = Color.Honeydew;
                    TxtIdProducto.Text = oProducto.Id_producto.ToString();
                    TxtProducto.Text = oProducto.Nombre_producto;
                    TxtPrecioCompra.Select();
                }
                else
                {
                    TxtCodProducto.BackColor = Color.MistyRose;
                    TxtIdProducto.Text = "0";
                    TxtProducto.Text = "";
                }
            }
        }

        private void limpiarProducto()
        {
            TxtIdProducto.Text = "0";
            TxtCodProducto.Text = "";
            TxtCodProducto.BackColor = Color.White;
            TxtProducto.Text = "";
            TxtPrecioCompra.Text = "";
            TxtPrecioVenta.Text = "";
            TxtCantidad.Value = 1;
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
                TxtTotalAPagar.Text = total.ToString("0.00");
            }
        }

        private void dataGridDatos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 6)
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

        private void TxtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (TxtPrecioCompra.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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

        private void TxtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (TxtPrecioCompra.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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
    }
}
