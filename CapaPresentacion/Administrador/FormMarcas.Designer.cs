﻿namespace CapaPresentacion.Administrador
{
    partial class FormMarcas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.IBBuscar = new FontAwesome.Sharp.IconButton();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.TxtDocumento = new System.Windows.Forms.TextBox();
            this.LDetalleUsuario = new System.Windows.Forms.Label();
            this.LDescripcion = new System.Windows.Forms.Label();
            this.LEstado = new System.Windows.Forms.Label();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IBEditar = new FontAwesome.Sharp.IconButton();
            this.IBEliminar = new FontAwesome.Sharp.IconButton();
            this.IBGuardar = new FontAwesome.Sharp.IconButton();
            this.CBBusqueda = new System.Windows.Forms.ComboBox();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.TxtSeleccionId = new System.Windows.Forms.TextBox();
            this.LBuscarPor = new System.Windows.Forms.Label();
            this.dataGridDatos = new System.Windows.Forms.DataGridView();
            this.BSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LListaUsuarios = new System.Windows.Forms.Label();
            this.IBLimpiar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(230, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(23, 20);
            this.textBox1.TabIndex = 42;
            this.textBox1.Text = "0";
            this.textBox1.Visible = false;
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
            this.IBBuscar.Location = new System.Drawing.Point(1065, 21);
            this.IBBuscar.Name = "IBBuscar";
            this.IBBuscar.Size = new System.Drawing.Size(41, 28);
            this.IBBuscar.TabIndex = 47;
            this.IBBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBBuscar.UseVisualStyleBackColor = false;
            // 
            // CBEstado
            // 
            this.CBEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Location = new System.Drawing.Point(42, 103);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(240, 21);
            this.CBEstado.TabIndex = 45;
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.Location = new System.Drawing.Point(42, 59);
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.Size = new System.Drawing.Size(240, 20);
            this.TxtDocumento.TabIndex = 41;
            // 
            // LDetalleUsuario
            // 
            this.LDetalleUsuario.AutoSize = true;
            this.LDetalleUsuario.BackColor = System.Drawing.Color.White;
            this.LDetalleUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDetalleUsuario.Location = new System.Drawing.Point(37, 9);
            this.LDetalleUsuario.Name = "LDetalleUsuario";
            this.LDetalleUsuario.Size = new System.Drawing.Size(168, 25);
            this.LDetalleUsuario.TabIndex = 40;
            this.LDetalleUsuario.Text = "Detalle de marcas";
            // 
            // LDescripcion
            // 
            this.LDescripcion.AutoSize = true;
            this.LDescripcion.BackColor = System.Drawing.Color.White;
            this.LDescripcion.Location = new System.Drawing.Point(39, 43);
            this.LDescripcion.Name = "LDescripcion";
            this.LDescripcion.Size = new System.Drawing.Size(63, 13);
            this.LDescripcion.TabIndex = 39;
            this.LDescripcion.Text = "Descripción";
            // 
            // LEstado
            // 
            this.LEstado.AutoSize = true;
            this.LEstado.BackColor = System.Drawing.Color.White;
            this.LEstado.Location = new System.Drawing.Point(39, 87);
            this.LEstado.Name = "LEstado";
            this.LEstado.Size = new System.Drawing.Size(43, 13);
            this.LEstado.TabIndex = 36;
            this.LEstado.Text = "Estado:";
            // 
            // EstadoValor
            // 
            this.EstadoValor.HeaderText = "Estado Valor";
            this.EstadoValor.Name = "EstadoValor";
            this.EstadoValor.ReadOnly = true;
            this.EstadoValor.Visible = false;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 150;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 571);
            this.label1.TabIndex = 35;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IdUsuario
            // 
            this.IdUsuario.HeaderText = "Id";
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.ReadOnly = true;
            this.IdUsuario.Visible = false;
            // 
            // IBEditar
            // 
            this.IBEditar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.IBEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBEditar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.IBEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBEditar.ForeColor = System.Drawing.Color.White;
            this.IBEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.IBEditar.IconColor = System.Drawing.Color.White;
            this.IBEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBEditar.IconSize = 16;
            this.IBEditar.Location = new System.Drawing.Point(42, 189);
            this.IBEditar.Name = "IBEditar";
            this.IBEditar.Size = new System.Drawing.Size(192, 28);
            this.IBEditar.TabIndex = 50;
            this.IBEditar.Text = "Editar";
            this.IBEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBEditar.UseVisualStyleBackColor = false;
            // 
            // IBEliminar
            // 
            this.IBEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.IBEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.IBEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBEliminar.ForeColor = System.Drawing.Color.White;
            this.IBEliminar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.IBEliminar.IconColor = System.Drawing.Color.White;
            this.IBEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBEliminar.IconSize = 16;
            this.IBEliminar.Location = new System.Drawing.Point(42, 223);
            this.IBEliminar.Name = "IBEliminar";
            this.IBEliminar.Size = new System.Drawing.Size(192, 28);
            this.IBEliminar.TabIndex = 49;
            this.IBEliminar.Text = "Eliminar";
            this.IBEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBEliminar.UseVisualStyleBackColor = false;
            // 
            // IBGuardar
            // 
            this.IBGuardar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.IBGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.IBGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBGuardar.ForeColor = System.Drawing.Color.White;
            this.IBGuardar.IconChar = FontAwesome.Sharp.IconChar.Memory;
            this.IBGuardar.IconColor = System.Drawing.Color.White;
            this.IBGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBGuardar.IconSize = 16;
            this.IBGuardar.Location = new System.Drawing.Point(42, 155);
            this.IBGuardar.Name = "IBGuardar";
            this.IBGuardar.Size = new System.Drawing.Size(192, 28);
            this.IBGuardar.TabIndex = 48;
            this.IBGuardar.Text = "Guardar";
            this.IBGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBGuardar.UseVisualStyleBackColor = false;
            // 
            // CBBusqueda
            // 
            this.CBBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBusqueda.FormattingEnabled = true;
            this.CBBusqueda.Location = new System.Drawing.Point(687, 26);
            this.CBBusqueda.Name = "CBBusqueda";
            this.CBBusqueda.Size = new System.Drawing.Size(146, 21);
            this.CBBusqueda.TabIndex = 46;
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(849, 26);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(183, 20);
            this.TxtBusqueda.TabIndex = 44;
            // 
            // TxtSeleccionId
            // 
            this.TxtSeleccionId.Location = new System.Drawing.Point(259, 32);
            this.TxtSeleccionId.Name = "TxtSeleccionId";
            this.TxtSeleccionId.Size = new System.Drawing.Size(23, 20);
            this.TxtSeleccionId.TabIndex = 43;
            this.TxtSeleccionId.Text = "0";
            this.TxtSeleccionId.Visible = false;
            // 
            // LBuscarPor
            // 
            this.LBuscarPor.AutoSize = true;
            this.LBuscarPor.BackColor = System.Drawing.Color.White;
            this.LBuscarPor.ForeColor = System.Drawing.Color.Black;
            this.LBuscarPor.Location = new System.Drawing.Point(620, 29);
            this.LBuscarPor.Name = "LBuscarPor";
            this.LBuscarPor.Size = new System.Drawing.Size(61, 13);
            this.LBuscarPor.TabIndex = 37;
            this.LBuscarPor.Text = "Buscar por:";
            // 
            // dataGridDatos
            // 
            this.dataGridDatos.AllowUserToAddRows = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BSeleccionar,
            this.IdUsuario,
            this.Descripcion,
            this.Estado,
            this.EstadoValor});
            this.dataGridDatos.Location = new System.Drawing.Point(322, 62);
            this.dataGridDatos.MultiSelect = false;
            this.dataGridDatos.Name = "dataGridDatos";
            this.dataGridDatos.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridDatos.RowTemplate.Height = 28;
            this.dataGridDatos.Size = new System.Drawing.Size(932, 347);
            this.dataGridDatos.TabIndex = 52;
            // 
            // BSeleccionar
            // 
            this.BSeleccionar.HeaderText = "";
            this.BSeleccionar.Name = "BSeleccionar";
            this.BSeleccionar.ReadOnly = true;
            this.BSeleccionar.Width = 30;
            // 
            // LListaUsuarios
            // 
            this.LListaUsuarios.BackColor = System.Drawing.Color.White;
            this.LListaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LListaUsuarios.ForeColor = System.Drawing.Color.Black;
            this.LListaUsuarios.Location = new System.Drawing.Point(322, 9);
            this.LListaUsuarios.Name = "LListaUsuarios";
            this.LListaUsuarios.Size = new System.Drawing.Size(931, 47);
            this.LListaUsuarios.TabIndex = 38;
            this.LListaUsuarios.Text = "Lista de marcas";
            this.LListaUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IBLimpiar
            // 
            this.IBLimpiar.BackColor = System.Drawing.Color.White;
            this.IBLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.IBLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBLimpiar.ForeColor = System.Drawing.Color.Black;
            this.IBLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.IBLimpiar.IconColor = System.Drawing.Color.Black;
            this.IBLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBLimpiar.IconSize = 16;
            this.IBLimpiar.Location = new System.Drawing.Point(1121, 21);
            this.IBLimpiar.Name = "IBLimpiar";
            this.IBLimpiar.Size = new System.Drawing.Size(41, 28);
            this.IBLimpiar.TabIndex = 51;
            this.IBLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBLimpiar.UseVisualStyleBackColor = false;
            // 
            // FormMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 571);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.IBBuscar);
            this.Controls.Add(this.CBEstado);
            this.Controls.Add(this.TxtDocumento);
            this.Controls.Add(this.LDetalleUsuario);
            this.Controls.Add(this.LDescripcion);
            this.Controls.Add(this.LEstado);
            this.Controls.Add(this.IBEditar);
            this.Controls.Add(this.IBEliminar);
            this.Controls.Add(this.IBGuardar);
            this.Controls.Add(this.CBBusqueda);
            this.Controls.Add(this.TxtBusqueda);
            this.Controls.Add(this.TxtSeleccionId);
            this.Controls.Add(this.LBuscarPor);
            this.Controls.Add(this.dataGridDatos);
            this.Controls.Add(this.LListaUsuarios);
            this.Controls.Add(this.IBLimpiar);
            this.Controls.Add(this.label1);
            this.Name = "FormMarcas";
            this.Text = "FormMarcas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton IBBuscar;
        private System.Windows.Forms.ComboBox CBEstado;
        private System.Windows.Forms.TextBox TxtDocumento;
        private System.Windows.Forms.Label LDetalleUsuario;
        private System.Windows.Forms.Label LDescripcion;
        private System.Windows.Forms.Label LEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private FontAwesome.Sharp.IconButton IBEditar;
        private FontAwesome.Sharp.IconButton IBEliminar;
        private FontAwesome.Sharp.IconButton IBGuardar;
        private System.Windows.Forms.ComboBox CBBusqueda;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.TextBox TxtSeleccionId;
        private System.Windows.Forms.Label LBuscarPor;
        private System.Windows.Forms.DataGridView dataGridDatos;
        private System.Windows.Forms.DataGridViewButtonColumn BSeleccionar;
        private System.Windows.Forms.Label LListaUsuarios;
        private FontAwesome.Sharp.IconButton IBLimpiar;
    }
}