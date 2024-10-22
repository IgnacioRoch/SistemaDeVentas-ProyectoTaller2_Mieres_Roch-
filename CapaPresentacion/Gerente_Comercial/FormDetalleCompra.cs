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
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Gerente_Comercial
{
    public partial class FormDetalleCompra : Form
    {
        public FormDetalleCompra()
        {
            InitializeComponent();
        }

        private void IBBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = TxtBusquedaDoc.Text;

            if (string.IsNullOrWhiteSpace(busqueda))
            {
                MessageBox.Show("Debe Completar el campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Compra oCompra = new CN_Compra().ObtenerCompra(TxtBusquedaDoc.Text);
            if (oCompra.Id_compra != 0)
            {
                TxtNroDocumento.Text = oCompra.NumeroDocumento_compra;

                TxtFecha.Text = oCompra.FechaRegistro_compra;
                TxtTipoDocumento.Text = oCompra.TipoDocumento_compra;
                TxtUsuario.Text = oCompra.objUsuario.Nombre_usuario + " " + oCompra.objUsuario.Apellido_usuario;
                TxtNroDocumentoProv.Text = oCompra.objProveedor.Documento_proveedor;
                TxtRazonSocialProv.Text = oCompra.objProveedor.RazonSocial_proveedor;

                dataGridDatos.Rows.Clear();
                foreach (Detalle_Compra dc in oCompra.objDetalleCompra)
                {
                    dataGridDatos.Rows.Add(new object[]
                    {
                        dc.oProducto.Nombre_producto, dc.PrecioCompra, dc.Cantidad, dc.MontoTotal
                    });
                }
                TxtMontoTotal.Text = oCompra.MontoTotal_compra.ToString("0.00");
            }
            else
            {
                MessageBox.Show("No existe el numero de compra solicitada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IBLimpiar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox  
            string busqueda = TxtBusquedaDoc.Text;


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
                TxtNroDocumentoProv.Text = "";
                TxtRazonSocialProv.Text = "";
                TxtBusquedaDoc.Clear();

                dataGridDatos.Rows.Clear();
                TxtMontoTotal.Text = "0.00";
            }
        }

        private void BDescaergarPdf_Click(object sender, EventArgs e)
        {
            /*// Obtener los valores de los TextBox
            string fecha = TxtFecha.Text;
            string tipoDocumento = TxtTipoDocumento.Text;
            string usuario = TxtUsuario.Text;
            string nroDocumento = TxtNroDocumentoProv.Text;
            string montoTotal = TxtMontoTotal.Text;
            string razonSocial = TxtRazonSocialProv.Text;

            if (string.IsNullOrWhiteSpace(fecha) || string.IsNullOrWhiteSpace(tipoDocumento) || string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(nroDocumento)
               || string.IsNullOrWhiteSpace(montoTotal) || string.IsNullOrWhiteSpace(razonSocial) || string.IsNullOrWhiteSpace(montoTotal))
            {
                MessageBox.Show("Los campos están vacios, no puede generar el pdf.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/

            if (TxtTipoDocumento.Text == "")
            {
                MessageBox.Show("No se han encontrado los resultados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string Texto_Html = Properties.Resources.PlantillaCompra.ToString();
            Negocio oDatos = new CN_Negocio().ObtenerDatos();

            Texto_Html = Texto_Html.Replace("@nombrenegocio", oDatos.Nombre_negocio.ToUpper());
            Texto_Html = Texto_Html.Replace("@docnegocio", oDatos.RUC_negocio);
            Texto_Html = Texto_Html.Replace("@direcnegocio", oDatos.Direccion_negocio);

            Texto_Html = Texto_Html.Replace("@tipodocumento", TxtTipoDocumento.Text.ToUpper());
            Texto_Html = Texto_Html.Replace("@numerodocumento", TxtNroDocumento.Text);

            Texto_Html = Texto_Html.Replace("@docproveedor", TxtNroDocumentoProv.Text);
            Texto_Html = Texto_Html.Replace("@nombreproveedor", TxtRazonSocialProv.Text);
            Texto_Html = Texto_Html.Replace("@fecharegistro", TxtFecha.Text);
            Texto_Html = Texto_Html.Replace("@usuarioregistro", TxtUsuario.Text);

            string filas = string.Empty;
            foreach (DataGridViewRow row in dataGridDatos.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PrecioCompra"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            Texto_Html = Texto_Html.Replace("@filas", filas);
            Texto_Html = Texto_Html.Replace("@montototal", TxtMontoTotal.Text);

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Compra_{0}.pdf",TxtNroDocumento.Text);
            savefile.Filter = "Pdf Files | *.pdf";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4,25,25,25,25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    bool obtenido = true;
                    byte[] byteImagen = new CN_Negocio().ObtenerLogo(out obtenido);

                    if (obtenido)
                    {
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteImagen);
                        img.ScaleToFit(60,60);
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
