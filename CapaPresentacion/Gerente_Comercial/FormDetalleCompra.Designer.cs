﻿namespace CapaPresentacion.Gerente_Comercial
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelDetalleCompra = new System.Windows.Forms.Panel();
            this.BDescaergarPdf = new System.Windows.Forms.Button();
            this.dataGridDatos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBInformacionProveedor = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.TxtRazonSocial = new System.Windows.Forms.TextBox();
            this.LRazonSocial = new System.Windows.Forms.Label();
            this.TxtNroDocumento = new System.Windows.Forms.TextBox();
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
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.LNuevoDocumento = new System.Windows.Forms.Label();
            this.CBNroDocumento = new System.Windows.Forms.ComboBox();
            this.panelDetalleCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatos)).BeginInit();
            this.GBInformacionProveedor.SuspendLayout();
            this.GBInformacionCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDetalleCompra
            // 
            this.panelDetalleCompra.BackColor = System.Drawing.Color.White;
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
            this.panelDetalleCompra.Controls.Add(this.TxtBusqueda);
            this.panelDetalleCompra.Controls.Add(this.LNuevoDocumento);
            this.panelDetalleCompra.Controls.Add(this.CBNroDocumento);
            this.panelDetalleCompra.Location = new System.Drawing.Point(202, 12);
            this.panelDetalleCompra.Name = "panelDetalleCompra";
            this.panelDetalleCompra.Size = new System.Drawing.Size(782, 611);
            this.panelDetalleCompra.TabIndex = 0;
            // 
            // BDescaergarPdf
            // 
            this.BDescaergarPdf.BackColor = System.Drawing.Color.White;
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
            this.dataGridDatos.Location = new System.Drawing.Point(8, 261);
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
            this.dataGridDatos.Size = new System.Drawing.Size(660, 295);
            this.dataGridDatos.TabIndex = 43;
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
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 180;
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
            // GBInformacionProveedor
            // 
            this.GBInformacionProveedor.Controls.Add(this.textBox4);
            this.GBInformacionProveedor.Controls.Add(this.TxtRazonSocial);
            this.GBInformacionProveedor.Controls.Add(this.LRazonSocial);
            this.GBInformacionProveedor.Controls.Add(this.TxtNroDocumento);
            this.GBInformacionProveedor.Controls.Add(this.LNroDocumento);
            this.GBInformacionProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBInformacionProveedor.Location = new System.Drawing.Point(8, 175);
            this.GBInformacionProveedor.Name = "GBInformacionProveedor";
            this.GBInformacionProveedor.Size = new System.Drawing.Size(698, 80);
            this.GBInformacionProveedor.TabIndex = 11;
            this.GBInformacionProveedor.TabStop = false;
            this.GBInformacionProveedor.Text = "Información Proveedor";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(635, 54);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(57, 20);
            this.textBox4.TabIndex = 1;
            this.textBox4.Visible = false;
            // 
            // TxtRazonSocial
            // 
            this.TxtRazonSocial.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtRazonSocial.Location = new System.Drawing.Point(212, 42);
            this.TxtRazonSocial.Name = "TxtRazonSocial";
            this.TxtRazonSocial.Size = new System.Drawing.Size(171, 20);
            this.TxtRazonSocial.TabIndex = 1;
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
            // TxtNroDocumento
            // 
            this.TxtNroDocumento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtNroDocumento.Location = new System.Drawing.Point(21, 42);
            this.TxtNroDocumento.Name = "TxtNroDocumento";
            this.TxtNroDocumento.Size = new System.Drawing.Size(171, 20);
            this.TxtNroDocumento.TabIndex = 1;
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
            this.GBInformacionCompra.Controls.Add(this.TxtUsuario);
            this.GBInformacionCompra.Controls.Add(this.LUsuario);
            this.GBInformacionCompra.Controls.Add(this.TxtTipoDocumento);
            this.GBInformacionCompra.Controls.Add(this.LTipoDocumento);
            this.GBInformacionCompra.Controls.Add(this.TxtFecha);
            this.GBInformacionCompra.Controls.Add(this.LFecha);
            this.GBInformacionCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // 
            // LDetalleCompra
            // 
            this.LDetalleCompra.AutoSize = true;
            this.LDetalleCompra.BackColor = System.Drawing.Color.White;
            this.LDetalleCompra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(368, 46);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(183, 20);
            this.TxtBusqueda.TabIndex = 6;
            // 
            // LNuevoDocumento
            // 
            this.LNuevoDocumento.AutoSize = true;
            this.LNuevoDocumento.BackColor = System.Drawing.Color.White;
            this.LNuevoDocumento.ForeColor = System.Drawing.Color.Black;
            this.LNuevoDocumento.Location = new System.Drawing.Point(93, 49);
            this.LNuevoDocumento.Name = "LNuevoDocumento";
            this.LNuevoDocumento.Size = new System.Drawing.Size(98, 13);
            this.LNuevoDocumento.TabIndex = 5;
            this.LNuevoDocumento.Text = "Nuevo documento:";
            // 
            // CBNroDocumento
            // 
            this.CBNroDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBNroDocumento.FormattingEnabled = true;
            this.CBNroDocumento.Location = new System.Drawing.Point(197, 46);
            this.CBNroDocumento.Name = "CBNroDocumento";
            this.CBNroDocumento.Size = new System.Drawing.Size(146, 21);
            this.CBNroDocumento.TabIndex = 7;
            // 
            // FormDetalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1067, 649);
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
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.Label LNuevoDocumento;
        private System.Windows.Forms.ComboBox CBNroDocumento;
        private System.Windows.Forms.GroupBox GBInformacionCompra;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label LUsuario;
        private System.Windows.Forms.TextBox TxtTipoDocumento;
        private System.Windows.Forms.Label LTipoDocumento;
        private System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.GroupBox GBInformacionProveedor;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox TxtRazonSocial;
        private System.Windows.Forms.Label LRazonSocial;
        private System.Windows.Forms.TextBox TxtNroDocumento;
        private System.Windows.Forms.Label LNroDocumento;
        private System.Windows.Forms.DataGridView dataGridDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.Label LMontototal;
        private System.Windows.Forms.TextBox TxtMontoTotal;
        private System.Windows.Forms.Button BDescaergarPdf;
    }
}