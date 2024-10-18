using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Proveedor
    {

        public List<Proveedor> Listar()
        {
            List<Proveedor> lista = new List<Proveedor>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select Id_proveedor, Documento_proveedor, NombreLegal_proveedor, NombreContacto_proveedor, RazonSocial_proveedor, Correo_proveedor, Direccion_proveedor, Telefono_proveedor, Estado_proveedor from PROVEEDOR");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Proveedor()
                            {
                                Id_proveedor = Convert.ToInt32(dr["Id_proveedor"]),
                                Documento_proveedor = dr["Documento_proveedor"].ToString(),
                                NombreLegal_proveedor = dr["NombreLegal_proveedor"].ToString(),
                                NombreContacto_proveedor = dr["NombreContacto_proveedor"].ToString(),
                                RazonSocial_proveedor = dr["RazonSocial_proveedor"].ToString(),
                                Correo_proveedor = dr["Correo_proveedor"].ToString(),
                                Direccion_proveedor = dr["Direccion_proveedor"].ToString(),
                                Telefono_proveedor = dr["Telefono_proveedor"].ToString(),
                                Estado_proveedor = Convert.ToBoolean(dr["Estado_proveedor"]),                               
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Proveedor>();
                }
            }
            return lista;
        }

        public int Registrar(Proveedor obj, out string Mensaje)
        {
            int idProveedorGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarProveedor", oconexion);
                    cmd.Parameters.AddWithValue("Documento_proveedor", obj.Documento_proveedor);
                    cmd.Parameters.AddWithValue("NombreLegal_proveedor", obj.NombreLegal_proveedor);
                    cmd.Parameters.AddWithValue("NombreContacto_proveedor", obj.NombreContacto_proveedor);
                    cmd.Parameters.AddWithValue("RazonSocial_proveedor", obj.RazonSocial_proveedor);
                    cmd.Parameters.AddWithValue("Correo_proveedor", obj.Correo_proveedor);
                    cmd.Parameters.AddWithValue("Direccion_proveedor", obj.Direccion_proveedor);
                    cmd.Parameters.AddWithValue("Telefono_proveedor", obj.Telefono_proveedor);
                    cmd.Parameters.AddWithValue("Estado_proveedor", obj.Estado_proveedor);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    idProveedorGenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                idProveedorGenerado = 0;
                Mensaje = ex.Message;
            }

            return idProveedorGenerado;
        }

        public bool Editar(Proveedor obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EditarProveedor", oconexion);
                    cmd.Parameters.AddWithValue("Id_proveedor", obj.Id_proveedor);
                    cmd.Parameters.AddWithValue("Documento_proveedor", obj.Documento_proveedor);
                    cmd.Parameters.AddWithValue("NombreLegal_proveedor", obj.NombreLegal_proveedor);
                    cmd.Parameters.AddWithValue("NombreContacto_proveedor", obj.NombreContacto_proveedor);
                    cmd.Parameters.AddWithValue("RazonSocial_proveedor", obj.RazonSocial_proveedor);
                    cmd.Parameters.AddWithValue("Correo_proveedor", obj.Correo_proveedor);
                    cmd.Parameters.AddWithValue("Direccion_proveedor", obj.Direccion_proveedor);
                    cmd.Parameters.AddWithValue("Telefono_proveedor", obj.Telefono_proveedor);
                    cmd.Parameters.AddWithValue("Estado_proveedor", obj.Estado_proveedor);
                    cmd.Parameters.Add("@Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["@Resultado"].Value);
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

        public bool Eliminar(Proveedor obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EliminarProveedor", oconexion);
                    cmd.Parameters.AddWithValue("Id_proveedor", obj.Id_proveedor);
                    cmd.Parameters.Add("@Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["@Resultado"].Value);
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

    }
}
