using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Detalle_Venta
    {
        //El id Venta ya esta referenciado en la tabla venta
        public Object objProducto {  get; set; }
        public decimal PrecioVenta {  get; set; }
        public int Cantidad {  get; set; }
        public decimal SubTotal {  get; set; }
        public DateTime FechaRegistro {  get; set; }
    }
}
