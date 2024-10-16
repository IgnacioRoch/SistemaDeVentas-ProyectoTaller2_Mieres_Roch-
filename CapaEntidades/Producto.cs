using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Producto
    {
        public int Id_producto { get; set; }
        public string Codigo_producto { get; set; }
        public string Nombre_producto { get; set; }
        public string Descripcion_producto { get; set; }
        public Categoria objCategoria { get; set; }
        public Marca objMarca { get; set; }
        public int Stock_producto { get; set; }
        public decimal PrecioCompra_producto { get; set; }
        public decimal PrecioVenta_producto { get; set; }
        public bool Estado_producto { get; set; }
        public string FechaRegistro_producto { get; set; }
    }
}
