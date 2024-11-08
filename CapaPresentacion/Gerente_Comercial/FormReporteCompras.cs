using CapaEntidades;
using CapaNegocio;
using CapaPresentacion.Modales;
using CapaPresentacion.Utilidades;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office.CustomUI;
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
    public partial class FormReporteCompras : Form
    {
        public FormReporteCompras()
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

        private void FormReporteCompras_Load(object sender, EventArgs e)
        {
            List<Proveedor> lista = new CN_Proveedor().Listar();
            CBProveedorReporteCompra.Items.Add(new Opcion_combo() { Valor = 0, Texto = "TODOS" });

            foreach (Proveedor item in lista)
            {
                CBProveedorReporteCompra.Items.Add(new Opcion_combo() { Valor = item.Id_proveedor, Texto = item.RazonSocial_proveedor });
            }
            CBProveedorReporteCompra.DisplayMember = "Texto";
            CBProveedorReporteCompra.ValueMember = "Valor";
            CBProveedorReporteCompra.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dataGridDatos.Columns)
            {
                CBBusqueda.Items.Add(new Opcion_combo() { Valor = columna.Name, Texto = columna.HeaderText });
            }
            CBBusqueda.DisplayMember = "Texto";
            CBBusqueda.ValueMember = "Valor";
            CBBusqueda.SelectedIndex = 0;
        }

        private void IBBuscarProveedorReporteCompra_Click(object sender, EventArgs e)
        {
            int idproveedor = Convert.ToInt32(((Opcion_combo)CBProveedorReporteCompra.SelectedItem).Valor.ToString());

            List<ReporteCompra> lista = new List<ReporteCompra>();

            lista = new CN_Reporte().Compra(
                TxtFechaInicio.Value.ToString(),
                TxtFechaFin.Value.ToString(),
                idproveedor
                );

            dataGridDatos.Rows.Clear();

            List<string> codigosUnicos = new List<string>();
      
                foreach (ReporteCompra rc in lista)
                {
                    if (!codigosUnicos.Contains(rc.NumeroDocumento_compra))
                    {
                        // Agrega el número de documento a la lista para evitar repeticiones
                        codigosUnicos.Add(rc.NumeroDocumento_compra);

                        dataGridDatos.Rows.Add(new object[]
                        {
                        rc.FechaRegistro,
                        rc.TipoDocumento_compra,
                        rc.NumeroDocumento_compra,
                        rc.MontoTotal_compra,
                        rc.Nombre_usuario + " " + rc.Apellido_usuario,
                        rc.Documento_proveedor,
                        rc.RazonSocial_proveedor,
                        BDetalle.Text = "Mostrar detalle"


                        /*rc.Codigo_producto,
                        rc.Nombre_producto,
                        rc.Descripcion_categoria,
                        rc.Descripcion_marca,
                        rc.PrecioCompra,
                        rc.PrecioVenta,
                        rc.Cantidad,
                        rc.MontoTotal*/

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
                      dt.Columns.Add(columna.HeaderText, typeof(string));            
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
                            row.Cells[13].Value.ToString(),
                            row.Cells[14].Value.ToString()*/
                        });
                    }
                }

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("ReporteCompra_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
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

        private void BVerDetalleCompra_Click(object sender, EventArgs e)
        {
            /*using (var modal = new mdDetalleCompra())
            {
                var result = modal.ShowDialog();
            }*/
        }

        private void dataGridDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string codigoCompra;

            if (dataGridDatos.Columns[e.ColumnIndex].Name == "BDetalle")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    codigoCompra = dataGridDatos.Rows[indice].Cells["NumeroDocumento"].Value.ToString();

                    using (var modal = new mdDetalleCompra(codigoCompra))
                    {
                        var result = modal.ShowDialog();
                    }
                }
            }
        }
    }
}
