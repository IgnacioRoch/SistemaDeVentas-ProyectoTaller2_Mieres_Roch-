using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Cliente
    {
        public int Id_cliente {  get; set; }
        public string Documento_cliente { get; set; }
        public string Nombre_cliente { get; set; }
        public string Apellido_cliente { get; set; }
        public string Correo_cliente { get; set; }
        public string Direccion_cliente { get; set; }
        public string Telefono_cliente { get; set; }
        public bool Estado_cliente { get; set; }
        public string FechaRegistro_cliente { get; set; }
    }
}
