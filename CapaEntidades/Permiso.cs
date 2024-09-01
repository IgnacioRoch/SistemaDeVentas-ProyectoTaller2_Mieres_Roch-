using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Permiso
    {
        public int Id_permiso {  get; set; }
        public Rol objRol { get; set; }
        public string NombreMenu { get; set; }
        public string FechaRegistro_permiso { get; set; }
    }
}
