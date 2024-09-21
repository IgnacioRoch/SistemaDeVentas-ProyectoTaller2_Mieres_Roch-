using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaPresentacion.Utilidades;
using CapaEntidades;
using CapaNegocio;
using System.Net.Http.Headers;


namespace CapaPresentacion.Administrador
{
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void dataGridDatos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if(e.ColumnIndex == 0) 
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

        private void IBGuardar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox  
            string dni = TxtDocumento.Text;
            string apellido = TxtApellido.Text;
            string nombre = TxtNombre.Text;
            string correo = TxtCorreo.Text;
            string clave = TxtClave.Text;
            string ConfClave = TxtConfClave.Text;

            if (string.IsNullOrWhiteSpace(dni) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(correo)
                || string.IsNullOrWhiteSpace(clave) || string.IsNullOrWhiteSpace(ConfClave))
            {
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación de que el DNI solo contenga números  
            if (!long.TryParse(dni, out _))
            {
                MessageBox.Show("El DNI debe contener solo números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación de que el apellido y nombre solo contengan letras  
            if (!apellido.All(char.IsLetter) || !nombre.All(char.IsLetter))
            {
                MessageBox.Show("El Apellido y el Nombre deben contener solo letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string mensaje = string.Empty;

            Usuario objUsuario = new Usuario()
            {
                Id_usuario = Convert.ToInt32(TxtSeleccionId.Text),
                Documento_usuario = TxtDocumento.Text,
                Nombre_usuario = TxtNombre.Text,
                Apellido_usuario = TxtApellido.Text,
                Correo_usuario = TxtCorreo.Text,
                Clave_usuario = TxtClave.Text,
                objRol = new Rol() { ID_rol = Convert.ToInt32(((Opcion_combo)CBRol.SelectedItem).Valor) },
                Estado_usuario = Convert.ToInt32(((Opcion_combo)CBEstado.SelectedItem).Valor) == 1 ? true : false,
            };

            int idUsuarioGenerado = new CN_Usuario().Registrar_Usuario(objUsuario, out mensaje);

            // Mostrar mensaje de consulta sobre la inserción  
            DialogResult ask = MessageBox.Show("¿Seguro que desea insertar un nuevo Cliente?", "Confirmar Inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            // Verificar la respuesta del usuario  
            if (ask == DialogResult.Yes)
            {
                // Aquí iría la lógica para insertar el nuevo cliente  
                // Por ejemplo, llamar a una función para insertar en la base de datos

                if (idUsuarioGenerado != 0)
                {
                    dataGridDatos.Rows.Add(new object[] {"", idUsuarioGenerado, TxtDocumento.Text, TxtNombre.Text, TxtApellido.Text, TxtCorreo.Text, TxtClave.Text,
                    ((Opcion_combo)CBRol.SelectedItem).Valor.ToString(),
                    ((Opcion_combo)CBRol.SelectedItem).Texto.ToString(),
                    ((Opcion_combo)CBEstado.SelectedItem).Valor.ToString(),
                    ((Opcion_combo)CBEstado.SelectedItem).Texto.ToString()
                     });


                    // Mostrar mensaje de información confirmando la inserción correcta  
                    MessageBox.Show($"El Usuario se insertó correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }

        }       

        private void IBVaciar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox  
            string dni = TxtDocumento.Text;
            string apellido = TxtApellido.Text;
            string nombre = TxtNombre.Text;
            string correo = TxtCorreo.Text;
            string clave = TxtClave.Text;
            string ConfClave = TxtConfClave.Text;

            if (string.IsNullOrWhiteSpace(dni) && string.IsNullOrWhiteSpace(apellido) && string.IsNullOrWhiteSpace(nombre) && string.IsNullOrWhiteSpace(correo)
               && string.IsNullOrWhiteSpace(clave) && string.IsNullOrWhiteSpace(ConfClave))
            {
                MessageBox.Show("Los campos están vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("¿Limpiar los campos del fomulario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                limpar();
            }
            
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            CBEstado.Items.Add(new Opcion_combo() { Valor = 1, Texto = "Activo"});
            CBEstado.Items.Add(new Opcion_combo() { Valor = 0, Texto = "No activo" });
            CBEstado.DisplayMember = "Texto";
            CBEstado.ValueMember = "Valor";
            CBEstado.SelectedIndex = 0;

            List<Rol> listaRol = new CN_Rol().Listar();
            foreach (Rol item in listaRol)
            {
                CBRol.Items.Add(new Opcion_combo() { Valor = item.ID_rol, Texto = item.Descripcion_rol });
                CBRol.DisplayMember = "Texto";
                CBRol.ValueMember = "Valor";
                CBRol.SelectedIndex = 0;
            }

            foreach (DataGridViewColumn columna in dataGridDatos.Columns)
            {
                if (columna.Visible == true && columna.Name != "BSeleccionar")
                {
                    CBBusqueda.Items.Add(new Opcion_combo() { Valor = columna.Name, Texto= columna.HeaderText});
                }
            }
            CBBusqueda.DisplayMember = "Texto";
            CBBusqueda.ValueMember = "Valor";
            CBBusqueda.SelectedIndex = 0;

            //MOSTRAR TODOS LOS USUARIOS
            List<Usuario> listaUsuario = new CN_Usuario().Listar();

            foreach (Usuario item in listaUsuario)
            {
                dataGridDatos.Rows.Add(new object[] {"", item.Id_usuario, item.Documento_usuario, item.Nombre_usuario, item.Apellido_usuario, item.Correo_usuario, item.Clave_usuario,
                    item.objRol.ID_rol, 
                    item.objRol.Descripcion_rol,
                    item.Estado_usuario == true ? 1 : 0,
                    item.Estado_usuario == true ? "Activo" : "No activo"
                 });
            }

        }

        private void limpar()
        {
            TxtDocumento.Clear();
            TxtNombre.Clear();
            TxtApellido.Clear();
            TxtCorreo.Clear();
            TxtClave.Clear();
            TxtConfClave.Clear();
            TxtSeleccionId.Text = "0";
            TxtIndice.Text = "-1";
            CBRol.SelectedIndex = 0;
            CBEstado.SelectedIndex = 0;
        }

        private void dataGridDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridDatos.Columns[e.ColumnIndex].Name == "BSeleccionar")
            {
                int indice = e.RowIndex; 
                if(indice >= 0)
                {
                    TxtIndice.Text = indice.ToString();
                    TxtSeleccionId.Text = dataGridDatos.Rows[indice].Cells["Id"].Value.ToString();
                    TxtDocumento.Text = dataGridDatos.Rows[indice].Cells["Documento"].Value.ToString();
                    TxtNombre.Text = dataGridDatos.Rows[indice].Cells["Nombre"].Value.ToString();
                    TxtApellido.Text = dataGridDatos.Rows[indice].Cells["Apellido"].Value.ToString();
                    TxtCorreo.Text = dataGridDatos.Rows[indice].Cells["Correo"].Value.ToString();
                    TxtClave.Text = dataGridDatos.Rows[indice].Cells["Clave"].Value.ToString();
                    TxtConfClave.Text = dataGridDatos.Rows[indice].Cells["Clave"].Value.ToString();

                    //TOMA EL VALOR DE LA COLUMNA ROL DEL GRID PARA AGREGARLA AL FORMULARIO PRINCIPAL
                    foreach (Opcion_combo oc in CBRol.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dataGridDatos.Rows[indice].Cells["IdRol"].Value))
                        {
                            int indice_combo = CBRol.Items.IndexOf(oc);
                            CBRol.SelectedIndex = indice_combo;
                            break;
                        }
                    }

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
