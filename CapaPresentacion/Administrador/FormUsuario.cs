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

            if(e.ColumnIndex < 0) 
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


        /*private void IBGuardar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox  
            string dni = TxtDocumento.Text;
            string apellido = TxtApellido.Text;
            string nombre = TxtNombre.Text;
            string correo = TxtCorreo.Text;
            string clave = TxtClave.Text;
            string ConfClave = TxtConfClave.Text;

            if (string.IsNullOrWhiteSpace(dni) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(correo)
                || string.IsNullOrWhiteSpace(clave) || string.IsNullOrWhiteSpace(ConfClave) )
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

            //Validacion si el correo tiene el formatio correcto
            if (EmailValido(correo))
            {
                MessageBox.Show("El correo tiene un formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mostrar mensaje de consulta sobre la inserción  
            DialogResult ask = MessageBox.Show("¿Seguro que desea insertar un nuevo Cliente?", "Confirmar Inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            // Verificar la respuesta del usuario  
            if (ask == DialogResult.Yes)
            {
                // Aquí iría la lógica para insertar el nuevo cliente  
                // Por ejemplo, llamar a una función para insertar en la base de datos

                // Mostrar mensaje de información confirmando la inserción correcta  
                MessageBox.Show($"El Usuario se insertó correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        public static bool EmailValido(string email)
        {
            // Expresión regular para validar un correo electrónico
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }*/

    }
}
