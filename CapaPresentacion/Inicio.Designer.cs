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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuInicio = new System.Windows.Forms.MenuStrip();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.contenedor = new System.Windows.Forms.Panel();
            this.LUsuario = new System.Windows.Forms.Label();
            this.LNomUsuario = new System.Windows.Forms.Label();
            this.GBInfoUsuario = new System.Windows.Forms.GroupBox();
            this.LHora = new System.Windows.Forms.Label();
            this.LFecha = new System.Windows.Forms.Label();
            this.LRol = new System.Windows.Forms.Label();
            this.LRolUsuario = new System.Windows.Forms.Label();
            this.TimerFechaHora = new System.Windows.Forms.Timer(this.components);
            this.IBSalirInicio = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menu_usuario = new FontAwesome.Sharp.IconMenuItem();
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
            this.menu_clientes = new FontAwesome.Sharp.IconMenuItem();
            this.menu_proveedores = new FontAwesome.Sharp.IconMenuItem();
            this.menu_reportes = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuReporteCompras = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuReporteVentas = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuGraficas = new FontAwesome.Sharp.IconMenuItem();
            this.menu_negocio = new FontAwesome.Sharp.IconMenuItem();
            this.menu_MisVentas = new FontAwesome.Sharp.IconMenuItem();
            this.menu_verProductos = new FontAwesome.Sharp.IconMenuItem();
            this.menu_informacion = new FontAwesome.Sharp.IconMenuItem();
            this.menu_verProveedor = new FontAwesome.Sharp.IconMenuItem();
            this.MenuInicio.SuspendLayout();
            this.GBInfoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(104, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema de Ventas ";
            // 
            // MenuInicio
            // 
            this.MenuInicio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MenuInicio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_usuario,
            this.menu_productos,
            this.menu_ventas,
            this.menu_compras,
            this.menu_clientes,
            this.menu_proveedores,
            this.menu_reportes,
            this.menu_negocio,
            this.menu_MisVentas,
            this.menu_verProductos,
            this.menu_verProveedor,
            this.menu_informacion});
            this.MenuInicio.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.MenuInicio.Location = new System.Drawing.Point(0, 90);
            this.MenuInicio.Name = "MenuInicio";
            this.MenuInicio.Size = new System.Drawing.Size(1257, 103);
            this.MenuInicio.TabIndex = 2;
            this.MenuInicio.Text = "menuStrip2";
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
            this.contenedor.Location = new System.Drawing.Point(0, 193);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1257, 609);
            this.contenedor.TabIndex = 5;
            // 
            // LUsuario
            // 
            this.LUsuario.AutoSize = true;
            this.LUsuario.BackColor = System.Drawing.SystemColors.Highlight;
            this.LUsuario.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUsuario.ForeColor = System.Drawing.Color.Snow;
            this.LUsuario.Location = new System.Drawing.Point(19, 13);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(79, 13);
            this.LUsuario.TabIndex = 0;
            this.LUsuario.Text = "Usuario:";
            // 
            // LNomUsuario
            // 
            this.LNomUsuario.AutoSize = true;
            this.LNomUsuario.BackColor = System.Drawing.SystemColors.Highlight;
            this.LNomUsuario.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNomUsuario.ForeColor = System.Drawing.Color.Snow;
            this.LNomUsuario.Location = new System.Drawing.Point(104, 13);
            this.LNomUsuario.Name = "LNomUsuario";
            this.LNomUsuario.Size = new System.Drawing.Size(105, 13);
            this.LNomUsuario.TabIndex = 0;
            this.LNomUsuario.Text = "Nombre usuario";
            // 
            // GBInfoUsuario
            // 
            this.GBInfoUsuario.BackColor = System.Drawing.SystemColors.Highlight;
            this.GBInfoUsuario.Controls.Add(this.LHora);
            this.GBInfoUsuario.Controls.Add(this.LFecha);
            this.GBInfoUsuario.Controls.Add(this.LRol);
            this.GBInfoUsuario.Controls.Add(this.LUsuario);
            this.GBInfoUsuario.Controls.Add(this.LRolUsuario);
            this.GBInfoUsuario.Controls.Add(this.LNomUsuario);
            this.GBInfoUsuario.Location = new System.Drawing.Point(474, 12);
            this.GBInfoUsuario.Name = "GBInfoUsuario";
            this.GBInfoUsuario.Size = new System.Drawing.Size(587, 59);
            this.GBInfoUsuario.TabIndex = 0;
            this.GBInfoUsuario.TabStop = false;
            // 
            // LHora
            // 
            this.LHora.AutoSize = true;
            this.LHora.BackColor = System.Drawing.Color.Transparent;
            this.LHora.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LHora.ForeColor = System.Drawing.Color.White;
            this.LHora.Location = new System.Drawing.Point(305, 13);
            this.LHora.Name = "LHora";
            this.LHora.Size = new System.Drawing.Size(48, 17);
            this.LHora.TabIndex = 0;
            this.LHora.Text = "Hora";
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.BackColor = System.Drawing.Color.Transparent;
            this.LFecha.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFecha.ForeColor = System.Drawing.Color.White;
            this.LFecha.Location = new System.Drawing.Point(305, 38);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(47, 13);
            this.LFecha.TabIndex = 0;
            this.LFecha.Text = "Fecha";
            // 
            // LRol
            // 
            this.LRol.AutoSize = true;
            this.LRol.BackColor = System.Drawing.SystemColors.Highlight;
            this.LRol.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRol.ForeColor = System.Drawing.Color.Snow;
            this.LRol.Location = new System.Drawing.Point(19, 38);
            this.LRol.Name = "LRol";
            this.LRol.Size = new System.Drawing.Size(43, 13);
            this.LRol.TabIndex = 0;
            this.LRol.Text = "Rol:";
            // 
            // LRolUsuario
            // 
            this.LRolUsuario.AutoSize = true;
            this.LRolUsuario.BackColor = System.Drawing.SystemColors.Highlight;
            this.LRolUsuario.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRolUsuario.ForeColor = System.Drawing.Color.Snow;
            this.LRolUsuario.Location = new System.Drawing.Point(62, 38);
            this.LRolUsuario.Name = "LRolUsuario";
            this.LRolUsuario.Size = new System.Drawing.Size(84, 13);
            this.LRolUsuario.TabIndex = 0;
            this.LRolUsuario.Text = "Rol usuario";
            // 
            // TimerFechaHora
            // 
            this.TimerFechaHora.Enabled = true;
            this.TimerFechaHora.Tick += new System.EventHandler(this.TimerFechaHora_Tick);
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
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.FrameLogo;
            this.pictureBox1.Location = new System.Drawing.Point(0, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // menu_usuario
            // 
            this.menu_usuario.AutoSize = false;
            this.menu_usuario.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_usuario.ForeColor = System.Drawing.Color.SlateGray;
            this.menu_usuario.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.menu_usuario.IconColor = System.Drawing.Color.Black;
            this.menu_usuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_usuario.IconSize = 55;
            this.menu_usuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_usuario.Name = "menu_usuario";
            this.menu_usuario.Size = new System.Drawing.Size(85, 80);
            this.menu_usuario.Text = "Usuarios";
            this.menu_usuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_usuario.Click += new System.EventHandler(this.menu_Usuario_Click);
            // 
            // menu_productos
            // 
            this.menu_productos.AutoSize = false;
            this.menu_productos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubmenuProductos,
            this.SubmenuCategorias,
            this.SubmenuMarcas});
            this.menu_productos.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_productos.ForeColor = System.Drawing.Color.LightSlateGray;
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
            this.SubmenuProductos.Size = new System.Drawing.Size(164, 22);
            this.SubmenuProductos.Text = "Productos";
            this.SubmenuProductos.Click += new System.EventHandler(this.SubmenuProductos_Click);
            // 
            // SubmenuCategorias
            // 
            this.SubmenuCategorias.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubmenuCategorias.IconColor = System.Drawing.Color.Black;
            this.SubmenuCategorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubmenuCategorias.Name = "SubmenuCategorias";
            this.SubmenuCategorias.Size = new System.Drawing.Size(164, 22);
            this.SubmenuCategorias.Text = "Categorías";
            this.SubmenuCategorias.Click += new System.EventHandler(this.SubmenuCategorias_Click);
            // 
            // SubmenuMarcas
            // 
            this.SubmenuMarcas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubmenuMarcas.IconColor = System.Drawing.Color.Black;
            this.SubmenuMarcas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubmenuMarcas.Name = "SubmenuMarcas";
            this.SubmenuMarcas.Size = new System.Drawing.Size(164, 22);
            this.SubmenuMarcas.Text = "Marcas";
            this.SubmenuMarcas.Click += new System.EventHandler(this.SubmenuMarcas_Click);
            // 
            // menu_ventas
            // 
            this.menu_ventas.AutoSize = false;
            this.menu_ventas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuRegistrarVenta,
            this.subMenuVerDetalleVenta});
            this.menu_ventas.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_ventas.ForeColor = System.Drawing.Color.LightSlateGray;
            this.menu_ventas.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
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
            this.subMenuRegistrarVenta.Size = new System.Drawing.Size(209, 22);
            this.subMenuRegistrarVenta.Text = "Registrar venta";
            this.subMenuRegistrarVenta.Click += new System.EventHandler(this.subMenuRegistrarVenta_Click);
            // 
            // subMenuVerDetalleVenta
            // 
            this.subMenuVerDetalleVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuVerDetalleVenta.IconColor = System.Drawing.Color.Black;
            this.subMenuVerDetalleVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuVerDetalleVenta.Name = "subMenuVerDetalleVenta";
            this.subMenuVerDetalleVenta.Size = new System.Drawing.Size(209, 22);
            this.subMenuVerDetalleVenta.Text = "Ver detalle";
            this.subMenuVerDetalleVenta.Click += new System.EventHandler(this.subMenuVerDetalleVenta_Click);
            // 
            // menu_compras
            // 
            this.menu_compras.AutoSize = false;
            this.menu_compras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuRegistrarCompra,
            this.subMenuVerDetalleCompra});
            this.menu_compras.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_compras.ForeColor = System.Drawing.Color.LightSlateGray;
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
            this.subMenuRegistrarCompra.Size = new System.Drawing.Size(218, 22);
            this.subMenuRegistrarCompra.Text = "Registrar compra";
            this.subMenuRegistrarCompra.Click += new System.EventHandler(this.subMenuRegistrarCompra_Click);
            // 
            // subMenuVerDetalleCompra
            // 
            this.subMenuVerDetalleCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuVerDetalleCompra.IconColor = System.Drawing.Color.Black;
            this.subMenuVerDetalleCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuVerDetalleCompra.Name = "subMenuVerDetalleCompra";
            this.subMenuVerDetalleCompra.Size = new System.Drawing.Size(218, 22);
            this.subMenuVerDetalleCompra.Text = "Ver detalle";
            this.subMenuVerDetalleCompra.Click += new System.EventHandler(this.subMenuVerDetalleCompra_Click);
            // 
            // menu_clientes
            // 
            this.menu_clientes.AutoSize = false;
            this.menu_clientes.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_clientes.ForeColor = System.Drawing.Color.LightSlateGray;
            this.menu_clientes.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.menu_clientes.IconColor = System.Drawing.Color.Black;
            this.menu_clientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_clientes.IconSize = 55;
            this.menu_clientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_clientes.Name = "menu_clientes";
            this.menu_clientes.Size = new System.Drawing.Size(85, 80);
            this.menu_clientes.Text = "Clientes";
            this.menu_clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_clientes.Click += new System.EventHandler(this.menu_Clientes_Click);
            // 
            // menu_proveedores
            // 
            this.menu_proveedores.AutoSize = false;
            this.menu_proveedores.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_proveedores.ForeColor = System.Drawing.Color.LightSlateGray;
            this.menu_proveedores.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.menu_proveedores.IconColor = System.Drawing.Color.Black;
            this.menu_proveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_proveedores.IconSize = 55;
            this.menu_proveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_proveedores.Name = "menu_proveedores";
            this.menu_proveedores.Size = new System.Drawing.Size(110, 80);
            this.menu_proveedores.Text = "Proveedores";
            this.menu_proveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_proveedores.Click += new System.EventHandler(this.menu_Proveedores_Click);
            // 
            // menu_reportes
            // 
            this.menu_reportes.AutoSize = false;
            this.menu_reportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuReporteCompras,
            this.subMenuReporteVentas,
            this.SubMenuGraficas});
            this.menu_reportes.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_reportes.ForeColor = System.Drawing.Color.LightSlateGray;
            this.menu_reportes.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.menu_reportes.IconColor = System.Drawing.Color.Black;
            this.menu_reportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_reportes.IconSize = 55;
            this.menu_reportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_reportes.Name = "menu_reportes";
            this.menu_reportes.Size = new System.Drawing.Size(85, 80);
            this.menu_reportes.Text = "Reportes";
            this.menu_reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuReporteCompras
            // 
            this.subMenuReporteCompras.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuReporteCompras.IconColor = System.Drawing.Color.Black;
            this.subMenuReporteCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuReporteCompras.Name = "subMenuReporteCompras";
            this.subMenuReporteCompras.Size = new System.Drawing.Size(263, 22);
            this.subMenuReporteCompras.Text = "Reporte compras";
            this.subMenuReporteCompras.Click += new System.EventHandler(this.subMenuReporteCompras_Click);
            // 
            // subMenuReporteVentas
            // 
            this.subMenuReporteVentas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuReporteVentas.IconColor = System.Drawing.Color.Black;
            this.subMenuReporteVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuReporteVentas.Name = "subMenuReporteVentas";
            this.subMenuReporteVentas.Size = new System.Drawing.Size(263, 22);
            this.subMenuReporteVentas.Text = "Reporte ventas";
            this.subMenuReporteVentas.Click += new System.EventHandler(this.subMenuReporteVentas_Click);
            // 
            // SubMenuGraficas
            // 
            this.SubMenuGraficas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuGraficas.IconColor = System.Drawing.Color.Black;
            this.SubMenuGraficas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuGraficas.Name = "SubMenuGraficas";
            this.SubMenuGraficas.Size = new System.Drawing.Size(263, 22);
            this.SubMenuGraficas.Text = "Gráficos Estadísticos";
            this.SubMenuGraficas.Click += new System.EventHandler(this.SubMenuGraficas_Click);
            // 
            // menu_negocio
            // 
            this.menu_negocio.AutoSize = false;
            this.menu_negocio.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_negocio.ForeColor = System.Drawing.Color.LightSlateGray;
            this.menu_negocio.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.menu_negocio.IconColor = System.Drawing.Color.Black;
            this.menu_negocio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_negocio.IconSize = 55;
            this.menu_negocio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_negocio.Name = "menu_negocio";
            this.menu_negocio.Size = new System.Drawing.Size(110, 80);
            this.menu_negocio.Text = "Negocio";
            this.menu_negocio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_negocio.Click += new System.EventHandler(this.menu_Negocio_Click);
            // 
            // menu_MisVentas
            // 
            this.menu_MisVentas.AutoSize = false;
            this.menu_MisVentas.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_MisVentas.ForeColor = System.Drawing.Color.LightSlateGray;
            this.menu_MisVentas.IconChar = FontAwesome.Sharp.IconChar.List;
            this.menu_MisVentas.IconColor = System.Drawing.Color.Black;
            this.menu_MisVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_MisVentas.IconSize = 55;
            this.menu_MisVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_MisVentas.Name = "menu_MisVentas";
            this.menu_MisVentas.Size = new System.Drawing.Size(100, 80);
            this.menu_MisVentas.Text = "Mis Ventas";
            this.menu_MisVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_MisVentas.Click += new System.EventHandler(this.menu_MisVentas_Click);
            // 
            // menu_verProductos
            // 
            this.menu_verProductos.AutoSize = false;
            this.menu_verProductos.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_verProductos.ForeColor = System.Drawing.Color.LightSlateGray;
            this.menu_verProductos.IconChar = FontAwesome.Sharp.IconChar.List;
            this.menu_verProductos.IconColor = System.Drawing.Color.Black;
            this.menu_verProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_verProductos.IconSize = 55;
            this.menu_verProductos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_verProductos.Name = "menu_verProductos";
            this.menu_verProductos.Size = new System.Drawing.Size(122, 80);
            this.menu_verProductos.Text = "Ver Productos";
            this.menu_verProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_verProductos.Click += new System.EventHandler(this.menu_verProductos_Click);
            // 
            // menu_informacion
            // 
            this.menu_informacion.AutoSize = false;
            this.menu_informacion.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_informacion.ForeColor = System.Drawing.Color.LightSlateGray;
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
            // menu_verProveedor
            // 
            this.menu_verProveedor.AutoSize = false;
            this.menu_verProveedor.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_verProveedor.ForeColor = System.Drawing.Color.LightSlateGray;
            this.menu_verProveedor.IconChar = FontAwesome.Sharp.IconChar.List;
            this.menu_verProveedor.IconColor = System.Drawing.Color.Black;
            this.menu_verProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_verProveedor.IconSize = 55;
            this.menu_verProveedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_verProveedor.Name = "menu_verProveedor";
            this.menu_verProveedor.Size = new System.Drawing.Size(122, 80);
            this.menu_verProveedor.Text = "Ver Proveedor";
            this.menu_verProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_verProveedor.Click += new System.EventHandler(this.menu_verProveedor_Click);
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
            this.Controls.Add(this.MenuInicio);
            this.Controls.Add(this.menuTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CeluStore - Gestión de ventas";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.MenuInicio.ResumeLayout(false);
            this.MenuInicio.PerformLayout();
            this.GBInfoUsuario.ResumeLayout(false);
            this.GBInfoUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip MenuInicio;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private FontAwesome.Sharp.IconMenuItem menu_usuario;
        private FontAwesome.Sharp.IconMenuItem menu_productos;
        private FontAwesome.Sharp.IconMenuItem menu_ventas;
        private FontAwesome.Sharp.IconMenuItem menu_compras;
        private FontAwesome.Sharp.IconMenuItem menu_clientes;
        private FontAwesome.Sharp.IconMenuItem menu_proveedores;
        private FontAwesome.Sharp.IconMenuItem menu_reportes;
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
        private FontAwesome.Sharp.IconMenuItem menu_negocio;
        private FontAwesome.Sharp.IconButton IBSalirInicio;
        private System.Windows.Forms.GroupBox GBInfoUsuario;
        private System.Windows.Forms.Label LRol;
        private System.Windows.Forms.Label LHora;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.Timer TimerFechaHora;
        private System.Windows.Forms.Label LRolUsuario;
        private FontAwesome.Sharp.IconMenuItem SubMenuGraficas;
        private FontAwesome.Sharp.IconMenuItem menu_MisVentas;
        private FontAwesome.Sharp.IconMenuItem menu_verProductos;
        private FontAwesome.Sharp.IconMenuItem menu_verProveedor;
    }
}

