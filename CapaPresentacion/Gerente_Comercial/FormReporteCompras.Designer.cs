namespace CapaPresentacion.Gerente_Comercial
{
    partial class FormReporteCompras
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
            this.PanelReporteComprasSuperior = new System.Windows.Forms.Panel();
            this.IBBuscarProveedorReporteCompra = new FontAwesome.Sharp.IconButton();
            this.CBProveedorReporteCompra = new System.Windows.Forms.ComboBox();
            this.TxtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.TxtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.LProveedorReporte = new System.Windows.Forms.Label();
            this.LFechaHasta = new System.Windows.Forms.Label();
            this.LFechaInicio = new System.Windows.Forms.Label();
            this.LReporteCompras = new System.Windows.Forms.Label();
            this.dataGridDatos = new System.Windows.Forms.DataGridView();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBusquedaInferior = new System.Windows.Forms.Panel();
            this.BDescargarExcel = new System.Windows.Forms.Button();
            this.IBLimpiar = new FontAwesome.Sharp.IconButton();
            this.LBuscarPor = new System.Windows.Forms.Label();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.CBBusqueda = new System.Windows.Forms.ComboBox();
            this.IBBuscar = new FontAwesome.Sharp.IconButton();
            this.BVerDetalleCompra = new FontAwesome.Sharp.IconButton();
            this.PanelReporteComprasSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatos)).BeginInit();
            this.panelBusquedaInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelReporteComprasSuperior
            // 
            this.PanelReporteComprasSuperior.BackColor = System.Drawing.Color.White;
            this.PanelReporteComprasSuperior.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelReporteComprasSuperior.Controls.Add(this.BVerDetalleCompra);
            this.PanelReporteComprasSuperior.Controls.Add(this.IBBuscarProveedorReporteCompra);
            this.PanelReporteComprasSuperior.Controls.Add(this.CBProveedorReporteCompra);
            this.PanelReporteComprasSuperior.Controls.Add(this.TxtFechaFin);
            this.PanelReporteComprasSuperior.Controls.Add(this.TxtFechaInicio);
            this.PanelReporteComprasSuperior.Controls.Add(this.LProveedorReporte);
            this.PanelReporteComprasSuperior.Controls.Add(this.LFechaHasta);
            this.PanelReporteComprasSuperior.Controls.Add(this.LFechaInicio);
            this.PanelReporteComprasSuperior.Controls.Add(this.LReporteCompras);
            this.PanelReporteComprasSuperior.Location = new System.Drawing.Point(16, 6);
            this.PanelReporteComprasSuperior.Margin = new System.Windows.Forms.Padding(4);
            this.PanelReporteComprasSuperior.Name = "PanelReporteComprasSuperior";
            this.PanelReporteComprasSuperior.Size = new System.Drawing.Size(1631, 95);
            this.PanelReporteComprasSuperior.TabIndex = 0;
            // 
            // IBBuscarProveedorReporteCompra
            // 
            this.IBBuscarProveedorReporteCompra.BackColor = System.Drawing.Color.LightGray;
            this.IBBuscarProveedorReporteCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBBuscarProveedorReporteCompra.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.IBBuscarProveedorReporteCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBBuscarProveedorReporteCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBBuscarProveedorReporteCompra.ForeColor = System.Drawing.Color.Black;
            this.IBBuscarProveedorReporteCompra.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.IBBuscarProveedorReporteCompra.IconColor = System.Drawing.Color.Black;
            this.IBBuscarProveedorReporteCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBBuscarProveedorReporteCompra.IconSize = 16;
            this.IBBuscarProveedorReporteCompra.Location = new System.Drawing.Point(817, 49);
            this.IBBuscarProveedorReporteCompra.Margin = new System.Windows.Forms.Padding(4);
            this.IBBuscarProveedorReporteCompra.Name = "IBBuscarProveedorReporteCompra";
            this.IBBuscarProveedorReporteCompra.Size = new System.Drawing.Size(120, 37);
            this.IBBuscarProveedorReporteCompra.TabIndex = 9;
            this.IBBuscarProveedorReporteCompra.Text = "Buscar";
            this.IBBuscarProveedorReporteCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBBuscarProveedorReporteCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBBuscarProveedorReporteCompra.UseVisualStyleBackColor = false;
            this.IBBuscarProveedorReporteCompra.Click += new System.EventHandler(this.IBBuscarProveedorReporteCompra_Click);
            // 
            // CBProveedorReporteCompra
            // 
            this.CBProveedorReporteCompra.FormattingEnabled = true;
            this.CBProveedorReporteCompra.Location = new System.Drawing.Point(625, 57);
            this.CBProveedorReporteCompra.Margin = new System.Windows.Forms.Padding(4);
            this.CBProveedorReporteCompra.Name = "CBProveedorReporteCompra";
            this.CBProveedorReporteCompra.Size = new System.Drawing.Size(160, 24);
            this.CBProveedorReporteCompra.TabIndex = 3;
            // 
            // TxtFechaFin
            // 
            this.TxtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TxtFechaFin.Location = new System.Drawing.Point(373, 58);
            this.TxtFechaFin.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFechaFin.Name = "TxtFechaFin";
            this.TxtFechaFin.Size = new System.Drawing.Size(135, 22);
            this.TxtFechaFin.TabIndex = 2;
            // 
            // TxtFechaInicio
            // 
            this.TxtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TxtFechaInicio.Location = new System.Drawing.Point(115, 58);
            this.TxtFechaInicio.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFechaInicio.Name = "TxtFechaInicio";
            this.TxtFechaInicio.Size = new System.Drawing.Size(135, 22);
            this.TxtFechaInicio.TabIndex = 2;
            // 
            // LProveedorReporte
            // 
            this.LProveedorReporte.AutoSize = true;
            this.LProveedorReporte.Location = new System.Drawing.Point(539, 58);
            this.LProveedorReporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LProveedorReporte.Name = "LProveedorReporte";
            this.LProveedorReporte.Size = new System.Drawing.Size(74, 16);
            this.LProveedorReporte.TabIndex = 1;
            this.LProveedorReporte.Text = "Proveedor:";
            // 
            // LFechaHasta
            // 
            this.LFechaHasta.AutoSize = true;
            this.LFechaHasta.Location = new System.Drawing.Point(276, 58);
            this.LFechaHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LFechaHasta.Name = "LFechaHasta";
            this.LFechaHasta.Size = new System.Drawing.Size(84, 16);
            this.LFechaHasta.TabIndex = 1;
            this.LFechaHasta.Text = "Fecha hasta:";
            // 
            // LFechaInicio
            // 
            this.LFechaInicio.AutoSize = true;
            this.LFechaInicio.Location = new System.Drawing.Point(17, 58);
            this.LFechaInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LFechaInicio.Name = "LFechaInicio";
            this.LFechaInicio.Size = new System.Drawing.Size(82, 16);
            this.LFechaInicio.TabIndex = 1;
            this.LFechaInicio.Text = "Fecha inicio:";
            // 
            // LReporteCompras
            // 
            this.LReporteCompras.AutoSize = true;
            this.LReporteCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LReporteCompras.Location = new System.Drawing.Point(17, 15);
            this.LReporteCompras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LReporteCompras.Name = "LReporteCompras";
            this.LReporteCompras.Size = new System.Drawing.Size(173, 24);
            this.LReporteCompras.TabIndex = 0;
            this.LReporteCompras.Text = "Reporte Compras";
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
            this.FechaRegistro,
            this.TipoDocumento,
            this.NumeroDocumento,
            this.MontoTotal,
            this.UsuarioRegistro,
            this.DocumentoProveedor,
            this.RazonSocial,
            this.CodigoProducto,
            this.NombreProducto,
            this.Categoria,
            this.Marca,
            this.PrecioCompra,
            this.PrecioVenta,
            this.Cantidad,
            this.SubTotal});
            this.dataGridDatos.Location = new System.Drawing.Point(21, 54);
            this.dataGridDatos.Margin = new System.Windows.Forms.Padding(4);
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
            this.dataGridDatos.RowHeadersWidth = 51;
            this.dataGridDatos.RowTemplate.Height = 28;
            this.dataGridDatos.Size = new System.Drawing.Size(1591, 500);
            this.dataGridDatos.TabIndex = 8;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha Registro";
            this.FechaRegistro.MinimumWidth = 6;
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            this.FechaRegistro.Width = 125;
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.HeaderText = "Tipo Documento";
            this.TipoDocumento.MinimumWidth = 6;
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            this.TipoDocumento.Width = 125;
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.HeaderText = "NumeroDocumento";
            this.NumeroDocumento.MinimumWidth = 6;
            this.NumeroDocumento.Name = "NumeroDocumento";
            this.NumeroDocumento.ReadOnly = true;
            this.NumeroDocumento.Width = 125;
            // 
            // MontoTotal
            // 
            this.MontoTotal.HeaderText = "Monto Total";
            this.MontoTotal.MinimumWidth = 6;
            this.MontoTotal.Name = "MontoTotal";
            this.MontoTotal.ReadOnly = true;
            this.MontoTotal.Width = 125;
            // 
            // UsuarioRegistro
            // 
            this.UsuarioRegistro.HeaderText = "Usuario Registro";
            this.UsuarioRegistro.MinimumWidth = 6;
            this.UsuarioRegistro.Name = "UsuarioRegistro";
            this.UsuarioRegistro.ReadOnly = true;
            this.UsuarioRegistro.Width = 125;
            // 
            // DocumentoProveedor
            // 
            this.DocumentoProveedor.HeaderText = "Documento Proveedor";
            this.DocumentoProveedor.MinimumWidth = 6;
            this.DocumentoProveedor.Name = "DocumentoProveedor";
            this.DocumentoProveedor.ReadOnly = true;
            this.DocumentoProveedor.Width = 125;
            // 
            // RazonSocial
            // 
            this.RazonSocial.HeaderText = "Razon Social";
            this.RazonSocial.MinimumWidth = 6;
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.ReadOnly = true;
            this.RazonSocial.Width = 125;
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.HeaderText = "Codigo Producto";
            this.CodigoProducto.MinimumWidth = 6;
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.ReadOnly = true;
            this.CodigoProducto.Visible = false;
            this.CodigoProducto.Width = 125;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre Producto";
            this.NombreProducto.MinimumWidth = 6;
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            this.NombreProducto.Visible = false;
            this.NombreProducto.Width = 125;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoría";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Visible = false;
            this.Categoria.Width = 125;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 6;
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Visible = false;
            this.Marca.Width = 125;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.MinimumWidth = 6;
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            this.PrecioCompra.Visible = false;
            this.PrecioCompra.Width = 125;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.MinimumWidth = 6;
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.Visible = false;
            this.PrecioVenta.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Visible = false;
            this.Cantidad.Width = 150;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Visible = false;
            this.SubTotal.Width = 125;
            // 
            // panelBusquedaInferior
            // 
            this.panelBusquedaInferior.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelBusquedaInferior.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBusquedaInferior.Controls.Add(this.dataGridDatos);
            this.panelBusquedaInferior.Controls.Add(this.BDescargarExcel);
            this.panelBusquedaInferior.Controls.Add(this.IBLimpiar);
            this.panelBusquedaInferior.Controls.Add(this.LBuscarPor);
            this.panelBusquedaInferior.Controls.Add(this.TxtBusqueda);
            this.panelBusquedaInferior.Controls.Add(this.CBBusqueda);
            this.panelBusquedaInferior.Controls.Add(this.IBBuscar);
            this.panelBusquedaInferior.Location = new System.Drawing.Point(16, 110);
            this.panelBusquedaInferior.Margin = new System.Windows.Forms.Padding(4);
            this.panelBusquedaInferior.Name = "panelBusquedaInferior";
            this.panelBusquedaInferior.Size = new System.Drawing.Size(1631, 592);
            this.panelBusquedaInferior.TabIndex = 37;
            // 
            // BDescargarExcel
            // 
            this.BDescargarExcel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BDescargarExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BDescargarExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BDescargarExcel.Image = global::CapaPresentacion.Properties.Resources.icons8_ms_excel_20;
            this.BDescargarExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BDescargarExcel.Location = new System.Drawing.Point(21, 15);
            this.BDescargarExcel.Margin = new System.Windows.Forms.Padding(4);
            this.BDescargarExcel.Name = "BDescargarExcel";
            this.BDescargarExcel.Size = new System.Drawing.Size(191, 34);
            this.BDescargarExcel.TabIndex = 34;
            this.BDescargarExcel.Text = "Descargar Excel";
            this.BDescargarExcel.UseVisualStyleBackColor = false;
            this.BDescargarExcel.Click += new System.EventHandler(this.BDescargarExcel_Click);
            // 
            // IBLimpiar
            // 
            this.IBLimpiar.BackColor = System.Drawing.Color.White;
            this.IBLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.IBLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBLimpiar.ForeColor = System.Drawing.Color.Black;
            this.IBLimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.IBLimpiar.IconColor = System.Drawing.Color.Black;
            this.IBLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBLimpiar.IconSize = 16;
            this.IBLimpiar.Location = new System.Drawing.Point(1497, 15);
            this.IBLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.IBLimpiar.Name = "IBLimpiar";
            this.IBLimpiar.Size = new System.Drawing.Size(55, 34);
            this.IBLimpiar.TabIndex = 33;
            this.IBLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBLimpiar.UseVisualStyleBackColor = false;
            this.IBLimpiar.Click += new System.EventHandler(this.IBLimpiar_Click);
            // 
            // LBuscarPor
            // 
            this.LBuscarPor.AutoSize = true;
            this.LBuscarPor.BackColor = System.Drawing.Color.LightSteelBlue;
            this.LBuscarPor.ForeColor = System.Drawing.Color.Black;
            this.LBuscarPor.Location = new System.Drawing.Point(705, 25);
            this.LBuscarPor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBuscarPor.Name = "LBuscarPor";
            this.LBuscarPor.Size = new System.Drawing.Size(75, 16);
            this.LBuscarPor.TabIndex = 16;
            this.LBuscarPor.Text = "Buscar por:";
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(1057, 21);
            this.TxtBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(313, 22);
            this.TxtBusqueda.TabIndex = 23;
            // 
            // CBBusqueda
            // 
            this.CBBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBusqueda.FormattingEnabled = true;
            this.CBBusqueda.Location = new System.Drawing.Point(817, 21);
            this.CBBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.CBBusqueda.Name = "CBBusqueda";
            this.CBBusqueda.Size = new System.Drawing.Size(193, 24);
            this.CBBusqueda.TabIndex = 27;
            // 
            // IBBuscar
            // 
            this.IBBuscar.BackColor = System.Drawing.Color.Gold;
            this.IBBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.IBBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBBuscar.ForeColor = System.Drawing.Color.Black;
            this.IBBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.IBBuscar.IconColor = System.Drawing.Color.Black;
            this.IBBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBBuscar.IconSize = 16;
            this.IBBuscar.Location = new System.Drawing.Point(1435, 15);
            this.IBBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.IBBuscar.Name = "IBBuscar";
            this.IBBuscar.Size = new System.Drawing.Size(55, 34);
            this.IBBuscar.TabIndex = 30;
            this.IBBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBBuscar.UseVisualStyleBackColor = false;
            this.IBBuscar.Click += new System.EventHandler(this.IBBuscar_Click);
            // 
            // BVerDetalleCompra
            // 
            this.BVerDetalleCompra.BackColor = System.Drawing.Color.LightGray;
            this.BVerDetalleCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BVerDetalleCompra.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BVerDetalleCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BVerDetalleCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BVerDetalleCompra.ForeColor = System.Drawing.Color.Black;
            this.BVerDetalleCompra.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BVerDetalleCompra.IconColor = System.Drawing.Color.Black;
            this.BVerDetalleCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BVerDetalleCompra.IconSize = 16;
            this.BVerDetalleCompra.Location = new System.Drawing.Point(979, 49);
            this.BVerDetalleCompra.Margin = new System.Windows.Forms.Padding(4);
            this.BVerDetalleCompra.Name = "BVerDetalleCompra";
            this.BVerDetalleCompra.Size = new System.Drawing.Size(229, 37);
            this.BVerDetalleCompra.TabIndex = 9;
            this.BVerDetalleCompra.Text = "Ver detalle específico";
            this.BVerDetalleCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BVerDetalleCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BVerDetalleCompra.UseVisualStyleBackColor = false;
            this.BVerDetalleCompra.Click += new System.EventHandler(this.BVerDetalleCompra_Click);
            // 
            // FormReporteCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1768, 793);
            this.Controls.Add(this.PanelReporteComprasSuperior);
            this.Controls.Add(this.panelBusquedaInferior);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormReporteCompras";
            this.Text = "FormReporteCompras";
            this.Load += new System.EventHandler(this.FormReporteCompras_Load);
            this.PanelReporteComprasSuperior.ResumeLayout(false);
            this.PanelReporteComprasSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatos)).EndInit();
            this.panelBusquedaInferior.ResumeLayout(false);
            this.panelBusquedaInferior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelReporteComprasSuperior;
        private System.Windows.Forms.Label LReporteCompras;
        private System.Windows.Forms.DateTimePicker TxtFechaInicio;
        private System.Windows.Forms.Label LFechaInicio;
        private System.Windows.Forms.ComboBox CBProveedorReporteCompra;
        private System.Windows.Forms.DateTimePicker TxtFechaFin;
        private System.Windows.Forms.Label LProveedorReporte;
        private System.Windows.Forms.Label LFechaHasta;
        private FontAwesome.Sharp.IconButton IBBuscarProveedorReporteCompra;
        private System.Windows.Forms.DataGridView dataGridDatos;
        private System.Windows.Forms.Panel panelBusquedaInferior;
        private FontAwesome.Sharp.IconButton IBLimpiar;
        private System.Windows.Forms.Label LBuscarPor;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.ComboBox CBBusqueda;
        private FontAwesome.Sharp.IconButton IBBuscar;
        private System.Windows.Forms.Button BDescargarExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentoProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private FontAwesome.Sharp.IconButton BVerDetalleCompra;
    }
}