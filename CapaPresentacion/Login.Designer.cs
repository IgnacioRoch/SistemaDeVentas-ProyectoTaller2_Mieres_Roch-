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
            this.TxtDocumento = new System.Windows.Forms.TextBox();
            this.LIniciarSesion = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.GBNroDoc = new System.Windows.Forms.GroupBox();
            this.GBContrasenia = new System.Windows.Forms.GroupBox();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.BIngresar = new FontAwesome.Sharp.IconButton();
            this.BCancelar = new FontAwesome.Sharp.IconButton();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelLogin.SuspendLayout();
            this.GBNroDoc.SuspendLayout();
            this.GBContrasenia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.Location = new System.Drawing.Point(6, 19);
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.Size = new System.Drawing.Size(226, 23);
            this.TxtDocumento.TabIndex = 5;
            // 
            // LIniciarSesion
            // 
            this.LIniciarSesion.AutoSize = true;
            this.LIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIniciarSesion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LIniciarSesion.Location = new System.Drawing.Point(422, 41);
            this.LIniciarSesion.Name = "LIniciarSesion";
            this.LIniciarSesion.Size = new System.Drawing.Size(118, 20);
            this.LIniciarSesion.TabIndex = 8;
            this.LIniciarSesion.Text = "Iniciar Sesión";
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelLogin.Controls.Add(this.pictureBoxLogo);
            this.panelLogin.Location = new System.Drawing.Point(-2, -1);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(322, 345);
            this.panelLogin.TabIndex = 9;
            // 
            // GBNroDoc
            // 
            this.GBNroDoc.Controls.Add(this.TxtDocumento);
            this.GBNroDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBNroDoc.Location = new System.Drawing.Point(365, 78);
            this.GBNroDoc.Name = "GBNroDoc";
            this.GBNroDoc.Size = new System.Drawing.Size(256, 54);
            this.GBNroDoc.TabIndex = 10;
            this.GBNroDoc.TabStop = false;
            this.GBNroDoc.Text = "Número Documento";
            // 
            // GBContrasenia
            // 
            this.GBContrasenia.Controls.Add(this.TxtClave);
            this.GBContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBContrasenia.Location = new System.Drawing.Point(365, 138);
            this.GBContrasenia.Name = "GBContrasenia";
            this.GBContrasenia.Size = new System.Drawing.Size(256, 54);
            this.GBContrasenia.TabIndex = 10;
            this.GBContrasenia.TabStop = false;
            this.GBContrasenia.Text = "Contraseña";
            // 
            // TxtClave
            // 
            this.TxtClave.Location = new System.Drawing.Point(6, 19);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.Size = new System.Drawing.Size(226, 23);
            this.TxtClave.TabIndex = 5;
            // 
            // BIngresar
            // 
            this.BIngresar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BIngresar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.BIngresar.IconColor = System.Drawing.Color.White;
            this.BIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BIngresar.IconSize = 21;
            this.BIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BIngresar.Location = new System.Drawing.Point(355, 217);
            this.BIngresar.Name = "BIngresar";
            this.BIngresar.Size = new System.Drawing.Size(123, 38);
            this.BIngresar.TabIndex = 7;
            this.BIngresar.Text = "Iniciar sesión";
            this.BIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BIngresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BIngresar.UseVisualStyleBackColor = false;
            this.BIngresar.Click += new System.EventHandler(this.BIngresar_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.BackColor = System.Drawing.Color.Crimson;
            this.BCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancelar.IconChar = FontAwesome.Sharp.IconChar.StopCircle;
            this.BCancelar.IconColor = System.Drawing.Color.White;
            this.BCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BCancelar.IconSize = 21;
            this.BCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCancelar.Location = new System.Drawing.Point(508, 217);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(123, 38);
            this.BCancelar.TabIndex = 7;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BCancelar.UseVisualStyleBackColor = false;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBoxLogo.Image = global::CapaPresentacion.Properties.Resources.FrameLogo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(31, 16);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(263, 262);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 289);
            this.Controls.Add(this.GBContrasenia);
            this.Controls.Add(this.GBNroDoc);
            this.Controls.Add(this.LIniciarSesion);
            this.Controls.Add(this.BIngresar);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.panelLogin);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panelLogin.ResumeLayout(false);
            this.GBNroDoc.ResumeLayout(false);
            this.GBNroDoc.PerformLayout();
            this.GBContrasenia.ResumeLayout(false);
            this.GBContrasenia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtDocumento;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private FontAwesome.Sharp.IconButton BCancelar;
        private FontAwesome.Sharp.IconButton BIngresar;
        private System.Windows.Forms.Label LIniciarSesion;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.GroupBox GBNroDoc;
        private System.Windows.Forms.GroupBox GBContrasenia;
        private System.Windows.Forms.TextBox TxtClave;
    }
}