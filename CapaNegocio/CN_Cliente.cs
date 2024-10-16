using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Cliente
    {

        private CD_Cliente objcd_Cliente = new CD_Cliente();
        public List<Cliente> Listar()
        {
            return objcd_Cliente.Listar(); //listar la misma lista que tiene cd_Cliente
        }

        public int Registrar_Cliente(Cliente obj, out string mensaje)
        {
            mensaje = string.Empty;
            if (obj.Documento_cliente == "")
            {
                mensaje += "Es necesario el documento del Cliente\n";
            }

            if (obj.Nombre_cliente == "")
            {
                mensaje += "Es necesario el nombre del Cliente\n";
            }

            if (obj.Apellido_cliente == "")
            {
                mensaje += "Es necesario el apellido del Cliente\n";
            }

            if (obj.Correo_cliente == "")
            {
                mensaje += "Es necesario el correo del Cliente\n";
            }


            if (obj.Direccion_cliente == "")
            {
                mensaje += "Es necesario la dirección del Cliente\n";
            }


            if (obj.Telefono_cliente == "")
            {
                mensaje += "Es necesario el telefono del Cliente\n";
            }

            if (mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Cliente.Registrar(obj, out mensaje); //listar la misma lista que tiene cd_Cliente
            }


        }

        public bool Editar_Cliente(Cliente obj, out string mensaje)
        {
            mensaje = string.Empty;
            if (obj.Documento_cliente == "")
            {
                mensaje += "Es necesario el documento del Cliente\n";
            }

            if (obj.Nombre_cliente == "")
            {
                mensaje += "Es necesario el nombre del Cliente\n";
            }

            if (obj.Apellido_cliente == "")
            {
                mensaje += "Es necesario el apellido del Cliente\n";
            }

            if (obj.Correo_cliente == "")
            {
                mensaje += "Es necesario el correo del Cliente\n";
            }


            if (obj.Direccion_cliente == "")
            {
                mensaje += "Es necesario la dirección del Cliente\n";
            }


            if (obj.Telefono_cliente == "")
            {
                mensaje += "Es necesario el telefono del Cliente\n";
            }

            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Cliente.Editar(obj, out mensaje); //listar la misma lista que tiene cd_Cliente
            }
        }

        public bool Eliminar_Cliente(Cliente obj, out string mensaje)
        {
            return objcd_Cliente.Eliminar(obj, out mensaje); //listar la misma lista que tiene cd_Cliente
        }

    }
}
