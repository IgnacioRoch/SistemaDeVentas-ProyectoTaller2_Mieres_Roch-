using CapaEntidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using Microsoft.Win32;
using System.Reflection;

namespace CapaDatos
{
    public class CD_Compra
    {
        public int ObtenerCorrelativo()
        {
            int idCorrelativo = 0;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count(*) + 1 from COMPRA");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    idCorrelativo = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    idCorrelativo = 0;
                }
            }
            return idCorrelativo;
        }

        public bool Registrar(Compra obj, DataTable DetalleCompra, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarCompra".ToString(), oconexion);
                    cmd.Parameters.AddWithValue("Id_usuario", obj.objUsuario.Id_usuario);
                    cmd.Parameters.AddWithValue("Id_proveedor", obj.objProveedor.Id_proveedor);
                    cmd.Parameters.AddWithValue("TipoDocumento_compra", obj.TipoDocumento_compra);
                    cmd.Parameters.AddWithValue("NumeroDocumento_compra", obj.NumeroDocumento_compra);
                    cmd.Parameters.AddWithValue("MontoTotal_compra", obj.MontoTotal_compra);
                    cmd.Parameters.AddWithValue("@DetalleCompra", DetalleCompra);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    Respuesta = false;
                    Mensaje = ex.Message;
                }
            }
            return Respuesta;
        }

        public Compra ObtenerCompra(string numero)
        {
            Compra obj = new Compra();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("select c.Id_compra, u.Nombre_usuario, u.Apellido_usuario, pr.Documento_proveedor, pr.RazonSocial_proveedor,");
                    query.AppendLine("c.TipoDocumento_compra, c.NumeroDocumento_compra, c.MontoTotal_compra, convert(char(10), c.FechaRegistro_compra, 103)[FechaRegistro] from COMPRA c");
                    query.AppendLine("inner join USUARIO u on u.Id_usuario = c.Id_usuario");
                    query.AppendLine("inner join PROVEEDOR pr on pr.Id_proveedor = c.Id_proveedor");
                    query.AppendLine("where c.NumeroDocumento_compra = @numero");


                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            obj = new Compra()
                            {
                                Id_compra = Convert.ToInt32(dr["Id_compra"]),
                                objUsuario = new Usuario() { Nombre_usuario = dr["Nombre_usuario"].ToString(), Apellido_usuario = dr["Apellido_usuario"].ToString() },
                                objProveedor = new Proveedor() { Documento_proveedor = dr["Documento_proveedor"].ToString(), RazonSocial_proveedor = dr["RazonSocial_proveedor"].ToString() },
                                TipoDocumento_compra = dr["TipoDocumento_compra"].ToString(),
                                NumeroDocumento_compra = dr["NumeroDocumento_compra"].ToString(),
                                MontoTotal_compra = Convert.ToDecimal(dr["MontoTotal_compra"].ToString()),
                                FechaRegistro_compra = dr["FechaRegistro"].ToString()
                            };
                            
                        }
                    }
                }
                catch (Exception ex)
                {
                    obj = new Compra();
                }
            }

            return obj;
        }

        public List<Detalle_Compra> ObtenerDetalleCompra(int idCompra)
        {
            List<Detalle_Compra> oLista = new List<Detalle_Compra>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("select p.Nombre_producto, dc.PrecioCompra, dc.Cantidad, dc.MontoTotal from DETALLE_COMPRA dc");
                    query.AppendLine("inner join PRODUCTO p on p.Id_producto = dc.Id_producto");
                    query.AppendLine("where dc.Id_compra = @idcompra");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@idcompra", idCompra);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new Detalle_Compra()
                            {
                                oProducto = new Producto() { Nombre_producto = dr["Nombre_producto"].ToString() },
                                PrecioCompra = Convert.ToDecimal(dr["PrecioCompra"].ToString()),
                                Cantidad = Convert.ToInt32(dr["Cantidad"].ToString()),
                                MontoTotal = Convert.ToDecimal(dr["MontoTotal"].ToString())
                            });
                        }
                    }
                }
            }
            catch (Exception ex) 
            {
                oLista = new List<Detalle_Compra>();
            }
            return oLista;
        }
    }
}
