using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class ReporteVentas
    {
        public string FechaRegistro { get; set; }
        public string TipoDocumento{ get; set; }
        public string NumeroDocumento{ get; set; }
        public string MontoTotal { get; set; }
        public string Documento_usuario { get; set; }
        public string Nombre_usuario { get; set; }
        public string Apellido_usuario { get; set; }
        public string Documento_cliente { get; set; }
        public string Nombre_cliente { get; set; }
        public string Codigo_producto { get; set; }
        public string Nombre_producto { get; set; }
        public string Descripcion_categoria { get; set; }
        public string Descripcion_marca { get; set; }
        public string PrecioVenta { get; set; }
        public string Cantidad { get; set; }
        public string SubTotal { get; set; }
    }
}
