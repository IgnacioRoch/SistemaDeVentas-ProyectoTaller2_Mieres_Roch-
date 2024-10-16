﻿namespace CapaPresentacion.Administrador
{
    partial class FormNegocio
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
            this.panelFormulario = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IBGuardar = new FontAwesome.Sharp.IconButton();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtRuc = new System.Windows.Forms.TextBox();
            this.TxtNombreNegocio = new System.Windows.Forms.TextBox();
            this.LInfoNegocio = new System.Windows.Forms.Label();
            this.LNombreNegocio = new System.Windows.Forms.Label();
            this.LRUC = new System.Windows.Forms.Label();
            this.LDireccion = new System.Windows.Forms.Label();
            this.IBSubir = new FontAwesome.Sharp.IconButton();
            this.LLogo = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.LDetalleNegocio = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelFormulario.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFormulario
            // 
            this.panelFormulario.BackColor = System.Drawing.Color.White;
            this.panelFormulario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFormulario.Controls.Add(this.groupBox1);
            this.panelFormulario.Controls.Add(this.LDetalleNegocio);
            this.panelFormulario.Location = new System.Drawing.Point(215, 3);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(855, 569);
            this.panelFormulario.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.BackgroundImage = global::CapaPresentacion.Properties.Resources.PanelNegocio;
            this.groupBox1.Controls.Add(this.IBGuardar);
            this.groupBox1.Controls.Add(this.TxtDireccion);
            this.groupBox1.Controls.Add(this.TxtRuc);
            this.groupBox1.Controls.Add(this.TxtNombreNegocio);
            this.groupBox1.Controls.Add(this.LInfoNegocio);
            this.groupBox1.Controls.Add(this.LNombreNegocio);
            this.groupBox1.Controls.Add(this.LRUC);
            this.groupBox1.Controls.Add(this.LDireccion);
            this.groupBox1.Controls.Add(this.IBSubir);
            this.groupBox1.Controls.Add(this.LLogo);
            this.groupBox1.Controls.Add(this.picLogo);
            this.groupBox1.Location = new System.Drawing.Point(112, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 507);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // IBGuardar
            // 
            this.IBGuardar.BackColor = System.Drawing.Color.CadetBlue;
            this.IBGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.IBGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBGuardar.ForeColor = System.Drawing.Color.White;
            this.IBGuardar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.IBGuardar.IconColor = System.Drawing.Color.White;
            this.IBGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBGuardar.IconSize = 16;
            this.IBGuardar.Location = new System.Drawing.Point(244, 216);
            this.IBGuardar.Name = "IBGuardar";
            this.IBGuardar.Size = new System.Drawing.Size(293, 36);
            this.IBGuardar.TabIndex = 12;
            this.IBGuardar.Text = "Guardar cambios";
            this.IBGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBGuardar.UseVisualStyleBackColor = false;
            this.IBGuardar.Click += new System.EventHandler(this.IBGuardar_Click);
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(244, 151);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(293, 20);
            this.TxtDireccion.TabIndex = 9;
            // 
            // TxtRuc
            // 
            this.TxtRuc.Location = new System.Drawing.Point(244, 102);
            this.TxtRuc.Name = "TxtRuc";
            this.TxtRuc.Size = new System.Drawing.Size(293, 20);
            this.TxtRuc.TabIndex = 10;
            // 
            // TxtNombreNegocio
            // 
            this.TxtNombreNegocio.Location = new System.Drawing.Point(244, 52);
            this.TxtNombreNegocio.Name = "TxtNombreNegocio";
            this.TxtNombreNegocio.Size = new System.Drawing.Size(293, 20);
            this.TxtNombreNegocio.TabIndex = 11;
            // 
            // LInfoNegocio
            // 
            this.LInfoNegocio.BackColor = System.Drawing.Color.Transparent;
            this.LInfoNegocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LInfoNegocio.ForeColor = System.Drawing.Color.White;
            this.LInfoNegocio.Location = new System.Drawing.Point(6, 443);
            this.LInfoNegocio.Name = "LInfoNegocio";
            this.LInfoNegocio.Size = new System.Drawing.Size(613, 61);
            this.LInfoNegocio.TabIndex = 6;
            this.LInfoNegocio.Text = "El siguiente apartado modifica la información del negocio, la cual figurará en co" +
    "mprobantes  y/o tickets.";
            // 
            // LNombreNegocio
            // 
            this.LNombreNegocio.AutoSize = true;
            this.LNombreNegocio.BackColor = System.Drawing.Color.Transparent;
            this.LNombreNegocio.ForeColor = System.Drawing.Color.White;
            this.LNombreNegocio.Location = new System.Drawing.Point(241, 36);
            this.LNombreNegocio.Name = "LNombreNegocio";
            this.LNombreNegocio.Size = new System.Drawing.Size(107, 13);
            this.LNombreNegocio.TabIndex = 6;
            this.LNombreNegocio.Text = "Nombre del Negocio:";
            // 
            // LRUC
            // 
            this.LRUC.AutoSize = true;
            this.LRUC.BackColor = System.Drawing.Color.Transparent;
            this.LRUC.ForeColor = System.Drawing.Color.White;
            this.LRUC.Location = new System.Drawing.Point(241, 86);
            this.LRUC.Name = "LRUC";
            this.LRUC.Size = new System.Drawing.Size(33, 13);
            this.LRUC.TabIndex = 7;
            this.LRUC.Text = "RUC:";
            // 
            // LDireccion
            // 
            this.LDireccion.AutoSize = true;
            this.LDireccion.BackColor = System.Drawing.Color.Transparent;
            this.LDireccion.ForeColor = System.Drawing.Color.White;
            this.LDireccion.Location = new System.Drawing.Point(241, 135);
            this.LDireccion.Name = "LDireccion";
            this.LDireccion.Size = new System.Drawing.Size(55, 13);
            this.LDireccion.TabIndex = 8;
            this.LDireccion.Text = "Dirección:";
            // 
            // IBSubir
            // 
            this.IBSubir.BackColor = System.Drawing.Color.SteelBlue;
            this.IBSubir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBSubir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.IBSubir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBSubir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBSubir.ForeColor = System.Drawing.Color.White;
            this.IBSubir.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.IBSubir.IconColor = System.Drawing.Color.White;
            this.IBSubir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBSubir.IconSize = 16;
            this.IBSubir.Location = new System.Drawing.Point(17, 216);
            this.IBSubir.Name = "IBSubir";
            this.IBSubir.Size = new System.Drawing.Size(194, 36);
            this.IBSubir.TabIndex = 5;
            this.IBSubir.Text = "Subir";
            this.IBSubir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IBSubir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBSubir.UseVisualStyleBackColor = false;
            this.IBSubir.Click += new System.EventHandler(this.IBSubir_Click);
            // 
            // LLogo
            // 
            this.LLogo.AutoSize = true;
            this.LLogo.BackColor = System.Drawing.Color.Transparent;
            this.LLogo.ForeColor = System.Drawing.Color.White;
            this.LLogo.Location = new System.Drawing.Point(14, 16);
            this.LLogo.Name = "LLogo";
            this.LLogo.Size = new System.Drawing.Size(34, 13);
            this.LLogo.TabIndex = 1;
            this.LLogo.Text = "Logo:";
            // 
            // picLogo
            // 
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Location = new System.Drawing.Point(17, 36);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(194, 174);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // LDetalleNegocio
            // 
            this.LDetalleNegocio.AutoSize = true;
            this.LDetalleNegocio.BackColor = System.Drawing.Color.White;
            this.LDetalleNegocio.Font = new System.Drawing.Font("OCR A Extended", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDetalleNegocio.Location = new System.Drawing.Point(270, 4);
            this.LDetalleNegocio.Name = "LDetalleNegocio";
            this.LDetalleNegocio.Size = new System.Drawing.Size(257, 23);
            this.LDetalleNegocio.TabIndex = 2;
            this.LDetalleNegocio.Text = "Detalle del Negocio";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormNegocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 575);
            this.Controls.Add(this.panelFormulario);
            this.Name = "FormNegocio";
            this.Text = "FormNegocio";
            this.Load += new System.EventHandler(this.FormNegocio_Load);
            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label LDetalleNegocio;
        private FontAwesome.Sharp.IconButton IBSubir;
        private FontAwesome.Sharp.IconButton IBGuardar;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtRuc;
        private System.Windows.Forms.TextBox TxtNombreNegocio;
        private System.Windows.Forms.Label LNombreNegocio;
        private System.Windows.Forms.Label LRUC;
        private System.Windows.Forms.Label LDireccion;
        private System.Windows.Forms.Label LInfoNegocio;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}