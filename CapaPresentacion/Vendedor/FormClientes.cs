using CapaEntidades;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using FontAwesome.Sharp;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CapaPresentacion.Vendedor
{
    public partial class FormClientes : Form
    {
        private static Usuario usuarioActual;

        public FormClientes(Usuario objusuario = null)
        {
            /*Funcion provisoria para trabajar sobre el sistema sin ingresar un usuario valido*/
            if (objusuario == null)
                usuarioActual = new Usuario() { Nombre_usuario = "ADMIN PREDEFINIDO", Id_usuario = 1 };
            else
                usuarioActual = objusuario; //usuario logeado en ese momento

            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            /*Oculta el boton eliminar y editar si se trata de un usuario vendedor*/
            if (usuarioActual.objRol.ID_rol == 2)
            {
                IBEliminarCliente.Visible = false;
                IBEditar.Visible = false;
            }
            /*Oculta el boton guardar si se trata de un usuario distinto a vendedor*/
            if (usuarioActual.objRol.ID_rol != 2)
            {
                IBGuardar.Visible = false;
            }

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
            List<Cliente> listaCliente = new CN_Cliente().Listar();

            foreach (Cliente item in listaCliente)
            {
                dataGridDatos.Rows.Add(new object[] {"", item.Id_cliente, item.Documento_cliente, item.Nombre_cliente, item.Apellido_cliente, item.Correo_cliente, item.Direccion_cliente, item.Telefono_cliente,
                    item.Estado_cliente == true ? 1 : 0,
                    item.Estado_cliente == true ? "Activo" : "No activo"
                 });
            }
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

        private void IBGuardar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox  
            string dni = TxtDocumento.Text;
            string apellido = TxtApellido.Text;
            string nombre = TxtNombre.Text;
            string correo = TxtCorreo.Text;
            string direccion = TxtDireccion.Text;
            string telefono = TxtTelefono.Text;

            if (string.IsNullOrWhiteSpace(dni) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(correo)
               && string.IsNullOrWhiteSpace(direccion) || string.IsNullOrWhiteSpace(telefono))
            {
                MessageBox.Show("Los campos están vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación de que el DNI solo contenga números  
            if (!long.TryParse(dni, out _))
            {
                MessageBox.Show("El DNI debe contener solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación de que el teléfono solo contenga números  
            if (!long.TryParse(telefono, out _))
            {
                MessageBox.Show("El Teléfono debe contener solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación de que el apellido y nombre solo contengan letras  
            if (!apellido.All(char.IsLetter) || !nombre.All(char.IsLetter))
            {
                MessageBox.Show("El Apellido y el Nombre deben contener solo letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!EsCorreoValido(correo))
            {
                // Si el correo no es válido
                MessageBox.Show("Correo no válido. Asegúrate de que siga el formato '@.com'.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mensaje = string.Empty;

            Cliente objCliente = new Cliente()
            {
                Id_cliente = Convert.ToInt32(TxtSeleccionId.Text),
                Documento_cliente = TxtDocumento.Text,
                Nombre_cliente = TxtNombre.Text,
                Apellido_cliente = TxtApellido.Text,
                Correo_cliente = TxtCorreo.Text,
                Direccion_cliente = TxtDireccion.Text,
                Telefono_cliente = TxtTelefono.Text,              
                Estado_cliente = Convert.ToInt32(((Opcion_combo)CBEstado.SelectedItem).Valor) == 1 ? true : false
            };

            if (objCliente.Id_cliente == 0)
            {

                int idUsuarioGenerado = new CN_Cliente().Registrar_Cliente(objCliente, out mensaje);

                // Mostrar mensaje de consulta sobre la inserción  
                DialogResult ask = MessageBox.Show("¿Seguro que desea insertar un nuevo usuario?", "Confirmar Inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                // Verificar la respuesta del usuario  
                if (ask == DialogResult.Yes)
                {
                    // Aquí iría la lógica para insertar el nuevo cliente  
                    // Por ejemplo, llamar a una función para insertar en la base de datos

                    if (idUsuarioGenerado != 0)
                    {
                        dataGridDatos.Rows.Add(new object[] {"", idUsuarioGenerado, TxtDocumento.Text, TxtNombre.Text, TxtApellido.Text, TxtCorreo.Text, TxtDireccion.Text, TxtTelefono.Text,
                    ((Opcion_combo)CBEstado.SelectedItem).Valor.ToString(),
                    ((Opcion_combo)CBEstado.SelectedItem).Texto.ToString()
                     });


                        // Mostrar mensaje de información confirmando la inserción correcta  
                        MessageBox.Show($"El Usuario se insertó correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                bool resultado = new CN_Cliente().Editar_Cliente(objCliente, out mensaje);


                // Mostrar mensaje de consulta sobre la inserción  
                DialogResult ask = MessageBox.Show("¿Seguro que deseas modificar los datos?", "Confirmar Inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (ask == DialogResult.Yes)
                {
                    if (resultado)
                    {
                        DataGridViewRow row = dataGridDatos.Rows[Convert.ToInt32(TxtIndice.Text)];
                        row.Cells["Id"].Value = TxtSeleccionId.Text;
                        row.Cells["Documento"].Value = TxtDocumento.Text;
                        row.Cells["Nombre"].Value = TxtNombre.Text;
                        row.Cells["Apellido"].Value = TxtApellido.Text;
                        row.Cells["Correo"].Value = TxtCorreo.Text;
                        row.Cells["Direccion"].Value = TxtDireccion.Text;
                        row.Cells["Telefono"].Value = TxtTelefono.Text;
                        row.Cells["EstadoValor"].Value = ((Opcion_combo)CBEstado.SelectedItem).Valor.ToString();
                        row.Cells["Estado"].Value = ((Opcion_combo)CBEstado.SelectedItem).Texto.ToString();

                        MessageBox.Show($"Los datos del cliente han sidos actualizados", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void limpar()
        {
            TxtDocumento.Clear();
            TxtNombre.Clear();
            TxtApellido.Clear();
            TxtCorreo.Clear();
            TxtDireccion.Clear();
            TxtTelefono.Clear();
            TxtSeleccionId.Text = "0";
            TxtIndice.Text = "-1";
            CBEstado.SelectedIndex = 0;
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
            string dni = TxtDocumento.Text;
            string apellido = TxtApellido.Text;
            string nombre = TxtNombre.Text;
            string correo = TxtCorreo.Text;
            string direccion = TxtDireccion.Text;
            string telefono = TxtTelefono.Text;

            if (string.IsNullOrWhiteSpace(dni) && string.IsNullOrWhiteSpace(apellido) && string.IsNullOrWhiteSpace(nombre) && string.IsNullOrWhiteSpace(correo)
               && string.IsNullOrWhiteSpace(direccion) && string.IsNullOrWhiteSpace(telefono) )
            {
                MessageBox.Show("Los campos están vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("¿Limpiar los campos del fomulario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                limpar();
            }


        }

        private void IBEditar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox  
            string dni = TxtDocumento.Text;
            string apellido = TxtApellido.Text;
            string nombre = TxtNombre.Text;
            string correo = TxtCorreo.Text;
            string direccion = TxtDireccion.Text;
            string telefono = TxtTelefono.Text;

            if (string.IsNullOrWhiteSpace(dni) && string.IsNullOrWhiteSpace(apellido) && string.IsNullOrWhiteSpace(nombre) && string.IsNullOrWhiteSpace(correo)
               && string.IsNullOrWhiteSpace(direccion) && string.IsNullOrWhiteSpace(telefono))
            {
                MessageBox.Show("Los campos están vacios, debe seleccionar el cliente a editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("¿Limpiar los campos del fomulario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                limpar();
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
                    TxtNombre.Text = dataGridDatos.Rows[indice].Cells["Nombre"].Value.ToString();
                    TxtApellido.Text = dataGridDatos.Rows[indice].Cells["Apellido"].Value.ToString();
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
    }
}
