using CapaEntidades;
using CapaNegocio;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Vendedor
{
    public partial class FormDetalleVenta : Form
    {
        public FormDetalleVenta()
        {
            InitializeComponent();
        }

        private void FormDetalleVenta_Load(object sender, EventArgs e)
        {
            TxtBusqueda.Select();
        }

        private void IBBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = TxtBusqueda.Text;

            if (string.IsNullOrWhiteSpace(busqueda))
            {
                MessageBox.Show("Debe Completar el campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Venta oVenta = new CN_Venta().ObtenerVenta(TxtBusqueda.Text);
            if (oVenta.Id_venta !=0)
            {
                TxtNroDocumento.Text = oVenta.NumeroDocumento;
                TxtFecha.Text = oVenta.FechaRegistro;
                TxtTipoDocumento.Text = oVenta.TipoDocumento;
                TxtUsuario.Text = oVenta.objUsuario.Nombre_usuario + " " + oVenta.objUsuario.Apellido_usuario;
                TxtNroDocCliente.Text = oVenta.DocumentoCliente;
                TxtNombreCliente.Text = oVenta.NombreCliente;
                dataGridDatos.Rows.Clear();

                foreach (Detalle_Venta dv in oVenta.objDetalleVenta)
                {
                    dataGridDatos.Rows.Add(new object[]
                    {
                       dv.objProducto.Nombre_producto ,dv.PrecioVenta ,dv.Cantidad , dv.SubTotal
                    });           
                }
                TxtMontoTotal.Text = oVenta.MontoTotal.ToString("0.00");
                TxtMontoPago.Text = oVenta.MontoPago.ToString("0.00");
                TxtMontoCambio.Text = oVenta.MontoCambio.ToString("0.00");

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
                TxtFecha.Text = "";
                TxtTipoDocumento.Text = "";
                TxtUsuario.Text = "";
                TxtNroDocCliente.Text = "";
                TxtNombreCliente.Text = "";
                TxtBusqueda.Clear();

                dataGridDatos.Rows.Clear();
                TxtMontoTotal.Text = "0.00";
                TxtMontoPago.Text = "0.00";
                TxtMontoCambio.Text = "0.00";
            }
        }

        private void BDescaergarPdf_Click(object sender, EventArgs e)
        {
            /*// Obtener los valores de los TextBox
            string fecha = TxtFecha.Text;
            string tipoDocumento = TxtTipoDocumento.Text;
            string usuario = TxtUsuario.Text;
            string nroDocumento = TxtNroDocCliente.Text;
            string nombreCliente =  TxtNombreCliente.Text;
            string montoTotal = TxtMontoTotal.Text;

            if (string.IsNullOrWhiteSpace(fecha) || string.IsNullOrWhiteSpace(tipoDocumento) || string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(nroDocumento)
               || string.IsNullOrWhiteSpace(nombreCliente) || string.IsNullOrWhiteSpace(montoTotal))
            {
                MessageBox.Show("Los campos están vacios, no puede generar el pdf.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/

            if (TxtTipoDocumento.Text == "")
            {
                MessageBox.Show("No se han encontrado los resultados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string Texto_Html = Properties.Resources.PlantillaVenta.ToString();
            Negocio oDatos = new CN_Negocio().ObtenerDatos();

            Texto_Html = Texto_Html.Replace("@nombrenegocio", oDatos.Nombre_negocio.ToUpper());
            Texto_Html = Texto_Html.Replace("@docnegocio", oDatos.RUC_negocio);
            Texto_Html = Texto_Html.Replace("@direcnegocio", oDatos.Direccion_negocio);

            Texto_Html = Texto_Html.Replace("@tipodocumento", TxtTipoDocumento.Text.ToUpper());
            Texto_Html = Texto_Html.Replace("@numerodocumento", TxtNroDocumento.Text);

            Texto_Html = Texto_Html.Replace("@doccliente", TxtNroDocCliente.Text);
            Texto_Html = Texto_Html.Replace("@nombrecliente", TxtNombreCliente.Text);
            Texto_Html = Texto_Html.Replace("@fecharegistro", TxtFecha.Text);
            Texto_Html = Texto_Html.Replace("@usuarioregistro", TxtUsuario.Text);

            string filas = string.Empty;
            foreach (DataGridViewRow row in dataGridDatos.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Precio"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            Texto_Html = Texto_Html.Replace("@filas", filas);
            Texto_Html = Texto_Html.Replace("@montototal", TxtMontoTotal.Text);
            Texto_Html = Texto_Html.Replace("@pagocon", TxtMontoPago.Text);
            Texto_Html = Texto_Html.Replace("@cambio", TxtMontoCambio.Text);

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Venta_{0}.pdf", TxtNroDocumento.Text);
            savefile.Filter = "Pdf Files | *.pdf";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    bool obtenido = true;
                    byte[] byteImagen = new CN_Negocio().ObtenerLogo(out obtenido);

                    if (obtenido)
                    {
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteImagen);
                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(pdfDoc.Left, pdfDoc.GetTop(51));
                        pdfDoc.Add(img);
                    }

                    using (StringReader sr = new StringReader(Texto_Html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Documento generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        
    }
}
