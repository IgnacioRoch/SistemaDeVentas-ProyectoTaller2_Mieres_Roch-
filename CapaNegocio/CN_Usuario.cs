using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario objcd_usuario = new CD_Usuario();
        public List<Usuario> Listar()
        {
            return objcd_usuario.Listar(); //listar la misma lista que tiene cd_usuario
        }

        public int Registrar_Usuario(Usuario obj, out string mensaje)
        {
            mensaje = string.Empty;
            if (obj.Documento_usuario == "")
            {
                mensaje += "Es necesario el documento del usuario\n";
            }

            if (obj.Nombre_usuario == "")
            {
                mensaje += "Es necesario el nombre del usuario\n";
            }

            if (obj.Apellido_usuario == "")
            {
                mensaje += "Es necesario el apellido del usuario\n";
            }

            if (obj.Clave_usuario == "")
            {
                mensaje += "Es necesario el clave del usuario\n";
            }

            if(mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_usuario.Registrar(obj, out mensaje); //listar la misma lista que tiene cd_usuario
            }

            
        }

        public bool Editar_Usuario(Usuario obj, out string mensaje)
        {
            mensaje = string.Empty;
            if (obj.Documento_usuario == "")
            {
                mensaje += "Es necesario el documento del usuario\n";
            }

            if (obj.Nombre_usuario == "")
            {
                mensaje += "Es necesario el nombre del usuario\n";
            }

            if (obj.Apellido_usuario == "")
            {
                mensaje += "Es necesario el apellido del usuario\n";
            }

            if (obj.Clave_usuario == "")
            {
                mensaje += "Es necesario el clave del usuario\n";
            }

            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_usuario.Editar(obj, out mensaje); //listar la misma lista que tiene cd_usuario
            }      
        }

        public bool Eliminar_Usuario(Usuario obj, out string mensaje)
        {
            return objcd_usuario.Eliminar(obj, out mensaje); //listar la misma lista que tiene cd_usuario
        }

    }
}
