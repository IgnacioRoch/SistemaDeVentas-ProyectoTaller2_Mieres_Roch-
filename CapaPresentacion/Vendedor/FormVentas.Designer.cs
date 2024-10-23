namespace CapaPresentacion.Vendedor
{
    partial class FormVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelRegistrarVenta = new System.Windows.Forms.Panel();
            this.IBCrearVenta = new FontAwesome.Sharp.IconButton();
            this.IBAgregar = new FontAwesome.Sharp.IconButton();
            this.dataGridDatos = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.GBInfoProducto = new System.Windows.Forms.GroupBox();
            this.TxtCantidad = new System.Windows.Forms.NumericUpDown();
            this.TextIdProducto = new System.Windows.Forms.TextBox();
            this.IBBuscarProducto = new FontAwesome.Sharp.IconButton();
            this.LCantidad = new System.Windows.Forms.Label();
            this.LStock = new System.Windows.Forms.Label();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.lPrecio = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.LProducto = new System.Windows.Forms.Label();
            this.TxtProducto = new System.Windows.Forms.TextBox();
            this.TextCodProducto = new System.Windows.Forms.TextBox();
            this.LCodProducto = new System.Windows.Forms.Label();
            this.GBInfoCliente = new System.Windows.Forms.GroupBox();
            this.IBBuscarCliente = new FontAwesome.Sharp.IconButton();
            this.LApellidoCliente = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtNroDocCliente = new System.Windows.Forms.TextBox();
            this.LNroDocCliente = new System.Windows.Forms.Label();
            this.GBInfoVenta = new System.Windows.Forms.GroupBox();
            this.CBTipoDocVenta = new System.Windows.Forms.ComboBox();
            this.TxtFechaVenta = new System.Windows.Forms.TextBox();
            this.LTipoDocVenta = new System.Windows.Forms.Label();
            this.LFechaVenta = new System.Windows.Forms.Label();
            this.LRegistrarVenta = new System.Windows.Forms.Label();
            this.LCambio = new System.Windows.Forms.Label();
            this.LPagaCon = new System.Windows.Forms.Label();
            this.LTotalAPagar = new System.Windows.Forms.Label();
            this.TxtCambio = new System.Windows.Forms.TextBox();
            this.TxtPagacon = new System.Windows.Forms.TextBox();
            this.TxtTotalPagar = new System.Windows.Forms.TextBox();
            this.PanelRegistrarVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatos)).BeginInit();
            this.GBInfoProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidad)).BeginInit();
            this.GBInfoCliente.SuspendLayout();
            this.GBInfoVenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelRegistrarVenta
            // 
            this.PanelRegistrarVenta.BackColor = System.Drawing.Color.White;
            this.PanelRegistrarVenta.BackgroundImage = global::CapaPresentacion.Properties.Resources.PanelCompraVenta;
            this.PanelRegistrarVenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelRegistrarVenta.Controls.Add(this.IBCrearVenta);
            this.PanelRegistrarVenta.Controls.Add(this.IBAgregar);
            this.PanelRegistrarVenta.Controls.Add(this.dataGridDatos);
            this.PanelRegistrarVenta.Controls.Add(this.GBInfoProducto);
            this.PanelRegistrarVenta.Controls.Add(this.GBInfoCliente);
            this.PanelRegistrarVenta.Controls.Add(this.GBInfoVenta);
            this.PanelRegistrarVenta.Controls.Add(this.LRegistrarVenta);
            this.PanelRegistrarVenta.Controls.Add(this.LCambio);
            this.PanelRegistrarVenta.Controls.Add(this.LPagaCon);
            this.PanelRegistrarVenta.Controls.Add(this.LTotalAPagar);
            this.PanelRegistrarVenta.Controls.Add(this.TxtCambio);
            this.PanelRegistrarVenta.Controls.Add(this.TxtPagacon);
            this.PanelRegistrarVenta.Controls.Add(this.TxtTotalPagar);
            this.PanelRegistrarVenta.Location = new System.Drawing.Point(148, 15);
            this.PanelRegistrarVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelRegistrarVenta.Name = "PanelRegistrarVenta";
            this.PanelRegistrarVenta.Size = new System.Drawing.Size(1348, 672);
            this.PanelRegistrarVenta.TabIndex = 5;
            // 
            // IBCrearVenta
            // 
            this.IBCrearVenta.BackColor = System.Drawing.Color.RoyalBlue;
            this.IBCrearVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBCrearVenta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.IBCrearVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBCrearVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBCrearVenta.ForeColor = System.Drawing.Color.White;
            this.IBCrearVenta.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.IBCrearVenta.IconColor = System.Drawing.Color.White;
            this.IBCrearVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBCrearVenta.IconSize = 16;
            this.IBCrearVenta.Location = new System.Drawing.Point(1161, 581);
            this.IBCrearVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IBCrearVenta.Name = "IBCrearVenta";
            this.IBCrearVenta.Size = new System.Drawing.Size(172, 55);
            this.IBCrearVenta.TabIndex = 8;
            this.IBCrearVenta.Text = "Crear venta";
            this.IBCrearVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBCrearVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBCrearVenta.UseVisualStyleBackColor = false;
            this.IBCrearVenta.Click += new System.EventHandler(this.IBCrearVenta_Click);
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
            this.IBAgregar.Location = new System.Drawing.Point(1191, 198);
            this.IBAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IBAgregar.Name = "IBAgregar";
            this.IBAgregar.Size = new System.Drawing.Size(132, 66);
            this.IBAgregar.TabIndex = 8;
            this.IBAgregar.Text = "Agregar";
            this.IBAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBAgregar.UseVisualStyleBackColor = false;
            this.IBAgregar.Click += new System.EventHandler(this.IBAgregar_Click_1);
            // 
            // dataGridDatos
            // 
            this.dataGridDatos.AllowUserToAddRows = false;
            this.dataGridDatos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.SubTotal,
            this.BEliminar});
            this.dataGridDatos.Location = new System.Drawing.Point(11, 284);
            this.dataGridDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridDatos.MultiSelect = false;
            this.dataGridDatos.Name = "dataGridDatos";
            this.dataGridDatos.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridDatos.RowHeadersWidth = 51;
            this.dataGridDatos.RowTemplate.Height = 28;
            this.dataGridDatos.Size = new System.Drawing.Size(1143, 370);
            this.dataGridDatos.TabIndex = 7;
            this.dataGridDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDatos_CellContentClick);
            this.dataGridDatos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridDatos_CellPainting);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.MinimumWidth = 6;
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
            this.IdProducto.Width = 125;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 220;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 180;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 150;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 125;
            // 
            // BEliminar
            // 
            this.BEliminar.HeaderText = "";
            this.BEliminar.MinimumWidth = 6;
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.ReadOnly = true;
            this.BEliminar.Width = 30;
            // 
            // GBInfoProducto
            // 
            this.GBInfoProducto.BackColor = System.Drawing.Color.Transparent;
            this.GBInfoProducto.Controls.Add(this.TxtCantidad);
            this.GBInfoProducto.Controls.Add(this.TextIdProducto);
            this.GBInfoProducto.Controls.Add(this.IBBuscarProducto);
            this.GBInfoProducto.Controls.Add(this.LCantidad);
            this.GBInfoProducto.Controls.Add(this.LStock);
            this.GBInfoProducto.Controls.Add(this.TxtStock);
            this.GBInfoProducto.Controls.Add(this.lPrecio);
            this.GBInfoProducto.Controls.Add(this.TxtPrecio);
            this.GBInfoProducto.Controls.Add(this.LProducto);
            this.GBInfoProducto.Controls.Add(this.TxtProducto);
            this.GBInfoProducto.Controls.Add(this.TextCodProducto);
            this.GBInfoProducto.Controls.Add(this.LCodProducto);
            this.GBInfoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBInfoProducto.ForeColor = System.Drawing.Color.White;
            this.GBInfoProducto.Location = new System.Drawing.Point(11, 175);
            this.GBInfoProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GBInfoProducto.Name = "GBInfoProducto";
            this.GBInfoProducto.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GBInfoProducto.Size = new System.Drawing.Size(1143, 98);
            this.GBInfoProducto.TabIndex = 6;
            this.GBInfoProducto.TabStop = false;
            this.GBInfoProducto.Text = "Información de Producto";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(1004, 52);
            this.TxtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(104, 23);
            this.TxtCantidad.TabIndex = 7;
            this.TxtCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TextIdProducto
            // 
            this.TextIdProducto.Location = new System.Drawing.Point(172, 23);
            this.TextIdProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextIdProducto.Name = "TextIdProducto";
            this.TextIdProducto.Size = new System.Drawing.Size(29, 23);
            this.TextIdProducto.TabIndex = 5;
            this.TextIdProducto.Text = "0";
            this.TextIdProducto.Visible = false;
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
            this.IBBuscarProducto.Location = new System.Drawing.Point(211, 50);
            this.IBBuscarProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IBBuscarProducto.Name = "IBBuscarProducto";
            this.IBBuscarProducto.Size = new System.Drawing.Size(47, 25);
            this.IBBuscarProducto.TabIndex = 5;
            this.IBBuscarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBBuscarProducto.UseVisualStyleBackColor = false;
            this.IBBuscarProducto.Click += new System.EventHandler(this.IBBuscarProducto_Click);
            // 
            // LCantidad
            // 
            this.LCantidad.AutoSize = true;
            this.LCantidad.Location = new System.Drawing.Point(999, 32);
            this.LCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LCantidad.Name = "LCantidad";
            this.LCantidad.Size = new System.Drawing.Size(77, 17);
            this.LCantidad.TabIndex = 0;
            this.LCantidad.Text = "Cantidad:";
            // 
            // LStock
            // 
            this.LStock.AutoSize = true;
            this.LStock.Location = new System.Drawing.Point(856, 32);
            this.LStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LStock.Name = "LStock";
            this.LStock.Size = new System.Drawing.Size(53, 17);
            this.LStock.TabIndex = 0;
            this.LStock.Text = "Stock:";
            // 
            // TxtStock
            // 
            this.TxtStock.Location = new System.Drawing.Point(861, 52);
            this.TxtStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(88, 23);
            this.TxtStock.TabIndex = 4;
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Location = new System.Drawing.Point(703, 32);
            this.lPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(59, 17);
            this.lPrecio.TabIndex = 0;
            this.lPrecio.Text = "Precio:";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(707, 52);
            this.TxtPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(88, 23);
            this.TxtPrecio.TabIndex = 4;
            this.TxtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecio_KeyPress);
            // 
            // LProducto
            // 
            this.LProducto.AutoSize = true;
            this.LProducto.Location = new System.Drawing.Point(291, 32);
            this.LProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LProducto.Name = "LProducto";
            this.LProducto.Size = new System.Drawing.Size(78, 17);
            this.LProducto.TabIndex = 0;
            this.LProducto.Text = "Producto:";
            // 
            // TxtProducto
            // 
            this.TxtProducto.Location = new System.Drawing.Point(295, 50);
            this.TxtProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtProducto.Name = "TxtProducto";
            this.TxtProducto.Size = new System.Drawing.Size(387, 23);
            this.TxtProducto.TabIndex = 4;
            // 
            // TextCodProducto
            // 
            this.TextCodProducto.Location = new System.Drawing.Point(12, 52);
            this.TextCodProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextCodProducto.Name = "TextCodProducto";
            this.TextCodProducto.Size = new System.Drawing.Size(189, 23);
            this.TextCodProducto.TabIndex = 4;
            this.TextCodProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextCodProducto_KeyDown);
            // 
            // LCodProducto
            // 
            this.LCodProducto.AutoSize = true;
            this.LCodProducto.Location = new System.Drawing.Point(8, 32);
            this.LCodProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LCodProducto.Name = "LCodProducto";
            this.LCodProducto.Size = new System.Drawing.Size(116, 17);
            this.LCodProducto.TabIndex = 0;
            this.LCodProducto.Text = "Cod. Producto:";
            // 
            // GBInfoCliente
            // 
            this.GBInfoCliente.BackColor = System.Drawing.Color.Transparent;
            this.GBInfoCliente.Controls.Add(this.IBBuscarCliente);
            this.GBInfoCliente.Controls.Add(this.LApellidoCliente);
            this.GBInfoCliente.Controls.Add(this.TxtApellido);
            this.GBInfoCliente.Controls.Add(this.TxtNroDocCliente);
            this.GBInfoCliente.Controls.Add(this.LNroDocCliente);
            this.GBInfoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBInfoCliente.ForeColor = System.Drawing.Color.White;
            this.GBInfoCliente.Location = new System.Drawing.Point(732, 47);
            this.GBInfoCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GBInfoCliente.Name = "GBInfoCliente";
            this.GBInfoCliente.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GBInfoCliente.Size = new System.Drawing.Size(601, 107);
            this.GBInfoCliente.TabIndex = 4;
            this.GBInfoCliente.TabStop = false;
            this.GBInfoCliente.Text = "Información Cliente";
            // 
            // IBBuscarCliente
            // 
            this.IBBuscarCliente.BackColor = System.Drawing.Color.Gainsboro;
            this.IBBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBBuscarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.IBBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBBuscarCliente.ForeColor = System.Drawing.Color.Black;
            this.IBBuscarCliente.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.IBBuscarCliente.IconColor = System.Drawing.Color.Black;
            this.IBBuscarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBBuscarCliente.IconSize = 16;
            this.IBBuscarCliente.Location = new System.Drawing.Point(211, 50);
            this.IBBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IBBuscarCliente.Name = "IBBuscarCliente";
            this.IBBuscarCliente.Size = new System.Drawing.Size(47, 25);
            this.IBBuscarCliente.TabIndex = 5;
            this.IBBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBBuscarCliente.UseVisualStyleBackColor = false;
            this.IBBuscarCliente.Click += new System.EventHandler(this.IBBuscarCliente_Click);
            // 
            // LApellidoCliente
            // 
            this.LApellidoCliente.AutoSize = true;
            this.LApellidoCliente.Location = new System.Drawing.Point(324, 31);
            this.LApellidoCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LApellidoCliente.Name = "LApellidoCliente";
            this.LApellidoCliente.Size = new System.Drawing.Size(124, 17);
            this.LApellidoCliente.TabIndex = 0;
            this.LApellidoCliente.Text = "Apellido cliente:";
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(328, 50);
            this.TxtApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(189, 23);
            this.TxtApellido.TabIndex = 4;
            // 
            // TxtNroDocCliente
            // 
            this.TxtNroDocCliente.Location = new System.Drawing.Point(12, 52);
            this.TxtNroDocCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtNroDocCliente.Name = "TxtNroDocCliente";
            this.TxtNroDocCliente.Size = new System.Drawing.Size(189, 23);
            this.TxtNroDocCliente.TabIndex = 4;
            // 
            // LNroDocCliente
            // 
            this.LNroDocCliente.AutoSize = true;
            this.LNroDocCliente.Location = new System.Drawing.Point(8, 31);
            this.LNroDocCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNroDocCliente.Name = "LNroDocCliente";
            this.LNroDocCliente.Size = new System.Drawing.Size(160, 17);
            this.LNroDocCliente.TabIndex = 0;
            this.LNroDocCliente.Text = "Número Documento: ";
            // 
            // GBInfoVenta
            // 
            this.GBInfoVenta.BackColor = System.Drawing.Color.Transparent;
            this.GBInfoVenta.Controls.Add(this.CBTipoDocVenta);
            this.GBInfoVenta.Controls.Add(this.TxtFechaVenta);
            this.GBInfoVenta.Controls.Add(this.LTipoDocVenta);
            this.GBInfoVenta.Controls.Add(this.LFechaVenta);
            this.GBInfoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBInfoVenta.ForeColor = System.Drawing.Color.White;
            this.GBInfoVenta.Location = new System.Drawing.Point(11, 47);
            this.GBInfoVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GBInfoVenta.Name = "GBInfoVenta";
            this.GBInfoVenta.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GBInfoVenta.Size = new System.Drawing.Size(645, 107);
            this.GBInfoVenta.TabIndex = 3;
            this.GBInfoVenta.TabStop = false;
            this.GBInfoVenta.Text = "Información de venta";
            // 
            // CBTipoDocVenta
            // 
            this.CBTipoDocVenta.FormattingEnabled = true;
            this.CBTipoDocVenta.Location = new System.Drawing.Point(245, 52);
            this.CBTipoDocVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBTipoDocVenta.Name = "CBTipoDocVenta";
            this.CBTipoDocVenta.Size = new System.Drawing.Size(263, 25);
            this.CBTipoDocVenta.TabIndex = 5;
            // 
            // TxtFechaVenta
            // 
            this.TxtFechaVenta.Location = new System.Drawing.Point(12, 52);
            this.TxtFechaVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtFechaVenta.Name = "TxtFechaVenta";
            this.TxtFechaVenta.Size = new System.Drawing.Size(155, 23);
            this.TxtFechaVenta.TabIndex = 4;
            // 
            // LTipoDocVenta
            // 
            this.LTipoDocVenta.AutoSize = true;
            this.LTipoDocVenta.Location = new System.Drawing.Point(241, 32);
            this.LTipoDocVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTipoDocVenta.Name = "LTipoDocVenta";
            this.LTipoDocVenta.Size = new System.Drawing.Size(129, 17);
            this.LTipoDocVenta.TabIndex = 0;
            this.LTipoDocVenta.Text = "Tipo documento:";
            // 
            // LFechaVenta
            // 
            this.LFechaVenta.AutoSize = true;
            this.LFechaVenta.Location = new System.Drawing.Point(8, 32);
            this.LFechaVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LFechaVenta.Name = "LFechaVenta";
            this.LFechaVenta.Size = new System.Drawing.Size(57, 17);
            this.LFechaVenta.TabIndex = 0;
            this.LFechaVenta.Text = "Fecha:";
            // 
            // LRegistrarVenta
            // 
            this.LRegistrarVenta.AutoSize = true;
            this.LRegistrarVenta.BackColor = System.Drawing.Color.Transparent;
            this.LRegistrarVenta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRegistrarVenta.ForeColor = System.Drawing.Color.White;
            this.LRegistrarVenta.Location = new System.Drawing.Point(4, 12);
            this.LRegistrarVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LRegistrarVenta.Name = "LRegistrarVenta";
            this.LRegistrarVenta.Size = new System.Drawing.Size(206, 29);
            this.LRegistrarVenta.TabIndex = 2;
            this.LRegistrarVenta.Text = "Registrar Venta";
            // 
            // LCambio
            // 
            this.LCambio.AutoSize = true;
            this.LCambio.BackColor = System.Drawing.Color.Transparent;
            this.LCambio.ForeColor = System.Drawing.Color.White;
            this.LCambio.Location = new System.Drawing.Point(1187, 507);
            this.LCambio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LCambio.Name = "LCambio";
            this.LCambio.Size = new System.Drawing.Size(57, 16);
            this.LCambio.TabIndex = 0;
            this.LCambio.Text = "Cambio:";
            // 
            // LPagaCon
            // 
            this.LPagaCon.AutoSize = true;
            this.LPagaCon.BackColor = System.Drawing.Color.Transparent;
            this.LPagaCon.ForeColor = System.Drawing.Color.White;
            this.LPagaCon.Location = new System.Drawing.Point(1187, 444);
            this.LPagaCon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LPagaCon.Name = "LPagaCon";
            this.LPagaCon.Size = new System.Drawing.Size(68, 16);
            this.LPagaCon.TabIndex = 0;
            this.LPagaCon.Text = "Paga con:";
            // 
            // LTotalAPagar
            // 
            this.LTotalAPagar.AutoSize = true;
            this.LTotalAPagar.BackColor = System.Drawing.Color.Transparent;
            this.LTotalAPagar.ForeColor = System.Drawing.Color.White;
            this.LTotalAPagar.Location = new System.Drawing.Point(1180, 348);
            this.LTotalAPagar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTotalAPagar.Name = "LTotalAPagar";
            this.LTotalAPagar.Size = new System.Drawing.Size(91, 16);
            this.LTotalAPagar.TabIndex = 0;
            this.LTotalAPagar.Text = "Total a pagar:";
            // 
            // TxtCambio
            // 
            this.TxtCambio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtCambio.Location = new System.Drawing.Point(1191, 527);
            this.TxtCambio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtCambio.Name = "TxtCambio";
            this.TxtCambio.Size = new System.Drawing.Size(141, 22);
            this.TxtCambio.TabIndex = 4;
            // 
            // TxtPagacon
            // 
            this.TxtPagacon.Location = new System.Drawing.Point(1191, 464);
            this.TxtPagacon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtPagacon.Name = "TxtPagacon";
            this.TxtPagacon.Size = new System.Drawing.Size(141, 22);
            this.TxtPagacon.TabIndex = 4;
            this.TxtPagacon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPagacon_KeyDown);
            this.TxtPagacon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPagacon_KeyPress);
            // 
            // TxtTotalPagar
            // 
            this.TxtTotalPagar.Location = new System.Drawing.Point(1191, 368);
            this.TxtTotalPagar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtTotalPagar.Name = "TxtTotalPagar";
            this.TxtTotalPagar.Size = new System.Drawing.Size(141, 22);
            this.TxtTotalPagar.TabIndex = 4;
            this.TxtTotalPagar.Text = "0";
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1575, 778);
            this.Controls.Add(this.PanelRegistrarVenta);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormVentas";
            this.Text = "FormVentas";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            this.PanelRegistrarVenta.ResumeLayout(false);
            this.PanelRegistrarVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatos)).EndInit();
            this.GBInfoProducto.ResumeLayout(false);
            this.GBInfoProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidad)).EndInit();
            this.GBInfoCliente.ResumeLayout(false);
            this.GBInfoCliente.PerformLayout();
            this.GBInfoVenta.ResumeLayout(false);
            this.GBInfoVenta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBInfoCliente;
        private FontAwesome.Sharp.IconButton IBBuscarCliente;
        private System.Windows.Forms.Label LApellidoCliente;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtNroDocCliente;
        private System.Windows.Forms.Label LNroDocCliente;
        private System.Windows.Forms.NumericUpDown TxtCantidad;
        private System.Windows.Forms.TextBox TextIdProducto;
        private FontAwesome.Sharp.IconButton IBBuscarProducto;
        private System.Windows.Forms.Label LCantidad;
        private System.Windows.Forms.TextBox TxtStock;
        private System.Windows.Forms.Label lPrecio;
        private System.Windows.Forms.GroupBox GBInfoVenta;
        private System.Windows.Forms.ComboBox CBTipoDocVenta;
        private System.Windows.Forms.TextBox TxtFechaVenta;
        private System.Windows.Forms.Label LTipoDocVenta;
        private System.Windows.Forms.Label LFechaVenta;
        private System.Windows.Forms.Label LRegistrarVenta;
        private System.Windows.Forms.TextBox TxtTotalPagar;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Panel PanelRegistrarVenta;
        private FontAwesome.Sharp.IconButton IBCrearVenta;
        private FontAwesome.Sharp.IconButton IBAgregar;
        private System.Windows.Forms.DataGridView dataGridDatos;
        private System.Windows.Forms.GroupBox GBInfoProducto;
        private System.Windows.Forms.Label LProducto;
        private System.Windows.Forms.TextBox TxtProducto;
        private System.Windows.Forms.TextBox TextCodProducto;
        private System.Windows.Forms.Label LCodProducto;
        private System.Windows.Forms.Label LTotalAPagar;
        private System.Windows.Forms.Label LStock;
        private System.Windows.Forms.Label LCambio;
        private System.Windows.Forms.Label LPagaCon;
        private System.Windows.Forms.TextBox TxtCambio;
        private System.Windows.Forms.TextBox TxtPagacon;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn BEliminar;
    }
}