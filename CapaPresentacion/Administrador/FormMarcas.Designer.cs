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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.IBBuscar = new FontAwesome.Sharp.IconButton();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.LDetalleMarca = new System.Windows.Forms.Label();
            this.LDescripcion = new System.Windows.Forms.Label();
            this.LEstado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LListaMarca = new System.Windows.Forms.Label();
            this.CBBusqueda = new System.Windows.Forms.ComboBox();
            this.IBLimpiar = new FontAwesome.Sharp.IconButton();
            this.LBuscarPor = new System.Windows.Forms.Label();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridDatos = new System.Windows.Forms.DataGridView();
            this.IBVaciar = new FontAwesome.Sharp.IconButton();
            this.IBEliminar = new FontAwesome.Sharp.IconButton();
            this.IBGuardar = new FontAwesome.Sharp.IconButton();
            this.TxtSeleccionId = new System.Windows.Forms.TextBox();
            this.panelFormulario = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatos)).BeginInit();
            this.panelFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(309, 39);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(29, 22);
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
            this.IBBuscar.Location = new System.Drawing.Point(983, 15);
            this.IBBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IBBuscar.Name = "IBBuscar";
            this.IBBuscar.Size = new System.Drawing.Size(55, 34);
            this.IBBuscar.TabIndex = 47;
            this.IBBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBBuscar.UseVisualStyleBackColor = false;
            this.IBBuscar.Click += new System.EventHandler(this.IBBuscar_Click);
            // 
            // CBEstado
            // 
            this.CBEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Location = new System.Drawing.Point(59, 127);
            this.CBEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(319, 24);
            this.CBEstado.TabIndex = 45;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(59, 73);
            this.TxtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(319, 22);
            this.TxtDescripcion.TabIndex = 41;
            // 
            // LDetalleMarca
            // 
            this.LDetalleMarca.AutoSize = true;
            this.LDetalleMarca.BackColor = System.Drawing.Color.Transparent;
            this.LDetalleMarca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDetalleMarca.ForeColor = System.Drawing.Color.White;
            this.LDetalleMarca.Location = new System.Drawing.Point(52, 11);
            this.LDetalleMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDetalleMarca.Name = "LDetalleMarca";
            this.LDetalleMarca.Size = new System.Drawing.Size(205, 26);
            this.LDetalleMarca.TabIndex = 40;
            this.LDetalleMarca.Text = "Detalle de Marcas";
            // 
            // LDescripcion
            // 
            this.LDescripcion.AutoSize = true;
            this.LDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.LDescripcion.ForeColor = System.Drawing.Color.White;
            this.LDescripcion.Location = new System.Drawing.Point(55, 53);
            this.LDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDescripcion.Name = "LDescripcion";
            this.LDescripcion.Size = new System.Drawing.Size(79, 16);
            this.LDescripcion.TabIndex = 39;
            this.LDescripcion.Text = "Descripción";
            // 
            // LEstado
            // 
            this.LEstado.AutoSize = true;
            this.LEstado.BackColor = System.Drawing.Color.Transparent;
            this.LEstado.ForeColor = System.Drawing.Color.White;
            this.LEstado.Location = new System.Drawing.Point(55, 107);
            this.LEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LEstado.Name = "LEstado";
            this.LEstado.Size = new System.Drawing.Size(53, 16);
            this.LEstado.TabIndex = 37;
            this.LEstado.Text = "Estado:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::CapaPresentacion.Properties.Resources.PanelLista;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.IBBuscar);
            this.panel1.Controls.Add(this.LListaMarca);
            this.panel1.Controls.Add(this.CBBusqueda);
            this.panel1.Controls.Add(this.IBLimpiar);
            this.panel1.Controls.Add(this.LBuscarPor);
            this.panel1.Controls.Add(this.TxtBusqueda);
            this.panel1.Location = new System.Drawing.Point(428, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 57);
            this.panel1.TabIndex = 54;
            // 
            // LListaMarca
            // 
            this.LListaMarca.AutoSize = true;
            this.LListaMarca.BackColor = System.Drawing.Color.Transparent;
            this.LListaMarca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LListaMarca.ForeColor = System.Drawing.Color.White;
            this.LListaMarca.Location = new System.Drawing.Point(4, 14);
            this.LListaMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LListaMarca.Name = "LListaMarca";
            this.LListaMarca.Size = new System.Drawing.Size(182, 26);
            this.LListaMarca.TabIndex = 14;
            this.LListaMarca.Text = "Lista de Marcas";
            this.LListaMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CBBusqueda
            // 
            this.CBBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBusqueda.FormattingEnabled = true;
            this.CBBusqueda.Location = new System.Drawing.Point(479, 21);
            this.CBBusqueda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBBusqueda.Name = "CBBusqueda";
            this.CBBusqueda.Size = new System.Drawing.Size(193, 24);
            this.CBBusqueda.TabIndex = 46;
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
            this.IBLimpiar.Location = new System.Drawing.Point(1057, 15);
            this.IBLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IBLimpiar.Name = "IBLimpiar";
            this.IBLimpiar.Size = new System.Drawing.Size(55, 34);
            this.IBLimpiar.TabIndex = 51;
            this.IBLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBLimpiar.UseVisualStyleBackColor = false;
            this.IBLimpiar.Click += new System.EventHandler(this.IBLimpiar_Click);
            // 
            // LBuscarPor
            // 
            this.LBuscarPor.AutoSize = true;
            this.LBuscarPor.BackColor = System.Drawing.Color.Transparent;
            this.LBuscarPor.ForeColor = System.Drawing.Color.White;
            this.LBuscarPor.Location = new System.Drawing.Point(389, 25);
            this.LBuscarPor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBuscarPor.Name = "LBuscarPor";
            this.LBuscarPor.Size = new System.Drawing.Size(75, 16);
            this.LBuscarPor.TabIndex = 38;
            this.LBuscarPor.Text = "Buscar por:";
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(695, 21);
            this.TxtBusqueda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(243, 22);
            this.TxtBusqueda.TabIndex = 44;
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
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 150;
            // 
            // IdUsuario
            // 
            this.IdUsuario.HeaderText = "Id";
            this.IdUsuario.MinimumWidth = 6;
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.ReadOnly = true;
            this.IdUsuario.Visible = false;
            this.IdUsuario.Width = 125;
            // 
            // BSeleccionar
            // 
            this.BSeleccionar.HeaderText = "";
            this.BSeleccionar.MinimumWidth = 6;
            this.BSeleccionar.Name = "BSeleccionar";
            this.BSeleccionar.ReadOnly = true;
            this.BSeleccionar.Width = 30;
            // 
            // dataGridDatos
            // 
            this.dataGridDatos.AllowUserToAddRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BSeleccionar,
            this.IdUsuario,
            this.Descripcion,
            this.Estado,
            this.EstadoValor});
            this.dataGridDatos.Location = new System.Drawing.Point(428, 76);
            this.dataGridDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridDatos.MultiSelect = false;
            this.dataGridDatos.Name = "dataGridDatos";
            this.dataGridDatos.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridDatos.RowHeadersWidth = 51;
            this.dataGridDatos.RowTemplate.Height = 28;
            this.dataGridDatos.Size = new System.Drawing.Size(1243, 427);
            this.dataGridDatos.TabIndex = 52;
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
            this.IBVaciar.Location = new System.Drawing.Point(59, 233);
            this.IBVaciar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IBVaciar.Name = "IBVaciar";
            this.IBVaciar.Size = new System.Drawing.Size(256, 34);
            this.IBVaciar.TabIndex = 50;
            this.IBVaciar.Text = "Limpiar";
            this.IBVaciar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBVaciar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBVaciar.UseVisualStyleBackColor = false;
            this.IBVaciar.Click += new System.EventHandler(this.IBVaciar_Click);
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
            this.IBEliminar.Location = new System.Drawing.Point(59, 274);
            this.IBEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IBEliminar.Name = "IBEliminar";
            this.IBEliminar.Size = new System.Drawing.Size(256, 34);
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
            this.IBGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBGuardar.ForeColor = System.Drawing.Color.White;
            this.IBGuardar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.IBGuardar.IconColor = System.Drawing.Color.White;
            this.IBGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBGuardar.IconSize = 16;
            this.IBGuardar.Location = new System.Drawing.Point(59, 191);
            this.IBGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IBGuardar.Name = "IBGuardar";
            this.IBGuardar.Size = new System.Drawing.Size(256, 34);
            this.IBGuardar.TabIndex = 48;
            this.IBGuardar.Text = "Guardar";
            this.IBGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBGuardar.UseVisualStyleBackColor = false;
            this.IBGuardar.Click += new System.EventHandler(this.IBGuardar_Click);
            // 
            // TxtSeleccionId
            // 
            this.TxtSeleccionId.Location = new System.Drawing.Point(348, 39);
            this.TxtSeleccionId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtSeleccionId.Name = "TxtSeleccionId";
            this.TxtSeleccionId.Size = new System.Drawing.Size(29, 22);
            this.TxtSeleccionId.TabIndex = 43;
            this.TxtSeleccionId.Text = "0";
            this.TxtSeleccionId.Visible = false;
            // 
            // panelFormulario
            // 
            this.panelFormulario.BackColor = System.Drawing.Color.White;
            this.panelFormulario.BackgroundImage = global::CapaPresentacion.Properties.Resources.PanelDetalle;
            this.panelFormulario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFormulario.Controls.Add(this.textBox1);
            this.panelFormulario.Controls.Add(this.LDetalleMarca);
            this.panelFormulario.Controls.Add(this.TxtSeleccionId);
            this.panelFormulario.Controls.Add(this.CBEstado);
            this.panelFormulario.Controls.Add(this.IBGuardar);
            this.panelFormulario.Controls.Add(this.TxtDescripcion);
            this.panelFormulario.Controls.Add(this.IBEliminar);
            this.panelFormulario.Controls.Add(this.IBVaciar);
            this.panelFormulario.Controls.Add(this.LDescripcion);
            this.panelFormulario.Controls.Add(this.LEstado);
            this.panelFormulario.Location = new System.Drawing.Point(0, 0);
            this.panelFormulario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(405, 702);
            this.panelFormulario.TabIndex = 53;
            // 
            // FormMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1687, 703);
            this.Controls.Add(this.dataGridDatos);
            this.Controls.Add(this.panelFormulario);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMarcas";
            this.Text = "FormMarcas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatos)).EndInit();
            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton IBBuscar;
        private System.Windows.Forms.ComboBox CBEstado;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label LDetalleMarca;
        private System.Windows.Forms.Label LDescripcion;
        private System.Windows.Forms.Label LEstado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LListaMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewButtonColumn BSeleccionar;
        private System.Windows.Forms.DataGridView dataGridDatos;
        private FontAwesome.Sharp.IconButton IBLimpiar;
        private FontAwesome.Sharp.IconButton IBVaciar;
        private FontAwesome.Sharp.IconButton IBEliminar;
        private FontAwesome.Sharp.IconButton IBGuardar;
        private System.Windows.Forms.ComboBox CBBusqueda;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.TextBox TxtSeleccionId;
        private System.Windows.Forms.Label LBuscarPor;
        private System.Windows.Forms.Panel panelFormulario;
    }
}