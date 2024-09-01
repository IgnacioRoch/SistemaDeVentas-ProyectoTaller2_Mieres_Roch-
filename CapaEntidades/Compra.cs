using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Compra
    {
        public int Id_compra {  get; set; }
        public Usuario objUsuario {  get; set; }
        public Proveedor objProveedor {  get; set; }
        public string TipoDocumento_compra { get; set; }
        public string NumeroDocumento_compra { get; set; }
        public decimal MontoTotal_compra { get; set; }
        public List<Detalle_Compra> objDetalleCompra { get; set; }
        public string FechaRegistro_compra { get; set; }
    }
}
