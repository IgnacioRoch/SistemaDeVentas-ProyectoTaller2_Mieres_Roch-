namespace CapaPresentacion.Gerente_Comercial
{
    partial class FormReporteVentas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BVerDetalleVenta = new FontAwesome.Sharp.IconButton();
            this.IBBuscarReporteVenta = new FontAwesome.Sharp.IconButton();
            this.TxtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.TxtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.LFechaHasta = new System.Windows.Forms.Label();
            this.LFechaInicio = new System.Windows.Forms.Label();
            this.LReporteVentas = new System.Windows.Forms.Label();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.dataGridDatos = new System.Windows.Forms.DataGridView();
            this.BDescargarExcel = new System.Windows.Forms.Button();
            this.IBLimpiar = new FontAwesome.Sharp.IconButton();
            this.LBuscarPor = new System.Windows.Forms.Label();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.CBBusqueda = new System.Windows.Forms.ComboBox();
            this.IBBuscar = new FontAwesome.Sharp.IconButton();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BDetalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.panelBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BVerDetalleVenta);
            this.panel1.Controls.Add(this.IBBuscarReporteVenta);
            this.panel1.Controls.Add(this.TxtFechaFin);
            this.panel1.Controls.Add(this.TxtFechaInicio);
            this.panel1.Controls.Add(this.LFechaHasta);
            this.panel1.Controls.Add(this.LFechaInicio);
            this.panel1.Controls.Add(this.LReporteVentas);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1224, 81);
            this.panel1.TabIndex = 38;
            // 
            // BVerDetalleVenta
            // 
            this.BVerDetalleVenta.BackColor = System.Drawing.Color.LightGray;
            this.BVerDetalleVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BVerDetalleVenta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BVerDetalleVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BVerDetalleVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BVerDetalleVenta.ForeColor = System.Drawing.Color.Black;
            this.BVerDetalleVenta.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BVerDetalleVenta.IconColor = System.Drawing.Color.Black;
            this.BVerDetalleVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BVerDetalleVenta.IconSize = 16;
            this.BVerDetalleVenta.Location = new System.Drawing.Point(514, 39);
            this.BVerDetalleVenta.Name = "BVerDetalleVenta";
            this.BVerDetalleVenta.Size = new System.Drawing.Size(183, 29);
            this.BVerDetalleVenta.TabIndex = 9;
            this.BVerDetalleVenta.Text = "Ver detalle específico";
            this.BVerDetalleVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BVerDetalleVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BVerDetalleVenta.UseVisualStyleBackColor = false;
            this.BVerDetalleVenta.Visible = false;
            this.BVerDetalleVenta.Click += new System.EventHandler(this.BVerDetalleVenta_Click);
            // 
            // IBBuscarReporteVenta
            // 
            this.IBBuscarReporteVenta.BackColor = System.Drawing.Color.LightGray;
            this.IBBuscarReporteVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBBuscarReporteVenta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.IBBuscarReporteVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBBuscarReporteVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBBuscarReporteVenta.ForeColor = System.Drawing.Color.Black;
            this.IBBuscarReporteVenta.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.IBBuscarReporteVenta.IconColor = System.Drawing.Color.Black;
            this.IBBuscarReporteVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBBuscarReporteVenta.IconSize = 16;
            this.IBBuscarReporteVenta.Location = new System.Drawing.Point(402, 39);
            this.IBBuscarReporteVenta.Name = "IBBuscarReporteVenta";
            this.IBBuscarReporteVenta.Size = new System.Drawing.Size(90, 29);
            this.IBBuscarReporteVenta.TabIndex = 9;
            this.IBBuscarReporteVenta.Text = "Buscar";
            this.IBBuscarReporteVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBBuscarReporteVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBBuscarReporteVenta.UseVisualStyleBackColor = false;
            this.IBBuscarReporteVenta.Click += new System.EventHandler(this.IBBuscarReporteVenta_Click);
            // 
            // TxtFechaFin
            // 
            this.TxtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TxtFechaFin.Location = new System.Drawing.Point(280, 47);
            this.TxtFechaFin.Name = "TxtFechaFin";
            this.TxtFechaFin.Size = new System.Drawing.Size(102, 20);
            this.TxtFechaFin.TabIndex = 2;
            // 
            // TxtFechaInicio
            // 
            this.TxtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TxtFechaInicio.Location = new System.Drawing.Point(86, 47);
            this.TxtFechaInicio.Name = "TxtFechaInicio";
            this.TxtFechaInicio.Size = new System.Drawing.Size(102, 20);
            this.TxtFechaInicio.TabIndex = 2;
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
            // LReporteVentas
            // 
            this.LReporteVentas.AutoSize = true;
            this.LReporteVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LReporteVentas.Location = new System.Drawing.Point(13, 12);
            this.LReporteVentas.Name = "LReporteVentas";
            this.LReporteVentas.Size = new System.Drawing.Size(124, 18);
            this.LReporteVentas.TabIndex = 0;
            this.LReporteVentas.Text = "Reporte Ventas";
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBusqueda.Controls.Add(this.dataGridDatos);
            this.panelBusqueda.Controls.Add(this.BDescargarExcel);
            this.panelBusqueda.Controls.Add(this.IBLimpiar);
            this.panelBusqueda.Controls.Add(this.LBuscarPor);
            this.panelBusqueda.Controls.Add(this.TxtBusqueda);
            this.panelBusqueda.Controls.Add(this.CBBusqueda);
            this.panelBusqueda.Controls.Add(this.IBBuscar);
            this.panelBusqueda.Location = new System.Drawing.Point(12, 90);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(1224, 479);
            this.panelBusqueda.TabIndex = 39;
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
            this.FechaRegistro,
            this.TipoDocumento,
            this.NumeroDocumento,
            this.MontoTotal,
            this.UsuarioRegistro,
            this.DocumentoCliente,
            this.NombreCliente,
            this.BDetalle});
            this.dataGridDatos.Location = new System.Drawing.Point(16, 44);
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
            this.dataGridDatos.Size = new System.Drawing.Size(1193, 407);
            this.dataGridDatos.TabIndex = 8;
            this.dataGridDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDatos_CellContentClick);
            // 
            // BDescargarExcel
            // 
            this.BDescargarExcel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BDescargarExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BDescargarExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BDescargarExcel.Image = global::CapaPresentacion.Properties.Resources.icons8_ms_excel_20;
            this.BDescargarExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BDescargarExcel.Location = new System.Drawing.Point(16, 12);
            this.BDescargarExcel.Name = "BDescargarExcel";
            this.BDescargarExcel.Size = new System.Drawing.Size(143, 28);
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
            this.NumeroDocumento.HeaderText = "Numero Documento";
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
            // DocumentoCliente
            // 
            this.DocumentoCliente.HeaderText = "Documento Cliente";
            this.DocumentoCliente.MinimumWidth = 6;
            this.DocumentoCliente.Name = "DocumentoCliente";
            this.DocumentoCliente.ReadOnly = true;
            this.DocumentoCliente.Width = 125;
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "Nombre Cliente";
            this.NombreCliente.MinimumWidth = 6;
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            this.NombreCliente.Width = 125;
            // 
            // BDetalle
            // 
            this.BDetalle.HeaderText = "Detallle Venta";
            this.BDetalle.Name = "BDetalle";
            this.BDetalle.ReadOnly = true;
            // 
            // FormReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 616);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBusqueda);
            this.Name = "FormReporteVentas";
            this.Text = "FormReporteVentas";
            this.Load += new System.EventHandler(this.FormReporteVentas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton IBBuscarReporteVenta;
        private System.Windows.Forms.DateTimePicker TxtFechaFin;
        private System.Windows.Forms.DateTimePicker TxtFechaInicio;
        private System.Windows.Forms.Label LFechaHasta;
        private System.Windows.Forms.Label LFechaInicio;
        private System.Windows.Forms.Label LReporteVentas;
        private System.Windows.Forms.Panel panelBusqueda;
        private System.Windows.Forms.DataGridView dataGridDatos;
        private System.Windows.Forms.Button BDescargarExcel;
        private FontAwesome.Sharp.IconButton IBLimpiar;
        private System.Windows.Forms.Label LBuscarPor;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.ComboBox CBBusqueda;
        private FontAwesome.Sharp.IconButton IBBuscar;
        private FontAwesome.Sharp.IconButton BVerDetalleVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewButtonColumn BDetalle;
    }
}