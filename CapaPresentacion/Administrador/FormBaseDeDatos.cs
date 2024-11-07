using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Administrador
{
    public partial class FormBaseDeDatos : Form
    {
        public FormBaseDeDatos()
        {
            InitializeComponent();
        }

        private void BGenerarBackup_Click(object sender, EventArgs e)
        {
            // Configurar el SaveFileDialog para que el usuario elija la ubicación y el nombre del archivo de backup
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de Backup (*.bak)|*.bak"; // Filtrar para que solo se elijan archivos .bak
            saveFileDialog.Title = "Seleccionar ubicación para guardar el backup";
            saveFileDialog.FileName = "BackUpDatos.bak"; // Nombre predeterminado del archivo

            // Mostrar el cuadro de diálogo
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string backupPath = saveFileDialog.FileName; // Ruta donde el usuario desea guardar el archivo de backup
                string connectionString = "Data Source=DESKTOP-T4VL56Q\\SQLEXPRESS;Initial Catalog=DBSITEMA_VENTA;Integrated Security=True"; // Ajusta según tu configuración
                string backupCommand = $"BACKUP DATABASE DBSITEMA_VENTA TO DISK = '{backupPath}'"; // Comando SQL para el backup

                try
                {
                    // Conexión a la base de datos
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Crear el comando de backup
                        using (SqlCommand command = new SqlCommand(backupCommand, connection))
                        {
                            // Ejecutar el comando
                            command.ExecuteNonQuery();
                            MessageBox.Show($"Backup generado exitosamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Mostrar error en caso de fallar
                    MessageBox.Show($"Error al generar el backup: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Si el usuario cancela la acción
                MessageBox.Show($"Operación cancelada. No se ha generado el backup.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
