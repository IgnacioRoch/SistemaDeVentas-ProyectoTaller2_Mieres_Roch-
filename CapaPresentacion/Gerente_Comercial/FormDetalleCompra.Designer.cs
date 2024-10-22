namespace CapaPresentacion.Gerente_Comercial
{
    partial class FormDetalleCompra
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
            this.panelDetalleCompra = new System.Windows.Forms.Panel();
            this.BDescaergarPdf = new System.Windows.Forms.Button();
            this.dataGridDatos = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBInformacionProveedor = new System.Windows.Forms.GroupBox();
            this.TxtNroDocumento = new System.Windows.Forms.TextBox();
            this.TxtRazonSocialProv = new System.Windows.Forms.TextBox();
            this.LRazonSocial = new System.Windows.Forms.Label();
            this.TxtNroDocumentoProv = new System.Windows.Forms.TextBox();
            this.LNroDocumento = new System.Windows.Forms.Label();
            this.LMontototal = new System.Windows.Forms.Label();
            this.TxtMontoTotal = new System.Windows.Forms.TextBox();
            this.GBInformacionCompra = new System.Windows.Forms.GroupBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.LUsuario = new System.Windows.Forms.Label();
            this.TxtTipoDocumento = new System.Windows.Forms.TextBox();
            this.LTipoDocumento = new System.Windows.Forms.Label();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.LFecha = new System.Windows.Forms.Label();
            this.IBLimpiar = new FontAwesome.Sharp.IconButton();
            this.LDetalleCompra = new System.Windows.Forms.Label();
            this.IBBuscar = new FontAwesome.Sharp.IconButton();
            this.TxtBusquedaDoc = new System.Windows.Forms.TextBox();
            this.LNuevoDocumento = new System.Windows.Forms.Label();
            this.panelDetalleCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatos)).BeginInit();
            this.GBInformacionProveedor.SuspendLayout();
            this.GBInformacionCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDetalleCompra
            // 
            this.panelDetalleCompra.BackColor = System.Drawing.Color.White;
            this.panelDetalleCompra.BackgroundImage = global::CapaPresentacion.Properties.Resources.PanelDetallesVC;
            this.panelDetalleCompra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDetalleCompra.Controls.Add(this.BDescaergarPdf);
            this.panelDetalleCompra.Controls.Add(this.dataGridDatos);
            this.panelDetalleCompra.Controls.Add(this.GBInformacionProveedor);
            this.panelDetalleCompra.Controls.Add(this.LMontototal);
            this.panelDetalleCompra.Controls.Add(this.TxtMontoTotal);
            this.panelDetalleCompra.Controls.Add(this.GBInformacionCompra);
            this.panelDetalleCompra.Controls.Add(this.IBLimpiar);
            this.panelDetalleCompra.Controls.Add(this.LDetalleCompra);
            this.panelDetalleCompra.Controls.Add(this.IBBuscar);
            this.panelDetalleCompra.Controls.Add(this.TxtBusquedaDoc);
            this.panelDetalleCompra.Controls.Add(this.LNuevoDocumento);
            this.panelDetalleCompra.Location = new System.Drawing.Point(229, 12);
            this.panelDetalleCompra.Name = "panelDetalleCompra";
            this.panelDetalleCompra.Size = new System.Drawing.Size(782, 611);
            this.panelDetalleCompra.TabIndex = 0;
            // 
            // BDescaergarPdf
            // 
            this.BDescaergarPdf.BackColor = System.Drawing.Color.White;
            this.BDescaergarPdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BDescaergarPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BDescaergarPdf.Image = global::CapaPresentacion.Properties.Resources.icons8_pdf_20;
            this.BDescaergarPdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BDescaergarPdf.Location = new System.Drawing.Point(583, 563);
            this.BDescaergarPdf.Name = "BDescaergarPdf";
            this.BDescaergarPdf.Size = new System.Drawing.Size(123, 36);
            this.BDescaergarPdf.TabIndex = 2;
            this.BDescaergarPdf.Text = "Descargar PDF";
            this.BDescaergarPdf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BDescaergarPdf.UseVisualStyleBackColor = false;
            this.BDescaergarPdf.Click += new System.EventHandler(this.BDescaergarPdf_Click);
            // 
            // dataGridDatos
            // 
            this.dataGridDatos.AllowUserToAddRows = false;
            this.dataGridDatos.BackgroundColor = System.Drawing.Color.White;
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
            this.Producto,
            this.PrecioCompra,
            this.Cantidad,
            this.SubTotal});
            this.dataGridDatos.Location = new System.Drawing.Point(8, 261);
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
            this.dataGridDatos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridDatos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridDatos.RowTemplate.Height = 28;
            this.dataGridDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDatos.Size = new System.Drawing.Size(698, 295);
            this.dataGridDatos.TabIndex = 43;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 125;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.MinimumWidth = 6;
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            this.PrecioCompra.Width = 125;
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
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 125;
            // 
            // GBInformacionProveedor
            // 
            this.GBInformacionProveedor.BackColor = System.Drawing.Color.Transparent;
            this.GBInformacionProveedor.Controls.Add(this.TxtNroDocumento);
            this.GBInformacionProveedor.Controls.Add(this.TxtRazonSocialProv);
            this.GBInformacionProveedor.Controls.Add(this.LRazonSocial);
            this.GBInformacionProveedor.Controls.Add(this.TxtNroDocumentoProv);
            this.GBInformacionProveedor.Controls.Add(this.LNroDocumento);
            this.GBInformacionProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBInformacionProveedor.ForeColor = System.Drawing.Color.White;
            this.GBInformacionProveedor.Location = new System.Drawing.Point(8, 175);
            this.GBInformacionProveedor.Name = "GBInformacionProveedor";
            this.GBInformacionProveedor.Size = new System.Drawing.Size(698, 80);
            this.GBInformacionProveedor.TabIndex = 11;
            this.GBInformacionProveedor.TabStop = false;
            this.GBInformacionProveedor.Text = "Información Proveedor";
            // 
            // TxtNroDocumento
            // 
            this.TxtNroDocumento.BackColor = System.Drawing.Color.White;
            this.TxtNroDocumento.Location = new System.Drawing.Point(635, 54);
            this.TxtNroDocumento.Name = "TxtNroDocumento";
            this.TxtNroDocumento.Size = new System.Drawing.Size(57, 20);
            this.TxtNroDocumento.TabIndex = 1;
            this.TxtNroDocumento.Visible = false;
            // 
            // TxtRazonSocialProv
            // 
            this.TxtRazonSocialProv.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtRazonSocialProv.Location = new System.Drawing.Point(212, 42);
            this.TxtRazonSocialProv.Name = "TxtRazonSocialProv";
            this.TxtRazonSocialProv.Size = new System.Drawing.Size(171, 20);
            this.TxtRazonSocialProv.TabIndex = 1;
            // 
            // LRazonSocial
            // 
            this.LRazonSocial.AutoSize = true;
            this.LRazonSocial.Location = new System.Drawing.Point(209, 26);
            this.LRazonSocial.Name = "LRazonSocial";
            this.LRazonSocial.Size = new System.Drawing.Size(84, 13);
            this.LRazonSocial.TabIndex = 0;
            this.LRazonSocial.Text = "Razón social:";
            // 
            // TxtNroDocumentoProv
            // 
            this.TxtNroDocumentoProv.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtNroDocumentoProv.Location = new System.Drawing.Point(21, 42);
            this.TxtNroDocumentoProv.Name = "TxtNroDocumentoProv";
            this.TxtNroDocumentoProv.Size = new System.Drawing.Size(171, 20);
            this.TxtNroDocumentoProv.TabIndex = 1;
            // 
            // LNroDocumento
            // 
            this.LNroDocumento.AutoSize = true;
            this.LNroDocumento.Location = new System.Drawing.Point(18, 26);
            this.LNroDocumento.Name = "LNroDocumento";
            this.LNroDocumento.Size = new System.Drawing.Size(120, 13);
            this.LNroDocumento.TabIndex = 0;
            this.LNroDocumento.Text = "Numero documento:";
            // 
            // LMontototal
            // 
            this.LMontototal.AutoSize = true;
            this.LMontototal.BackColor = System.Drawing.Color.Transparent;
            this.LMontototal.ForeColor = System.Drawing.Color.White;
            this.LMontototal.Location = new System.Drawing.Point(15, 575);
            this.LMontototal.Name = "LMontototal";
            this.LMontototal.Size = new System.Drawing.Size(67, 13);
            this.LMontototal.TabIndex = 0;
            this.LMontototal.Text = "Monto Total:";
            // 
            // TxtMontoTotal
            // 
            this.TxtMontoTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtMontoTotal.Location = new System.Drawing.Point(88, 572);
            this.TxtMontoTotal.Name = "TxtMontoTotal";
            this.TxtMontoTotal.Size = new System.Drawing.Size(66, 20);
            this.TxtMontoTotal.TabIndex = 1;
            // 
            // GBInformacionCompra
            // 
            this.GBInformacionCompra.BackColor = System.Drawing.Color.Transparent;
            this.GBInformacionCompra.Controls.Add(this.TxtUsuario);
            this.GBInformacionCompra.Controls.Add(this.LUsuario);
            this.GBInformacionCompra.Controls.Add(this.TxtTipoDocumento);
            this.GBInformacionCompra.Controls.Add(this.LTipoDocumento);
            this.GBInformacionCompra.Controls.Add(this.TxtFecha);
            this.GBInformacionCompra.Controls.Add(this.LFecha);
            this.GBInformacionCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBInformacionCompra.ForeColor = System.Drawing.Color.White;
            this.GBInformacionCompra.Location = new System.Drawing.Point(8, 89);
            this.GBInformacionCompra.Name = "GBInformacionCompra";
            this.GBInformacionCompra.Size = new System.Drawing.Size(698, 80);
            this.GBInformacionCompra.TabIndex = 10;
            this.GBInformacionCompra.TabStop = false;
            this.GBInformacionCompra.Text = "Información Compra";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtUsuario.Location = new System.Drawing.Point(418, 42);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(171, 20);
            this.TxtUsuario.TabIndex = 1;
            // 
            // LUsuario
            // 
            this.LUsuario.AutoSize = true;
            this.LUsuario.Location = new System.Drawing.Point(415, 26);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(54, 13);
            this.LUsuario.TabIndex = 0;
            this.LUsuario.Text = "Usuario:";
            // 
            // TxtTipoDocumento
            // 
            this.TxtTipoDocumento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtTipoDocumento.Location = new System.Drawing.Point(212, 42);
            this.TxtTipoDocumento.Name = "TxtTipoDocumento";
            this.TxtTipoDocumento.Size = new System.Drawing.Size(171, 20);
            this.TxtTipoDocumento.TabIndex = 1;
            // 
            // LTipoDocumento
            // 
            this.LTipoDocumento.AutoSize = true;
            this.LTipoDocumento.Location = new System.Drawing.Point(209, 26);
            this.LTipoDocumento.Name = "LTipoDocumento";
            this.LTipoDocumento.Size = new System.Drawing.Size(102, 13);
            this.LTipoDocumento.TabIndex = 0;
            this.LTipoDocumento.Text = "Tipo documento:";
            // 
            // TxtFecha
            // 
            this.TxtFecha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtFecha.Location = new System.Drawing.Point(21, 42);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(171, 20);
            this.TxtFecha.TabIndex = 1;
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.Location = new System.Drawing.Point(18, 26);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(46, 13);
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
            this.IBLimpiar.Location = new System.Drawing.Point(665, 41);
            this.IBLimpiar.Name = "IBLimpiar";
            this.IBLimpiar.Size = new System.Drawing.Size(41, 28);
            this.IBLimpiar.TabIndex = 8;
            this.IBLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBLimpiar.UseVisualStyleBackColor = false;
            this.IBLimpiar.Click += new System.EventHandler(this.IBLimpiar_Click);
            // 
            // LDetalleCompra
            // 
            this.LDetalleCompra.AutoSize = true;
            this.LDetalleCompra.BackColor = System.Drawing.Color.Transparent;
            this.LDetalleCompra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDetalleCompra.ForeColor = System.Drawing.Color.White;
            this.LDetalleCompra.Location = new System.Drawing.Point(3, 10);
            this.LDetalleCompra.Name = "LDetalleCompra";
            this.LDetalleCompra.Size = new System.Drawing.Size(162, 23);
            this.LDetalleCompra.TabIndex = 3;
            this.LDetalleCompra.Text = "Detalle Compra";
            // 
            // IBBuscar
            // 
            this.IBBuscar.BackColor = System.Drawing.Color.Gold;
            this.IBBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.IBBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBBuscar.ForeColor = System.Drawing.Color.Black;
            this.IBBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.IBBuscar.IconColor = System.Drawing.Color.Black;
            this.IBBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBBuscar.IconSize = 16;
            this.IBBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBBuscar.Location = new System.Drawing.Point(568, 41);
            this.IBBuscar.Name = "IBBuscar";
            this.IBBuscar.Size = new System.Drawing.Size(91, 28);
            this.IBBuscar.TabIndex = 9;
            this.IBBuscar.Text = "Buscar";
            this.IBBuscar.UseVisualStyleBackColor = false;
            this.IBBuscar.Click += new System.EventHandler(this.IBBuscar_Click);
            // 
            // TxtBusquedaDoc
            // 
            this.TxtBusquedaDoc.Location = new System.Drawing.Point(307, 46);
            this.TxtBusquedaDoc.Name = "TxtBusquedaDoc";
            this.TxtBusquedaDoc.Size = new System.Drawing.Size(240, 20);
            this.TxtBusquedaDoc.TabIndex = 6;
            // 
            // LNuevoDocumento
            // 
            this.LNuevoDocumento.AutoSize = true;
            this.LNuevoDocumento.BackColor = System.Drawing.Color.Transparent;
            this.LNuevoDocumento.ForeColor = System.Drawing.Color.White;
            this.LNuevoDocumento.Location = new System.Drawing.Point(203, 49);
            this.LNuevoDocumento.Name = "LNuevoDocumento";
            this.LNuevoDocumento.Size = new System.Drawing.Size(98, 13);
            this.LNuevoDocumento.TabIndex = 5;
            this.LNuevoDocumento.Text = "Nuevo documento:";
            // 
            // FormDetalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1176, 649);
            this.Controls.Add(this.panelDetalleCompra);
            this.Name = "FormDetalleCompra";
            this.Text = "FormDetalleCompra";
            this.panelDetalleCompra.ResumeLayout(false);
            this.panelDetalleCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatos)).EndInit();
            this.GBInformacionProveedor.ResumeLayout(false);
            this.GBInformacionProveedor.PerformLayout();
            this.GBInformacionCompra.ResumeLayout(false);
            this.GBInformacionCompra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDetalleCompra;
        private System.Windows.Forms.Label LDetalleCompra;
        private FontAwesome.Sharp.IconButton IBLimpiar;
        private FontAwesome.Sharp.IconButton IBBuscar;
        private System.Windows.Forms.TextBox TxtBusquedaDoc;
        private System.Windows.Forms.Label LNuevoDocumento;
        private System.Windows.Forms.GroupBox GBInformacionCompra;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label LUsuario;
        private System.Windows.Forms.TextBox TxtTipoDocumento;
        private System.Windows.Forms.Label LTipoDocumento;
        private System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.GroupBox GBInformacionProveedor;
        private System.Windows.Forms.TextBox TxtNroDocumento;
        private System.Windows.Forms.TextBox TxtRazonSocialProv;
        private System.Windows.Forms.Label LRazonSocial;
        private System.Windows.Forms.TextBox TxtNroDocumentoProv;
        private System.Windows.Forms.Label LNroDocumento;
        private System.Windows.Forms.DataGridView dataGridDatos;
        private System.Windows.Forms.Label LMontototal;
        private System.Windows.Forms.TextBox TxtMontoTotal;
        private System.Windows.Forms.Button BDescaergarPdf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
    }
}