using CapaPresentacion.Administrador;
using CapaPresentacion.Gerente_Comercial;
using CapaPresentacion.Modales;
using CapaPresentacion.Vendedor;
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

using CapaEntidades;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual; 

        private static IconMenuItem menuActivo = null;
        private Form formularioActivo = null;

        public Inicio(Usuario objusuario = null)
        {
            if (objusuario == null)
                usuarioActual = new Usuario() { Nombre_usuario = "ADMIN PREDEFINIDO", Id_usuario = 1 };
            else
            usuarioActual = objusuario; //usuario logeado en ese momento

            InitializeComponent();
        }

        private void abrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (menuActivo != null)
            {
                menuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            menuActivo = menu;

            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.DimGray;

            contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void menu_Usuario_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new FormUsuario());
        }

        private void SubmenuCategorias_Click(object sender, EventArgs e)
        {
            abrirFormulario(menu_productos, new FormCategorias());
        }

        private void SubmenuProductos_Click(object sender, EventArgs e)
        {
            abrirFormulario(menu_productos, new FormProductos());
        }

        private void SubmenuMarcas_Click(object sender, EventArgs e)
        {
            abrirFormulario(menu_productos, new FormMarcas());
        }

        private void subMenuRegistrarVenta_Click(object sender, EventArgs e)
        {
            abrirFormulario(menu_ventas, new FormVentas(usuarioActual));
        }

        private void subMenuVerDetalleVenta_Click(object sender, EventArgs e)
        {
            abrirFormulario(menu_ventas, new FormDetalleVenta());
        }

        private void subMenuRegistrarCompra_Click(object sender, EventArgs e)
        {
            abrirFormulario(menu_compras, new FormCompras(usuarioActual));
        }

        private void subMenuVerDetalleCompra_Click(object sender, EventArgs e)
        {
            abrirFormulario(menu_compras, new FormDetalleCompra());
        }

        private void menu_Clientes_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem) sender, new FormClientes(usuarioActual));
        }

        private void menu_Proveedores_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new FormProveedores());
        }

        private void subMenuReporteCompras_Click(object sender, EventArgs e)
        {
            abrirFormulario(menu_reportes, new FormReporteCompras());
        }

        private void subMenuReporteVentas_Click(object sender, EventArgs e)
        {
            abrirFormulario(menu_reportes, new FormReporteVentas());
        }

        private void menu_Negocio_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new FormNegocio());
        }

        private void menu_informacion_Click(object sender, EventArgs e)
        {
            using (var modal = new mdAcercaDe())
            {
                var result = modal.ShowDialog();
            }
        }

        private void IBSalirInicio_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea salir?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void TimerFechaHora_Tick(object sender, EventArgs e)
        {
            LHora.Text = DateTime.Now.ToShortTimeString();
            LFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            /*Permite recorrer la lista de permisos para determinar cuales menus son visble para cada usuario en el inicio*/
           List<Permiso> ListaPermisos = new CN_Permiso().Listar(usuarioActual.Id_usuario);
            foreach (IconMenuItem iconmenu in MenuInicio.Items)
            {
                bool encontrado = ListaPermisos.Any(m => m.NombreMenu == iconmenu.Name);
                if(encontrado == false)
                {
                    iconmenu.Visible = false;
                }
            }

            LNomUsuario.Text = usuarioActual.Nombre_usuario + " " + usuarioActual.Apellido_usuario;

            /*Agrega el texto al label que designa el rol del usuario actual*/
            switch (usuarioActual.objRol.ID_rol)
            {
                case 1:
                    LRolUsuario.Text = "ADMINISTRADOR";
                    break;
                case 2:
                    LRolUsuario.Text = "VENDEDOR";
                    break;
                case 3:
                    LRolUsuario.Text = "GERENTE COMERCIAL";
                    break;
            }

        }

        private void SubMenuGraficas_Click(object sender, EventArgs e)
        {
            abrirFormulario(menu_reportes, new FormEstadisticas());
        }

        private void menu_MisVentas_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new FormMisVentas(usuarioActual));
        }

        private void menu_verProductos_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new FormListarProductos()); 
        }

        private void menu_verProveedor_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new FormListarProveedor());
        }

        private void menu_BackupBD_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new FormBaseDeDatos());
        }
    }
}
