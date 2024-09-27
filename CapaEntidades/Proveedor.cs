using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Proveedor
    {
        public int Id_proveedor {  get; set; }
        public string Documento_proveedor { get; set; }
        public string NombreLegal_proveedor { get; set; }
        public string NombreContacto_proveedor { get; set; }
        public string RazonSocial_proveedor { get; set; }
        public string Correo_proveedor { get; set; }
        public string Direccion_proveedor { get; set; }
        public string Telefono_proveedor { get; set; }
        public bool Estado_proveedor { get; set; }
        public string FechaRegistro_proveedor { get; set; }
    }
}
