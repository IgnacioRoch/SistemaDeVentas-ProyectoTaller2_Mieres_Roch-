using CapaEntidades;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using ClosedXML.Excel;
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

namespace CapaPresentacion.Administrador
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        private void IBGuardar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            string codigo = TxtCodigo.Text;
            string nombre = TxtNombre.Text;
            string descripcion = TxtDescripcion.Text;
            string precioCompra = TxtPrecioCompra.Text;
            string precioVenta = TxtPrecioVenta.Text;


            // Validación de que no se permite campos vacios
            if (string.IsNullOrWhiteSpace(codigo) || string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(descripcion) || string.IsNullOrWhiteSpace(precioCompra) || string.IsNullOrWhiteSpace(precioVenta))
            {
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación de que el codigo solo contenga números  
            if (!long.TryParse(codigo, out _))
            {
                MessageBox.Show("El Código debe contener solo números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string mensaje = string.Empty;
            Producto objProducto = new Producto()
            {
                Id_producto = Convert.ToInt32(TxtSeleccionId.Text),
                Codigo_producto = TxtCodigo.Text,
                Nombre_producto = TxtNombre.Text,
                Descripcion_producto = TxtDescripcion.Text,
                objCategoria = new Categoria() { Id_categoria = Convert.ToInt32(((Opcion_combo)CBCategoria.SelectedItem).Valor) },
                objMarca = new Marca() { Id_marca = Convert.ToInt32(((Opcion_combo)CBMarca.SelectedItem).Valor) },
                Estado_producto = Convert.ToInt32(((Opcion_combo)CBEstado.SelectedItem).Valor) == 1 ? true : false,
            };

            if (objProducto.Id_producto == 0)
            {

                int idGenerado = new CN_Producto().Registrar_Producto(objProducto, out mensaje);

                // Mostrar mensaje de consulta sobre la inserción  
                DialogResult ask = MessageBox.Show("¿Seguro que desea insertar un nuevo producto?", "Confirmar Inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                // Verificar la respuesta del usuario  
                if (ask == DialogResult.Yes)
                {
                    // Aquí iría la lógica para insertar el nuevo cliente  
                    // Por ejemplo, llamar a una función para insertar en la base de datos

                    if (idGenerado != 0)
                    {
                        dataGridDatos.Rows.Add(new object[] {"", idGenerado, TxtCodigo.Text, TxtNombre.Text, TxtDescripcion.Text,
                    ((Opcion_combo)CBCategoria.SelectedItem).Valor.ToString(),
                    ((Opcion_combo)CBCategoria.SelectedItem).Texto.ToString(),
                    ((Opcion_combo)CBMarca.SelectedItem).Valor.ToString(),
                    ((Opcion_combo)CBMarca.SelectedItem).Texto.ToString(),
                    ((Opcion_combo)CBEstado.SelectedItem).Valor.ToString(),
                    ((Opcion_combo)CBEstado.SelectedItem).Texto.ToString()
                     });


                        // Mostrar mensaje de información confirmando la inserción correcta  
                        MessageBox.Show($"El producto se insertó correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limpar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // MessageBox.Show(mensaje);
                    }


                }


            }
            else
            {
                bool resultado = new CN_Producto().Editar_Producto(objProducto, out mensaje);


                // Mostrar mensaje de consulta sobre la inserción  
                DialogResult ask = MessageBox.Show("¿Seguro que deseas modificar los datos?", "Confirmar Inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (ask == DialogResult.Yes)
                {
                    if (resultado)
                    {
                        DataGridViewRow row = dataGridDatos.Rows[Convert.ToInt32(TxtIndice.Text)];
                        row.Cells["Id"].Value = TxtSeleccionId.Text;
                        row.Cells["Codigo"].Value = TxtCodigo.Text;
                        row.Cells["Nombre"].Value = TxtNombre.Text;
                        row.Cells["Descripcion"].Value = TxtDescripcion.Text;
                        row.Cells["IdCategoria"].Value = ((Opcion_combo)CBCategoria.SelectedItem).Valor.ToString();
                        row.Cells["Categoria"].Value = ((Opcion_combo)CBCategoria.SelectedItem).Texto.ToString();
                        row.Cells["IdMarca"].Value = ((Opcion_combo)CBMarca.SelectedItem).Valor.ToString();
                        row.Cells["Marca"].Value = ((Opcion_combo)CBMarca.SelectedItem).Texto.ToString();
                        row.Cells["EstadoValor"].Value = ((Opcion_combo)CBEstado.SelectedItem).Valor.ToString();
                        row.Cells["Estado"].Value = ((Opcion_combo)CBEstado.SelectedItem).Texto.ToString();

                        MessageBox.Show($"Los datos del producto han sidos actualizados", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limpar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // MessageBox.Show(mensaje);
                    }
                }


            }

        }

        private void IBVaciar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox  
            string codigo = TxtCodigo.Text;
            string nombre = TxtNombre.Text;
            string descripcion = TxtDescripcion.Text;

            if (string.IsNullOrWhiteSpace(codigo) && string.IsNullOrWhiteSpace(nombre) && string.IsNullOrWhiteSpace(descripcion)
               )
            {
                MessageBox.Show("Los campos están vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("¿Limpiar los campos del fomulario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                limpar();
            }
        }

        private void limpar()
        {
            TxtIndice.Text = "-1";
            TxtSeleccionId.Text = "0";
            TxtCodigo.Clear();
            TxtNombre.Clear();
            TxtDescripcion.Clear();
            TxtPrecioCompra.Text = "0";
            TxtPrecioVenta.Text = "0";
            CBCategoria.SelectedIndex = 0;
            CBEstado.SelectedIndex = 0;
            CBMarca.SelectedIndex = 0;
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

            if (MessageBox.Show("¿Limpiar el campo de busqueda?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TxtBusqueda.Clear();
                foreach (DataGridViewRow row in dataGridDatos.Rows)
                {
                    row.Visible = true;
                }
            }

        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            TxtPrecioCompra.Text = "0";
            TxtPrecioVenta.Text = "0";

            CBEstado.Items.Add(new Opcion_combo() { Valor = 1, Texto = "Activo" });
            CBEstado.Items.Add(new Opcion_combo() { Valor = 0, Texto = "No activo" });
            CBEstado.DisplayMember = "Texto";
            CBEstado.ValueMember = "Valor";
            CBEstado.SelectedIndex = 0;

            List<Categoria> listaCategorias = new CN_Categoria().Listar();
            foreach (Categoria item in listaCategorias)
            {
                CBCategoria.Items.Add(new Opcion_combo() { Valor = item.Id_categoria, Texto = item.Descripcion_categoria });
                CBCategoria.DisplayMember = "Texto";
                CBCategoria.ValueMember = "Valor";
                CBCategoria.SelectedIndex = 0;
            }

            List<Marca> listaMarcas = new CN_Marca().Listar();
            foreach (Marca item in listaMarcas)
            {
                CBMarca.Items.Add(new Opcion_combo() { Valor = item.Id_marca, Texto = item.Descripcion_marca });
                CBMarca.DisplayMember = "Texto";
                CBMarca.ValueMember = "Valor";
                CBMarca.SelectedIndex = 0;
            }

            foreach (DataGridViewColumn columna in dataGridDatos.Columns)
            {
                if (columna.Visible == true && columna.Name != "BSeleccionar")
                {
                    CBBusqueda.Items.Add(new Opcion_combo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            CBBusqueda.DisplayMember = "Texto";
            CBBusqueda.ValueMember = "Valor";
            CBBusqueda.SelectedIndex = 0;

            //MOSTRAR TODOS LOS PRODUCTOS
            List<Producto> listaProducto = new CN_Producto().Listar();

            foreach (Producto item in listaProducto)
            {
                dataGridDatos.Rows.Add(new object[] {
                    "",
                    item.Id_producto,
                    item.Codigo_producto,
                    item.Nombre_producto,
                    item.Descripcion_producto,
                    item.objCategoria.Id_categoria,
                    item.objCategoria.Descripcion_categoria,
                    item.objMarca.Id_marca,
                    item.objMarca.Descripcion_marca,
                    item.Stock_producto,
                    item.PrecioCompra_producto,
                    item.PrecioVenta_producto,
                    item.Estado_producto == true ? 1 : 0,
                    item.Estado_producto == true ? "Activo" : "No activo"
                 });
            }
        }

        private void dataGridDatos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.iconCheck.Width;
                var h = Properties.Resources.iconCheck.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.iconCheck, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dataGridDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridDatos.Columns[e.ColumnIndex].Name == "BSeleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    TxtIndice.Text = indice.ToString();
                    TxtSeleccionId.Text = dataGridDatos.Rows[indice].Cells["Id"].Value.ToString();
                    TxtCodigo.Text = dataGridDatos.Rows[indice].Cells["Codigo"].Value.ToString();
                    TxtNombre.Text = dataGridDatos.Rows[indice].Cells["Nombre"].Value.ToString();
                    TxtDescripcion.Text = dataGridDatos.Rows[indice].Cells["Descripcion"].Value.ToString();
                    TxtPrecioCompra.Text = dataGridDatos.Rows[indice].Cells["PrecioCompra"].Value.ToString();
                    TxtPrecioVenta.Text = dataGridDatos.Rows[indice].Cells["PrecioVenta"].Value.ToString();

                    //TOMA EL VALOR DE LA COLUMNA ESTADO DEL GRID PARA AGREGARLA AL FORMULARIO PRINCIPAL
                    foreach (Opcion_combo oc in CBCategoria.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dataGridDatos.Rows[indice].Cells["IdCategoria"].Value))
                        {
                            int indice_combo = CBCategoria.Items.IndexOf(oc);
                            CBCategoria.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                    foreach (Opcion_combo oc in CBMarca.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dataGridDatos.Rows[indice].Cells["IdMarca"].Value))
                        {
                            int indice_combo = CBMarca.Items.IndexOf(oc);
                            CBMarca.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                    foreach (Opcion_combo oc in CBEstado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dataGridDatos.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = CBEstado.Items.IndexOf(oc);
                            CBEstado.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                }
            }
        }

        private void IBEliminar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox  
            string codigo = TxtCodigo.Text;
            string nombre = TxtNombre.Text;
            string descripcion = TxtDescripcion.Text;
            string precioC = TxtPrecioCompra.Text;
            string precioV = TxtPrecioVenta.Text;

            if (string.IsNullOrWhiteSpace(codigo) && string.IsNullOrWhiteSpace(nombre) && string.IsNullOrWhiteSpace(nombre) && string.IsNullOrWhiteSpace(descripcion)
               && string.IsNullOrWhiteSpace(precioC) && string.IsNullOrWhiteSpace(precioV))
            {
                MessageBox.Show("No se seleccionó un registro a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Convert.ToInt32(TxtIndice.Text) != 0)
            {
                DialogResult ask = MessageBox.Show("¿Seguro que deseas eliminar los datos?", "Confirmar Inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (ask == DialogResult.Yes)
                {
                    string mensaje = string.Empty;

                    Producto objUsuario = new Producto()
                    {
                        Id_producto = Convert.ToInt32(TxtSeleccionId.Text)
                    };

                    bool respuesta = new CN_Producto().Eliminar_Producto(objUsuario, out mensaje);

                    if (respuesta)
                    {
                        dataGridDatos.Rows.RemoveAt(Convert.ToInt32(TxtIndice.Text));
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }

                    MessageBox.Show($"Los datos del producto han sidos eliminados", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpar();
                }
            }
        }

        private void BExportarExcel_Click(object sender, EventArgs e)
        {
            if(dataGridDatos.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();

                foreach(DataGridViewColumn columna in dataGridDatos.Columns)
                {
                    if(columna.HeaderText != "Editar" && columna.Visible)
                    {
                        dt.Columns.Add(columna.HeaderText, typeof(string));
                    }
                }
                foreach(DataGridViewRow row in dataGridDatos.Rows)
                {
                    if (row.Visible)
                    {
                        dt.Rows.Add(new object[]
                        {
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[4].Value.ToString(),
                            row.Cells[6].Value.ToString(),
                            row.Cells[8].Value.ToString(),
                            row.Cells[9].Value.ToString(),
                            row.Cells[10].Value.ToString(),
                            row.Cells[11].Value.ToString(),
                            row.Cells[13].Value.ToString(),
                        });
                    }                  
                }

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("ReporteProductos_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
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
    }
}
