using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Detalle_Compra
    {
        //Omitimos la id compra ya que la clase compra está referida en la clase compra
        public Producto Id_producto {  get; set; }
        public decimal PrecioCompra {  get; set; }
        public decimal PrecioVenta {  get; set; }
        public int Cantidad {  get; set; }
        public decimal MontoTotal {  get; set; }
        public string FechaRegistro_detalleCompra {  get; set; }
    }
}
