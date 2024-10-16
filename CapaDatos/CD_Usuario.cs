using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CapaEntidades;
using System.Collections;

namespace CapaDatos
{
    public class CD_Usuario
    {
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select  u.Id_usuario, u.Documento_usuario, u.Nombre_usuario, u.Apellido_usuario, u.Correo_usuario, u.Direccion_usuario, u.Clave_usuario, u.Estado_usuario, r.Id_rol, r.Descripcion_rol from usuario u");
                    query.AppendLine("inner join rol r on r.Id_rol = u.Id_rol");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Usuario()
                            {
                                Id_usuario = Convert.ToInt32(dr["Id_usuario"]),
                                Documento_usuario = dr["Documento_usuario"].ToString(),
                                Nombre_usuario = dr["Nombre_usuario"].ToString(),
                                Apellido_usuario = dr["Apellido_usuario"].ToString(),
                                Correo_usuario = dr["Correo_usuario"].ToString(),
                                Direccion_usuario = dr["Direccion_usuario"].ToString(),
                                Clave_usuario = dr["Clave_usuario"].ToString(),
                                Estado_usuario = Convert.ToBoolean(dr["Estado_usuario"]),
                                objRol = new Rol() { ID_rol = Convert.ToInt32(dr["Id_rol"]), Descripcion_rol = dr["Descripcion_rol"].ToString()}
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Usuario>();
                }
            }
            return lista;
        }

        public int Registrar(Usuario obj, out string Mensaje)
        {
            int idUsuarioGenerado = 0;
            Mensaje = string.Empty; 
            
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarUsuario", oconexion);
                    cmd.Parameters.AddWithValue("Documento_usuario",obj.Documento_usuario);
                    cmd.Parameters.AddWithValue("Nombre_usuario", obj.Nombre_usuario);
                    cmd.Parameters.AddWithValue("Apellido_usuario", obj.Apellido_usuario);
                    cmd.Parameters.AddWithValue("Correo_usuario", obj.Correo_usuario);
                    cmd.Parameters.AddWithValue("Direccion_usuario", obj.Direccion_usuario);
                    cmd.Parameters.AddWithValue("Clave_usuario", obj.Clave_usuario);
                    cmd.Parameters.AddWithValue("Id_rol", obj.objRol.ID_rol);
                    cmd.Parameters.AddWithValue("Estado_usuario", obj.Estado_usuario);
                    cmd.Parameters.Add("idUsuarioResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    idUsuarioGenerado = Convert.ToInt32(cmd.Parameters["idUsuarioResultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }

            }
            catch(Exception ex) 
            {
                idUsuarioGenerado = 0;
                Mensaje = ex.Message;
            }

            return idUsuarioGenerado;
        }

        public bool Editar(Usuario obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EditarUsuario", oconexion);
                    cmd.Parameters.AddWithValue("Id_Usuario", obj.Id_usuario);
                    cmd.Parameters.AddWithValue("Documento_usuario", obj.Documento_usuario);
                    cmd.Parameters.AddWithValue("Nombre_usuario", obj.Nombre_usuario);
                    cmd.Parameters.AddWithValue("Apellido_usuario", obj.Apellido_usuario);
                    cmd.Parameters.AddWithValue("Correo_usuario", obj.Correo_usuario);
                    cmd.Parameters.AddWithValue("Direccion_usuario", obj.Direccion_usuario);
                    cmd.Parameters.AddWithValue("Clave_usuario", obj.Clave_usuario);
                    cmd.Parameters.AddWithValue("Id_rol", obj.objRol.ID_rol);
                    cmd.Parameters.AddWithValue("Estado_usuario", obj.Estado_usuario);
                    cmd.Parameters.Add("respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["respuesta"].Value);
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

        public bool Eliminar(Usuario obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EliminarUsuario", oconexion);
                    cmd.Parameters.AddWithValue("Id_Usuario", obj.Id_usuario);
                    cmd.Parameters.Add("respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["respuesta"].Value);
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
