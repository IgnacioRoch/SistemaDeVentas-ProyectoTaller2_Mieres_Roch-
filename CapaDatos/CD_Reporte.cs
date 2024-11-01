using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Reporte
    {
        public List<ReporteCompra> Compra(string fechainicio, string fechafin, int idproveedor)
        {
            List<ReporteCompra> lista = new List<ReporteCompra>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    SqlCommand cmd = new SqlCommand("sp_ReporteCompras", oconexion);
                    cmd.Parameters.AddWithValue("FechaInicio", fechainicio);
                    cmd.Parameters.AddWithValue("FechaFin", fechafin);
                    cmd.Parameters.AddWithValue("Id_Proveedor", idproveedor);
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ReporteCompra()
                            {
                                FechaRegistro = dr["FechaRegistro"].ToString(),
                                TipoDocumento_compra = dr["TipoDocumento_compra"].ToString(),
                                NumeroDocumento_compra = dr["NumeroDocumento_compra"].ToString(),
                                /*MontoTotal = dr["MontoTotal"].ToString(),*/
                                Nombre_usuario = dr["Nombre_usuario"].ToString(),
                                Apellido_usuario = dr["Apellido_usuario"].ToString(),
                                Documento_proveedor = dr["Documento_proveedor"].ToString(),
                                RazonSocial_proveedor = dr["RazonSocial_proveedor"].ToString(),
                                /*Codigo_producto = dr["Codigo_producto"].ToString(),
                                Nombre_producto = dr["Nombre_producto"].ToString(),
                                Descripcion_categoria = dr["Descripcion_categoria"].ToString(),
                                Descripcion_marca = dr["Descripcion_marca"].ToString(),
                                PrecioCompra = dr["PrecioCompra"].ToString(),
                                PrecioVenta = dr["PrecioVenta"].ToString(),
                                Cantidad = dr["Cantidad"].ToString(),*/
                                MontoTotal_compra = dr["MontoTotal_compra"].ToString(),
                            });
                        }
                    }
                }
                catch(Exception ex)
                {
                    lista = new List<ReporteCompra>();
                }
            }
            return lista;
        }

        public List<ReporteVentas> Venta(string fechainicio, string fechafin)
        {
            List<ReporteVentas> lista = new List<ReporteVentas>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    SqlCommand cmd = new SqlCommand("sp_ReporteVentas", oconexion);
                    cmd.Parameters.AddWithValue("FechaInicio", fechainicio);
                    cmd.Parameters.AddWithValue("FechaFin", fechafin);        
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ReporteVentas()
                            {
                                FechaRegistro = dr["FechaRegistro"].ToString(),
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                MontoTotal = dr["MontoTotal"].ToString(),
                                Documento_usuario = dr["Documento_usuario"].ToString(),
                                Nombre_usuario = dr["Nombre_usuario"].ToString(),
                                Apellido_usuario = dr["Apellido_usuario"].ToString(),
                                Documento_cliente = dr["DocumentoCliente"].ToString(),
                                Nombre_cliente = dr["NombreCliente"].ToString(),
                                Codigo_producto = dr["Codigo_producto"].ToString(),
                                Nombre_producto = dr["Nombre_producto"].ToString(),
                                Descripcion_categoria = dr["Descripcion_categoria"].ToString(),
                                Descripcion_marca = dr["Descripcion_marca"].ToString(),
                                PrecioVenta = dr["PrecioVenta"].ToString(),
                                Cantidad = dr["Cantidad"].ToString(),
                                SubTotal = dr["SubTotal"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<ReporteVentas>();
                }
            }
            return lista;
        }

    }
}
