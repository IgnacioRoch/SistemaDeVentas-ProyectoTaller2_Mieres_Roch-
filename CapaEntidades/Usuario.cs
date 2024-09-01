using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Usuario
    {
        public int Id_usuario {  get; set; }
        public string Documento_usuario { get; set; }
        public string Nombre_usuario { get; set; }
        public string Apellido_usuario { get; set; }
        public string Correo_usuario { get; set; }
        public string Clave_usuario { get; set; }
        public Rol objRol { get; set; }
        public bool Estado_usuario { get; set; } 
        public string FechaRegistro_usuario { get; set; }
    }
}
