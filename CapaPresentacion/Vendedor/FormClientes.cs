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
using System.Threading.Tasks;
using System.Windows.Forms;

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
            /*if (usuarioActual.objRol.ID_rol == 2)
            {
                IBEliminarCliente.Visible = false; 
            }*/
            
        }
    }
}
