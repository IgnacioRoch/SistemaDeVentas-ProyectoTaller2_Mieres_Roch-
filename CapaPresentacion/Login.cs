using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;
using CapaEntidades;
using CapaPresentacion.Vendedor;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BIngresar_Click(object sender, EventArgs e)
        {
            string documento = TxtDocumento.Text;


            // Validación de que no se permite campos vacios
            if (string.IsNullOrWhiteSpace(documento) )
            {
                MessageBox.Show("No se permite campos vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación de que el codigo solo contenga números  
            if (!long.TryParse(documento, out _))
            {
                MessageBox.Show("El Documento debe contener solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            List<Usuario> TEST = new CN_Usuario().Listar();

            Usuario ousuario = new CN_Usuario().Listar().Where(u => u.Documento_usuario == TxtDocumento.Text && u.Clave_usuario == TxtClave.Text).FirstOrDefault();

            if (ousuario != null)
            {
                Inicio form = new Inicio(ousuario);
                FormClientes formcliente = new FormClientes(ousuario);
                form.Show();
                this.Hide();
                form.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show("No se encontró el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void frm_closing(object sender,FormClosingEventArgs e)
        {
            TxtDocumento.Text = "";
            TxtClave.Text = "";
            this.Show();
        }

        
    }
}
