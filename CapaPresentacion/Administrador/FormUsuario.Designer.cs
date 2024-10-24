﻿namespace CapaPresentacion.Administrador
{
    partial class FormUsuario
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuario));
            this.dataGridDatos = new System.Windows.Forms.DataGridView();
            this.BSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LListaUsuarios = new System.Windows.Forms.Label();
            this.LBuscarPor = new System.Windows.Forms.Label();
            this.CBBusqueda = new System.Windows.Forms.ComboBox();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.IBLimpiar = new FontAwesome.Sharp.IconButton();
            this.IBBuscar = new FontAwesome.Sharp.IconButton();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.TxtSeleccionId = new System.Windows.Forms.TextBox();
            this.TxtDocumento = new System.Windows.Forms.TextBox();
            this.TxtConfClave = new System.Windows.Forms.TextBox();
            this.L_NroDocumento = new System.Windows.Forms.Label();
            this.CBRol = new System.Windows.Forms.ComboBox();
            this.LEstado = new System.Windows.Forms.Label();
            this.LRol = new System.Windows.Forms.Label();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.LConfirmarContrasenia = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.LContrasenia = new System.Windows.Forms.Label();
            this.LCorreo = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LDetalleUsuario = new System.Windows.Forms.Label();
            this.panelFormulario = new System.Windows.Forms.Panel();
            this.TxtIndice = new System.Windows.Forms.TextBox();
            this.IBVaciar = new FontAwesome.Sharp.IconButton();
            this.LDireccion = new System.Windows.Forms.Label();
            this.IBEliminar = new FontAwesome.Sharp.IconButton();
            this.IBGuardar = new FontAwesome.Sharp.IconButton();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatos)).BeginInit();
            this.panelBusqueda.SuspendLayout();
            this.panelFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridDatos
            // 
            this.dataGridDatos.AllowUserToAddRows = false;
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
            this.Id,
            this.Documento,
            this.Nombre,
            this.Apellido,
            this.Correo,
            this.Direccion,
            this.Clave,
            this.IdRol,
            this.Rol,
            this.EstadoValor,
            this.Estado});
            this.dataGridDatos.Location = new System.Drawing.Point(321, 62);
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
            this.dataGridDatos.TabIndex = 5;
            this.dataGridDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDatos_CellContentClick);
            this.dataGridDatos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridDatos_CellPainting);
            // 
            // BSeleccionar
            // 
            this.BSeleccionar.HeaderText = "Editar";
            this.BSeleccionar.MinimumWidth = 6;
            this.BSeleccionar.Name = "BSeleccionar";
            this.BSeleccionar.ReadOnly = true;
            this.BSeleccionar.Width = 50;
            // 
            // Id
            // 
            this.Id.HeaderText = "IdUsuario";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Nro. Documento";
            this.Documento.MinimumWidth = 6;
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 180;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 180;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 150;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Clave";
            this.Clave.MinimumWidth = 6;
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            this.Clave.Visible = false;
            this.Clave.Width = 125;
            // 
            // IdRol
            // 
            this.IdRol.HeaderText = "IdRol";
            this.IdRol.MinimumWidth = 6;
            this.IdRol.Name = "IdRol";
            this.IdRol.ReadOnly = true;
            this.IdRol.Visible = false;
            this.IdRol.Width = 125;
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.MinimumWidth = 6;
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            this.Rol.Width = 125;
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
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 125;
            // 
            // LListaUsuarios
            // 
            this.LListaUsuarios.AutoSize = true;
            this.LListaUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.LListaUsuarios.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LListaUsuarios.ForeColor = System.Drawing.Color.White;
            this.LListaUsuarios.Location = new System.Drawing.Point(3, 11);
            this.LListaUsuarios.Name = "LListaUsuarios";
            this.LListaUsuarios.Size = new System.Drawing.Size(162, 21);
            this.LListaUsuarios.TabIndex = 1;
            this.LListaUsuarios.Text = "Lista de usuarios";
            this.LListaUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LBuscarPor
            // 
            this.LBuscarPor.AutoSize = true;
            this.LBuscarPor.BackColor = System.Drawing.Color.Transparent;
            this.LBuscarPor.ForeColor = System.Drawing.Color.White;
            this.LBuscarPor.Location = new System.Drawing.Point(290, 20);
            this.LBuscarPor.Name = "LBuscarPor";
            this.LBuscarPor.Size = new System.Drawing.Size(61, 13);
            this.LBuscarPor.TabIndex = 1;
            this.LBuscarPor.Text = "Buscar por:";
            // 
            // CBBusqueda
            // 
            this.CBBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBusqueda.FormattingEnabled = true;
            this.CBBusqueda.Location = new System.Drawing.Point(357, 17);
            this.CBBusqueda.Name = "CBBusqueda";
            this.CBBusqueda.Size = new System.Drawing.Size(146, 21);
            this.CBBusqueda.TabIndex = 3;
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(519, 17);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(183, 20);
            this.TxtBusqueda.TabIndex = 2;
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.BackColor = System.Drawing.Color.White;
            this.panelBusqueda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBusqueda.BackgroundImage")));
            this.panelBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBusqueda.Controls.Add(this.LListaUsuarios);
            this.panelBusqueda.Controls.Add(this.IBLimpiar);
            this.panelBusqueda.Controls.Add(this.IBBuscar);
            this.panelBusqueda.Controls.Add(this.LBuscarPor);
            this.panelBusqueda.Controls.Add(this.CBBusqueda);
            this.panelBusqueda.Controls.Add(this.TxtBusqueda);
            this.panelBusqueda.Location = new System.Drawing.Point(321, 9);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(931, 47);
            this.panelBusqueda.TabIndex = 7;
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
            this.IBLimpiar.Location = new System.Drawing.Point(791, 12);
            this.IBLimpiar.Name = "IBLimpiar";
            this.IBLimpiar.Size = new System.Drawing.Size(41, 28);
            this.IBLimpiar.TabIndex = 4;
            this.IBLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBLimpiar.UseVisualStyleBackColor = false;
            this.IBLimpiar.Click += new System.EventHandler(this.IBLimpiar_Click);
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
            this.IBBuscar.Location = new System.Drawing.Point(735, 12);
            this.IBBuscar.Name = "IBBuscar";
            this.IBBuscar.Size = new System.Drawing.Size(41, 28);
            this.IBBuscar.TabIndex = 4;
            this.IBBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBBuscar.UseVisualStyleBackColor = false;
            this.IBBuscar.Click += new System.EventHandler(this.IBBuscar_Click);
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(43, 146);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(240, 20);
            this.TxtApellido.TabIndex = 2;
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(43, 195);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(240, 20);
            this.TxtCorreo.TabIndex = 2;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(44, 102);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(240, 20);
            this.TxtNombre.TabIndex = 2;
            // 
            // TxtClave
            // 
            this.TxtClave.Location = new System.Drawing.Point(44, 286);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.PasswordChar = '*';
            this.TxtClave.Size = new System.Drawing.Size(240, 20);
            this.TxtClave.TabIndex = 2;
            // 
            // TxtSeleccionId
            // 
            this.TxtSeleccionId.Location = new System.Drawing.Point(261, 26);
            this.TxtSeleccionId.Name = "TxtSeleccionId";
            this.TxtSeleccionId.Size = new System.Drawing.Size(23, 20);
            this.TxtSeleccionId.TabIndex = 2;
            this.TxtSeleccionId.Text = "0";
            this.TxtSeleccionId.Visible = false;
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.Location = new System.Drawing.Point(44, 59);
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.Size = new System.Drawing.Size(240, 20);
            this.TxtDocumento.TabIndex = 2;
            // 
            // TxtConfClave
            // 
            this.TxtConfClave.Location = new System.Drawing.Point(44, 325);
            this.TxtConfClave.Name = "TxtConfClave";
            this.TxtConfClave.PasswordChar = '*';
            this.TxtConfClave.Size = new System.Drawing.Size(240, 20);
            this.TxtConfClave.TabIndex = 2;
            // 
            // L_NroDocumento
            // 
            this.L_NroDocumento.AutoSize = true;
            this.L_NroDocumento.BackColor = System.Drawing.Color.Transparent;
            this.L_NroDocumento.ForeColor = System.Drawing.Color.White;
            this.L_NroDocumento.Location = new System.Drawing.Point(41, 43);
            this.L_NroDocumento.Name = "L_NroDocumento";
            this.L_NroDocumento.Size = new System.Drawing.Size(88, 13);
            this.L_NroDocumento.TabIndex = 1;
            this.L_NroDocumento.Text = "Nro. Documento:";
            // 
            // CBRol
            // 
            this.CBRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRol.FormattingEnabled = true;
            this.CBRol.Location = new System.Drawing.Point(44, 372);
            this.CBRol.Name = "CBRol";
            this.CBRol.Size = new System.Drawing.Size(240, 21);
            this.CBRol.TabIndex = 3;
            // 
            // LEstado
            // 
            this.LEstado.AutoSize = true;
            this.LEstado.BackColor = System.Drawing.Color.Transparent;
            this.LEstado.ForeColor = System.Drawing.Color.White;
            this.LEstado.Location = new System.Drawing.Point(41, 404);
            this.LEstado.Name = "LEstado";
            this.LEstado.Size = new System.Drawing.Size(43, 13);
            this.LEstado.TabIndex = 1;
            this.LEstado.Text = "Estado:";
            // 
            // LRol
            // 
            this.LRol.AutoSize = true;
            this.LRol.BackColor = System.Drawing.Color.Transparent;
            this.LRol.ForeColor = System.Drawing.Color.White;
            this.LRol.Location = new System.Drawing.Point(41, 356);
            this.LRol.Name = "LRol";
            this.LRol.Size = new System.Drawing.Size(26, 13);
            this.LRol.TabIndex = 1;
            this.LRol.Text = "Rol:";
            // 
            // CBEstado
            // 
            this.CBEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Location = new System.Drawing.Point(44, 420);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(240, 21);
            this.CBEstado.TabIndex = 3;
            // 
            // LConfirmarContrasenia
            // 
            this.LConfirmarContrasenia.AutoSize = true;
            this.LConfirmarContrasenia.BackColor = System.Drawing.Color.Transparent;
            this.LConfirmarContrasenia.ForeColor = System.Drawing.Color.White;
            this.LConfirmarContrasenia.Location = new System.Drawing.Point(41, 309);
            this.LConfirmarContrasenia.Name = "LConfirmarContrasenia";
            this.LConfirmarContrasenia.Size = new System.Drawing.Size(110, 13);
            this.LConfirmarContrasenia.TabIndex = 1;
            this.LConfirmarContrasenia.Text = "Confirmar contraseña:";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.BackColor = System.Drawing.Color.Transparent;
            this.LNombre.ForeColor = System.Drawing.Color.White;
            this.LNombre.Location = new System.Drawing.Point(41, 86);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(47, 13);
            this.LNombre.TabIndex = 1;
            this.LNombre.Text = "Nombre:";
            // 
            // LContrasenia
            // 
            this.LContrasenia.AutoSize = true;
            this.LContrasenia.BackColor = System.Drawing.Color.Transparent;
            this.LContrasenia.ForeColor = System.Drawing.Color.White;
            this.LContrasenia.Location = new System.Drawing.Point(41, 270);
            this.LContrasenia.Name = "LContrasenia";
            this.LContrasenia.Size = new System.Drawing.Size(64, 13);
            this.LContrasenia.TabIndex = 1;
            this.LContrasenia.Text = "Contraseña:";
            // 
            // LCorreo
            // 
            this.LCorreo.AutoSize = true;
            this.LCorreo.BackColor = System.Drawing.Color.Transparent;
            this.LCorreo.ForeColor = System.Drawing.Color.White;
            this.LCorreo.Location = new System.Drawing.Point(40, 179);
            this.LCorreo.Name = "LCorreo";
            this.LCorreo.Size = new System.Drawing.Size(96, 13);
            this.LCorreo.TabIndex = 1;
            this.LCorreo.Text = "Correo electrónico:";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.BackColor = System.Drawing.Color.Transparent;
            this.LApellido.ForeColor = System.Drawing.Color.White;
            this.LApellido.Location = new System.Drawing.Point(40, 130);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(47, 13);
            this.LApellido.TabIndex = 1;
            this.LApellido.Text = "Apellido:";
            // 
            // LDetalleUsuario
            // 
            this.LDetalleUsuario.AutoSize = true;
            this.LDetalleUsuario.BackColor = System.Drawing.Color.Transparent;
            this.LDetalleUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDetalleUsuario.ForeColor = System.Drawing.Color.White;
            this.LDetalleUsuario.Location = new System.Drawing.Point(39, 9);
            this.LDetalleUsuario.Name = "LDetalleUsuario";
            this.LDetalleUsuario.Size = new System.Drawing.Size(171, 21);
            this.LDetalleUsuario.TabIndex = 1;
            this.LDetalleUsuario.Text = "Detalle de usuario";
            // 
            // panelFormulario
            // 
            this.panelFormulario.BackColor = System.Drawing.Color.White;
            this.panelFormulario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelFormulario.BackgroundImage")));
            this.panelFormulario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFormulario.Controls.Add(this.TxtIndice);
            this.panelFormulario.Controls.Add(this.LDetalleUsuario);
            this.panelFormulario.Controls.Add(this.LApellido);
            this.panelFormulario.Controls.Add(this.IBVaciar);
            this.panelFormulario.Controls.Add(this.LDireccion);
            this.panelFormulario.Controls.Add(this.LCorreo);
            this.panelFormulario.Controls.Add(this.IBEliminar);
            this.panelFormulario.Controls.Add(this.LContrasenia);
            this.panelFormulario.Controls.Add(this.LNombre);
            this.panelFormulario.Controls.Add(this.IBGuardar);
            this.panelFormulario.Controls.Add(this.LConfirmarContrasenia);
            this.panelFormulario.Controls.Add(this.CBEstado);
            this.panelFormulario.Controls.Add(this.LRol);
            this.panelFormulario.Controls.Add(this.LEstado);
            this.panelFormulario.Controls.Add(this.CBRol);
            this.panelFormulario.Controls.Add(this.L_NroDocumento);
            this.panelFormulario.Controls.Add(this.TxtConfClave);
            this.panelFormulario.Controls.Add(this.TxtDocumento);
            this.panelFormulario.Controls.Add(this.TxtSeleccionId);
            this.panelFormulario.Controls.Add(this.TxtClave);
            this.panelFormulario.Controls.Add(this.TxtNombre);
            this.panelFormulario.Controls.Add(this.TxtDireccion);
            this.panelFormulario.Controls.Add(this.TxtCorreo);
            this.panelFormulario.Controls.Add(this.TxtApellido);
            this.panelFormulario.Location = new System.Drawing.Point(0, 0);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(305, 569);
            this.panelFormulario.TabIndex = 6;
            // 
            // TxtIndice
            // 
            this.TxtIndice.Location = new System.Drawing.Point(232, 27);
            this.TxtIndice.Name = "TxtIndice";
            this.TxtIndice.Size = new System.Drawing.Size(23, 20);
            this.TxtIndice.TabIndex = 5;
            this.TxtIndice.Text = "-1";
            this.TxtIndice.Visible = false;
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
            this.IBVaciar.Location = new System.Drawing.Point(43, 520);
            this.IBVaciar.Name = "IBVaciar";
            this.IBVaciar.Size = new System.Drawing.Size(192, 28);
            this.IBVaciar.TabIndex = 4;
            this.IBVaciar.Text = "Limpiar";
            this.IBVaciar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBVaciar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBVaciar.UseVisualStyleBackColor = false;
            this.IBVaciar.Click += new System.EventHandler(this.IBVaciar_Click);
            // 
            // LDireccion
            // 
            this.LDireccion.AutoSize = true;
            this.LDireccion.BackColor = System.Drawing.Color.Transparent;
            this.LDireccion.ForeColor = System.Drawing.Color.White;
            this.LDireccion.Location = new System.Drawing.Point(41, 222);
            this.LDireccion.Name = "LDireccion";
            this.LDireccion.Size = new System.Drawing.Size(52, 13);
            this.LDireccion.TabIndex = 1;
            this.LDireccion.Text = "Dirección";
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
            this.IBEliminar.Location = new System.Drawing.Point(43, 488);
            this.IBEliminar.Name = "IBEliminar";
            this.IBEliminar.Size = new System.Drawing.Size(192, 28);
            this.IBEliminar.TabIndex = 4;
            this.IBEliminar.Text = "Eliminar";
            this.IBEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBEliminar.UseVisualStyleBackColor = false;
            this.IBEliminar.Click += new System.EventHandler(this.IBEliminar_Click);
            // 
            // IBGuardar
            // 
            this.IBGuardar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.IBGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.IBGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBGuardar.ForeColor = System.Drawing.Color.White;
            this.IBGuardar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.IBGuardar.IconColor = System.Drawing.Color.White;
            this.IBGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBGuardar.IconSize = 16;
            this.IBGuardar.Location = new System.Drawing.Point(44, 454);
            this.IBGuardar.Name = "IBGuardar";
            this.IBGuardar.Size = new System.Drawing.Size(192, 28);
            this.IBGuardar.TabIndex = 4;
            this.IBGuardar.Text = "Guardar";
            this.IBGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBGuardar.UseVisualStyleBackColor = false;
            this.IBGuardar.Click += new System.EventHandler(this.IBGuardar_Click);
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(44, 238);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(240, 20);
            this.TxtDireccion.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 569);
            this.Controls.Add(this.dataGridDatos);
            this.Controls.Add(this.panelBusqueda);
            this.Controls.Add(this.panelFormulario);
            this.Name = "FormUsuario";
            this.Text = "FormUsuario";
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatos)).EndInit();
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridDatos;
        private System.Windows.Forms.Label LListaUsuarios;
        private System.Windows.Forms.Label LBuscarPor;
        private System.Windows.Forms.ComboBox CBBusqueda;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private FontAwesome.Sharp.IconButton IBBuscar;
        private FontAwesome.Sharp.IconButton IBLimpiar;
        private System.Windows.Forms.Panel panelBusqueda;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.TextBox TxtSeleccionId;
        private System.Windows.Forms.TextBox TxtDocumento;
        private System.Windows.Forms.TextBox TxtConfClave;
        private System.Windows.Forms.Label L_NroDocumento;
        private System.Windows.Forms.ComboBox CBRol;
        private System.Windows.Forms.Label LEstado;
        private System.Windows.Forms.Label LRol;
        private System.Windows.Forms.ComboBox CBEstado;
        private System.Windows.Forms.Label LConfirmarContrasenia;
        private FontAwesome.Sharp.IconButton IBGuardar;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LContrasenia;
        private FontAwesome.Sharp.IconButton IBEliminar;
        private System.Windows.Forms.Label LCorreo;
        private FontAwesome.Sharp.IconButton IBVaciar;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LDetalleUsuario;
        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.TextBox TxtIndice;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label LDireccion;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.DataGridViewButtonColumn BSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}