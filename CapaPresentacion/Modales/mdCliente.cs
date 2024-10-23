using CapaEntidades;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Modales
{
    public partial class mdCliente : Form
    {

        public Cliente _Cliente {get; set;}

        public mdCliente()
        {
            InitializeComponent();
        }

        private void IBBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = TxtBusqueda.Text;

            if (string.IsNullOrWhiteSpace(busqueda))
            {
                MessageBox.Show("Debe Completar el campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(busqueda))
            {
                MessageBox.Show("Debe Completar el campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string columnaFiltro = ((Opcion_combo)CBBusqueda.SelectedItem).Valor.ToString();

            if (dataGridDatos.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridDatos.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().ToUpper().Contains(TxtBusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;

                }
            }



        }

        private void IBLimpiar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox  
            string busqueda = TxtBusqueda.Text;


            if (string.IsNullOrWhiteSpace(busqueda)
               )
            {
                MessageBox.Show("El campo está vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("¿Limpiar el campo de busqueda?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TxtBusqueda.Clear();
                foreach (DataGridViewRow row in dataGridDatos.Rows)
                {
                    row.Visible = true;
                }
            }
        }

        private void mdCliente_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dataGridDatos.Columns)
            {
                if (columna.Visible == true)
                {
                    CBBusqueda.Items.Add(new Opcion_combo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            CBBusqueda.DisplayMember = "Texto";
            CBBusqueda.ValueMember = "Valor";
            CBBusqueda.SelectedIndex = 0;

            //MOSTRAR TODOS LOS USUARIOS
            List<Cliente> lista = new CN_Cliente().Listar();

            foreach (Cliente item in lista)
            {
                dataGridDatos.Rows.Add(new object[] {
                    item.Id_cliente,
                    item.Documento_cliente,
                    item.Nombre_cliente,
                    item.Apellido_cliente,
                    item.Correo_cliente,
                    item.Direccion_cliente,
                    item.Telefono_cliente
                 });
            }
        }

        private void dataGridDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;

            if (iRow >= 0 && iColum > 0)
            {
                _Cliente = new Cliente()
                {
                    Id_cliente = Convert.ToInt32(dataGridDatos.Rows[iRow].Cells["Id"].Value.ToString()),
                    Documento_cliente = dataGridDatos.Rows[iRow].Cells["Documento"].Value.ToString(),
                    Nombre_cliente = dataGridDatos.Rows[iRow].Cells["Nombre"].Value.ToString(),
                    Apellido_cliente = dataGridDatos.Rows[iRow].Cells["Apellido"].Value.ToString(),
                    Correo_cliente = dataGridDatos.Rows[iRow].Cells["Correo"].Value.ToString()
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


    }
}
