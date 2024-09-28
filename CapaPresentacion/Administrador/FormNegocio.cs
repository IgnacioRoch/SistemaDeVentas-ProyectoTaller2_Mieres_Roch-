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
    public partial class FormNegocio : Form
    {

        private string imagePath;

        public FormNegocio()
        {
            InitializeComponent();
        }

        private void IBGuardar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox  
            string nombre = TxtNombreNegocio.Text;
            string ruc = TxtRuc.Text;
            string direccion = TxtDireccion.Text;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(ruc) || string.IsNullOrWhiteSpace(direccion) || string.IsNullOrEmpty(imagePath))
            {
                MessageBox.Show("Debe Completar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación de que el negocio y ruc y dirección solo contengan letras  
            if (!nombre.All(char.IsLetter) || !ruc.All(char.IsLetter))
            {
                MessageBox.Show("El Nombre del negocio y el RUC deben contener solo letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mostrar mensaje de consulta sobre la inserción  
            DialogResult ask = MessageBox.Show("¿Seguro que desea insertar una nueva información de negocio?", "Confirmar Inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);



        }

        private void IBSubir_Click(object sender, EventArgs e)
        {
            using (openFileDialog1)
            {
                openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    imagePath = openFileDialog1.FileName;
                    picLogo.Image = Image.FromFile(imagePath);
                }
            }
        }
    }
}
