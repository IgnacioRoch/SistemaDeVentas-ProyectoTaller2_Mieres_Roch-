namespace CapaPresentacion
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.LSistemaVentas = new System.Windows.Forms.Label();
            this.LNroDni = new System.Windows.Forms.Label();
            this.TxtDocumento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.BCancelar = new FontAwesome.Sharp.IconButton();
            this.BIngresar = new FontAwesome.Sharp.IconButton();
            this.LIniciarSesion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 412);
            this.label1.TabIndex = 0;
            // 
            // LSistemaVentas
            // 
            this.LSistemaVentas.AutoSize = true;
            this.LSistemaVentas.BackColor = System.Drawing.SystemColors.Highlight;
            this.LSistemaVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSistemaVentas.Location = new System.Drawing.Point(16, 241);
            this.LSistemaVentas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LSistemaVentas.Name = "LSistemaVentas";
            this.LSistemaVentas.Size = new System.Drawing.Size(343, 36);
            this.LSistemaVentas.TabIndex = 1;
            this.LSistemaVentas.Text = "SISTEMA DE VENTAS";
            // 
            // LNroDni
            // 
            this.LNroDni.AutoSize = true;
            this.LNroDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNroDni.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LNroDni.Location = new System.Drawing.Point(460, 87);
            this.LNroDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNroDni.Name = "LNroDni";
            this.LNroDni.Size = new System.Drawing.Size(186, 20);
            this.LNroDni.TabIndex = 4;
            this.LNroDni.Text = "Número De Documento";
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.Location = new System.Drawing.Point(464, 129);
            this.TxtDocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.Size = new System.Drawing.Size(280, 22);
            this.TxtDocumento.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(460, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña";
            // 
            // TxtClave
            // 
            this.TxtClave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtClave.Location = new System.Drawing.Point(464, 190);
            this.TxtClave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.PasswordChar = '*';
            this.TxtClave.Size = new System.Drawing.Size(280, 22);
            this.TxtClave.TabIndex = 5;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBoxLogo.Image = global::CapaPresentacion.Properties.Resources.Frame_1;
            this.pictureBoxLogo.Location = new System.Drawing.Point(105, 57);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(188, 158);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // BCancelar
            // 
            this.BCancelar.BackColor = System.Drawing.Color.Crimson;
            this.BCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCancelar.IconChar = FontAwesome.Sharp.IconChar.StopCircle;
            this.BCancelar.IconColor = System.Drawing.Color.White;
            this.BCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BCancelar.IconSize = 21;
            this.BCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCancelar.Location = new System.Drawing.Point(629, 279);
            this.BCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(137, 37);
            this.BCancelar.TabIndex = 7;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BCancelar.UseVisualStyleBackColor = false;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BIngresar
            // 
            this.BIngresar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BIngresar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.BIngresar.IconColor = System.Drawing.Color.White;
            this.BIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BIngresar.IconSize = 21;
            this.BIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BIngresar.Location = new System.Drawing.Point(464, 279);
            this.BIngresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BIngresar.Name = "BIngresar";
            this.BIngresar.Size = new System.Drawing.Size(137, 37);
            this.BIngresar.TabIndex = 7;
            this.BIngresar.Text = "Iniciar sesión";
            this.BIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BIngresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BIngresar.UseVisualStyleBackColor = false;
            this.BIngresar.Click += new System.EventHandler(this.BIngresar_Click);
            // 
            // LIniciarSesion
            // 
            this.LIniciarSesion.AutoSize = true;
            this.LIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIniciarSesion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LIniciarSesion.Location = new System.Drawing.Point(524, 34);
            this.LIniciarSesion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LIniciarSesion.Name = "LIniciarSesion";
            this.LIniciarSesion.Size = new System.Drawing.Size(124, 20);
            this.LIniciarSesion.TabIndex = 8;
            this.LIniciarSesion.Text = "Iniciar Sesión";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 412);
            this.Controls.Add(this.LIniciarSesion);
            this.Controls.Add(this.BIngresar);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.TxtClave);
            this.Controls.Add(this.TxtDocumento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LNroDni);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.LSistemaVentas);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LSistemaVentas;
        private System.Windows.Forms.Label LNroDni;
        private System.Windows.Forms.TextBox TxtDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private FontAwesome.Sharp.IconButton BCancelar;
        private FontAwesome.Sharp.IconButton BIngresar;
        private System.Windows.Forms.Label LIniciarSesion;
    }
}