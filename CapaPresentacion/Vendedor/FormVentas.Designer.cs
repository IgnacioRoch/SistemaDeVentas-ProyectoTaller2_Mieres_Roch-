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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GBInfoCliente = new System.Windows.Forms.GroupBox();
            this.IBBuscarProveedor = new FontAwesome.Sharp.IconButton();
            this.LApellidoCliente = new System.Windows.Forms.Label();
            this.TxtRazonSocial = new System.Windows.Forms.TextBox();
            this.TxtNroDocCliente = new System.Windows.Forms.TextBox();
            this.LNroDocCliente = new System.Windows.Forms.Label();
            this.NUpDCantidad = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LCantidad = new System.Windows.Forms.Label();
            this.TxtPrecioVenta = new System.Windows.Forms.TextBox();
            this.LPrecio = new System.Windows.Forms.Label();
            this.GBInfoVenta = new System.Windows.Forms.GroupBox();
            this.CBTipoDocVenta = new System.Windows.Forms.ComboBox();
            this.TxtFechaVenta = new System.Windows.Forms.TextBox();
            this.LTipoDocVenta = new System.Windows.Forms.Label();
            this.LFechaVenta = new System.Windows.Forms.Label();
            this.LRegistrarVenta = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.TxtPrecioCompra = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.IBBuscarProducto = new FontAwesome.Sharp.IconButton();
            this.LStock = new System.Windows.Forms.Label();
            this.LProducto = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.LCodProducto = new System.Windows.Forms.Label();
            this.LCambio = new System.Windows.Forms.Label();
            this.LPagaCon = new System.Windows.Forms.Label();
            this.LTotalAPagar = new System.Windows.Forms.Label();
            this.TxtCambio = new System.Windows.Forms.TextBox();
            this.TxtPagacon = new System.Windows.Forms.TextBox();
            this.GBInfoCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUpDCantidad)).BeginInit();
            this.GBInfoVenta.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatos)).BeginInit();
            this.GBInfoProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBInfoCliente
            // 
            this.GBInfoCliente.Controls.Add(this.IBBuscarProveedor);
            this.GBInfoCliente.Controls.Add(this.LApellidoCliente);
            this.GBInfoCliente.Controls.Add(this.TxtRazonSocial);
            this.GBInfoCliente.Controls.Add(this.TxtNroDocCliente);
            this.GBInfoCliente.Controls.Add(this.LNroDocCliente);
            this.GBInfoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBInfoCliente.Location = new System.Drawing.Point(549, 38);
            this.GBInfoCliente.Name = "GBInfoCliente";
            this.GBInfoCliente.Size = new System.Drawing.Size(451, 87);
            this.GBInfoCliente.TabIndex = 4;
            this.GBInfoCliente.TabStop = false;
            this.GBInfoCliente.Text = "Información Cliente";
            // 
            // IBBuscarProveedor
            // 
            this.IBBuscarProveedor.BackColor = System.Drawing.Color.Gainsboro;
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
            // 
            // LApellidoCliente
            // 
            this.LApellidoCliente.AutoSize = true;
            this.LApellidoCliente.Location = new System.Drawing.Point(243, 25);
            this.LApellidoCliente.Name = "LApellidoCliente";
            this.LApellidoCliente.Size = new System.Drawing.Size(98, 13);
            this.LApellidoCliente.TabIndex = 0;
            this.LApellidoCliente.Text = "Apellido cliente:";
            // 
            // TxtRazonSocial
            // 
            this.TxtRazonSocial.Location = new System.Drawing.Point(246, 41);
            this.TxtRazonSocial.Name = "TxtRazonSocial";
            this.TxtRazonSocial.Size = new System.Drawing.Size(143, 20);
            this.TxtRazonSocial.TabIndex = 4;
            // 
            // TxtNroDocCliente
            // 
            this.TxtNroDocCliente.Location = new System.Drawing.Point(9, 42);
            this.TxtNroDocCliente.Name = "TxtNroDocCliente";
            this.TxtNroDocCliente.Size = new System.Drawing.Size(143, 20);
            this.TxtNroDocCliente.TabIndex = 4;
            // 
            // LNroDocCliente
            // 
            this.LNroDocCliente.AutoSize = true;
            this.LNroDocCliente.Location = new System.Drawing.Point(6, 25);
            this.LNroDocCliente.Name = "LNroDocCliente";
            this.LNroDocCliente.Size = new System.Drawing.Size(126, 13);
            this.LNroDocCliente.TabIndex = 0;
            this.LNroDocCliente.Text = "Número Documento: ";
            // 
            // NUpDCantidad
            // 
            this.NUpDCantidad.Location = new System.Drawing.Point(752, 42);
            this.NUpDCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUpDCantidad.Name = "NUpDCantidad";
            this.NUpDCantidad.Size = new System.Drawing.Size(78, 20);
            this.NUpDCantidad.TabIndex = 7;
            this.NUpDCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(23, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "0";
            this.textBox1.Visible = false;
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
            // TxtPrecioVenta
            // 
            this.TxtPrecioVenta.Location = new System.Drawing.Point(646, 42);
            this.TxtPrecioVenta.Name = "TxtPrecioVenta";
            this.TxtPrecioVenta.Size = new System.Drawing.Size(67, 20);
            this.TxtPrecioVenta.TabIndex = 4;
            // 
            // LPrecio
            // 
            this.LPrecio.AutoSize = true;
            this.LPrecio.Location = new System.Drawing.Point(527, 26);
            this.LPrecio.Name = "LPrecio";
            this.LPrecio.Size = new System.Drawing.Size(47, 13);
            this.LPrecio.TabIndex = 0;
            this.LPrecio.Text = "Precio:";
            // 
            // GBInfoVenta
            // 
            this.GBInfoVenta.Controls.Add(this.CBTipoDocVenta);
            this.GBInfoVenta.Controls.Add(this.TxtFechaVenta);
            this.GBInfoVenta.Controls.Add(this.LTipoDocVenta);
            this.GBInfoVenta.Controls.Add(this.LFechaVenta);
            this.GBInfoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBInfoVenta.Location = new System.Drawing.Point(8, 38);
            this.GBInfoVenta.Name = "GBInfoVenta";
            this.GBInfoVenta.Size = new System.Drawing.Size(484, 87);
            this.GBInfoVenta.TabIndex = 3;
            this.GBInfoVenta.TabStop = false;
            this.GBInfoVenta.Text = "Información de venta";
            // 
            // CBTipoDocVenta
            // 
            this.CBTipoDocVenta.FormattingEnabled = true;
            this.CBTipoDocVenta.Location = new System.Drawing.Point(184, 42);
            this.CBTipoDocVenta.Name = "CBTipoDocVenta";
            this.CBTipoDocVenta.Size = new System.Drawing.Size(198, 21);
            this.CBTipoDocVenta.TabIndex = 5;
            // 
            // TxtFechaVenta
            // 
            this.TxtFechaVenta.Location = new System.Drawing.Point(9, 42);
            this.TxtFechaVenta.Name = "TxtFechaVenta";
            this.TxtFechaVenta.Size = new System.Drawing.Size(117, 20);
            this.TxtFechaVenta.TabIndex = 4;
            // 
            // LTipoDocVenta
            // 
            this.LTipoDocVenta.AutoSize = true;
            this.LTipoDocVenta.Location = new System.Drawing.Point(181, 26);
            this.LTipoDocVenta.Name = "LTipoDocVenta";
            this.LTipoDocVenta.Size = new System.Drawing.Size(102, 13);
            this.LTipoDocVenta.TabIndex = 0;
            this.LTipoDocVenta.Text = "Tipo documento:";
            // 
            // LFechaVenta
            // 
            this.LFechaVenta.AutoSize = true;
            this.LFechaVenta.Location = new System.Drawing.Point(6, 26);
            this.LFechaVenta.Name = "LFechaVenta";
            this.LFechaVenta.Size = new System.Drawing.Size(46, 13);
            this.LFechaVenta.TabIndex = 0;
            this.LFechaVenta.Text = "Fecha:";
            // 
            // LRegistrarVenta
            // 
            this.LRegistrarVenta.AutoSize = true;
            this.LRegistrarVenta.BackColor = System.Drawing.Color.White;
            this.LRegistrarVenta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRegistrarVenta.Location = new System.Drawing.Point(3, 10);
            this.LRegistrarVenta.Name = "LRegistrarVenta";
            this.LRegistrarVenta.Size = new System.Drawing.Size(164, 23);
            this.LRegistrarVenta.TabIndex = 2;
            this.LRegistrarVenta.Text = "Registrar Venta";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(893, 299);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(107, 20);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "0";
            // 
            // TxtPrecioCompra
            // 
            this.TxtPrecioCompra.Location = new System.Drawing.Point(530, 42);
            this.TxtPrecioCompra.Name = "TxtPrecioCompra";
            this.TxtPrecioCompra.Size = new System.Drawing.Size(67, 20);
            this.TxtPrecioCompra.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.IBCrearVenta);
            this.panel1.Controls.Add(this.IBAgregar);
            this.panel1.Controls.Add(this.dataGridDatos);
            this.panel1.Controls.Add(this.GBInfoProducto);
            this.panel1.Controls.Add(this.GBInfoCliente);
            this.panel1.Controls.Add(this.GBInfoVenta);
            this.panel1.Controls.Add(this.LRegistrarVenta);
            this.panel1.Controls.Add(this.LCambio);
            this.panel1.Controls.Add(this.LPagaCon);
            this.panel1.Controls.Add(this.LTotalAPagar);
            this.panel1.Controls.Add(this.TxtCambio);
            this.panel1.Controls.Add(this.TxtPagacon);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Location = new System.Drawing.Point(111, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 535);
            this.panel1.TabIndex = 5;
            // 
            // IBCrearVenta
            // 
            this.IBCrearVenta.BackColor = System.Drawing.Color.RoyalBlue;
            this.IBCrearVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBCrearVenta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.IBCrearVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBCrearVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBCrearVenta.ForeColor = System.Drawing.Color.White;
            this.IBCrearVenta.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.IBCrearVenta.IconColor = System.Drawing.Color.White;
            this.IBCrearVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBCrearVenta.IconSize = 16;
            this.IBCrearVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBCrearVenta.Location = new System.Drawing.Point(879, 471);
            this.IBCrearVenta.Name = "IBCrearVenta";
            this.IBCrearVenta.Size = new System.Drawing.Size(121, 45);
            this.IBCrearVenta.TabIndex = 8;
            this.IBCrearVenta.Text = "Crear venta";
            this.IBCrearVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBCrearVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBCrearVenta.UseVisualStyleBackColor = false;
            // 
            // IBAgregar
            // 
            this.IBAgregar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.IBAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBAgregar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.IBAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // 
            // dataGridDatos
            // 
            this.dataGridDatos.AllowUserToAddRows = false;
            this.dataGridDatos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.SubTotal,
            this.BEliminar});
            this.dataGridDatos.Location = new System.Drawing.Point(8, 231);
            this.dataGridDatos.MultiSelect = false;
            this.dataGridDatos.Name = "dataGridDatos";
            this.dataGridDatos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridDatos.RowTemplate.Height = 28;
            this.dataGridDatos.Size = new System.Drawing.Size(857, 301);
            this.dataGridDatos.TabIndex = 7;
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
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 180;
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
            this.GBInfoProducto.Controls.Add(this.NUpDCantidad);
            this.GBInfoProducto.Controls.Add(this.textBox1);
            this.GBInfoProducto.Controls.Add(this.IBBuscarProducto);
            this.GBInfoProducto.Controls.Add(this.LCantidad);
            this.GBInfoProducto.Controls.Add(this.LStock);
            this.GBInfoProducto.Controls.Add(this.TxtPrecioVenta);
            this.GBInfoProducto.Controls.Add(this.LPrecio);
            this.GBInfoProducto.Controls.Add(this.TxtPrecioCompra);
            this.GBInfoProducto.Controls.Add(this.LProducto);
            this.GBInfoProducto.Controls.Add(this.textBox2);
            this.GBInfoProducto.Controls.Add(this.textBox3);
            this.GBInfoProducto.Controls.Add(this.LCodProducto);
            this.GBInfoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBInfoProducto.Location = new System.Drawing.Point(8, 142);
            this.GBInfoProducto.Name = "GBInfoProducto";
            this.GBInfoProducto.Size = new System.Drawing.Size(857, 80);
            this.GBInfoProducto.TabIndex = 6;
            this.GBInfoProducto.TabStop = false;
            this.GBInfoProducto.Text = "Información de Producto";
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
            // 
            // LStock
            // 
            this.LStock.AutoSize = true;
            this.LStock.Location = new System.Drawing.Point(642, 26);
            this.LStock.Name = "LStock";
            this.LStock.Size = new System.Drawing.Size(44, 13);
            this.LStock.TabIndex = 0;
            this.LStock.Text = "Stock:";
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(221, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(291, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(9, 42);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(143, 20);
            this.textBox3.TabIndex = 4;
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
            // LCambio
            // 
            this.LCambio.AutoSize = true;
            this.LCambio.Location = new System.Drawing.Point(890, 412);
            this.LCambio.Name = "LCambio";
            this.LCambio.Size = new System.Drawing.Size(45, 13);
            this.LCambio.TabIndex = 0;
            this.LCambio.Text = "Cambio:";
            // 
            // LPagaCon
            // 
            this.LPagaCon.AutoSize = true;
            this.LPagaCon.Location = new System.Drawing.Point(890, 361);
            this.LPagaCon.Name = "LPagaCon";
            this.LPagaCon.Size = new System.Drawing.Size(56, 13);
            this.LPagaCon.TabIndex = 0;
            this.LPagaCon.Text = "Paga con:";
            // 
            // LTotalAPagar
            // 
            this.LTotalAPagar.AutoSize = true;
            this.LTotalAPagar.Location = new System.Drawing.Point(885, 283);
            this.LTotalAPagar.Name = "LTotalAPagar";
            this.LTotalAPagar.Size = new System.Drawing.Size(73, 13);
            this.LTotalAPagar.TabIndex = 0;
            this.LTotalAPagar.Text = "Total a pagar:";
            // 
            // TxtCambio
            // 
            this.TxtCambio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtCambio.Location = new System.Drawing.Point(893, 428);
            this.TxtCambio.Name = "TxtCambio";
            this.TxtCambio.Size = new System.Drawing.Size(107, 20);
            this.TxtCambio.TabIndex = 4;
            // 
            // TxtPagacon
            // 
            this.TxtPagacon.Location = new System.Drawing.Point(893, 377);
            this.TxtPagacon.Name = "TxtPagacon";
            this.TxtPagacon.Size = new System.Drawing.Size(107, 20);
            this.TxtPagacon.TabIndex = 4;
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 632);
            this.Controls.Add(this.panel1);
            this.Name = "FormVentas";
            this.Text = "FormVentas";
            this.GBInfoCliente.ResumeLayout(false);
            this.GBInfoCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUpDCantidad)).EndInit();
            this.GBInfoVenta.ResumeLayout(false);
            this.GBInfoVenta.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatos)).EndInit();
            this.GBInfoProducto.ResumeLayout(false);
            this.GBInfoProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBInfoCliente;
        private FontAwesome.Sharp.IconButton IBBuscarProveedor;
        private System.Windows.Forms.Label LApellidoCliente;
        private System.Windows.Forms.TextBox TxtRazonSocial;
        private System.Windows.Forms.TextBox TxtNroDocCliente;
        private System.Windows.Forms.Label LNroDocCliente;
        private System.Windows.Forms.NumericUpDown NUpDCantidad;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton IBBuscarProducto;
        private System.Windows.Forms.Label LCantidad;
        private System.Windows.Forms.TextBox TxtPrecioVenta;
        private System.Windows.Forms.Label LPrecio;
        private System.Windows.Forms.GroupBox GBInfoVenta;
        private System.Windows.Forms.ComboBox CBTipoDocVenta;
        private System.Windows.Forms.TextBox TxtFechaVenta;
        private System.Windows.Forms.Label LTipoDocVenta;
        private System.Windows.Forms.Label LFechaVenta;
        private System.Windows.Forms.Label LRegistrarVenta;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox TxtPrecioCompra;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton IBCrearVenta;
        private FontAwesome.Sharp.IconButton IBAgregar;
        private System.Windows.Forms.DataGridView dataGridDatos;
        private System.Windows.Forms.GroupBox GBInfoProducto;
        private System.Windows.Forms.Label LProducto;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
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