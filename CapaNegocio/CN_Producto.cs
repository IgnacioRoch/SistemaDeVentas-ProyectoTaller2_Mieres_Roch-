using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Producto
    {

        private CD_Producto objcd_Producto = new CD_Producto();
        public List<Producto> Listar()
        {
            return objcd_Producto.Listar(); //listar la misma lista que tiene cd_Producto
        }

        public int Registrar_Producto(Producto obj, out string mensaje)
        {
            mensaje = string.Empty;
            if (obj.Codigo_producto == "")
            {
                mensaje += "Es necesario el código del Producto\n";
            }

            if (obj.Nombre_producto == "")
            {
                mensaje += "Es necesario el nombre del Producto\n";
            }

            if (obj.Descripcion_producto == "")
            {
                mensaje += "Es necesario la descripción del Producto\n";
            }

            if (mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Producto.Registrar(obj, out mensaje); //listar la misma lista que tiene cd_Producto
            }


        }

        public bool Editar_Producto(Producto obj, out string mensaje)
        {
            mensaje = string.Empty;
            if (obj.Codigo_producto == "")
            {
                mensaje += "Es necesario el código del Producto\n";
            }

            if (obj.Nombre_producto == "")
            {
                mensaje += "Es necesario el nombre del Producto\n";
            }

            if (obj.Descripcion_producto == "")
            {
                mensaje += "Es necesario la descripción del Producto\n";
            }

            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Producto.Editar(obj, out mensaje); //listar la misma lista que tiene cd_Producto
            }
        }

        public bool Eliminar_Producto(Producto obj, out string mensaje)
        {
            return objcd_Producto.Eliminar(obj, out mensaje); //listar la misma lista que tiene cd_Producto
        }

    }
}
