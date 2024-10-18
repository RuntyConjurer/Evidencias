using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string CodigoProducto { get; set; }
        public string Categoria { get; set; }
        public decimal Precio { get; set; }
        public int Existencia { get; set; }
        public string Proveedor { get; set; }
    }

}
