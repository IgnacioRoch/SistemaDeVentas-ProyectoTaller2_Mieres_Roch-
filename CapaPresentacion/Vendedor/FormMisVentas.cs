using CapaEntidades;
using CapaNegocio;
using CapaPresentacion.Modales;
using CapaPresentacion.Utilidades;
using ClosedXML.Excel;
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
    public partial class FormMisVentas : Form
    {
        private static Usuario usuarioActual;
        public FormMisVentas(Usuario objUsuario)
        {
            usuarioActual = objUsuario;
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

            string columnaFiltro = ((Opcion_combo)CBBusqueda.SelectedItem).Valor.ToString();

            if (dataGridDatos.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridDatos.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().ToUpper().Contains(TxtBusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;

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

            if (MessageBox.Show("¿Limpiar el campo del fomulario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TxtBusqueda.Clear();
                foreach (DataGridViewRow row in dataGridDatos.Rows)
                {
                    row.Visible = true;
                }
            }
        }

        private void FormMisVentas_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dataGridDatos.Columns)
            {
                CBBusqueda.Items.Add(new Opcion_combo() { Valor = columna.Name, Texto = columna.HeaderText });
            }
            CBBusqueda.DisplayMember = "Texto";
            CBBusqueda.ValueMember = "Valor";
            CBBusqueda.SelectedIndex = 0;
        }

        private void IBBuscarVentas_Click(object sender, EventArgs e)
        {

            List<ReporteVentas> lista = new List<ReporteVentas>();

            lista = new CN_Reporte().Venta(
                TxtFechaInicio.Value.ToString(),
                TxtFechaFin.Value.ToString()
            );

            dataGridDatos.Rows.Clear();

            List<string> codigosUnicos = new List<string>();

            foreach (ReporteVentas rv in lista)
            {
                if (rv.Documento_usuario == usuarioActual.Documento_usuario && !codigosUnicos.Contains(rv.NumeroDocumento))
                {
                    // Agrega el número de documento a la lista para evitar repeticiones
                    codigosUnicos.Add(rv.NumeroDocumento);

                    dataGridDatos.Rows.Add(new object[]
                    {
                    rv.FechaRegistro,
                    rv.TipoDocumento,
                    rv.NumeroDocumento,
                    rv.MontoTotal,
                    rv.Nombre_usuario + " " + rv.Apellido_usuario,
                    rv.Documento_cliente,
                    rv.Nombre_cliente,
                    BDetalle.Text = "Ver detalle"
                   /* rv.Codigo_producto,
                    rv.Nombre_producto,
                    rv.Descripcion_categoria,
                    rv.Descripcion_marca,
                    rv.PrecioVenta,
                    rv.Cantidad,
                    rv.SubTotal,
                    rv.Documento_usuario*/
                    });
                }
            }
        }

        private void BDescargarExcel_Click(object sender, EventArgs e)
        {
            if (dataGridDatos.Rows.Count < 1)
            {
                MessageBox.Show("No hay registros para exportar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable dt = new DataTable();

                foreach (DataGridViewColumn columna in dataGridDatos.Columns)
                {
                    if (columna.HeaderText != "Detalle venta")
                    {
                        dt.Columns.Add(columna.HeaderText, typeof(string));
                    }
                }
                foreach (DataGridViewRow row in dataGridDatos.Rows)
                {
                    if (row.Visible)
                    {
                        dt.Rows.Add(new object[]
                        {
                            row.Cells[0].Value.ToString(),
                            row.Cells[1].Value.ToString(),
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[4].Value.ToString(),
                            row.Cells[5].Value.ToString(),
                            row.Cells[6].Value.ToString(),
                            /*row.Cells[7].Value.ToString(),
                            row.Cells[8].Value.ToString(),
                            row.Cells[9].Value.ToString(),
                            row.Cells[10].Value.ToString(),
                            row.Cells[11].Value.ToString(),
                            row.Cells[12].Value.ToString(),
                            row.Cells[13].Value.ToString()*/
                        });
                    }
                }

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("ReporteMisVenta_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                savefile.Filter = "Excel Files | *.xlsx";

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(savefile.FileName);
                        MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Error al exportar reporte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BVerDetalle_Click(object sender, EventArgs e)
        {
            /*using (var modal = new mdDetalleVenta())
            {
                var result = modal.ShowDialog();
            }*/
        }

        private void dataGridDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string codigoventa;

            if (dataGridDatos.Columns[e.ColumnIndex].Name == "BDetalle")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    codigoventa = dataGridDatos.Rows[indice].Cells["NumeroDocumento"].Value.ToString();

                    using (var modal = new mdDetalleVenta(codigoventa))
                    {
                        var result = modal.ShowDialog();
                    }
                }
            }
        }
    }
}
