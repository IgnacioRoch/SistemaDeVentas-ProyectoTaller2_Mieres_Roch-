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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lAcercaDe = new System.Windows.Forms.Label();
            this.LDesarolladoPor = new System.Windows.Forms.Label();
            this.GBAcercaDe = new System.Windows.Forms.GroupBox();
            this.GBAcercaDe.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 143);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 164);
            this.label2.TabIndex = 0;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // lAcercaDe
            // 
            this.lAcercaDe.AutoSize = true;
            this.lAcercaDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAcercaDe.Location = new System.Drawing.Point(22, 21);
            this.lAcercaDe.Name = "lAcercaDe";
            this.lAcercaDe.Size = new System.Drawing.Size(128, 24);
            this.lAcercaDe.TabIndex = 1;
            this.lAcercaDe.Text = "ACERCA DE";
            // 
            // LDesarolladoPor
            // 
            this.LDesarolladoPor.AutoSize = true;
            this.LDesarolladoPor.Location = new System.Drawing.Point(205, 387);
            this.LDesarolladoPor.Name = "LDesarolladoPor";
            this.LDesarolladoPor.Size = new System.Drawing.Size(227, 13);
            this.LDesarolladoPor.TabIndex = 2;
            this.LDesarolladoPor.Text = "Desarollado por: Mieres, Julian - Roch, Ignacio";
            // 
            // GBAcercaDe
            // 
            this.GBAcercaDe.Controls.Add(this.label1);
            this.GBAcercaDe.Controls.Add(this.label2);
            this.GBAcercaDe.Location = new System.Drawing.Point(12, 48);
            this.GBAcercaDe.Name = "GBAcercaDe";
            this.GBAcercaDe.Size = new System.Drawing.Size(420, 336);
            this.GBAcercaDe.TabIndex = 3;
            this.GBAcercaDe.TabStop = false;
            // 
            // mdAcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 417);
            this.Controls.Add(this.LDesarolladoPor);
            this.Controls.Add(this.lAcercaDe);
            this.Controls.Add(this.GBAcercaDe);
            this.Name = "mdAcercaDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mdAcercaDe";
            this.GBAcercaDe.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lAcercaDe;
        private System.Windows.Forms.Label LDesarolladoPor;
        private System.Windows.Forms.GroupBox GBAcercaDe;
    }
}