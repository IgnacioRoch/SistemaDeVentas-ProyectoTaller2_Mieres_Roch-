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
    public class CD_Permiso
    {
        public List<Permiso> Listar(int Id_usuario)
        {
            List<Permiso> lista = new List<Permiso>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.Id_rol, p.NombreMenu from PERMISO p");
                    query.AppendLine("inner join ROL r on r.Id_rol = p.Id_rol");
                    query.AppendLine("inner join USUARIO u on u.Id_rol = r.Id_rol");
                    query.AppendLine("where u.Id_usuario = @Id_usuario;");
                   
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("Id_usuario", Id_usuario);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Permiso()
                            {
                                objRol = new Rol() { ID_rol = Convert.ToInt32(dr["Id_rol"])  },
                                NombreMenu = dr["NombreMenu"].ToString(),                   
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Permiso>();
                }
            }
            return lista;
        }
    }
}
