using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class ReporteCompra
    {
        public string FechaRegistro { get; set; }
        public string TipoDocumento_compra { get; set; }
        public string NumeroDocumento_compra { get; set; }
        public string MontoTotal_compra { get; set; }
        public string Nombre_usuario { get; set; }
        public string Apellido_usuario { get; set; }
        public string Documento_proveedor { get; set; }
        public string RazonSocial_proveedor { get; set; }
        public string Codigo_producto { get; set; }
        public string Nombre_producto { get; set; }
        public string Descripcion_categoria { get; set; }
        public string Descripcion_marca { get; set; }
        public string PrecioCompra { get; set; }
        public string PrecioVenta { get; set; }
        public string Cantidad { get; set; }
        public string MontoTotal { get; set; }     
    }

}
