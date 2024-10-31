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
using System.Windows.Forms.DataVisualization.Charting;

namespace CapaPresentacion.Gerente_Comercial
{
    public partial class FormEstadisticas : Form
    {
        public FormEstadisticas()
        {
            InitializeComponent();
        }

        private void FormEstadisticas_Load(object sender, EventArgs e)
        {
            /*List<Venta> lista = new List<Venta>();

            lista = new CN_Venta().TopVentas(
                dateTPVentaInicio.Value.ToString(),
                dateTPVentaFin.Value.ToString()
                );

            int xfilas = lista.*/

        }

        private void BGenerarGraficaVenta_Click(object sender, EventArgs e)
        {
            List<Venta> lista = new List<Venta>();

            lista = new CN_Venta().TopVentas(
                TxtTPVentaInicio.Value.ToString(),
                TxtTPVentaFin.Value.ToString()
                );

            ChartTopVentas.Series["Ventas"].Points.Clear(); //Limpiamos el chart antes de volver a graficar

            int index = 1;
            foreach (var dato in lista)
            {
                ChartTopVentas.Series["Ventas"].Points.AddXY(index, dato.MontoTotal);
                index++;
            }

        }

        private void BGenerarGraficaProdPreferidos_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            tabla = new CN_Producto().ProductosPreferidos(
                TxtProdPrefInicio.Value.ToString(),
                TxtProdPrefFin.Value.ToString()
            );

            ChartTopProductos.Series["ProductosPreferidos"].Points.Clear(); //Limpiamos el chart antes de volver a graficar
            
            int index = 1;
            foreach (DataRow fila in tabla.Rows)
            {
                string nombre = fila["Nombre_producto"].ToString();
                decimal totalVendido = Convert.ToDecimal(fila["Total_vendido"].ToString());

                ChartTopProductos.Series["ProductosPreferidos"].Points.AddXY(nombre, totalVendido);
                index++;
                //series.Points.AddXY(dato.MontoTotal);
            }
        }

        private void BGenerarGraficaProductoCategoria_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            tabla = new CN_Producto().ProductosPorCategoria();

            ChartCantProductosCategoria.Series["Productos por Categoria"].Points.Clear(); //Limpiamos el chart antes de volver a graficar

            int index = 1;
            foreach (DataRow fila in tabla.Rows)
            {
                string categoria = fila["Descripcion_categoria"].ToString();
                decimal cantidadProductos = Convert.ToInt32(fila["NumeroProductos"].ToString());

                ChartCantProductosCategoria.Series["Productos por Categoria"].Points.AddXY(categoria, cantidadProductos);
                index++;
                //series.Points.AddXY(dato.MontoTotal);
            }
        }
    }
}
