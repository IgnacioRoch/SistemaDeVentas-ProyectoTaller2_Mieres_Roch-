using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

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
            Negocio datos = new CN_Negocio().ObtenerDatos();

            // Obtener los valores predeterminados (por ejemplo, los que estaban al cargar la ventana o formulario)
            string nombrePredeterminado = datos.Nombre_negocio;
            string rucPredeterminado = datos.RUC_negocio;
            string direccionPredeterminada = datos.Direccion_negocio;

            // Obtener los valores de los TextBox  
            string nombre = TxtNombreNegocio.Text;
            string ruc = TxtRuc.Text;
            string direccion = TxtDireccion.Text;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(ruc) || string.IsNullOrWhiteSpace(direccion))
            {
                MessageBox.Show("Debe Completar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación de que el negocio y ruc y dirección solo contengan letras  
            if (!nombre.All(char.IsLetter))
            {
                MessageBox.Show("El Nombre del negocio deben contener solo letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar si el usuario ha realizado cambios en los TextBox
            if (TxtNombreNegocio.Text == nombrePredeterminado && TxtRuc.Text == rucPredeterminado && TxtDireccion.Text == direccionPredeterminada)
            {
                MessageBox.Show("No se ha realizado ningún cambio. Para editar, modifique los valores.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string mensaje = string.Empty;
            Negocio obj = new Negocio()
            {
                Nombre_negocio = TxtNombreNegocio.Text,
                RUC_negocio = TxtRuc.Text,
                Direccion_negocio = TxtDireccion.Text
            };

            // Mostrar mensaje de consulta sobre la inserción  
            DialogResult ask = MessageBox.Show("¿Seguro que desea insertar una nueva información de negocio?", "Confirmar Inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            // Verificar la respuesta del usuario  
            if (ask == DialogResult.Yes)
            {
                bool respuesta = new CN_Negocio().GuardarDatos(obj, out mensaje);

                if (respuesta)
                {
                    MessageBox.Show($"Los datos fueron guardados", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void IBSubir_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            OpenFileDialog oOpenFileDialog = new OpenFileDialog();
            oOpenFileDialog.FileName = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] byteImage = File.ReadAllBytes(oOpenFileDialog.FileName);
                bool respuesta = new CN_Negocio().ActualizarLogo(byteImage, out mensaje);

                if (respuesta)
                {
                    picLogo.Image = ByterToImage(byteImage);
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public Image ByterToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image imagen = new Bitmap(ms);

            return imagen;
        }

        private void FormNegocio_Load(object sender, EventArgs e)
        {
            bool obtenido = true;
            byte[] byteImagen = new CN_Negocio().ObtenerLogo(out obtenido);

            if (obtenido)
            {
                picLogo.Image = ByterToImage(byteImagen);
            }

            Negocio datos = new CN_Negocio().ObtenerDatos();

            TxtNombreNegocio.Text = datos.Nombre_negocio;
            TxtRuc.Text = datos.RUC_negocio;
            TxtDireccion.Text = datos.Direccion_negocio;
        }
    }
}
