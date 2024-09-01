﻿namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menu_Usuario = new FontAwesome.Sharp.IconMenuItem();
            this.menu_productos = new FontAwesome.Sharp.IconMenuItem();
            this.SubmenuProductos = new FontAwesome.Sharp.IconMenuItem();
            this.SubmenuCategorias = new FontAwesome.Sharp.IconMenuItem();
            this.SubmenuMarcas = new FontAwesome.Sharp.IconMenuItem();
            this.menu_ventas = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuRegistrarVenta = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuVerDetalleVenta = new FontAwesome.Sharp.IconMenuItem();
            this.menu_compras = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuRegistrarCompra = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuVerDetalleCompra = new FontAwesome.Sharp.IconMenuItem();
            this.menu_Clientes = new FontAwesome.Sharp.IconMenuItem();
            this.menu_Proveedores = new FontAwesome.Sharp.IconMenuItem();
            this.menu_Reportes = new FontAwesome.Sharp.IconMenuItem();
            this.menu_informacion = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.contenedor = new System.Windows.Forms.Panel();
            this.LUsuario = new System.Windows.Forms.Label();
            this.LNomUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(104, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema de Ventas ";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Usuario,
            this.menu_productos,
            this.menu_ventas,
            this.menu_compras,
            this.menu_Clientes,
            this.menu_Proveedores,
            this.menu_Reportes,
            this.menu_informacion});
            this.menuStrip2.Location = new System.Drawing.Point(0, 90);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1037, 73);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menu_Usuario
            // 
            this.menu_Usuario.AutoSize = false;
            this.menu_Usuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menu_Usuario.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.menu_Usuario.IconColor = System.Drawing.Color.Black;
            this.menu_Usuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_Usuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_Usuario.Name = "menu_Usuario";
            this.menu_Usuario.Size = new System.Drawing.Size(85, 69);
            this.menu_Usuario.Text = "Usuarios";
            this.menu_Usuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_Usuario.Click += new System.EventHandler(this.menu_Usuario_Click);
            // 
            // menu_productos
            // 
            this.menu_productos.AutoSize = false;
            this.menu_productos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubmenuProductos,
            this.SubmenuCategorias,
            this.SubmenuMarcas});
            this.menu_productos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menu_productos.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.menu_productos.IconColor = System.Drawing.Color.Black;
            this.menu_productos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_productos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_productos.Name = "menu_productos";
            this.menu_productos.Size = new System.Drawing.Size(122, 69);
            this.menu_productos.Text = "Productos";
            this.menu_productos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SubmenuProductos
            // 
            this.SubmenuProductos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubmenuProductos.IconColor = System.Drawing.Color.Black;
            this.SubmenuProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubmenuProductos.Name = "SubmenuProductos";
            this.SubmenuProductos.Size = new System.Drawing.Size(143, 24);
            this.SubmenuProductos.Text = "Productos";
            this.SubmenuProductos.Click += new System.EventHandler(this.SubmenuProductos_Click);
            // 
            // SubmenuCategorias
            // 
            this.SubmenuCategorias.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubmenuCategorias.IconColor = System.Drawing.Color.Black;
            this.SubmenuCategorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubmenuCategorias.Name = "SubmenuCategorias";
            this.SubmenuCategorias.Size = new System.Drawing.Size(143, 24);
            this.SubmenuCategorias.Text = "Categorías";
            this.SubmenuCategorias.Click += new System.EventHandler(this.SubmenuCategorias_Click);
            // 
            // SubmenuMarcas
            // 
            this.SubmenuMarcas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubmenuMarcas.IconColor = System.Drawing.Color.Black;
            this.SubmenuMarcas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubmenuMarcas.Name = "SubmenuMarcas";
            this.SubmenuMarcas.Size = new System.Drawing.Size(143, 24);
            this.SubmenuMarcas.Text = "Marcas";
            this.SubmenuMarcas.Click += new System.EventHandler(this.SubmenuMarcas_Click);
            // 
            // menu_ventas
            // 
            this.menu_ventas.AutoSize = false;
            this.menu_ventas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuRegistrarVenta,
            this.subMenuVerDetalleVenta});
            this.menu_ventas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menu_ventas.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.menu_ventas.IconColor = System.Drawing.Color.Black;
            this.menu_ventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_ventas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_ventas.Name = "menu_ventas";
            this.menu_ventas.Size = new System.Drawing.Size(122, 69);
            this.menu_ventas.Text = "Ventas";
            this.menu_ventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuRegistrarVenta
            // 
            this.subMenuRegistrarVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuRegistrarVenta.IconColor = System.Drawing.Color.Black;
            this.subMenuRegistrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuRegistrarVenta.Name = "subMenuRegistrarVenta";
            this.subMenuRegistrarVenta.Size = new System.Drawing.Size(170, 24);
            this.subMenuRegistrarVenta.Text = "Registrar venta";
            this.subMenuRegistrarVenta.Click += new System.EventHandler(this.subMenuRegistrarVenta_Click);
            // 
            // subMenuVerDetalleVenta
            // 
            this.subMenuVerDetalleVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuVerDetalleVenta.IconColor = System.Drawing.Color.Black;
            this.subMenuVerDetalleVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuVerDetalleVenta.Name = "subMenuVerDetalleVenta";
            this.subMenuVerDetalleVenta.Size = new System.Drawing.Size(170, 24);
            this.subMenuVerDetalleVenta.Text = "Ver detalle";
            this.subMenuVerDetalleVenta.Click += new System.EventHandler(this.subMenuVerDetalleVenta_Click);
            // 
            // menu_compras
            // 
            this.menu_compras.AutoSize = false;
            this.menu_compras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuRegistrarCompra,
            this.subMenuVerDetalleCompra});
            this.menu_compras.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menu_compras.IconChar = FontAwesome.Sharp.IconChar.Dolly;
            this.menu_compras.IconColor = System.Drawing.Color.Black;
            this.menu_compras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_compras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_compras.Name = "menu_compras";
            this.menu_compras.Size = new System.Drawing.Size(85, 69);
            this.menu_compras.Text = "Compras";
            this.menu_compras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuRegistrarCompra
            // 
            this.subMenuRegistrarCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuRegistrarCompra.IconColor = System.Drawing.Color.Black;
            this.subMenuRegistrarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuRegistrarCompra.Name = "subMenuRegistrarCompra";
            this.subMenuRegistrarCompra.Size = new System.Drawing.Size(182, 24);
            this.subMenuRegistrarCompra.Text = "Registrar compra";
            this.subMenuRegistrarCompra.Click += new System.EventHandler(this.subMenuRegistrarCompra_Click);
            // 
            // subMenuVerDetalleCompra
            // 
            this.subMenuVerDetalleCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuVerDetalleCompra.IconColor = System.Drawing.Color.Black;
            this.subMenuVerDetalleCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuVerDetalleCompra.Name = "subMenuVerDetalleCompra";
            this.subMenuVerDetalleCompra.Size = new System.Drawing.Size(182, 24);
            this.subMenuVerDetalleCompra.Text = "Ver detalle";
            this.subMenuVerDetalleCompra.Click += new System.EventHandler(this.subMenuVerDetalleCompra_Click);
            // 
            // menu_Clientes
            // 
            this.menu_Clientes.AutoSize = false;
            this.menu_Clientes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menu_Clientes.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.menu_Clientes.IconColor = System.Drawing.Color.Black;
            this.menu_Clientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_Clientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_Clientes.Name = "menu_Clientes";
            this.menu_Clientes.Size = new System.Drawing.Size(85, 69);
            this.menu_Clientes.Text = "Clientes";
            this.menu_Clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_Clientes.Click += new System.EventHandler(this.menu_Clientes_Click);
            // 
            // menu_Proveedores
            // 
            this.menu_Proveedores.AutoSize = false;
            this.menu_Proveedores.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menu_Proveedores.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.menu_Proveedores.IconColor = System.Drawing.Color.Black;
            this.menu_Proveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_Proveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_Proveedores.Name = "menu_Proveedores";
            this.menu_Proveedores.Size = new System.Drawing.Size(85, 69);
            this.menu_Proveedores.Text = "Proveedores";
            this.menu_Proveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_Proveedores.Click += new System.EventHandler(this.menu_Proveedores_Click);
            // 
            // menu_Reportes
            // 
            this.menu_Reportes.AutoSize = false;
            this.menu_Reportes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menu_Reportes.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            this.menu_Reportes.IconColor = System.Drawing.Color.Black;
            this.menu_Reportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_Reportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_Reportes.Name = "menu_Reportes";
            this.menu_Reportes.Size = new System.Drawing.Size(85, 69);
            this.menu_Reportes.Text = "Reportes";
            this.menu_Reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_Reportes.Click += new System.EventHandler(this.menu_Reportes_Click);
            // 
            // menu_informacion
            // 
            this.menu_informacion.AutoSize = false;
            this.menu_informacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menu_informacion.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.menu_informacion.IconColor = System.Drawing.Color.Black;
            this.menu_informacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_informacion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_informacion.Name = "menu_informacion";
            this.menu_informacion.Size = new System.Drawing.Size(85, 69);
            this.menu_informacion.Text = "Acerca de";
            this.menu_informacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(1037, 90);
            this.menuTitulo.TabIndex = 3;
            this.menuTitulo.Text = "menuStrip1";
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 163);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1037, 560);
            this.contenedor.TabIndex = 5;
            // 
            // LUsuario
            // 
            this.LUsuario.AutoSize = true;
            this.LUsuario.BackColor = System.Drawing.SystemColors.Highlight;
            this.LUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUsuario.ForeColor = System.Drawing.Color.Snow;
            this.LUsuario.Location = new System.Drawing.Point(813, 40);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(53, 15);
            this.LUsuario.TabIndex = 0;
            this.LUsuario.Text = "Usuario:";
            // 
            // LNomUsuario
            // 
            this.LNomUsuario.AutoSize = true;
            this.LNomUsuario.BackColor = System.Drawing.SystemColors.Highlight;
            this.LNomUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNomUsuario.ForeColor = System.Drawing.Color.Snow;
            this.LNomUsuario.Location = new System.Drawing.Point(888, 40);
            this.LNomUsuario.Name = "LNomUsuario";
            this.LNomUsuario.Size = new System.Drawing.Size(96, 15);
            this.LNomUsuario.TabIndex = 0;
            this.LNomUsuario.Text = "Nombre usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.Frame_1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1037, 723);
            this.Controls.Add(this.LNomUsuario);
            this.Controls.Add(this.LUsuario);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuTitulo);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CeluStore - Gestión de ventas";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private FontAwesome.Sharp.IconMenuItem menu_Usuario;
        private FontAwesome.Sharp.IconMenuItem menu_productos;
        private FontAwesome.Sharp.IconMenuItem menu_ventas;
        private FontAwesome.Sharp.IconMenuItem menu_compras;
        private FontAwesome.Sharp.IconMenuItem menu_Clientes;
        private FontAwesome.Sharp.IconMenuItem menu_Proveedores;
        private FontAwesome.Sharp.IconMenuItem menu_Reportes;
        private FontAwesome.Sharp.IconMenuItem menu_informacion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Label LUsuario;
        private System.Windows.Forms.Label LNomUsuario;
        private FontAwesome.Sharp.IconMenuItem SubmenuProductos;
        private FontAwesome.Sharp.IconMenuItem SubmenuCategorias;
        private FontAwesome.Sharp.IconMenuItem SubmenuMarcas;
        private FontAwesome.Sharp.IconMenuItem subMenuRegistrarVenta;
        private FontAwesome.Sharp.IconMenuItem subMenuVerDetalleVenta;
        private FontAwesome.Sharp.IconMenuItem subMenuRegistrarCompra;
        private FontAwesome.Sharp.IconMenuItem subMenuVerDetalleCompra;
    }
}

