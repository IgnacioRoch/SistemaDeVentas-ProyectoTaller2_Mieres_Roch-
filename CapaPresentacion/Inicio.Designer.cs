namespace CapaPresentacion
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
            this.subMenuReporteCompras = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuReporteVentas = new FontAwesome.Sharp.IconMenuItem();
            this.menu_Negocio = new FontAwesome.Sharp.IconMenuItem();
            this.menu_informacion = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.contenedor = new System.Windows.Forms.Panel();
            this.LUsuario = new System.Windows.Forms.Label();
            this.LNomUsuario = new System.Windows.Forms.Label();
            this.IBSalirInicio = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GBInfoUsuario = new System.Windows.Forms.GroupBox();
            this.LRol = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GBInfoUsuario.SuspendLayout();
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
            this.menu_Negocio,
            this.menu_informacion});
            this.menuStrip2.Location = new System.Drawing.Point(0, 90);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1257, 84);
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
            this.menu_Usuario.IconSize = 55;
            this.menu_Usuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_Usuario.Name = "menu_Usuario";
            this.menu_Usuario.Size = new System.Drawing.Size(85, 80);
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
            this.menu_productos.IconSize = 55;
            this.menu_productos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_productos.Name = "menu_productos";
            this.menu_productos.Size = new System.Drawing.Size(100, 80);
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
            this.menu_ventas.IconSize = 55;
            this.menu_ventas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_ventas.Name = "menu_ventas";
            this.menu_ventas.Size = new System.Drawing.Size(100, 80);
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
            this.menu_compras.IconSize = 55;
            this.menu_compras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_compras.Name = "menu_compras";
            this.menu_compras.Size = new System.Drawing.Size(85, 80);
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
            this.menu_Clientes.IconSize = 55;
            this.menu_Clientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_Clientes.Name = "menu_Clientes";
            this.menu_Clientes.Size = new System.Drawing.Size(85, 80);
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
            this.menu_Proveedores.IconSize = 55;
            this.menu_Proveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_Proveedores.Name = "menu_Proveedores";
            this.menu_Proveedores.Size = new System.Drawing.Size(100, 80);
            this.menu_Proveedores.Text = "Proveedores";
            this.menu_Proveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_Proveedores.Click += new System.EventHandler(this.menu_Proveedores_Click);
            // 
            // menu_Reportes
            // 
            this.menu_Reportes.AutoSize = false;
            this.menu_Reportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuReporteCompras,
            this.subMenuReporteVentas});
            this.menu_Reportes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menu_Reportes.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.menu_Reportes.IconColor = System.Drawing.Color.Black;
            this.menu_Reportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_Reportes.IconSize = 55;
            this.menu_Reportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_Reportes.Name = "menu_Reportes";
            this.menu_Reportes.Size = new System.Drawing.Size(85, 80);
            this.menu_Reportes.Text = "Reportes";
            this.menu_Reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuReporteCompras
            // 
            this.subMenuReporteCompras.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuReporteCompras.IconColor = System.Drawing.Color.Black;
            this.subMenuReporteCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuReporteCompras.Name = "subMenuReporteCompras";
            this.subMenuReporteCompras.Size = new System.Drawing.Size(182, 24);
            this.subMenuReporteCompras.Text = "Reporte compras";
            this.subMenuReporteCompras.Click += new System.EventHandler(this.subMenuReporteCompras_Click);
            // 
            // subMenuReporteVentas
            // 
            this.subMenuReporteVentas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuReporteVentas.IconColor = System.Drawing.Color.Black;
            this.subMenuReporteVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuReporteVentas.Name = "subMenuReporteVentas";
            this.subMenuReporteVentas.Size = new System.Drawing.Size(182, 24);
            this.subMenuReporteVentas.Text = "Reporte ventas";
            this.subMenuReporteVentas.Click += new System.EventHandler(this.subMenuReporteVentas_Click);
            // 
            // menu_Negocio
            // 
            this.menu_Negocio.AutoSize = false;
            this.menu_Negocio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menu_Negocio.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.menu_Negocio.IconColor = System.Drawing.Color.Black;
            this.menu_Negocio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_Negocio.IconSize = 55;
            this.menu_Negocio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_Negocio.Name = "menu_Negocio";
            this.menu_Negocio.Size = new System.Drawing.Size(110, 80);
            this.menu_Negocio.Text = "Negocio";
            this.menu_Negocio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_Negocio.Click += new System.EventHandler(this.menu_Negocio_Click);
            // 
            // menu_informacion
            // 
            this.menu_informacion.AutoSize = false;
            this.menu_informacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menu_informacion.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.menu_informacion.IconColor = System.Drawing.Color.Black;
            this.menu_informacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_informacion.IconSize = 55;
            this.menu_informacion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_informacion.Name = "menu_informacion";
            this.menu_informacion.Size = new System.Drawing.Size(100, 80);
            this.menu_informacion.Text = "Acerca de";
            this.menu_informacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_informacion.Click += new System.EventHandler(this.menu_informacion_Click);
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(1257, 90);
            this.menuTitulo.TabIndex = 3;
            this.menuTitulo.Text = "menuStrip1";
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 174);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1257, 628);
            this.contenedor.TabIndex = 5;
            // 
            // LUsuario
            // 
            this.LUsuario.AutoSize = true;
            this.LUsuario.BackColor = System.Drawing.SystemColors.Highlight;
            this.LUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUsuario.ForeColor = System.Drawing.Color.Snow;
            this.LUsuario.Location = new System.Drawing.Point(19, 28);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(64, 18);
            this.LUsuario.TabIndex = 0;
            this.LUsuario.Text = "Usuario:";
            // 
            // LNomUsuario
            // 
            this.LNomUsuario.AutoSize = true;
            this.LNomUsuario.BackColor = System.Drawing.SystemColors.Highlight;
            this.LNomUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNomUsuario.ForeColor = System.Drawing.Color.Snow;
            this.LNomUsuario.Location = new System.Drawing.Point(89, 28);
            this.LNomUsuario.Name = "LNomUsuario";
            this.LNomUsuario.Size = new System.Drawing.Size(115, 18);
            this.LNomUsuario.TabIndex = 0;
            this.LNomUsuario.Text = "Nombre usuario";
            // 
            // IBSalirInicio
            // 
            this.IBSalirInicio.BackColor = System.Drawing.Color.Firebrick;
            this.IBSalirInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBSalirInicio.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.IBSalirInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBSalirInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBSalirInicio.ForeColor = System.Drawing.Color.White;
            this.IBSalirInicio.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.IBSalirInicio.IconColor = System.Drawing.Color.White;
            this.IBSalirInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBSalirInicio.IconSize = 30;
            this.IBSalirInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBSalirInicio.Location = new System.Drawing.Point(1143, 12);
            this.IBSalirInicio.Name = "IBSalirInicio";
            this.IBSalirInicio.Size = new System.Drawing.Size(102, 31);
            this.IBSalirInicio.TabIndex = 6;
            this.IBSalirInicio.Text = "Salir";
            this.IBSalirInicio.UseVisualStyleBackColor = false;
            this.IBSalirInicio.Click += new System.EventHandler(this.IBSalirInicio_Click);
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
            // GBInfoUsuario
            // 
            this.GBInfoUsuario.BackColor = System.Drawing.SystemColors.Highlight;
            this.GBInfoUsuario.Controls.Add(this.LRol);
            this.GBInfoUsuario.Controls.Add(this.LUsuario);
            this.GBInfoUsuario.Controls.Add(this.LNomUsuario);
            this.GBInfoUsuario.Location = new System.Drawing.Point(712, 12);
            this.GBInfoUsuario.Name = "GBInfoUsuario";
            this.GBInfoUsuario.Size = new System.Drawing.Size(349, 59);
            this.GBInfoUsuario.TabIndex = 0;
            this.GBInfoUsuario.TabStop = false;
            // 
            // LRol
            // 
            this.LRol.AutoSize = true;
            this.LRol.BackColor = System.Drawing.SystemColors.Highlight;
            this.LRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRol.ForeColor = System.Drawing.Color.Snow;
            this.LRol.Location = new System.Drawing.Point(210, 28);
            this.LRol.Name = "LRol";
            this.LRol.Size = new System.Drawing.Size(35, 18);
            this.LRol.TabIndex = 0;
            this.LRol.Text = "Rol:";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1257, 802);
            this.Controls.Add(this.GBInfoUsuario);
            this.Controls.Add(this.IBSalirInicio);
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
            this.GBInfoUsuario.ResumeLayout(false);
            this.GBInfoUsuario.PerformLayout();
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
        private FontAwesome.Sharp.IconMenuItem subMenuReporteCompras;
        private FontAwesome.Sharp.IconMenuItem subMenuReporteVentas;
        private FontAwesome.Sharp.IconMenuItem menu_Negocio;
        private FontAwesome.Sharp.IconButton IBSalirInicio;
        private System.Windows.Forms.GroupBox GBInfoUsuario;
        private System.Windows.Forms.Label LRol;
    }
}

