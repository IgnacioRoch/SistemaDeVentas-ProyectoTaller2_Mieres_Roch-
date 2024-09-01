using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Categoria
    {
        public int Id_categoria {  get; set; }
        public string Descripcion_categoria { get; set; }
        public bool Estado_categoria { get; set; }
        public string FechaRegistro_categoria { get; set; }
    }
}
