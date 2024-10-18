using CapaEntidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Negocio
    {
        public Negocio ObtenerDatos()
        {
            Negocio objNegocio = new Negocio();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    string query = "select Id_negocio, Nombre_negocio, RUC_negocio, Direccion_negocio from NEGOCIO";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while(dr.Read())
                        {
                            objNegocio = new Negocio()
                            {
                                Id_negocio = int.Parse(dr["Id_negocio"].ToString()),
                                Nombre_negocio = dr["Nombre_negocio"].ToString(),
                                RUC_negocio = dr["RUC_negocio"].ToString(),
                                Direccion_negocio = dr["Direccion_negocio"].ToString(),
                            };
                        }
                    }
                }
            }
            catch
            {
                objNegocio = new Negocio();
            }

            return objNegocio;
        }
        
        public bool GuardarDatos(Negocio objeto, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = true;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update NEGOCIO set Nombre_negocio = @Nombre_negocio,");
                    query.AppendLine("RUC_negocio = @RUC_negocio,");
                    query.AppendLine("Direccion_negocio = @Direccion_negocio");
                    query.AppendLine("where Id_negocio = 1");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@Nombre_negocio", objeto.Nombre_negocio);
                    cmd.Parameters.AddWithValue("@RUC_negocio", objeto.RUC_negocio);
                    cmd.Parameters.AddWithValue("@Direccion_negocio", objeto.Direccion_negocio);
                    cmd.CommandType = CommandType.Text;
                    
                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        mensaje = "No se pudo guardar los datos";
                        respuesta = false;
                    }

                }   
            }
            catch(Exception ex)
            {
                mensaje = ex.Message;
                respuesta = false;
            }
            return respuesta;
        }

        public byte[] ObtenerLogo(out bool obtenido)
        {
            obtenido = true;
            byte[] LogoByte = new byte[0];

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    string query = "select Logo_negocio from NEGOCIO where Id_negocio = 1";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            LogoByte = (byte[])dr["Logo_negocio"];                          
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                obtenido = false;
                LogoByte = new byte[0];
            }
            return LogoByte;
        }

        public bool ActualizarLogo(byte[] image, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = true;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update NEGOCIO set Logo_negocio = @imagen");
                    query.AppendLine("where Id_negocio = 1;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@imagen", image);
                    cmd.CommandType = CommandType.Text;

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        mensaje = "No se pudo actualizar el logo";
                        respuesta = false;
                    }

                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                respuesta = false;
            }
            return respuesta;
        }
    }
}
