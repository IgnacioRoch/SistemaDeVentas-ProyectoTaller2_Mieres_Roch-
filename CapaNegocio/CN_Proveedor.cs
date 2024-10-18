using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Proveedor
    {
        private CD_Proveedor objcd_Proveedor = new CD_Proveedor();
        public List<Proveedor> Listar()
        {
            return objcd_Proveedor.Listar(); //listar la misma lista que tiene cd_Proveedor
        }

        public int Registrar_Proveedor(Proveedor obj, out string mensaje)
        {
            mensaje = string.Empty;
            if (obj.Documento_proveedor == "")
            {
                mensaje += "Es necesario el documento del Proveedor\n";
            }

            if (obj.NombreLegal_proveedor == "")
            {
                mensaje += "Es necesario el nombre legal del Proveedor\n";
            }

            if (obj.NombreContacto_proveedor == "")
            {
                mensaje += "Es necesario el nombre del contacto del Proveedor\n";
            }

            if (obj.RazonSocial_proveedor == "")
            {
                mensaje += "Es necesario la razon social del Proveedor\n";
            }

            if (obj.Correo_proveedor == "")
            {
                mensaje += "Es necesario el correo del Proveedor\n";
            }

            if (obj.Direccion_proveedor == "")
            {
                mensaje += "Es necesario la dirección del Proveedor\n";
            }

            if (obj.Telefono_proveedor == "")
            {
                mensaje += "Es necesario el teléfono del Proveedor\n";
            }

            if (mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Proveedor.Registrar(obj, out mensaje); //listar la misma lista que tiene cd_Proveedor
            }


        }

        public bool Editar_Proveedor(Proveedor obj, out string mensaje)
        {
            mensaje = string.Empty;
            if (obj.Documento_proveedor == "")
            {
                mensaje += "Es necesario el documento del Proveedor\n";
            }

            if (obj.NombreLegal_proveedor == "")
            {
                mensaje += "Es necesario el nombre legal del Proveedor\n";
            }

            if (obj.NombreContacto_proveedor == "")
            {
                mensaje += "Es necesario el nombre del contacto del Proveedor\n";
            }

            if (obj.RazonSocial_proveedor == "")
            {
                mensaje += "Es necesario la razon social del Proveedor\n";
            }

            if (obj.Correo_proveedor == "")
            {
                mensaje += "Es necesario el correo del Proveedor\n";
            }

            if (obj.Direccion_proveedor == "")
            {
                mensaje += "Es necesario la dirección del Proveedor\n";
            }

            if (obj.Telefono_proveedor == "")
            {
                mensaje += "Es necesario el teléfono del Proveedor\n";
            }

            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Proveedor.Editar(obj, out mensaje); //listar la misma lista que tiene cd_Proveedor
            }
        }

        public bool Eliminar_Proveedor(Proveedor obj, out string mensaje)
        {
            return objcd_Proveedor.Eliminar(obj, out mensaje); //listar la misma lista que tiene cd_Proveedor
        }

    }
}
