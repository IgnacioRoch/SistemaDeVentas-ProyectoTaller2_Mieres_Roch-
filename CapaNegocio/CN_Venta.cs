using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Venta
    {
        private CD_Venta objcd_venta = new CD_Venta();

        public bool RestarStock(int idproducto, int cantidad)
        {
            return objcd_venta.RestarStock(idproducto, cantidad);
        }

        public bool SumarStock(int idproducto, int cantidad)
        {
            return objcd_venta.SumarStock(idproducto, cantidad);
        }

        public int ObtenerCorrelativo()
        {
            return objcd_venta.ObtenerCorrelativo();
        }

        public bool Registrar_Venta(Venta obj, DataTable DetalleVenta, out string mensaje)
        {
            return objcd_venta.Registrar(obj, DetalleVenta, out mensaje);
        }

        public Venta ObtenerVenta(string numero)
        {
            Venta oVenta = objcd_venta.ObtenerVenta(numero);

            if (oVenta.Id_venta !=0)
            {
                List<Detalle_Venta> oDetalleVenta = objcd_venta.ObtenerDetalleVenta(oVenta.Id_venta);
                oVenta.objDetalleVenta = oDetalleVenta;
            }

            return oVenta;

        }

        public DataTable TopVentas(string fechainicio, string fechafin)
        {
            return objcd_venta.TopVentas(fechainicio, fechafin);
        }
    }
}
