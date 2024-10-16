using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Categoria
    {
        private CD_Categoria objcd_Categoria = new CD_Categoria();
        public List<Categoria> Listar()
        {
            return objcd_Categoria.Listar(); //listar la misma lista que tiene cd_Categoria
        }

        public int Registrar_Categoria(Categoria obj, out string mensaje)
        {
            mensaje = string.Empty;

            if (obj.Descripcion_categoria == "")
            {
                mensaje += "Es necesaria la descripción de la categoría";
            }

            if (mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Categoria.Registrar(obj, out mensaje); //listar la misma lista que tiene cd_Categoria
            }


        }

        public bool Editar_Categoria(Categoria obj, out string mensaje)
        {
            mensaje = string.Empty;

            if (obj.Descripcion_categoria == "")
            {
                mensaje += "Es necesaria la descripción de la categoría";
            }

            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Categoria.Editar(obj, out mensaje); //listar la misma lista que tiene cd_Categoria
            }
        }

        public bool Eliminar_Categoria(Categoria obj, out string mensaje)
        {
            return objcd_Categoria.Eliminar(obj, out mensaje); //listar la misma lista que tiene cd_Categoria
        }

    }
}
