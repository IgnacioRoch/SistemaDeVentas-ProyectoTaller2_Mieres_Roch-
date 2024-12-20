﻿namespace CapaPresentacion.Vendedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.LNombreCliente = new System.Windows.Forms.Label();
            this.TxtCliente = new System.Windows.Forms.TextBox();
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
            this.PanelRegistrarVenta.Location = new System.Drawing.Point(111, 12);
            this.PanelRegistrarVenta.Name = "PanelRegistrarVenta";
            this.PanelRegistrarVenta.Size = new System.Drawing.Size(1012, 547);
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
            this.IBCrearVenta.Location = new System.Drawing.Point(871, 472);
            this.IBCrearVenta.Name = "IBCrearVenta";
            this.IBCrearVenta.Size = new System.Drawing.Size(129, 45);
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
            this.IBAgregar.Location = new System.Drawing.Point(893, 161);
            this.IBAgregar.Name = "IBAgregar";
            this.IBAgregar.Size = new System.Drawing.Size(99, 54);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridDatos.RowHeadersWidth = 51;
            this.dataGridDatos.RowTemplate.Height = 28;
            this.dataGridDatos.Size = new System.Drawing.Size(857, 301);
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
            this.GBInfoProducto.Location = new System.Drawing.Point(8, 142);
            this.GBInfoProducto.Name = "GBInfoProducto";
            this.GBInfoProducto.Size = new System.Drawing.Size(857, 80);
            this.GBInfoProducto.TabIndex = 6;
            this.GBInfoProducto.TabStop = false;
            this.GBInfoProducto.Text = "Información de Producto";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(753, 42);
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
            // TextIdProducto
            // 
            this.TextIdProducto.Location = new System.Drawing.Point(129, 19);
            this.TextIdProducto.Name = "TextIdProducto";
            this.TextIdProducto.Size = new System.Drawing.Size(23, 20);
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
            // LStock
            // 
            this.LStock.AutoSize = true;
            this.LStock.Location = new System.Drawing.Point(642, 26);
            this.LStock.Name = "LStock";
            this.LStock.Size = new System.Drawing.Size(44, 13);
            this.LStock.TabIndex = 0;
            this.LStock.Text = "Stock:";
            // 
            // TxtStock
            // 
            this.TxtStock.Location = new System.Drawing.Point(646, 42);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(67, 20);
            this.TxtStock.TabIndex = 4;
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Location = new System.Drawing.Point(527, 26);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(47, 13);
            this.lPrecio.TabIndex = 0;
            this.lPrecio.Text = "Precio:";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(530, 42);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(67, 20);
            this.TxtPrecio.TabIndex = 4;
            this.TxtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecio_KeyPress);
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
            // TextCodProducto
            // 
            this.TextCodProducto.Location = new System.Drawing.Point(9, 42);
            this.TextCodProducto.Name = "TextCodProducto";
            this.TextCodProducto.Size = new System.Drawing.Size(143, 20);
            this.TextCodProducto.TabIndex = 4;
            this.TextCodProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextCodProducto_KeyDown);
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
            // GBInfoCliente
            // 
            this.GBInfoCliente.BackColor = System.Drawing.Color.Transparent;
            this.GBInfoCliente.Controls.Add(this.IBBuscarCliente);
            this.GBInfoCliente.Controls.Add(this.LNombreCliente);
            this.GBInfoCliente.Controls.Add(this.TxtCliente);
            this.GBInfoCliente.Controls.Add(this.TxtNroDocCliente);
            this.GBInfoCliente.Controls.Add(this.LNroDocCliente);
            this.GBInfoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBInfoCliente.ForeColor = System.Drawing.Color.White;
            this.GBInfoCliente.Location = new System.Drawing.Point(549, 38);
            this.GBInfoCliente.Name = "GBInfoCliente";
            this.GBInfoCliente.Size = new System.Drawing.Size(451, 87);
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
            this.IBBuscarCliente.Location = new System.Drawing.Point(158, 41);
            this.IBBuscarCliente.Name = "IBBuscarCliente";
            this.IBBuscarCliente.Size = new System.Drawing.Size(35, 20);
            this.IBBuscarCliente.TabIndex = 5;
            this.IBBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBBuscarCliente.UseVisualStyleBackColor = false;
            this.IBBuscarCliente.Click += new System.EventHandler(this.IBBuscarCliente_Click);
            // 
            // LNombreCliente
            // 
            this.LNombreCliente.AutoSize = true;
            this.LNombreCliente.Location = new System.Drawing.Point(243, 25);
            this.LNombreCliente.Name = "LNombreCliente";
            this.LNombreCliente.Size = new System.Drawing.Size(50, 13);
            this.LNombreCliente.TabIndex = 0;
            this.LNombreCliente.Text = "Cliente:";
            // 
            // TxtCliente
            // 
            this.TxtCliente.Location = new System.Drawing.Point(246, 41);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(143, 20);
            this.TxtCliente.TabIndex = 4;
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
            // GBInfoVenta
            // 
            this.GBInfoVenta.BackColor = System.Drawing.Color.Transparent;
            this.GBInfoVenta.Controls.Add(this.CBTipoDocVenta);
            this.GBInfoVenta.Controls.Add(this.TxtFechaVenta);
            this.GBInfoVenta.Controls.Add(this.LTipoDocVenta);
            this.GBInfoVenta.Controls.Add(this.LFechaVenta);
            this.GBInfoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBInfoVenta.ForeColor = System.Drawing.Color.White;
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
            this.LRegistrarVenta.BackColor = System.Drawing.Color.Transparent;
            this.LRegistrarVenta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRegistrarVenta.ForeColor = System.Drawing.Color.White;
            this.LRegistrarVenta.Location = new System.Drawing.Point(3, 10);
            this.LRegistrarVenta.Name = "LRegistrarVenta";
            this.LRegistrarVenta.Size = new System.Drawing.Size(164, 23);
            this.LRegistrarVenta.TabIndex = 2;
            this.LRegistrarVenta.Text = "Registrar Venta";
            // 
            // LCambio
            // 
            this.LCambio.AutoSize = true;
            this.LCambio.BackColor = System.Drawing.Color.Transparent;
            this.LCambio.ForeColor = System.Drawing.Color.White;
            this.LCambio.Location = new System.Drawing.Point(890, 412);
            this.LCambio.Name = "LCambio";
            this.LCambio.Size = new System.Drawing.Size(45, 13);
            this.LCambio.TabIndex = 0;
            this.LCambio.Text = "Cambio:";
            // 
            // LPagaCon
            // 
            this.LPagaCon.AutoSize = true;
            this.LPagaCon.BackColor = System.Drawing.Color.Transparent;
            this.LPagaCon.ForeColor = System.Drawing.Color.White;
            this.LPagaCon.Location = new System.Drawing.Point(890, 361);
            this.LPagaCon.Name = "LPagaCon";
            this.LPagaCon.Size = new System.Drawing.Size(56, 13);
            this.LPagaCon.TabIndex = 0;
            this.LPagaCon.Text = "Paga con:";
            // 
            // LTotalAPagar
            // 
            this.LTotalAPagar.AutoSize = true;
            this.LTotalAPagar.BackColor = System.Drawing.Color.Transparent;
            this.LTotalAPagar.ForeColor = System.Drawing.Color.White;
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
            this.TxtPagacon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPagacon_KeyDown);
            this.TxtPagacon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPagacon_KeyPress);
            // 
            // TxtTotalPagar
            // 
            this.TxtTotalPagar.Location = new System.Drawing.Point(893, 299);
            this.TxtTotalPagar.Name = "TxtTotalPagar";
            this.TxtTotalPagar.Size = new System.Drawing.Size(107, 20);
            this.TxtTotalPagar.TabIndex = 4;
            this.TxtTotalPagar.Text = "0";
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 632);
            this.Controls.Add(this.PanelRegistrarVenta);
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
        private System.Windows.Forms.Label LNombreCliente;
        private System.Windows.Forms.TextBox TxtCliente;
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