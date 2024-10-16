using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Marca
    {

        private CD_Marca objcd_Marca = new CD_Marca();
        public List<Marca> Listar()
        {
            return objcd_Marca.Listar(); //listar la misma lista que tiene cd_Marca
        }

        public int Registrar_Marca(Marca obj, out string mensaje)
        {
            mensaje = string.Empty;

            if (obj.Descripcion_marca == "")
            {
                mensaje += "Es necesaria la descripción de la marca";
            }

            if (mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Marca.Registrar(obj, out mensaje); //listar la misma lista que tiene cd_Marca
            }


        }

        public bool Editar_Marca(Marca obj, out string mensaje)
        {
            mensaje = string.Empty;

            if (obj.Descripcion_marca == "")
            {
                mensaje += "Es necesaria la descripción de la marca";
            }

            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Marca.Editar(obj, out mensaje); //listar la misma lista que tiene cd_Marca
            }
        }

        public bool Eliminar_Marca(Marca obj, out string mensaje)
        {
            return objcd_Marca.Eliminar(obj, out mensaje); //listar la misma lista que tiene cd_Marca
        }

    }
}
