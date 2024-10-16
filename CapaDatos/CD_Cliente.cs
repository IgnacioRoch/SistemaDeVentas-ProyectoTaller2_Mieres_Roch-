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
    public class CD_Cliente
    {

        public List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select Id_cliente, Documento_cliente, Nombre_cliente, Apellido_cliente, Correo_cliente, Direccion_cliente, Telefono_cliente, Estado_cliente from CLIENTE;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Cliente()
                            {
                                Id_cliente = Convert.ToInt32(dr["Id_cliente"]),
                                Documento_cliente = dr["Documento_cliente"].ToString(),
                                Nombre_cliente = dr["Nombre_cliente"].ToString(),
                                Apellido_cliente = dr["Apellido_cliente"].ToString(),
                                Correo_cliente = dr["Correo_cliente"].ToString(),
                                Direccion_cliente = dr["Direccion_cliente"].ToString(),
                                Telefono_cliente = dr["Telefono_cliente"].ToString(),
                                Estado_cliente = Convert.ToBoolean(dr["Estado_cliente"]),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Cliente>();
                }
            }
            return lista;
        }

        public int Registrar(Cliente obj, out string Mensaje)
        {
            int idGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarCliente", oconexion);
                    cmd.Parameters.AddWithValue("Documento_cliente", obj.Documento_cliente);
                    cmd.Parameters.AddWithValue("Nombre_cliente", obj.Nombre_cliente);
                    cmd.Parameters.AddWithValue("Apellido_cliente", obj.Apellido_cliente);
                    cmd.Parameters.AddWithValue("Correo_cliente", obj.Correo_cliente);
                    cmd.Parameters.AddWithValue("Direccion_cliente", obj.Direccion_cliente);
                    cmd.Parameters.AddWithValue("Telefono_cliente", obj.Telefono_cliente);
                    cmd.Parameters.AddWithValue("Estado_cliente", obj.Estado_cliente);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    idGenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                idGenerado = 0;
                Mensaje = ex.Message;
            }

            return idGenerado;
        }

        public bool Editar(Cliente obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EditarCliente", oconexion);
                    cmd.Parameters.AddWithValue("Id_cliente", obj.Id_cliente);
                    cmd.Parameters.AddWithValue("Documento_cliente", obj.Documento_cliente);
                    cmd.Parameters.AddWithValue("Nombre_cliente", obj.Nombre_cliente);
                    cmd.Parameters.AddWithValue("Apellido_cliente", obj.Apellido_cliente);
                    cmd.Parameters.AddWithValue("Correo_cliente", obj.Correo_cliente);
                    cmd.Parameters.AddWithValue("Direccion_cliente", obj.Direccion_cliente);
                    cmd.Parameters.AddWithValue("Telefono_cliente", obj.Telefono_cliente);
                    cmd.Parameters.AddWithValue("Estado_cliente", obj.Estado_cliente);
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

        public bool Eliminar(Cliente obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("delete from cliente Id_Cliente = @id", oconexion);
                    cmd.Parameters.AddWithValue("@id", obj.Id_cliente);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
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
