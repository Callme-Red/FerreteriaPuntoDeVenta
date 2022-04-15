using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteríaPuntoVenta.Model
{
    public class ProductoCategoria
    {
        public int productocat_codigo { get; set; }

        public int productocat_producto_id { get; set; }

        public int productocat_categoria_id { get; set; }
    }
}
