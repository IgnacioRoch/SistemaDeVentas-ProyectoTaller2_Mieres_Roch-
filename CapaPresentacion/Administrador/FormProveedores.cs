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

            // Mostrar mensaje de consulta sobre la inserción  
            DialogResult ask = MessageBox.Show("¿Seguro que desea insertar un nuevo Proveedor?", "Confirmar Inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

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
            string razonSocial = TxtRazonSocial.Text;
            string correo = TxtCorreo.Text;
            string telefono = TxtTelefono.Text;

            if (string.IsNullOrWhiteSpace(dni) && string.IsNullOrWhiteSpace(razonSocial) && string.IsNullOrWhiteSpace(correo) && string.IsNullOrWhiteSpace(telefono)
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
            TxtDocumento.Clear();
            TxtRazonSocial.Clear();
            TxtCorreo.Clear();
            TxtTelefono.Clear();
            TxtNombreLegal.Clear();
            TxtNombreContacto.Clear();
            TxtDireccion.Clear();
            TxtSeleccionId.Text = "0";
            //CBEstado.SelectedIndex = 0;
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

    }
}
