namespace CapaPresentacion.Modales
{
    partial class mdAcercaDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdAcercaDe));
            this.lAcercaDe = new System.Windows.Forms.Label();
            this.LDesarolladoPor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IBVolver = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lAcercaDe
            // 
            this.lAcercaDe.AutoSize = true;
            this.lAcercaDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAcercaDe.ForeColor = System.Drawing.Color.White;
            this.lAcercaDe.Location = new System.Drawing.Point(12, 21);
            this.lAcercaDe.Name = "lAcercaDe";
            this.lAcercaDe.Size = new System.Drawing.Size(206, 24);
            this.lAcercaDe.TabIndex = 1;
            this.lAcercaDe.Text = "Sombre la aplicación";
            // 
            // LDesarolladoPor
            // 
            this.LDesarolladoPor.AutoSize = true;
            this.LDesarolladoPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDesarolladoPor.ForeColor = System.Drawing.Color.White;
            this.LDesarolladoPor.Location = new System.Drawing.Point(205, 395);
            this.LDesarolladoPor.Name = "LDesarolladoPor";
            this.LDesarolladoPor.Size = new System.Drawing.Size(227, 13);
            this.LDesarolladoPor.TabIndex = 2;
            this.LDesarolladoPor.Text = "Desarollado por: Mieres, Julian - Roch, Ignacio";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 164);
            this.label2.TabIndex = 0;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 143);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 334);
            this.panel1.TabIndex = 3;
            // 
            // IBVolver
            // 
            this.IBVolver.BackColor = System.Drawing.Color.SteelBlue;
            this.IBVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBVolver.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.IBVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBVolver.ForeColor = System.Drawing.Color.White;
            this.IBVolver.IconChar = FontAwesome.Sharp.IconChar.Hands;
            this.IBVolver.IconColor = System.Drawing.Color.White;
            this.IBVolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBVolver.IconSize = 30;
            this.IBVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBVolver.Location = new System.Drawing.Point(309, 11);
            this.IBVolver.Name = "IBVolver";
            this.IBVolver.Size = new System.Drawing.Size(123, 31);
            this.IBVolver.TabIndex = 7;
            this.IBVolver.Text = "Volver";
            this.IBVolver.UseVisualStyleBackColor = false;
            this.IBVolver.Click += new System.EventHandler(this.IBVolver_Click);
            // 
            // mdAcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(444, 417);
            this.Controls.Add(this.IBVolver);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LDesarolladoPor);
            this.Controls.Add(this.lAcercaDe);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mdAcercaDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mdAcercaDe";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lAcercaDe;
        private System.Windows.Forms.Label LDesarolladoPor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton IBVolver;
    }
}