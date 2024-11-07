namespace CapaPresentacion.Administrador
{
    partial class FormBaseDeDatos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BGenerarBackup = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CapaPresentacion.Properties.Resources._20160602w13;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.BGenerarBackup);
            this.panel1.Location = new System.Drawing.Point(177, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 478);
            this.panel1.TabIndex = 0;
            // 
            // BGenerarBackup
            // 
            this.BGenerarBackup.BackColor = System.Drawing.Color.White;
            this.BGenerarBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BGenerarBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGenerarBackup.Location = new System.Drawing.Point(263, 378);
            this.BGenerarBackup.Name = "BGenerarBackup";
            this.BGenerarBackup.Size = new System.Drawing.Size(332, 66);
            this.BGenerarBackup.TabIndex = 0;
            this.BGenerarBackup.Text = "Generar Backup de Datos";
            this.BGenerarBackup.UseVisualStyleBackColor = false;
            this.BGenerarBackup.Click += new System.EventHandler(this.BGenerarBackup_Click);
            // 
            // FormBaseDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 542);
            this.Controls.Add(this.panel1);
            this.Name = "FormBaseDeDatos";
            this.Text = "FormBaseDeDatos";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BGenerarBackup;
    }
}