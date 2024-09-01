using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Marca
    {
        public int Id_marca { get; set; }
        public string Descripcion_marca { get; set; }
        public bool Estado_marca { get; set; }
        public string FechaRegistro_marca { get; set; }
    }
}
