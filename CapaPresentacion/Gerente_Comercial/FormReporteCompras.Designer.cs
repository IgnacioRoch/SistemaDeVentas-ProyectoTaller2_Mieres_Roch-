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
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
            this.PanelReporteComprasSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatos)).BeginInit();
            this.panelBusquedaInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelReporteComprasSuperior
            // 
            this.PanelReporteComprasSuperior.BackColor = System.Drawing.Color.White;
            this.PanelReporteComprasSuperior.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelReporteComprasSuperior.Controls.Add(this.IBBuscarProveedorReporteCompra);
            this.PanelReporteComprasSuperior.Controls.Add(this.CBProveedorReporteCompra);
            this.PanelReporteComprasSuperior.Controls.Add(this.dateTimePicker2);
            this.PanelReporteComprasSuperior.Controls.Add(this.dateTimePicker1);
            this.PanelReporteComprasSuperior.Controls.Add(this.LProveedorReporte);
            this.PanelReporteComprasSuperior.Controls.Add(this.LFechaHasta);
            this.PanelReporteComprasSuperior.Controls.Add(this.LFechaInicio);
            this.PanelReporteComprasSuperior.Controls.Add(this.LReporteCompras);
            this.PanelReporteComprasSuperior.Location = new System.Drawing.Point(12, 5);
            this.PanelReporteComprasSuperior.Name = "PanelReporteComprasSuperior";
            this.PanelReporteComprasSuperior.Size = new System.Drawing.Size(1224, 78);
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
            this.IBBuscarProveedorReporteCompra.Location = new System.Drawing.Point(613, 40);
            this.IBBuscarProveedorReporteCompra.Name = "IBBuscarProveedorReporteCompra";
            this.IBBuscarProveedorReporteCompra.Size = new System.Drawing.Size(90, 30);
            this.IBBuscarProveedorReporteCompra.TabIndex = 9;
            this.IBBuscarProveedorReporteCompra.Text = "Buscar";
            this.IBBuscarProveedorReporteCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBBuscarProveedorReporteCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBBuscarProveedorReporteCompra.UseVisualStyleBackColor = false;
            // 
            // CBProveedorReporteCompra
            // 
            this.CBProveedorReporteCompra.FormattingEnabled = true;
            this.CBProveedorReporteCompra.Location = new System.Drawing.Point(469, 46);
            this.CBProveedorReporteCompra.Name = "CBProveedorReporteCompra";
            this.CBProveedorReporteCompra.Size = new System.Drawing.Size(121, 21);
            this.CBProveedorReporteCompra.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(280, 47);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(102, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(86, 47);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(102, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // LProveedorReporte
            // 
            this.LProveedorReporte.AutoSize = true;
            this.LProveedorReporte.Location = new System.Drawing.Point(404, 47);
            this.LProveedorReporte.Name = "LProveedorReporte";
            this.LProveedorReporte.Size = new System.Drawing.Size(59, 13);
            this.LProveedorReporte.TabIndex = 1;
            this.LProveedorReporte.Text = "Proveedor:";
            // 
            // LFechaHasta
            // 
            this.LFechaHasta.AutoSize = true;
            this.LFechaHasta.Location = new System.Drawing.Point(207, 47);
            this.LFechaHasta.Name = "LFechaHasta";
            this.LFechaHasta.Size = new System.Drawing.Size(69, 13);
            this.LFechaHasta.TabIndex = 1;
            this.LFechaHasta.Text = "Fecha hasta:";
            // 
            // LFechaInicio
            // 
            this.LFechaInicio.AutoSize = true;
            this.LFechaInicio.Location = new System.Drawing.Point(13, 47);
            this.LFechaInicio.Name = "LFechaInicio";
            this.LFechaInicio.Size = new System.Drawing.Size(67, 13);
            this.LFechaInicio.TabIndex = 1;
            this.LFechaInicio.Text = "Fecha inicio:";
            // 
            // LReporteCompras
            // 
            this.LReporteCompras.AutoSize = true;
            this.LReporteCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LReporteCompras.Location = new System.Drawing.Point(13, 12);
            this.LReporteCompras.Name = "LReporteCompras";
            this.LReporteCompras.Size = new System.Drawing.Size(142, 18);
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
            this.PrecioCompra,
            this.PrecioVenta,
            this.Cantidad,
            this.SubTotal});
            this.dataGridDatos.Location = new System.Drawing.Point(16, 44);
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
            this.dataGridDatos.Size = new System.Drawing.Size(1193, 406);
            this.dataGridDatos.TabIndex = 8;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha Registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.HeaderText = "Tipo Documento";
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.HeaderText = "NumeroDocumento";
            this.NumeroDocumento.Name = "NumeroDocumento";
            this.NumeroDocumento.ReadOnly = true;
            // 
            // MontoTotal
            // 
            this.MontoTotal.HeaderText = "Monto Total";
            this.MontoTotal.Name = "MontoTotal";
            this.MontoTotal.ReadOnly = true;
            // 
            // UsuarioRegistro
            // 
            this.UsuarioRegistro.HeaderText = "Usuario Registro";
            this.UsuarioRegistro.Name = "UsuarioRegistro";
            this.UsuarioRegistro.ReadOnly = true;
            // 
            // DocumentoProveedor
            // 
            this.DocumentoProveedor.HeaderText = "Documento Proveedor";
            this.DocumentoProveedor.Name = "DocumentoProveedor";
            this.DocumentoProveedor.ReadOnly = true;
            // 
            // RazonSocial
            // 
            this.RazonSocial.HeaderText = "Razon Social";
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.ReadOnly = true;
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.HeaderText = "Codigo Producto";
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.ReadOnly = true;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre Producto";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoría";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
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
            this.panelBusquedaInferior.Location = new System.Drawing.Point(12, 89);
            this.panelBusquedaInferior.Name = "panelBusquedaInferior";
            this.panelBusquedaInferior.Size = new System.Drawing.Size(1224, 482);
            this.panelBusquedaInferior.TabIndex = 37;
            // 
            // BDescargarExcel
            // 
            this.BDescargarExcel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BDescargarExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BDescargarExcel.Image = global::CapaPresentacion.Properties.Resources.icons8_ms_excel_20;
            this.BDescargarExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BDescargarExcel.Location = new System.Drawing.Point(16, 12);
            this.BDescargarExcel.Name = "BDescargarExcel";
            this.BDescargarExcel.Size = new System.Drawing.Size(143, 28);
            this.BDescargarExcel.TabIndex = 34;
            this.BDescargarExcel.Text = "Descargar Excel";
            this.BDescargarExcel.UseVisualStyleBackColor = false;
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
            this.IBLimpiar.Location = new System.Drawing.Point(1123, 12);
            this.IBLimpiar.Name = "IBLimpiar";
            this.IBLimpiar.Size = new System.Drawing.Size(41, 28);
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
            this.LBuscarPor.Location = new System.Drawing.Point(529, 20);
            this.LBuscarPor.Name = "LBuscarPor";
            this.LBuscarPor.Size = new System.Drawing.Size(61, 13);
            this.LBuscarPor.TabIndex = 16;
            this.LBuscarPor.Text = "Buscar por:";
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(793, 17);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(236, 20);
            this.TxtBusqueda.TabIndex = 23;
            // 
            // CBBusqueda
            // 
            this.CBBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBusqueda.FormattingEnabled = true;
            this.CBBusqueda.Location = new System.Drawing.Point(613, 17);
            this.CBBusqueda.Name = "CBBusqueda";
            this.CBBusqueda.Size = new System.Drawing.Size(146, 21);
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
            this.IBBuscar.Location = new System.Drawing.Point(1076, 12);
            this.IBBuscar.Name = "IBBuscar";
            this.IBBuscar.Size = new System.Drawing.Size(41, 28);
            this.IBBuscar.TabIndex = 30;
            this.IBBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBBuscar.UseVisualStyleBackColor = false;
            this.IBBuscar.Click += new System.EventHandler(this.IBBuscar_Click);
            // 
            // FormReporteCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 644);
            this.Controls.Add(this.PanelReporteComprasSuperior);
            this.Controls.Add(this.panelBusquedaInferior);
            this.Name = "FormReporteCompras";
            this.Text = "FormReporteCompras";
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label LFechaInicio;
        private System.Windows.Forms.ComboBox CBProveedorReporteCompra;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label LProveedorReporte;
        private System.Windows.Forms.Label LFechaHasta;
        private FontAwesome.Sharp.IconButton IBBuscarProveedorReporteCompra;
        private System.Windows.Forms.DataGridView dataGridDatos;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.Panel panelBusquedaInferior;
        private FontAwesome.Sharp.IconButton IBLimpiar;
        private System.Windows.Forms.Label LBuscarPor;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.ComboBox CBBusqueda;
        private FontAwesome.Sharp.IconButton IBBuscar;
        private System.Windows.Forms.Button BDescargarExcel;
    }
}