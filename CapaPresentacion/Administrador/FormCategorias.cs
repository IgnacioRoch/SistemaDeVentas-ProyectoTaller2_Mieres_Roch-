using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Administrador
{
    public partial class FormCategorias : Form
    {
        public FormCategorias()
        {
            InitializeComponent();
        }

        private void IBGuardar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            string documento = TxtDocumento.Text;

            // Validación de que no se permite campos vacios
            if (string.IsNullOrWhiteSpace(documento))
            {
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación de que el descripcion solo contenga letras  
            if (!documento.All(char.IsLetter) )
            {
                MessageBox.Show("El campo descripción deben contener solo letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mostrar mensaje de consulta sobre la inserción  
            DialogResult ask = MessageBox.Show("¿Seguro que desea insertar una nueva categoria?", "Confirmar Inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

        }

        private void IBVaciar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            string documento = TxtDocumento.Text;

            if (string.IsNullOrWhiteSpace(documento)
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
            TxtSeleccionId.Text = "0";
            //textBox1 = "0";
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
                MessageBox.Show("el campo está vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("¿Limpiar el campo del fomulario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TxtBusqueda.Clear();
            }
        }
    }
}
