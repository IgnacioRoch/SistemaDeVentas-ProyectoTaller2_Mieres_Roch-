using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;

namespace CapaDatos
{
    public class CD_Producto
    {

        public List<Producto> Listar()
        {
            List<Producto> lista = new List<Producto>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.Id_producto, p.Codigo_producto, p.Nombre_producto, p.Descripcion_producto, c.Id_categoria, c.Descripcion_categoria, m.Id_marca, m.Descripcion_marca, p.Stock_producto, p.PrecioCompra_producto, p.PrecioVenta_producto, p.Estado_producto from PRODUCTO p");
                    query.AppendLine("inner join CATEGORIA c on c.Id_categoria = p.Id_categoria");
                    query.AppendLine("inner join MARCA m on m.Id_marca = p.Id_marca");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Producto()
                            {
                                Id_producto = Convert.ToInt32(dr["Id_producto"]),
                                Codigo_producto = dr["Codigo_producto"].ToString(),
                                Nombre_producto = dr["Nombre_producto"].ToString(),
                                Descripcion_producto = dr["Descripcion_producto"].ToString(),
                                objCategoria = new Categoria() { Id_categoria = Convert.ToInt32(dr["Id_categoria"]), Descripcion_categoria = dr["Descripcion_categoria"].ToString()},
                                objMarca = new Marca() { Id_marca = Convert.ToInt32(dr["Id_marca"]), Descripcion_marca = dr["Descripcion_marca"].ToString()},
                                Stock_producto = Convert.ToInt32(dr["Stock_producto"].ToString()),
                                PrecioCompra_producto = Convert.ToDecimal(dr["PrecioCompra_producto"].ToString()),
                                PrecioVenta_producto = Convert.ToDecimal(dr["PrecioVenta_producto"].ToString()),
                                Estado_producto = Convert.ToBoolean(dr["Estado_producto"])                            
                            });
                        }                        
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Producto>();
                }
            }
            return lista;
        }

        public int Registrar(Producto obj, out string Mensaje)
        {
            int idProductoGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarProducto", oconexion);
                    cmd.Parameters.AddWithValue("Codigo_producto", obj.Codigo_producto);
                    cmd.Parameters.AddWithValue("Nombre_producto", obj.Nombre_producto);
                    cmd.Parameters.AddWithValue("Descripcion_producto", obj.Descripcion_producto);
                    cmd.Parameters.AddWithValue("Id_categoria", obj.objCategoria.Id_categoria);
                    cmd.Parameters.AddWithValue("Id_marca", obj.objMarca.Id_marca);
                    //cmd.Parameters.AddWithValue("Stock_producto", obj.Stock_producto);
                    //cmd.Parameters.AddWithValue("PrecioCompra_producto", obj.PrecioCompra_producto);
                    //cmd.Parameters.AddWithValue("PrecioVenta_producto", obj.PrecioVenta_producto);
                    cmd.Parameters.AddWithValue("Estado_producto", obj.Estado_producto);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure; 

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    idProductoGenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                idProductoGenerado = 0;
                Mensaje = ex.Message;
            }

            return idProductoGenerado;
        }

        public bool Editar(Producto obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EditarProducto", oconexion);
                    cmd.Parameters.AddWithValue("Id_producto", obj.Id_producto);
                    cmd.Parameters.AddWithValue("Codigo_producto", obj.Codigo_producto);
                    cmd.Parameters.AddWithValue("Nombre_producto", obj.Nombre_producto);
                    cmd.Parameters.AddWithValue("Descripcion_producto", obj.Descripcion_producto);
                    cmd.Parameters.AddWithValue("Id_categoria", obj.objCategoria.Id_categoria);
                    cmd.Parameters.AddWithValue("Id_marca", obj.objMarca.Id_marca);
                    //cmd.Parameters.AddWithValue("Stock_producto", obj.Stock_producto);
                    //cmd.Parameters.AddWithValue("PrecioCompra_producto", obj.PrecioCompra_producto);
                    //cmd.Parameters.AddWithValue("PrecioVenta_producto", obj.PrecioVenta_producto);
                    cmd.Parameters.AddWithValue("Estado_producto", obj.Estado_producto);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }

            return respuesta;
        }

        public bool Eliminar(Producto obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EliminarProducto", oconexion);
                    cmd.Parameters.AddWithValue("Id_producto", obj.Id_producto);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }

            return respuesta;
        }

        public DataTable ProductosPreferidos(string fechainicio, string fechafin)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ProductoPreferidos", oconexion))
                    {
                        cmd.Parameters.AddWithValue("FechaInicio", fechainicio);
                        cmd.Parameters.AddWithValue("FechaFin", fechafin);
                        cmd.CommandType = CommandType.StoredProcedure;
                        oconexion.Open();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(tabla);
                        }
                    }

                }
                catch (Exception ex)
                {
                    tabla = new DataTable();
                }
            }
            return tabla;
        }

        public DataTable ProductosPorCategoria()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_FiltrarProductoCategoria", oconexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        oconexion.Open();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(tabla);
                        }
                    }

                }
                catch (Exception ex)
                {
                    tabla = new DataTable();
                }
            }
            return tabla;
        }
    }
}
