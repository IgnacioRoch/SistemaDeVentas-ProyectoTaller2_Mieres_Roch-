﻿using CapaPresentacion.Administrador;
using CapaPresentacion.Gerente_Comercial;
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

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static IconMenuItem menuActivo = null;
        private Form formularioActivo = null;

        public Inicio()
        {
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
            formulario.BackColor = Color.LightBlue;

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
            abrirFormulario(menu_ventas, new FormVentas());
        }

        private void subMenuVerDetalleVenta_Click(object sender, EventArgs e)
        {
            abrirFormulario(menu_ventas, new FormDetalleVenta());
        }

        private void subMenuRegistrarCompra_Click(object sender, EventArgs e)
        {
            abrirFormulario(menu_compras, new FormCompras());
        }

        private void subMenuVerDetalleCompra_Click(object sender, EventArgs e)
        {
            abrirFormulario(menu_compras, new FormDetalleCompra());
        }

        private void menu_Clientes_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem) sender, new FormClientes());
        }

        private void menu_Proveedores_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new FormProveedores());
        }

        private void menu_Reportes_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new FormReportes());
        }

    }
}
