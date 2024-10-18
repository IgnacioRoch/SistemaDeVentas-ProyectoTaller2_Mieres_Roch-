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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Administrador
{
    public partial class FormProveedores : Form
    {
        public FormProveedores()
        {
            InitializeComponent();
        }

        private void IBGuardar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            string dni = TxtDocumento.Text;
            string razonSocial = TxtRazonSocial.Text;
            string correo = TxtCorreo.Text;
            string telefono = TxtTelefono.Text;
            string nombreLegal = TxtNombreLegal.Text;
            string nombreContacto = TxtNombreContacto.Text;
            string direccion = TxtDireccion.Text;


            if (string.IsNullOrWhiteSpace(dni) || string.IsNullOrWhiteSpace(razonSocial) || string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(direccion)
               || string.IsNullOrWhiteSpace(telefono) || string.IsNullOrWhiteSpace(nombreLegal) || string.IsNullOrWhiteSpace(nombreContacto))
            {
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación de que el DNI y Teléfono solo contenga números  
            if (!long.TryParse(dni, out _) || !long.TryParse(telefono, out _))
            {
                MessageBox.Show("El DNI y el Teléfono deben contener solo números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación de que la Razon social solo contengan letras  
            if (!razonSocial.All(char.IsLetter) || !nombreContacto.All(char.IsLetter) || !nombreLegal.All(char.IsLetter))
            {
                MessageBox.Show("El campo Razon Social, Nombre de contacto y Nombre legal debe contener solo letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!EsCorreoValido(correo))
            {
                // Si el correo no es válido
                MessageBox.Show("Correo no válido. Asegúrate de que siga el formato '@.com'.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mensaje = string.Empty;

            Proveedor objProveedor = new Proveedor()
            {
                Id_proveedor = Convert.ToInt32(TxtSeleccionId.Text),
                Documento_proveedor = TxtDocumento.Text,
                NombreLegal_proveedor = TxtNombreLegal.Text,
                NombreContacto_proveedor = TxtNombreContacto.Text,
                RazonSocial_proveedor = TxtRazonSocial.Text,
                Correo_proveedor = TxtCorreo.Text,
                Direccion_proveedor = TxtDireccion.Text,
                Telefono_proveedor = TxtTelefono.Text,
                Estado_proveedor = Convert.ToInt32(((Opcion_combo)CBEstado.SelectedItem).Valor) == 1 ? true : false,
            };

            if (objProveedor.Id_proveedor == 0)
            {

                int idGenerado = new CN_Proveedor().Registrar_Proveedor(objProveedor, out mensaje);

                // Mostrar mensaje de consulta sobre la inserción  
                DialogResult ask = MessageBox.Show("¿Seguro que desea insertar un nuevo proveedor?", "Confirmar Inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                // Verificar la respuesta del usuario  
                if (ask == DialogResult.Yes)
                {
                    // Aquí iría la lógica para insertar el nuevo cliente  
                    // Por ejemplo, llamar a una función para insertar en la base de datos

                    if (idGenerado != 0)
                    {
                        dataGridDatos.Rows.Add(new object[] {
                            "",
                            idGenerado,
                            TxtDocumento.Text,
                            TxtNombreLegal.Text,
                            TxtNombreContacto.Text,
                            TxtRazonSocial.Text,
                            TxtCorreo.Text,
                            TxtDireccion.Text,
                            TxtTelefono.Text,
                            ((Opcion_combo)CBEstado.SelectedItem).Valor.ToString(),
                            ((Opcion_combo)CBEstado.SelectedItem).Texto.ToString()
                     });


                        // Mostrar mensaje de información confirmando la inserción correcta  
                        MessageBox.Show($"El proveedor se insertó correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                bool resultado = new CN_Proveedor().Editar_Proveedor(objProveedor, out mensaje);


                // Mostrar mensaje de consulta sobre la inserción  
                DialogResult ask = MessageBox.Show("¿Seguro que deseas modificar los datos?", "Confirmar Inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (ask == DialogResult.Yes)
                {
                    if (resultado)
                    {
                        DataGridViewRow row = dataGridDatos.Rows[Convert.ToInt32(TxtIndice.Text)];
                        row.Cells["Id"].Value = TxtSeleccionId.Text;
                        row.Cells["Documento"].Value = TxtDocumento.Text;
                        row.Cells["NombreLegal"].Value = TxtNombreLegal.Text;
                        row.Cells["NombreContacto"].Value = TxtNombreContacto.Text;
                        row.Cells["RazonSocial"].Value = TxtRazonSocial.Text;
                        row.Cells["Correo"].Value = TxtCorreo.Text;
                        row.Cells["Direccion"].Value = TxtDireccion.Text;
                        row.Cells["Telefono"].Value = TxtTelefono.Text;
                        row.Cells["EstadoValor"].Value = ((Opcion_combo)CBEstado.SelectedItem).Valor.ToString();
                        row.Cells["Estado"].Value = ((Opcion_combo)CBEstado.SelectedItem).Texto.ToString();

                        MessageBox.Show($"Los datos del proveedor han sidos actualizados", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        // Función para validar si el correo sigue el formato '@.com'
        private bool EsCorreoValido(string email)
        {
            // Expresión regular que asegura que el correo contenga '@' y termine con '.com'
            string patron = @"^[^@\s]+@[^@\s]+\.com$";
            return Regex.IsMatch(email, patron);
        }

        private void IBVaciar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            string documento = TxtDocumento.Text;
            string nombreLegal = TxtNombreLegal.Text;
            string nombreContacto = TxtNombreContacto.Text;
            string razonSocial = TxtRazonSocial.Text;
            string correo = TxtCorreo.Text;
            string direccion = TxtDireccion.Text;
            string telefono = TxtTelefono.Text;


            if (string.IsNullOrWhiteSpace(documento) && string.IsNullOrWhiteSpace(nombreLegal) && string.IsNullOrWhiteSpace(nombreContacto) && string.IsNullOrWhiteSpace(nombreContacto)
                && string.IsNullOrWhiteSpace(razonSocial) && string.IsNullOrWhiteSpace(correo) && string.IsNullOrWhiteSpace(direccion) && string.IsNullOrWhiteSpace(telefono))
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
            TxtDocumento.Clear();
            TxtRazonSocial.Clear();
            TxtCorreo.Clear();
            TxtTelefono.Clear();
            TxtNombreLegal.Clear();
            TxtNombreContacto.Clear();
            TxtDireccion.Clear();
            TxtSeleccionId.Text = "0";
            TxtIndice.Text =  "-1";
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

        private void FormProveedores_Load(object sender, EventArgs e)
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
            List<Proveedor> lista = new CN_Proveedor().Listar();

            foreach (Proveedor item in lista)
            {
                dataGridDatos.Rows.Add(new object[] {
                    "", 
                    item.Id_proveedor, 
                    item.Documento_proveedor,
                    item.NombreLegal_proveedor,
                    item.NombreContacto_proveedor,
                    item.RazonSocial_proveedor,
                    item.Correo_proveedor,
                    item.Direccion_proveedor,
                    item.Telefono_proveedor,
                    item.Estado_proveedor == true ? 1 : 0,
                    item.Estado_proveedor == true ? "Activo" : "No activo"
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
                    TxtDocumento.Text = dataGridDatos.Rows[indice].Cells["Documento"].Value.ToString();
                    TxtNombreLegal.Text = dataGridDatos.Rows[indice].Cells["NombreLegal"].Value.ToString();
                    TxtNombreContacto.Text = dataGridDatos.Rows[indice].Cells["NombreContacto"].Value.ToString();
                    TxtRazonSocial.Text = dataGridDatos.Rows[indice].Cells["RazonSocial"].Value.ToString();
                    TxtCorreo.Text = dataGridDatos.Rows[indice].Cells["Correo"].Value.ToString();
                    TxtDireccion.Text = dataGridDatos.Rows[indice].Cells["Direccion"].Value.ToString();
                    TxtTelefono.Text = dataGridDatos.Rows[indice].Cells["Telefono"].Value.ToString();

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
            string dni = TxtDocumento.Text;
            string razonSocial = TxtRazonSocial.Text;
            string correo = TxtCorreo.Text;
            string telefono = TxtTelefono.Text;
            string nombreLegal = TxtNombreLegal.Text;
            string nombreContacto = TxtNombreContacto.Text;
            string direccion = TxtDireccion.Text;

            if (string.IsNullOrWhiteSpace(dni) && string.IsNullOrWhiteSpace(razonSocial) && string.IsNullOrWhiteSpace(correo) && string.IsNullOrWhiteSpace(telefono) && string.IsNullOrWhiteSpace(nombreLegal) 
                && string.IsNullOrWhiteSpace(nombreContacto) && string.IsNullOrWhiteSpace(direccion)
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

                    Proveedor objProveedor = new Proveedor()
                    {
                        Id_proveedor = Convert.ToInt32(TxtSeleccionId.Text)
                    };

                    bool respuesta = new CN_Proveedor().Eliminar_Proveedor(objProveedor, out mensaje);

                    if (respuesta)
                    {
                        dataGridDatos.Rows.RemoveAt(Convert.ToInt32(TxtIndice.Text));
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }

                    MessageBox.Show($"Los datos de la categoria han sidos eliminados", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpar();
                }
            }
        }
    }
}
