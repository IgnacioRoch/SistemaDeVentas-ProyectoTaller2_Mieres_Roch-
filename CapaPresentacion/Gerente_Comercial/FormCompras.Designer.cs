namespace CapaPresentacion.Gerente_Comercial
{
    partial class FormCompras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IBRegistrarCompra = new FontAwesome.Sharp.IconButton();
            this.IBAgregar = new FontAwesome.Sharp.IconButton();
            this.dataGridDatos = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.GBInfoProducto = new System.Windows.Forms.GroupBox();
            this.TxtCantidad = new System.Windows.Forms.NumericUpDown();
            this.TxtIdProducto = new System.Windows.Forms.TextBox();
            this.IBBuscarProducto = new FontAwesome.Sharp.IconButton();
            this.LCantidad = new System.Windows.Forms.Label();
            this.LPrecioVenta = new System.Windows.Forms.Label();
            this.TxtPrecioVenta = new System.Windows.Forms.TextBox();
            this.LPrecioCompra = new System.Windows.Forms.Label();
            this.TxtPrecioCompra = new System.Windows.Forms.TextBox();
            this.LProducto = new System.Windows.Forms.Label();
            this.TxtProducto = new System.Windows.Forms.TextBox();
            this.TxtCodProducto = new System.Windows.Forms.TextBox();
            this.LCodProducto = new System.Windows.Forms.Label();
            this.GBInfoProveedor = new System.Windows.Forms.GroupBox();
            this.TxtIdProveedor = new System.Windows.Forms.TextBox();
            this.IBBuscarProveedor = new FontAwesome.Sharp.IconButton();
            this.LRazonSocial = new System.Windows.Forms.Label();
            this.TxtRazonSocial = new System.Windows.Forms.TextBox();
            this.TxtNroDocProveedor = new System.Windows.Forms.TextBox();
            this.LNroDoc = new System.Windows.Forms.Label();
            this.GBInfoCompra = new System.Windows.Forms.GroupBox();
            this.CBTipoDoc = new System.Windows.Forms.ComboBox();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.LTipoDoc = new System.Windows.Forms.Label();
            this.LFecha = new System.Windows.Forms.Label();
            this.LRegistrarCompra = new System.Windows.Forms.Label();
            this.LTotalAPagar = new System.Windows.Forms.Label();
            this.TxtTotalAPagar = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatos)).BeginInit();
            this.GBInfoProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidad)).BeginInit();
            this.GBInfoProveedor.SuspendLayout();
            this.GBInfoCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::CapaPresentacion.Properties.Resources.PanelDetallesVC;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.IBRegistrarCompra);
            this.panel1.Controls.Add(this.IBAgregar);
            this.panel1.Controls.Add(this.dataGridDatos);
            this.panel1.Controls.Add(this.GBInfoProducto);
            this.panel1.Controls.Add(this.GBInfoProveedor);
            this.panel1.Controls.Add(this.GBInfoCompra);
            this.panel1.Controls.Add(this.LRegistrarCompra);
            this.panel1.Controls.Add(this.LTotalAPagar);
            this.panel1.Controls.Add(this.TxtTotalAPagar);
            this.panel1.Location = new System.Drawing.Point(111, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 545);
            this.panel1.TabIndex = 4;
            // 
            // IBRegistrarCompra
            // 
            this.IBRegistrarCompra.BackColor = System.Drawing.Color.SteelBlue;
            this.IBRegistrarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBRegistrarCompra.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.IBRegistrarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBRegistrarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBRegistrarCompra.ForeColor = System.Drawing.Color.White;
            this.IBRegistrarCompra.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.IBRegistrarCompra.IconColor = System.Drawing.Color.White;
            this.IBRegistrarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBRegistrarCompra.IconSize = 16;
            this.IBRegistrarCompra.Location = new System.Drawing.Point(893, 473);
            this.IBRegistrarCompra.Name = "IBRegistrarCompra";
            this.IBRegistrarCompra.Size = new System.Drawing.Size(107, 39);
            this.IBRegistrarCompra.TabIndex = 8;
            this.IBRegistrarCompra.Text = "Registrar";
            this.IBRegistrarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBRegistrarCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBRegistrarCompra.UseVisualStyleBackColor = false;
            this.IBRegistrarCompra.Click += new System.EventHandler(this.IBRegistrarCompra_Click);
            // 
            // IBAgregar
            // 
            this.IBAgregar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.IBAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBAgregar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.IBAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBAgregar.ForeColor = System.Drawing.Color.White;
            this.IBAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.IBAgregar.IconColor = System.Drawing.Color.White;
            this.IBAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBAgregar.IconSize = 16;
            this.IBAgregar.Location = new System.Drawing.Point(893, 161);
            this.IBAgregar.Name = "IBAgregar";
            this.IBAgregar.Size = new System.Drawing.Size(99, 54);
            this.IBAgregar.TabIndex = 8;
            this.IBAgregar.Text = "Agregar";
            this.IBAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBAgregar.UseVisualStyleBackColor = false;
            this.IBAgregar.Click += new System.EventHandler(this.IBAgregar_Click);
            // 
            // dataGridDatos
            // 
            this.dataGridDatos.AllowUserToAddRows = false;
            this.dataGridDatos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Producto,
            this.PrecioCompra,
            this.PrecioVenta,
            this.Cantidad,
            this.SubTotal,
            this.BEliminar});
            this.dataGridDatos.Location = new System.Drawing.Point(8, 231);
            this.dataGridDatos.MultiSelect = false;
            this.dataGridDatos.Name = "dataGridDatos";
            this.dataGridDatos.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridDatos.RowTemplate.Height = 28;
            this.dataGridDatos.Size = new System.Drawing.Size(857, 301);
            this.dataGridDatos.TabIndex = 7;
            this.dataGridDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDatos_CellContentClick);
            this.dataGridDatos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridDatos_CellPainting);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 220;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            this.PrecioCompra.Width = 180;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.Visible = false;
            this.PrecioVenta.Width = 180;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 150;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // BEliminar
            // 
            this.BEliminar.HeaderText = "";
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.ReadOnly = true;
            this.BEliminar.Width = 30;
            // 
            // GBInfoProducto
            // 
            this.GBInfoProducto.BackColor = System.Drawing.Color.Transparent;
            this.GBInfoProducto.Controls.Add(this.TxtCantidad);
            this.GBInfoProducto.Controls.Add(this.TxtIdProducto);
            this.GBInfoProducto.Controls.Add(this.IBBuscarProducto);
            this.GBInfoProducto.Controls.Add(this.LCantidad);
            this.GBInfoProducto.Controls.Add(this.LPrecioVenta);
            this.GBInfoProducto.Controls.Add(this.TxtPrecioVenta);
            this.GBInfoProducto.Controls.Add(this.LPrecioCompra);
            this.GBInfoProducto.Controls.Add(this.TxtPrecioCompra);
            this.GBInfoProducto.Controls.Add(this.LProducto);
            this.GBInfoProducto.Controls.Add(this.TxtProducto);
            this.GBInfoProducto.Controls.Add(this.TxtCodProducto);
            this.GBInfoProducto.Controls.Add(this.LCodProducto);
            this.GBInfoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBInfoProducto.ForeColor = System.Drawing.Color.White;
            this.GBInfoProducto.Location = new System.Drawing.Point(8, 142);
            this.GBInfoProducto.Name = "GBInfoProducto";
            this.GBInfoProducto.Size = new System.Drawing.Size(857, 80);
            this.GBInfoProducto.TabIndex = 6;
            this.GBInfoProducto.TabStop = false;
            this.GBInfoProducto.Text = "Información de Producto";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(752, 42);
            this.TxtCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(78, 20);
            this.TxtCantidad.TabIndex = 7;
            this.TxtCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TxtIdProducto
            // 
            this.TxtIdProducto.Location = new System.Drawing.Point(129, 19);
            this.TxtIdProducto.Name = "TxtIdProducto";
            this.TxtIdProducto.Size = new System.Drawing.Size(23, 20);
            this.TxtIdProducto.TabIndex = 5;
            this.TxtIdProducto.Visible = false;
            // 
            // IBBuscarProducto
            // 
            this.IBBuscarProducto.BackColor = System.Drawing.Color.LightGray;
            this.IBBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBBuscarProducto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.IBBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBBuscarProducto.ForeColor = System.Drawing.Color.Black;
            this.IBBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.IBBuscarProducto.IconColor = System.Drawing.Color.Black;
            this.IBBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBBuscarProducto.IconSize = 16;
            this.IBBuscarProducto.Location = new System.Drawing.Point(158, 41);
            this.IBBuscarProducto.Name = "IBBuscarProducto";
            this.IBBuscarProducto.Size = new System.Drawing.Size(35, 20);
            this.IBBuscarProducto.TabIndex = 5;
            this.IBBuscarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBBuscarProducto.UseVisualStyleBackColor = false;
            this.IBBuscarProducto.Click += new System.EventHandler(this.IBBuscarProducto_Click);
            // 
            // LCantidad
            // 
            this.LCantidad.AutoSize = true;
            this.LCantidad.Location = new System.Drawing.Point(749, 26);
            this.LCantidad.Name = "LCantidad";
            this.LCantidad.Size = new System.Drawing.Size(61, 13);
            this.LCantidad.TabIndex = 0;
            this.LCantidad.Text = "Cantidad:";
            // 
            // LPrecioVenta
            // 
            this.LPrecioVenta.AutoSize = true;
            this.LPrecioVenta.Location = new System.Drawing.Point(642, 26);
            this.LPrecioVenta.Name = "LPrecioVenta";
            this.LPrecioVenta.Size = new System.Drawing.Size(84, 13);
            this.LPrecioVenta.TabIndex = 0;
            this.LPrecioVenta.Text = "Precio Venta:";
            // 
            // TxtPrecioVenta
            // 
            this.TxtPrecioVenta.Location = new System.Drawing.Point(646, 42);
            this.TxtPrecioVenta.Name = "TxtPrecioVenta";
            this.TxtPrecioVenta.Size = new System.Drawing.Size(67, 20);
            this.TxtPrecioVenta.TabIndex = 4;
            this.TxtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecioVenta_KeyPress);
            // 
            // LPrecioCompra
            // 
            this.LPrecioCompra.AutoSize = true;
            this.LPrecioCompra.Location = new System.Drawing.Point(527, 26);
            this.LPrecioCompra.Name = "LPrecioCompra";
            this.LPrecioCompra.Size = new System.Drawing.Size(93, 13);
            this.LPrecioCompra.TabIndex = 0;
            this.LPrecioCompra.Text = "Precio Compra:";
            // 
            // TxtPrecioCompra
            // 
            this.TxtPrecioCompra.Location = new System.Drawing.Point(530, 42);
            this.TxtPrecioCompra.Name = "TxtPrecioCompra";
            this.TxtPrecioCompra.Size = new System.Drawing.Size(67, 20);
            this.TxtPrecioCompra.TabIndex = 4;
            this.TxtPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecioCompra_KeyPress);
            // 
            // LProducto
            // 
            this.LProducto.AutoSize = true;
            this.LProducto.Location = new System.Drawing.Point(218, 26);
            this.LProducto.Name = "LProducto";
            this.LProducto.Size = new System.Drawing.Size(62, 13);
            this.LProducto.TabIndex = 0;
            this.LProducto.Text = "Producto:";
            // 
            // TxtProducto
            // 
            this.TxtProducto.Location = new System.Drawing.Point(221, 41);
            this.TxtProducto.Name = "TxtProducto";
            this.TxtProducto.Size = new System.Drawing.Size(291, 20);
            this.TxtProducto.TabIndex = 4;
            // 
            // TxtCodProducto
            // 
            this.TxtCodProducto.Location = new System.Drawing.Point(9, 42);
            this.TxtCodProducto.Name = "TxtCodProducto";
            this.TxtCodProducto.Size = new System.Drawing.Size(143, 20);
            this.TxtCodProducto.TabIndex = 4;
            this.TxtCodProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCodProducto_KeyDown);
            // 
            // LCodProducto
            // 
            this.LCodProducto.AutoSize = true;
            this.LCodProducto.Location = new System.Drawing.Point(6, 26);
            this.LCodProducto.Name = "LCodProducto";
            this.LCodProducto.Size = new System.Drawing.Size(92, 13);
            this.LCodProducto.TabIndex = 0;
            this.LCodProducto.Text = "Cod. Producto:";
            // 
            // GBInfoProveedor
            // 
            this.GBInfoProveedor.BackColor = System.Drawing.Color.Transparent;
            this.GBInfoProveedor.Controls.Add(this.TxtIdProveedor);
            this.GBInfoProveedor.Controls.Add(this.IBBuscarProveedor);
            this.GBInfoProveedor.Controls.Add(this.LRazonSocial);
            this.GBInfoProveedor.Controls.Add(this.TxtRazonSocial);
            this.GBInfoProveedor.Controls.Add(this.TxtNroDocProveedor);
            this.GBInfoProveedor.Controls.Add(this.LNroDoc);
            this.GBInfoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBInfoProveedor.ForeColor = System.Drawing.Color.White;
            this.GBInfoProveedor.Location = new System.Drawing.Point(549, 38);
            this.GBInfoProveedor.Name = "GBInfoProveedor";
            this.GBInfoProveedor.Size = new System.Drawing.Size(451, 87);
            this.GBInfoProveedor.TabIndex = 4;
            this.GBInfoProveedor.TabStop = false;
            this.GBInfoProveedor.Text = "Información Proveedor";
            // 
            // TxtIdProveedor
            // 
            this.TxtIdProveedor.Location = new System.Drawing.Point(410, 19);
            this.TxtIdProveedor.Name = "TxtIdProveedor";
            this.TxtIdProveedor.Size = new System.Drawing.Size(23, 20);
            this.TxtIdProveedor.TabIndex = 5;
            this.TxtIdProveedor.Visible = false;
            // 
            // IBBuscarProveedor
            // 
            this.IBBuscarProveedor.BackColor = System.Drawing.Color.Gold;
            this.IBBuscarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBBuscarProveedor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.IBBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBBuscarProveedor.ForeColor = System.Drawing.Color.Black;
            this.IBBuscarProveedor.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.IBBuscarProveedor.IconColor = System.Drawing.Color.Black;
            this.IBBuscarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBBuscarProveedor.IconSize = 16;
            this.IBBuscarProveedor.Location = new System.Drawing.Point(158, 41);
            this.IBBuscarProveedor.Name = "IBBuscarProveedor";
            this.IBBuscarProveedor.Size = new System.Drawing.Size(35, 20);
            this.IBBuscarProveedor.TabIndex = 5;
            this.IBBuscarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBBuscarProveedor.UseVisualStyleBackColor = false;
            this.IBBuscarProveedor.Click += new System.EventHandler(this.IBBuscarProveedor_Click);
            // 
            // LRazonSocial
            // 
            this.LRazonSocial.AutoSize = true;
            this.LRazonSocial.Location = new System.Drawing.Point(243, 25);
            this.LRazonSocial.Name = "LRazonSocial";
            this.LRazonSocial.Size = new System.Drawing.Size(86, 13);
            this.LRazonSocial.TabIndex = 0;
            this.LRazonSocial.Text = "Razón Social:";
            // 
            // TxtRazonSocial
            // 
            this.TxtRazonSocial.Location = new System.Drawing.Point(246, 41);
            this.TxtRazonSocial.Name = "TxtRazonSocial";
            this.TxtRazonSocial.Size = new System.Drawing.Size(143, 20);
            this.TxtRazonSocial.TabIndex = 4;
            // 
            // TxtNroDocProveedor
            // 
            this.TxtNroDocProveedor.Location = new System.Drawing.Point(9, 42);
            this.TxtNroDocProveedor.Name = "TxtNroDocProveedor";
            this.TxtNroDocProveedor.Size = new System.Drawing.Size(143, 20);
            this.TxtNroDocProveedor.TabIndex = 4;
            // 
            // LNroDoc
            // 
            this.LNroDoc.AutoSize = true;
            this.LNroDoc.Location = new System.Drawing.Point(6, 26);
            this.LNroDoc.Name = "LNroDoc";
            this.LNroDoc.Size = new System.Drawing.Size(126, 13);
            this.LNroDoc.TabIndex = 0;
            this.LNroDoc.Text = "Número Documento: ";
            // 
            // GBInfoCompra
            // 
            this.GBInfoCompra.BackColor = System.Drawing.Color.Transparent;
            this.GBInfoCompra.Controls.Add(this.CBTipoDoc);
            this.GBInfoCompra.Controls.Add(this.TxtFecha);
            this.GBInfoCompra.Controls.Add(this.LTipoDoc);
            this.GBInfoCompra.Controls.Add(this.LFecha);
            this.GBInfoCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBInfoCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBInfoCompra.ForeColor = System.Drawing.Color.White;
            this.GBInfoCompra.Location = new System.Drawing.Point(8, 38);
            this.GBInfoCompra.Name = "GBInfoCompra";
            this.GBInfoCompra.Size = new System.Drawing.Size(484, 87);
            this.GBInfoCompra.TabIndex = 3;
            this.GBInfoCompra.TabStop = false;
            this.GBInfoCompra.Text = "Información de compra";
            // 
            // CBTipoDoc
            // 
            this.CBTipoDoc.FormattingEnabled = true;
            this.CBTipoDoc.Location = new System.Drawing.Point(184, 42);
            this.CBTipoDoc.Name = "CBTipoDoc";
            this.CBTipoDoc.Size = new System.Drawing.Size(198, 21);
            this.CBTipoDoc.TabIndex = 5;
            // 
            // TxtFecha
            // 
            this.TxtFecha.Location = new System.Drawing.Point(9, 42);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(117, 20);
            this.TxtFecha.TabIndex = 4;
            // 
            // LTipoDoc
            // 
            this.LTipoDoc.AutoSize = true;
            this.LTipoDoc.Location = new System.Drawing.Point(181, 26);
            this.LTipoDoc.Name = "LTipoDoc";
            this.LTipoDoc.Size = new System.Drawing.Size(102, 13);
            this.LTipoDoc.TabIndex = 0;
            this.LTipoDoc.Text = "Tipo documento:";
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.Location = new System.Drawing.Point(6, 26);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(46, 13);
            this.LFecha.TabIndex = 0;
            this.LFecha.Text = "Fecha:";
            // 
            // LRegistrarCompra
            // 
            this.LRegistrarCompra.AutoSize = true;
            this.LRegistrarCompra.BackColor = System.Drawing.Color.Transparent;
            this.LRegistrarCompra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRegistrarCompra.ForeColor = System.Drawing.Color.White;
            this.LRegistrarCompra.Location = new System.Drawing.Point(3, 10);
            this.LRegistrarCompra.Name = "LRegistrarCompra";
            this.LRegistrarCompra.Size = new System.Drawing.Size(186, 23);
            this.LRegistrarCompra.TabIndex = 2;
            this.LRegistrarCompra.Text = "Registrar Compra";
            // 
            // LTotalAPagar
            // 
            this.LTotalAPagar.AutoSize = true;
            this.LTotalAPagar.BackColor = System.Drawing.Color.Transparent;
            this.LTotalAPagar.ForeColor = System.Drawing.Color.White;
            this.LTotalAPagar.Location = new System.Drawing.Point(885, 431);
            this.LTotalAPagar.Name = "LTotalAPagar";
            this.LTotalAPagar.Size = new System.Drawing.Size(73, 13);
            this.LTotalAPagar.TabIndex = 0;
            this.LTotalAPagar.Text = "Total a pagar:";
            // 
            // TxtTotalAPagar
            // 
            this.TxtTotalAPagar.Location = new System.Drawing.Point(893, 447);
            this.TxtTotalAPagar.Name = "TxtTotalAPagar";
            this.TxtTotalAPagar.Size = new System.Drawing.Size(107, 20);
            this.TxtTotalAPagar.TabIndex = 4;
            this.TxtTotalAPagar.Text = "0";
            // 
            // FormCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 594);
            this.Controls.Add(this.panel1);
            this.Name = "FormCompras";
            this.Text = "FormCompras";
            this.Load += new System.EventHandler(this.FormCompras_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatos)).EndInit();
            this.GBInfoProducto.ResumeLayout(false);
            this.GBInfoProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidad)).EndInit();
            this.GBInfoProveedor.ResumeLayout(false);
            this.GBInfoProveedor.PerformLayout();
            this.GBInfoCompra.ResumeLayout(false);
            this.GBInfoCompra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox GBInfoCompra;
        private System.Windows.Forms.ComboBox CBTipoDoc;
        private System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.Label LTipoDoc;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.Label LRegistrarCompra;
        private System.Windows.Forms.GroupBox GBInfoProveedor;
        private System.Windows.Forms.Label LRazonSocial;
        private System.Windows.Forms.Label LNroDoc;
        private System.Windows.Forms.TextBox TxtRazonSocial;
        private System.Windows.Forms.TextBox TxtNroDocProveedor;
        private FontAwesome.Sharp.IconButton IBBuscarProveedor;
        private System.Windows.Forms.TextBox TxtIdProveedor;
        private System.Windows.Forms.GroupBox GBInfoProducto;
        private System.Windows.Forms.TextBox TxtIdProducto;
        private FontAwesome.Sharp.IconButton IBBuscarProducto;
        private System.Windows.Forms.Label LProducto;
        private System.Windows.Forms.TextBox TxtProducto;
        private System.Windows.Forms.TextBox TxtCodProducto;
        private System.Windows.Forms.Label LCodProducto;
        private System.Windows.Forms.Label LCantidad;
        private System.Windows.Forms.Label LPrecioVenta;
        private System.Windows.Forms.TextBox TxtPrecioVenta;
        private System.Windows.Forms.Label LPrecioCompra;
        private System.Windows.Forms.TextBox TxtPrecioCompra;
        private System.Windows.Forms.NumericUpDown TxtCantidad;
        private System.Windows.Forms.DataGridView dataGridDatos;
        private FontAwesome.Sharp.IconButton IBAgregar;
        private System.Windows.Forms.Label LTotalAPagar;
        private System.Windows.Forms.TextBox TxtTotalAPagar;
        private FontAwesome.Sharp.IconButton IBRegistrarCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn BEliminar;
    }
}