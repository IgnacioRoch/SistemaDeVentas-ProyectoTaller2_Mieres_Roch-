namespace CapaPresentacion.Administrador
{
    partial class FormProveedores
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
            this.dataGridDatos = new System.Windows.Forms.DataGridView();
            this.BSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFormulario = new System.Windows.Forms.Panel();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.IBVaciar = new FontAwesome.Sharp.IconButton();
            this.LEstado = new System.Windows.Forms.Label();
            this.IBEliminar = new FontAwesome.Sharp.IconButton();
            this.TxtSeleccionId = new System.Windows.Forms.TextBox();
            this.IBGuardar = new FontAwesome.Sharp.IconButton();
            this.LDetalleProveedor = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.LCorreo = new System.Windows.Forms.Label();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.LTelefono = new System.Windows.Forms.Label();
            this.LRazonSocial = new System.Windows.Forms.Label();
            this.TxtRazonSocial = new System.Windows.Forms.TextBox();
            this.L_NroDocumento = new System.Windows.Forms.Label();
            this.TxtDocumento = new System.Windows.Forms.TextBox();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.IBLimpiar = new FontAwesome.Sharp.IconButton();
            this.LListaProveedor = new System.Windows.Forms.Label();
            this.IBBuscar = new FontAwesome.Sharp.IconButton();
            this.CBBusqueda = new System.Windows.Forms.ComboBox();
            this.LBuscarPor = new System.Windows.Forms.Label();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatos)).BeginInit();
            this.panelFormulario.SuspendLayout();
            this.panelBusqueda.SuspendLayout();
            this.SuspendLayout();
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
            this.BSeleccionar,
            this.IdUsuario,
            this.Documento,
            this.RazonSocial,
            this.Correo,
            this.Telefono,
            this.Estado,
            this.EstadoValor});
            this.dataGridDatos.Location = new System.Drawing.Point(323, 63);
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
            this.dataGridDatos.Size = new System.Drawing.Size(932, 488);
            this.dataGridDatos.TabIndex = 37;
            // 
            // BSeleccionar
            // 
            this.BSeleccionar.HeaderText = "";
            this.BSeleccionar.MinimumWidth = 6;
            this.BSeleccionar.Name = "BSeleccionar";
            this.BSeleccionar.ReadOnly = true;
            this.BSeleccionar.Width = 30;
            // 
            // IdUsuario
            // 
            this.IdUsuario.HeaderText = "IdUsuario";
            this.IdUsuario.MinimumWidth = 6;
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.ReadOnly = true;
            this.IdUsuario.Visible = false;
            this.IdUsuario.Width = 125;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Nro. Documento";
            this.Documento.MinimumWidth = 6;
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 150;
            // 
            // RazonSocial
            // 
            this.RazonSocial.HeaderText = "Razon Social";
            this.RazonSocial.MinimumWidth = 6;
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.ReadOnly = true;
            this.RazonSocial.Width = 180;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 150;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Visible = false;
            this.Telefono.Width = 125;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 125;
            // 
            // EstadoValor
            // 
            this.EstadoValor.HeaderText = "Estado Valor";
            this.EstadoValor.MinimumWidth = 6;
            this.EstadoValor.Name = "EstadoValor";
            this.EstadoValor.ReadOnly = true;
            this.EstadoValor.Visible = false;
            this.EstadoValor.Width = 125;
            // 
            // panelFormulario
            // 
            this.panelFormulario.BackColor = System.Drawing.Color.White;
            this.panelFormulario.BackgroundImage = global::CapaPresentacion.Properties.Resources.PanelDetalle;
            this.panelFormulario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFormulario.Controls.Add(this.CBEstado);
            this.panelFormulario.Controls.Add(this.IBVaciar);
            this.panelFormulario.Controls.Add(this.LEstado);
            this.panelFormulario.Controls.Add(this.IBEliminar);
            this.panelFormulario.Controls.Add(this.TxtSeleccionId);
            this.panelFormulario.Controls.Add(this.IBGuardar);
            this.panelFormulario.Controls.Add(this.LDetalleProveedor);
            this.panelFormulario.Controls.Add(this.TxtTelefono);
            this.panelFormulario.Controls.Add(this.LCorreo);
            this.panelFormulario.Controls.Add(this.TxtCorreo);
            this.panelFormulario.Controls.Add(this.LTelefono);
            this.panelFormulario.Controls.Add(this.LRazonSocial);
            this.panelFormulario.Controls.Add(this.TxtRazonSocial);
            this.panelFormulario.Controls.Add(this.L_NroDocumento);
            this.panelFormulario.Controls.Add(this.TxtDocumento);
            this.panelFormulario.Location = new System.Drawing.Point(0, 0);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(305, 569);
            this.panelFormulario.TabIndex = 38;
            // 
            // CBEstado
            // 
            this.CBEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Location = new System.Drawing.Point(42, 263);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(240, 21);
            this.CBEstado.TabIndex = 26;
            // 
            // IBVaciar
            // 
            this.IBVaciar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.IBVaciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBVaciar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.IBVaciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBVaciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBVaciar.ForeColor = System.Drawing.Color.White;
            this.IBVaciar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.IBVaciar.IconColor = System.Drawing.Color.White;
            this.IBVaciar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBVaciar.IconSize = 16;
            this.IBVaciar.Location = new System.Drawing.Point(42, 349);
            this.IBVaciar.Name = "IBVaciar";
            this.IBVaciar.Size = new System.Drawing.Size(192, 28);
            this.IBVaciar.TabIndex = 32;
            this.IBVaciar.Text = "Limpiar";
            this.IBVaciar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBVaciar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBVaciar.UseVisualStyleBackColor = false;
            // 
            // LEstado
            // 
            this.LEstado.AutoSize = true;
            this.LEstado.BackColor = System.Drawing.Color.Transparent;
            this.LEstado.ForeColor = System.Drawing.Color.White;
            this.LEstado.Location = new System.Drawing.Point(39, 248);
            this.LEstado.Name = "LEstado";
            this.LEstado.Size = new System.Drawing.Size(43, 13);
            this.LEstado.TabIndex = 13;
            this.LEstado.Text = "Estado:";
            // 
            // IBEliminar
            // 
            this.IBEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.IBEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.IBEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBEliminar.ForeColor = System.Drawing.Color.White;
            this.IBEliminar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.IBEliminar.IconColor = System.Drawing.Color.White;
            this.IBEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBEliminar.IconSize = 16;
            this.IBEliminar.Location = new System.Drawing.Point(42, 384);
            this.IBEliminar.Name = "IBEliminar";
            this.IBEliminar.Size = new System.Drawing.Size(192, 28);
            this.IBEliminar.TabIndex = 31;
            this.IBEliminar.Text = "Eliminar";
            this.IBEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBEliminar.UseVisualStyleBackColor = false;
            // 
            // TxtSeleccionId
            // 
            this.TxtSeleccionId.Location = new System.Drawing.Point(259, 26);
            this.TxtSeleccionId.Name = "TxtSeleccionId";
            this.TxtSeleccionId.Size = new System.Drawing.Size(23, 20);
            this.TxtSeleccionId.TabIndex = 24;
            this.TxtSeleccionId.Text = "0";
            this.TxtSeleccionId.Visible = false;
            // 
            // IBGuardar
            // 
            this.IBGuardar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.IBGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.IBGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBGuardar.ForeColor = System.Drawing.Color.White;
            this.IBGuardar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.IBGuardar.IconColor = System.Drawing.Color.White;
            this.IBGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBGuardar.IconSize = 16;
            this.IBGuardar.Location = new System.Drawing.Point(42, 315);
            this.IBGuardar.Name = "IBGuardar";
            this.IBGuardar.Size = new System.Drawing.Size(192, 28);
            this.IBGuardar.TabIndex = 29;
            this.IBGuardar.Text = "Guardar";
            this.IBGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBGuardar.UseVisualStyleBackColor = false;
            // 
            // LDetalleProveedor
            // 
            this.LDetalleProveedor.AutoSize = true;
            this.LDetalleProveedor.BackColor = System.Drawing.Color.Transparent;
            this.LDetalleProveedor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDetalleProveedor.ForeColor = System.Drawing.Color.White;
            this.LDetalleProveedor.Location = new System.Drawing.Point(38, 9);
            this.LDetalleProveedor.Name = "LDetalleProveedor";
            this.LDetalleProveedor.Size = new System.Drawing.Size(170, 21);
            this.LDetalleProveedor.TabIndex = 15;
            this.LDetalleProveedor.Text = "Detalle Proveedor";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(41, 205);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(240, 20);
            this.TxtTelefono.TabIndex = 22;
            // 
            // LCorreo
            // 
            this.LCorreo.AutoSize = true;
            this.LCorreo.BackColor = System.Drawing.Color.Transparent;
            this.LCorreo.ForeColor = System.Drawing.Color.White;
            this.LCorreo.Location = new System.Drawing.Point(38, 141);
            this.LCorreo.Name = "LCorreo";
            this.LCorreo.Size = new System.Drawing.Size(93, 13);
            this.LCorreo.TabIndex = 17;
            this.LCorreo.Text = "Correo electónico:";
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(41, 157);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(240, 20);
            this.TxtCorreo.TabIndex = 21;
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.BackColor = System.Drawing.Color.Transparent;
            this.LTelefono.ForeColor = System.Drawing.Color.White;
            this.LTelefono.Location = new System.Drawing.Point(39, 188);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(52, 13);
            this.LTelefono.TabIndex = 9;
            this.LTelefono.Text = "Teléfono:";
            // 
            // LRazonSocial
            // 
            this.LRazonSocial.AutoSize = true;
            this.LRazonSocial.BackColor = System.Drawing.Color.Transparent;
            this.LRazonSocial.ForeColor = System.Drawing.Color.White;
            this.LRazonSocial.Location = new System.Drawing.Point(39, 93);
            this.LRazonSocial.Name = "LRazonSocial";
            this.LRazonSocial.Size = new System.Drawing.Size(73, 13);
            this.LRazonSocial.TabIndex = 10;
            this.LRazonSocial.Text = "Razon Social:";
            // 
            // TxtRazonSocial
            // 
            this.TxtRazonSocial.Location = new System.Drawing.Point(42, 109);
            this.TxtRazonSocial.Name = "TxtRazonSocial";
            this.TxtRazonSocial.Size = new System.Drawing.Size(240, 20);
            this.TxtRazonSocial.TabIndex = 19;
            // 
            // L_NroDocumento
            // 
            this.L_NroDocumento.AutoSize = true;
            this.L_NroDocumento.BackColor = System.Drawing.Color.Transparent;
            this.L_NroDocumento.ForeColor = System.Drawing.Color.White;
            this.L_NroDocumento.Location = new System.Drawing.Point(39, 43);
            this.L_NroDocumento.Name = "L_NroDocumento";
            this.L_NroDocumento.Size = new System.Drawing.Size(88, 13);
            this.L_NroDocumento.TabIndex = 14;
            this.L_NroDocumento.Text = "Nro. Documento:";
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.Location = new System.Drawing.Point(42, 59);
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.Size = new System.Drawing.Size(240, 20);
            this.TxtDocumento.TabIndex = 18;
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.BackColor = System.Drawing.Color.White;
            this.panelBusqueda.BackgroundImage = global::CapaPresentacion.Properties.Resources.PanelLista;
            this.panelBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBusqueda.Controls.Add(this.IBLimpiar);
            this.panelBusqueda.Controls.Add(this.LListaProveedor);
            this.panelBusqueda.Controls.Add(this.IBBuscar);
            this.panelBusqueda.Controls.Add(this.CBBusqueda);
            this.panelBusqueda.Controls.Add(this.LBuscarPor);
            this.panelBusqueda.Controls.Add(this.TxtBusqueda);
            this.panelBusqueda.Location = new System.Drawing.Point(323, 11);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(931, 47);
            this.panelBusqueda.TabIndex = 39;
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
            this.IBLimpiar.Location = new System.Drawing.Point(795, 12);
            this.IBLimpiar.Name = "IBLimpiar";
            this.IBLimpiar.Size = new System.Drawing.Size(41, 28);
            this.IBLimpiar.TabIndex = 33;
            this.IBLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBLimpiar.UseVisualStyleBackColor = false;
            // 
            // LListaProveedor
            // 
            this.LListaProveedor.AutoSize = true;
            this.LListaProveedor.BackColor = System.Drawing.Color.Transparent;
            this.LListaProveedor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LListaProveedor.ForeColor = System.Drawing.Color.White;
            this.LListaProveedor.Location = new System.Drawing.Point(3, 11);
            this.LListaProveedor.Name = "LListaProveedor";
            this.LListaProveedor.Size = new System.Drawing.Size(198, 21);
            this.LListaProveedor.TabIndex = 1;
            this.LListaProveedor.Text = "Lista de proveedores";
            this.LListaProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.IBBuscar.Location = new System.Drawing.Point(739, 12);
            this.IBBuscar.Name = "IBBuscar";
            this.IBBuscar.Size = new System.Drawing.Size(41, 28);
            this.IBBuscar.TabIndex = 30;
            this.IBBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBBuscar.UseVisualStyleBackColor = false;
            // 
            // CBBusqueda
            // 
            this.CBBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBusqueda.FormattingEnabled = true;
            this.CBBusqueda.Location = new System.Drawing.Point(361, 17);
            this.CBBusqueda.Name = "CBBusqueda";
            this.CBBusqueda.Size = new System.Drawing.Size(146, 21);
            this.CBBusqueda.TabIndex = 27;
            // 
            // LBuscarPor
            // 
            this.LBuscarPor.AutoSize = true;
            this.LBuscarPor.BackColor = System.Drawing.Color.Transparent;
            this.LBuscarPor.ForeColor = System.Drawing.Color.White;
            this.LBuscarPor.Location = new System.Drawing.Point(294, 20);
            this.LBuscarPor.Name = "LBuscarPor";
            this.LBuscarPor.Size = new System.Drawing.Size(61, 13);
            this.LBuscarPor.TabIndex = 16;
            this.LBuscarPor.Text = "Buscar por:";
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(523, 17);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(183, 20);
            this.TxtBusqueda.TabIndex = 25;
            // 
            // FormProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 572);
            this.Controls.Add(this.dataGridDatos);
            this.Controls.Add(this.panelFormulario);
            this.Controls.Add(this.panelBusqueda);
            this.Name = "FormProveedores";
            this.Text = "FormProveedores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatos)).EndInit();
            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridDatos;
        private System.Windows.Forms.ComboBox CBEstado;
        private System.Windows.Forms.Label LEstado;
        private System.Windows.Forms.Label LDetalleProveedor;
        private System.Windows.Forms.TextBox TxtSeleccionId;
        private FontAwesome.Sharp.IconButton IBGuardar;
        private FontAwesome.Sharp.IconButton IBVaciar;
        private FontAwesome.Sharp.IconButton IBEliminar;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label LCorreo;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.Label LRazonSocial;
        private System.Windows.Forms.TextBox TxtRazonSocial;
        private System.Windows.Forms.Label L_NroDocumento;
        private System.Windows.Forms.TextBox TxtDocumento;
        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.Label LListaProveedor;
        private System.Windows.Forms.Panel panelBusqueda;
        private FontAwesome.Sharp.IconButton IBLimpiar;
        private FontAwesome.Sharp.IconButton IBBuscar;
        private System.Windows.Forms.ComboBox CBBusqueda;
        private System.Windows.Forms.Label LBuscarPor;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.DataGridViewButtonColumn BSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
    }
}