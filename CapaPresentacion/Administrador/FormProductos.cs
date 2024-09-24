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


            // Validación de que no se permite campos vacios
            if (string.IsNullOrWhiteSpace(codigo) || string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(descripcion))
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

            // Mostrar mensaje de consulta sobre la inserción  
            DialogResult ask = MessageBox.Show("¿Seguro que desea insertar un nuevo Producto?", "Confirmar Inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);



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
            TxtCodigo.Clear();
            TxtNombre.Clear();
            TxtDescripcion.Clear();
            TxtSeleccionId.Text = "0";
            //CBCategoria.SelectedIndex = 0;
            //CBEstado.SelectedIndex = 0;
            //CBMarca.SelectedIndex = 0;
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

            if (MessageBox.Show("¿Limpiar el campo de busqueda?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TxtBusqueda.Clear();
            }

        }
    }
}
