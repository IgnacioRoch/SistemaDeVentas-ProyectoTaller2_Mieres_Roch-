using CapaEntidades;
using CapaNegocio;
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
using System.Xml.Linq;

namespace CapaPresentacion.Administrador
{
    public partial class FormMarcas : Form
    {
        public FormMarcas()
        {
            InitializeComponent();
        }

        private void IBGuardar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            string descripcion = TxtDescripcion.Text;

            // Validación de que no se permite campos vacios
            if (string.IsNullOrWhiteSpace(descripcion))
            {
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación de que el descripcion solo contenga letras  
            if (!descripcion.All(char.IsLetter))
            {
                MessageBox.Show("El campo descripción deben contener solo letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string mensaje = string.Empty;

            Marca objMarca = new Marca()
            {
                Id_marca = Convert.ToInt32(TxtSeleccionId.Text),
                Descripcion_marca = TxtDescripcion.Text,
                Estado_marca = Convert.ToInt32(((Opcion_combo)CBEstado.SelectedItem).Valor) == 1 ? true : false,
            };

            if (objMarca.Id_marca == 0)
            {

                int idGenerado = new CN_Marca().Registrar_Marca(objMarca, out mensaje);

                // Mostrar mensaje de consulta sobre la inserción  
                DialogResult ask = MessageBox.Show("¿Seguro que desea insertar una nueva marca?", "Confirmar Inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                // Verificar la respuesta del usuario  
                if (ask == DialogResult.Yes)
                {
                    // Aquí iría la lógica para insertar el nuevo cliente  
                    // Por ejemplo, llamar a una función para insertar en la base de datos

                    if (idGenerado != 0)
                    {
                        dataGridDatos.Rows.Add(new object[] {"", idGenerado, TxtDescripcion.Text,
                    ((Opcion_combo)CBEstado.SelectedItem).Valor.ToString(),
                    ((Opcion_combo)CBEstado.SelectedItem).Texto.ToString()
                     });


                        // Mostrar mensaje de información confirmando la inserción correcta  
                        MessageBox.Show($"La marca se insertó correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                bool resultado = new CN_Marca().Editar_Marca(objMarca, out mensaje);


                // Mostrar mensaje de consulta sobre la inserción  
                DialogResult ask = MessageBox.Show("¿Seguro que deseas modificar los datos?", "Confirmar Inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (ask == DialogResult.Yes)
                {
                    if (resultado)
                    {
                        DataGridViewRow row = dataGridDatos.Rows[Convert.ToInt32(TxtIndice.Text)];
                        row.Cells["Id"].Value = TxtSeleccionId.Text;
                        row.Cells["Descripcion"].Value = TxtDescripcion.Text;
                        row.Cells["EstadoValor"].Value = ((Opcion_combo)CBEstado.SelectedItem).Valor.ToString();
                        row.Cells["Estado"].Value = ((Opcion_combo)CBEstado.SelectedItem).Texto.ToString();

                        MessageBox.Show($"Los datos de la marca han sidos actualizados", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            string descripcion = TxtDescripcion.Text;

            if (string.IsNullOrWhiteSpace(descripcion)
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
            TxtDescripcion.Clear();
            TxtSeleccionId.Text = "0";
            TxtIndice.Text = "-1";
            CBEstado.SelectedIndex = 0;
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

        private void FormMarcas_Load(object sender, EventArgs e)
        {
            CBEstado.Items.Add(new Opcion_combo() { Valor = 1, Texto = "Activo" });
            CBEstado.Items.Add(new Opcion_combo() { Valor = 0, Texto = "No activo" });
            CBEstado.DisplayMember = "Texto";
            CBEstado.ValueMember = "Valor";
            CBEstado.SelectedIndex = 0;

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

            //MOSTRAR TODOS LOS USUARIOS
            List<Marca> lista = new CN_Marca().Listar();

            foreach (Marca item in lista)
            {
                dataGridDatos.Rows.Add(new object[] {"", item.Id_marca, item.Descripcion_marca,
                    item.Estado_marca == true ? 1 : 0,
                    item.Estado_marca == true ? "Activo" : "No activo"
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
                    TxtDescripcion.Text = dataGridDatos.Rows[indice].Cells["Descripcion"].Value.ToString();

                    //TOMA EL VALOR DE LA COLUMNA ESTADO DEL GRID PARA AGREGARLA AL FORMULARIO PRINCIPAL
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
            string descripcion = TxtDescripcion.Text;

            if (string.IsNullOrWhiteSpace(descripcion)
               )
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

                    Marca objMarca = new Marca()
                    {
                        Id_marca = Convert.ToInt32(TxtSeleccionId.Text)
                    };

                    bool respuesta = new CN_Marca().Eliminar_Marca(objMarca, out mensaje);

                    if (respuesta)
                    {
                        dataGridDatos.Rows.RemoveAt(Convert.ToInt32(TxtIndice.Text));
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }

                    MessageBox.Show($"Los datos de la marca han sidos eliminados", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpar();
                }
            }
        }

    }
}
