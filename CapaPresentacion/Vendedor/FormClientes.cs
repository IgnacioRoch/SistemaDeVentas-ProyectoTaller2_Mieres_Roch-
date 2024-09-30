using CapaEntidades;
using CapaNegocio;
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
            if (objusuario == null)
                usuarioActual = new Usuario() { Nombre_usuario = "ADMIN PREDEFINIDO", Id_usuario = 1 };
            else
                usuarioActual = objusuario; //usuario logeado en ese momento

            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            if (usuarioActual.objRol.ID_rol == 2)
            {
                IBEliminarCliente.Visible = false; 
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

            // Mostrar mensaje de consulta sobre la inserción  
            DialogResult ask = MessageBox.Show("¿Seguro que desea insertar un nuevo cliente?", "Confirmar Inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);





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
            //CBEstado.SelectedIndex = 0;
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
    }
}
