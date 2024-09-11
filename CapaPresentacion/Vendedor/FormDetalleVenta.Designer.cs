namespace CapaPresentacion.Vendedor
{
    partial class FormDetalleVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TxtMontoTotal = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.TxtNombreCliente = new System.Windows.Forms.TextBox();
            this.LNombreCliente = new System.Windows.Forms.Label();
            this.TxtNroDocumento = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.LUsuario = new System.Windows.Forms.Label();
            this.GBInformacionCompra = new System.Windows.Forms.GroupBox();
            this.TxtTipoDocumento = new System.Windows.Forms.TextBox();
            this.LTipoDocumento = new System.Windows.Forms.Label();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.LFecha = new System.Windows.Forms.Label();
            this.IBLimpiar = new FontAwesome.Sharp.IconButton();
            this.LDetalleVentas = new System.Windows.Forms.Label();
            this.IBBuscar = new FontAwesome.Sharp.IconButton();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.CBNroDocumento = new System.Windows.Forms.ComboBox();
            this.LNroDocumentoCliente = new System.Windows.Forms.Label();
            this.GBInformacionCliente = new System.Windows.Forms.GroupBox();
            this.LNuevoDocumento = new System.Windows.Forms.Label();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BDescaergarPdf = new System.Windows.Forms.Button();
            this.dataGridDatos = new System.Windows.Forms.DataGridView();
            this.LMontototal = new System.Windows.Forms.Label();
            this.panelDetalleCompra = new System.Windows.Forms.Panel();
            this.GBInformacionCompra.SuspendLayout();
            this.GBInformacionCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatos)).BeginInit();
            this.panelDetalleCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtMontoTotal
            // 
            this.TxtMontoTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtMontoTotal.Location = new System.Drawing.Point(117, 704);
            this.TxtMontoTotal.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMontoTotal.Name = "TxtMontoTotal";
            this.TxtMontoTotal.Size = new System.Drawing.Size(87, 22);
            this.TxtMontoTotal.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(847, 66);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(75, 22);
            this.textBox4.TabIndex = 1;
            this.textBox4.Visible = false;
            // 
            // TxtNombreCliente
            // 
            this.TxtNombreCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtNombreCliente.Location = new System.Drawing.Point(283, 52);
            this.TxtNombreCliente.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombreCliente.Name = "TxtNombreCliente";
            this.TxtNombreCliente.Size = new System.Drawing.Size(227, 22);
            this.TxtNombreCliente.TabIndex = 1;
            // 
            // LNombreCliente
            // 
            this.LNombreCliente.AutoSize = true;
            this.LNombreCliente.Location = new System.Drawing.Point(279, 32);
            this.LNombreCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNombreCliente.Name = "LNombreCliente";
            this.LNombreCliente.Size = new System.Drawing.Size(103, 16);
            this.LNombreCliente.TabIndex = 0;
            this.LNombreCliente.Text = "Nombre Cliente:";
            // 
            // TxtNroDocumento
            // 
            this.TxtNroDocumento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtNroDocumento.Location = new System.Drawing.Point(28, 52);
            this.TxtNroDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNroDocumento.Name = "TxtNroDocumento";
            this.TxtNroDocumento.Size = new System.Drawing.Size(227, 22);
            this.TxtNroDocumento.TabIndex = 1;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtUsuario.Location = new System.Drawing.Point(557, 52);
            this.TxtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(227, 22);
            this.TxtUsuario.TabIndex = 1;
            // 
            // LUsuario
            // 
            this.LUsuario.AutoSize = true;
            this.LUsuario.Location = new System.Drawing.Point(553, 32);
            this.LUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(57, 16);
            this.LUsuario.TabIndex = 0;
            this.LUsuario.Text = "Usuario:";
            // 
            // GBInformacionCompra
            // 
            this.GBInformacionCompra.Controls.Add(this.TxtUsuario);
            this.GBInformacionCompra.Controls.Add(this.LUsuario);
            this.GBInformacionCompra.Controls.Add(this.TxtTipoDocumento);
            this.GBInformacionCompra.Controls.Add(this.LTipoDocumento);
            this.GBInformacionCompra.Controls.Add(this.TxtFecha);
            this.GBInformacionCompra.Controls.Add(this.LFecha);
            this.GBInformacionCompra.Location = new System.Drawing.Point(11, 110);
            this.GBInformacionCompra.Margin = new System.Windows.Forms.Padding(4);
            this.GBInformacionCompra.Name = "GBInformacionCompra";
            this.GBInformacionCompra.Padding = new System.Windows.Forms.Padding(4);
            this.GBInformacionCompra.Size = new System.Drawing.Size(931, 98);
            this.GBInformacionCompra.TabIndex = 10;
            this.GBInformacionCompra.TabStop = false;
            this.GBInformacionCompra.Text = "Información Compra";
            // 
            // TxtTipoDocumento
            // 
            this.TxtTipoDocumento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtTipoDocumento.Location = new System.Drawing.Point(283, 52);
            this.TxtTipoDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTipoDocumento.Name = "TxtTipoDocumento";
            this.TxtTipoDocumento.Size = new System.Drawing.Size(227, 22);
            this.TxtTipoDocumento.TabIndex = 1;
            // 
            // LTipoDocumento
            // 
            this.LTipoDocumento.AutoSize = true;
            this.LTipoDocumento.Location = new System.Drawing.Point(279, 32);
            this.LTipoDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTipoDocumento.Name = "LTipoDocumento";
            this.LTipoDocumento.Size = new System.Drawing.Size(108, 16);
            this.LTipoDocumento.TabIndex = 0;
            this.LTipoDocumento.Text = "Tipo documento:";
            // 
            // TxtFecha
            // 
            this.TxtFecha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtFecha.Location = new System.Drawing.Point(28, 52);
            this.TxtFecha.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(227, 22);
            this.TxtFecha.TabIndex = 1;
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.Location = new System.Drawing.Point(24, 32);
            this.LFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(48, 16);
            this.LFecha.TabIndex = 0;
            this.LFecha.Text = "Fecha:";
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
            this.IBLimpiar.Location = new System.Drawing.Point(887, 50);
            this.IBLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.IBLimpiar.Name = "IBLimpiar";
            this.IBLimpiar.Size = new System.Drawing.Size(55, 34);
            this.IBLimpiar.TabIndex = 8;
            this.IBLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBLimpiar.UseVisualStyleBackColor = false;
            // 
            // LDetalleVentas
            // 
            this.LDetalleVentas.AutoSize = true;
            this.LDetalleVentas.BackColor = System.Drawing.Color.White;
            this.LDetalleVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDetalleVentas.Location = new System.Drawing.Point(4, 12);
            this.LDetalleVentas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDetalleVentas.Name = "LDetalleVentas";
            this.LDetalleVentas.Size = new System.Drawing.Size(165, 29);
            this.LDetalleVentas.TabIndex = 3;
            this.LDetalleVentas.Text = "Detalle Venta";
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
            this.IBBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBBuscar.Location = new System.Drawing.Point(757, 50);
            this.IBBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.IBBuscar.Name = "IBBuscar";
            this.IBBuscar.Size = new System.Drawing.Size(121, 34);
            this.IBBuscar.TabIndex = 9;
            this.IBBuscar.Text = "Buscar";
            this.IBBuscar.UseVisualStyleBackColor = false;
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(491, 57);
            this.TxtBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(243, 22);
            this.TxtBusqueda.TabIndex = 6;
            // 
            // CBNroDocumento
            // 
            this.CBNroDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBNroDocumento.FormattingEnabled = true;
            this.CBNroDocumento.Location = new System.Drawing.Point(263, 57);
            this.CBNroDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.CBNroDocumento.Name = "CBNroDocumento";
            this.CBNroDocumento.Size = new System.Drawing.Size(193, 24);
            this.CBNroDocumento.TabIndex = 7;
            // 
            // LNroDocumentoCliente
            // 
            this.LNroDocumentoCliente.AutoSize = true;
            this.LNroDocumentoCliente.Location = new System.Drawing.Point(24, 32);
            this.LNroDocumentoCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNroDocumentoCliente.Name = "LNroDocumentoCliente";
            this.LNroDocumentoCliente.Size = new System.Drawing.Size(123, 16);
            this.LNroDocumentoCliente.TabIndex = 0;
            this.LNroDocumentoCliente.Text = "Documento Cliente:";
            // 
            // GBInformacionCliente
            // 
            this.GBInformacionCliente.Controls.Add(this.textBox4);
            this.GBInformacionCliente.Controls.Add(this.TxtNombreCliente);
            this.GBInformacionCliente.Controls.Add(this.LNombreCliente);
            this.GBInformacionCliente.Controls.Add(this.TxtNroDocumento);
            this.GBInformacionCliente.Controls.Add(this.LNroDocumentoCliente);
            this.GBInformacionCliente.Location = new System.Drawing.Point(11, 215);
            this.GBInformacionCliente.Margin = new System.Windows.Forms.Padding(4);
            this.GBInformacionCliente.Name = "GBInformacionCliente";
            this.GBInformacionCliente.Padding = new System.Windows.Forms.Padding(4);
            this.GBInformacionCliente.Size = new System.Drawing.Size(931, 98);
            this.GBInformacionCliente.TabIndex = 11;
            this.GBInformacionCliente.TabStop = false;
            this.GBInformacionCliente.Text = "Información del cliente";
            // 
            // LNuevoDocumento
            // 
            this.LNuevoDocumento.AutoSize = true;
            this.LNuevoDocumento.BackColor = System.Drawing.Color.White;
            this.LNuevoDocumento.ForeColor = System.Drawing.Color.Black;
            this.LNuevoDocumento.Location = new System.Drawing.Point(124, 60);
            this.LNuevoDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNuevoDocumento.Name = "LNuevoDocumento";
            this.LNuevoDocumento.Size = new System.Drawing.Size(120, 16);
            this.LNuevoDocumento.TabIndex = 5;
            this.LNuevoDocumento.Text = "Nuevo documento:";
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
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.MinimumWidth = 6;
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            this.PrecioCompra.Visible = false;
            this.PrecioCompra.Width = 125;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Visible = false;
            this.Stock.Width = 150;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 180;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 150;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // BDescaergarPdf
            // 
            this.BDescaergarPdf.BackColor = System.Drawing.Color.White;
            this.BDescaergarPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BDescaergarPdf.Image = global::CapaPresentacion.Properties.Resources.icons8_pdf_20;
            this.BDescaergarPdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BDescaergarPdf.Location = new System.Drawing.Point(777, 693);
            this.BDescaergarPdf.Margin = new System.Windows.Forms.Padding(4);
            this.BDescaergarPdf.Name = "BDescaergarPdf";
            this.BDescaergarPdf.Size = new System.Drawing.Size(164, 44);
            this.BDescaergarPdf.TabIndex = 2;
            this.BDescaergarPdf.Text = "Descargar PDF";
            this.BDescaergarPdf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BDescaergarPdf.UseVisualStyleBackColor = false;
            // 
            // dataGridDatos
            // 
            this.dataGridDatos.AllowUserToAddRows = false;
            this.dataGridDatos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Codigo,
            this.Nombre,
            this.Categoria,
            this.Stock,
            this.PrecioCompra,
            this.PrecioVenta});
            this.dataGridDatos.Location = new System.Drawing.Point(11, 321);
            this.dataGridDatos.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridDatos.MultiSelect = false;
            this.dataGridDatos.Name = "dataGridDatos";
            this.dataGridDatos.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridDatos.RowHeadersWidth = 51;
            this.dataGridDatos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridDatos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridDatos.RowTemplate.Height = 28;
            this.dataGridDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDatos.Size = new System.Drawing.Size(880, 363);
            this.dataGridDatos.TabIndex = 43;
            // 
            // LMontototal
            // 
            this.LMontototal.AutoSize = true;
            this.LMontototal.Location = new System.Drawing.Point(20, 708);
            this.LMontototal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LMontototal.Name = "LMontototal";
            this.LMontototal.Size = new System.Drawing.Size(81, 16);
            this.LMontototal.TabIndex = 0;
            this.LMontototal.Text = "Monto Total:";
            // 
            // panelDetalleCompra
            // 
            this.panelDetalleCompra.BackColor = System.Drawing.Color.White;
            this.panelDetalleCompra.Controls.Add(this.BDescaergarPdf);
            this.panelDetalleCompra.Controls.Add(this.dataGridDatos);
            this.panelDetalleCompra.Controls.Add(this.GBInformacionCliente);
            this.panelDetalleCompra.Controls.Add(this.LMontototal);
            this.panelDetalleCompra.Controls.Add(this.TxtMontoTotal);
            this.panelDetalleCompra.Controls.Add(this.GBInformacionCompra);
            this.panelDetalleCompra.Controls.Add(this.IBLimpiar);
            this.panelDetalleCompra.Controls.Add(this.LDetalleVentas);
            this.panelDetalleCompra.Controls.Add(this.IBBuscar);
            this.panelDetalleCompra.Controls.Add(this.TxtBusqueda);
            this.panelDetalleCompra.Controls.Add(this.LNuevoDocumento);
            this.panelDetalleCompra.Controls.Add(this.CBNroDocumento);
            this.panelDetalleCompra.Location = new System.Drawing.Point(285, 13);
            this.panelDetalleCompra.Margin = new System.Windows.Forms.Padding(4);
            this.panelDetalleCompra.Name = "panelDetalleCompra";
            this.panelDetalleCompra.Size = new System.Drawing.Size(965, 752);
            this.panelDetalleCompra.TabIndex = 1;
            // 
            // FormDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 799);
            this.Controls.Add(this.panelDetalleCompra);
            this.Name = "FormDetalleVenta";
            this.Text = "FormDetalleVenta";
            this.GBInformacionCompra.ResumeLayout(false);
            this.GBInformacionCompra.PerformLayout();
            this.GBInformacionCliente.ResumeLayout(false);
            this.GBInformacionCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatos)).EndInit();
            this.panelDetalleCompra.ResumeLayout(false);
            this.panelDetalleCompra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtMontoTotal;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox TxtNombreCliente;
        private System.Windows.Forms.Label LNombreCliente;
        private System.Windows.Forms.TextBox TxtNroDocumento;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label LUsuario;
        private System.Windows.Forms.GroupBox GBInformacionCompra;
        private System.Windows.Forms.TextBox TxtTipoDocumento;
        private System.Windows.Forms.Label LTipoDocumento;
        private System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.Label LFecha;
        private FontAwesome.Sharp.IconButton IBLimpiar;
        private System.Windows.Forms.Label LDetalleVentas;
        private FontAwesome.Sharp.IconButton IBBuscar;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.ComboBox CBNroDocumento;
        private System.Windows.Forms.Label LNroDocumentoCliente;
        private System.Windows.Forms.GroupBox GBInformacionCliente;
        private System.Windows.Forms.Label LNuevoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.Button BDescaergarPdf;
        private System.Windows.Forms.DataGridView dataGridDatos;
        private System.Windows.Forms.Label LMontototal;
        private System.Windows.Forms.Panel panelDetalleCompra;
    }
}