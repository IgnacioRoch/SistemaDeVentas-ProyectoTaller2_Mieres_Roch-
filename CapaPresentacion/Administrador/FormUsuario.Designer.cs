namespace CapaPresentacion.Administrador
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.L_NroDocumento = new System.Windows.Forms.Label();
            this.TxtDocumento = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.LCorreo = new System.Windows.Forms.Label();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.LContrasenia = new System.Windows.Forms.Label();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.LConfirmarContrasenia = new System.Windows.Forms.Label();
            this.TxtConfClave = new System.Windows.Forms.TextBox();
            this.CBRol = new System.Windows.Forms.ComboBox();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.LRol = new System.Windows.Forms.Label();
            this.LEstado = new System.Windows.Forms.Label();
            this.IBGuardar = new FontAwesome.Sharp.IconButton();
            this.IBEditar = new FontAwesome.Sharp.IconButton();
            this.IBEliminar = new FontAwesome.Sharp.IconButton();
            this.LDetalleUsuario = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LListaUsuarios = new System.Windows.Forms.Label();
            this.BSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtSeleccionId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 569);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.BackColor = System.Drawing.Color.White;
            this.LApellido.Location = new System.Drawing.Point(41, 142);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(47, 13);
            this.LApellido.TabIndex = 1;
            this.LApellido.Text = "Apellido:";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.BackColor = System.Drawing.Color.White;
            this.LNombre.Location = new System.Drawing.Point(41, 93);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(47, 13);
            this.LNombre.TabIndex = 1;
            this.LNombre.Text = "Nombre:";
            // 
            // L_NroDocumento
            // 
            this.L_NroDocumento.AutoSize = true;
            this.L_NroDocumento.BackColor = System.Drawing.Color.White;
            this.L_NroDocumento.Location = new System.Drawing.Point(41, 43);
            this.L_NroDocumento.Name = "L_NroDocumento";
            this.L_NroDocumento.Size = new System.Drawing.Size(88, 13);
            this.L_NroDocumento.TabIndex = 1;
            this.L_NroDocumento.Text = "Nro. Documento:";
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.Location = new System.Drawing.Point(44, 59);
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.Size = new System.Drawing.Size(240, 20);
            this.TxtDocumento.TabIndex = 2;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(44, 109);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(240, 20);
            this.TxtNombre.TabIndex = 2;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(44, 158);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(240, 20);
            this.TxtApellido.TabIndex = 2;
            // 
            // LCorreo
            // 
            this.LCorreo.AutoSize = true;
            this.LCorreo.BackColor = System.Drawing.Color.White;
            this.LCorreo.Location = new System.Drawing.Point(41, 191);
            this.LCorreo.Name = "LCorreo";
            this.LCorreo.Size = new System.Drawing.Size(93, 13);
            this.LCorreo.TabIndex = 1;
            this.LCorreo.Text = "Correo electónico:";
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(44, 207);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(240, 20);
            this.TxtCorreo.TabIndex = 2;
            // 
            // LContrasenia
            // 
            this.LContrasenia.AutoSize = true;
            this.LContrasenia.BackColor = System.Drawing.Color.White;
            this.LContrasenia.Location = new System.Drawing.Point(41, 239);
            this.LContrasenia.Name = "LContrasenia";
            this.LContrasenia.Size = new System.Drawing.Size(64, 13);
            this.LContrasenia.TabIndex = 1;
            this.LContrasenia.Text = "Contraseña:";
            // 
            // TxtClave
            // 
            this.TxtClave.Location = new System.Drawing.Point(44, 255);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.Size = new System.Drawing.Size(240, 20);
            this.TxtClave.TabIndex = 2;
            // 
            // LConfirmarContrasenia
            // 
            this.LConfirmarContrasenia.AutoSize = true;
            this.LConfirmarContrasenia.BackColor = System.Drawing.Color.White;
            this.LConfirmarContrasenia.Location = new System.Drawing.Point(41, 287);
            this.LConfirmarContrasenia.Name = "LConfirmarContrasenia";
            this.LConfirmarContrasenia.Size = new System.Drawing.Size(110, 13);
            this.LConfirmarContrasenia.TabIndex = 1;
            this.LConfirmarContrasenia.Text = "Confirmar contraseña:";
            // 
            // TxtConfClave
            // 
            this.TxtConfClave.Location = new System.Drawing.Point(44, 303);
            this.TxtConfClave.Name = "TxtConfClave";
            this.TxtConfClave.Size = new System.Drawing.Size(240, 20);
            this.TxtConfClave.TabIndex = 2;
            // 
            // CBRol
            // 
            this.CBRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRol.FormattingEnabled = true;
            this.CBRol.Location = new System.Drawing.Point(44, 354);
            this.CBRol.Name = "CBRol";
            this.CBRol.Size = new System.Drawing.Size(240, 21);
            this.CBRol.TabIndex = 3;
            // 
            // CBEstado
            // 
            this.CBEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Location = new System.Drawing.Point(44, 402);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(240, 21);
            this.CBEstado.TabIndex = 3;
            // 
            // LRol
            // 
            this.LRol.AutoSize = true;
            this.LRol.BackColor = System.Drawing.Color.White;
            this.LRol.Location = new System.Drawing.Point(41, 338);
            this.LRol.Name = "LRol";
            this.LRol.Size = new System.Drawing.Size(26, 13);
            this.LRol.TabIndex = 1;
            this.LRol.Text = "Rol:";
            // 
            // LEstado
            // 
            this.LEstado.AutoSize = true;
            this.LEstado.BackColor = System.Drawing.Color.White;
            this.LEstado.Location = new System.Drawing.Point(41, 386);
            this.LEstado.Name = "LEstado";
            this.LEstado.Size = new System.Drawing.Size(43, 13);
            this.LEstado.TabIndex = 1;
            this.LEstado.Text = "Estado:";
            // 
            // IBGuardar
            // 
            this.IBGuardar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.IBGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.IBGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBGuardar.ForeColor = System.Drawing.Color.White;
            this.IBGuardar.IconChar = FontAwesome.Sharp.IconChar.Memory;
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
            // 
            // IBEditar
            // 
            this.IBEditar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.IBEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.IBEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBEditar.ForeColor = System.Drawing.Color.White;
            this.IBEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.IBEditar.IconColor = System.Drawing.Color.White;
            this.IBEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBEditar.IconSize = 16;
            this.IBEditar.Location = new System.Drawing.Point(44, 488);
            this.IBEditar.Name = "IBEditar";
            this.IBEditar.Size = new System.Drawing.Size(192, 28);
            this.IBEditar.TabIndex = 4;
            this.IBEditar.Text = "Editar";
            this.IBEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBEditar.UseVisualStyleBackColor = false;
            // 
            // IBEliminar
            // 
            this.IBEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.IBEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.IBEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBEliminar.ForeColor = System.Drawing.Color.White;
            this.IBEliminar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.IBEliminar.IconColor = System.Drawing.Color.White;
            this.IBEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBEliminar.IconSize = 16;
            this.IBEliminar.Location = new System.Drawing.Point(44, 522);
            this.IBEliminar.Name = "IBEliminar";
            this.IBEliminar.Size = new System.Drawing.Size(192, 28);
            this.IBEliminar.TabIndex = 4;
            this.IBEliminar.Text = "Eliminar";
            this.IBEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBEliminar.UseVisualStyleBackColor = false;
            // 
            // LDetalleUsuario
            // 
            this.LDetalleUsuario.AutoSize = true;
            this.LDetalleUsuario.BackColor = System.Drawing.Color.White;
            this.LDetalleUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDetalleUsuario.Location = new System.Drawing.Point(39, 9);
            this.LDetalleUsuario.Name = "LDetalleUsuario";
            this.LDetalleUsuario.Size = new System.Drawing.Size(168, 25);
            this.LDetalleUsuario.TabIndex = 1;
            this.LDetalleUsuario.Text = "Detalle de usuario";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BSeleccionar,
            this.IdUsuario,
            this.Documento,
            this.Nombre,
            this.Apellido,
            this.Correo,
            this.Clave,
            this.IdRol,
            this.Rol,
            this.Estado,
            this.EstadoValor});
            this.dataGridView1.Location = new System.Drawing.Point(321, 62);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(932, 488);
            this.dataGridView1.TabIndex = 5;
            // 
            // LListaUsuarios
            // 
            this.LListaUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.LListaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LListaUsuarios.ForeColor = System.Drawing.Color.White;
            this.LListaUsuarios.Location = new System.Drawing.Point(316, 17);
            this.LListaUsuarios.Name = "LListaUsuarios";
            this.LListaUsuarios.Size = new System.Drawing.Size(763, 35);
            this.LListaUsuarios.TabIndex = 1;
            this.LListaUsuarios.Text = "Lista de usuarios";
            this.LListaUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BSeleccionar
            // 
            this.BSeleccionar.HeaderText = "";
            this.BSeleccionar.Name = "BSeleccionar";
            this.BSeleccionar.ReadOnly = true;
            this.BSeleccionar.Width = 30;
            // 
            // IdUsuario
            // 
            this.IdUsuario.HeaderText = "IdUsuario";
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.ReadOnly = true;
            this.IdUsuario.Visible = false;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Nro. Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 180;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 180;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 150;
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Clave";
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            this.Clave.Visible = false;
            // 
            // IdRol
            // 
            this.IdRol.HeaderText = "IdRol";
            this.IdRol.Name = "IdRol";
            this.IdRol.ReadOnly = true;
            this.IdRol.Visible = false;
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // EstadoValor
            // 
            this.EstadoValor.HeaderText = "Estado Valor";
            this.EstadoValor.Name = "EstadoValor";
            this.EstadoValor.ReadOnly = true;
            this.EstadoValor.Visible = false;
            // 
            // TxtSeleccionId
            // 
            this.TxtSeleccionId.Location = new System.Drawing.Point(261, 32);
            this.TxtSeleccionId.Name = "TxtSeleccionId";
            this.TxtSeleccionId.Size = new System.Drawing.Size(23, 20);
            this.TxtSeleccionId.TabIndex = 2;
            this.TxtSeleccionId.Visible = false;
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 569);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.IBEditar);
            this.Controls.Add(this.IBEliminar);
            this.Controls.Add(this.IBGuardar);
            this.Controls.Add(this.CBEstado);
            this.Controls.Add(this.CBRol);
            this.Controls.Add(this.TxtConfClave);
            this.Controls.Add(this.TxtClave);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtSeleccionId);
            this.Controls.Add(this.TxtDocumento);
            this.Controls.Add(this.LDetalleUsuario);
            this.Controls.Add(this.LListaUsuarios);
            this.Controls.Add(this.L_NroDocumento);
            this.Controls.Add(this.LEstado);
            this.Controls.Add(this.LRol);
            this.Controls.Add(this.LConfirmarContrasenia);
            this.Controls.Add(this.LNombre);
            this.Controls.Add(this.LContrasenia);
            this.Controls.Add(this.LCorreo);
            this.Controls.Add(this.LApellido);
            this.Controls.Add(this.label1);
            this.Name = "FormUsuario";
            this.Text = "FormUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label L_NroDocumento;
        private System.Windows.Forms.TextBox TxtDocumento;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Label LCorreo;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.Label LContrasenia;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.Label LConfirmarContrasenia;
        private System.Windows.Forms.TextBox TxtConfClave;
        private System.Windows.Forms.ComboBox CBRol;
        private System.Windows.Forms.ComboBox CBEstado;
        private System.Windows.Forms.Label LRol;
        private System.Windows.Forms.Label LEstado;
        private FontAwesome.Sharp.IconButton IBGuardar;
        private FontAwesome.Sharp.IconButton IBEditar;
        private FontAwesome.Sharp.IconButton IBEliminar;
        private System.Windows.Forms.Label LDetalleUsuario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LListaUsuarios;
        private System.Windows.Forms.DataGridViewButtonColumn BSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.TextBox TxtSeleccionId;
    }
}