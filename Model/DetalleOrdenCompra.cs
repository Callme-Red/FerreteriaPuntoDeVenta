using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteríaPuntoVenta.Model
{
    public class DetalleOrdenCompra
    {
        public int dt_ocompra_codigo { get; set; }

        public int dt_ocompra_compra_id { get; set; }

        public int dt_ocompra_producto_id { get; set; }

        public double dt_ocompra_precio { get; set; }

        public double dt_ocompra_cantidad { get; set; }

        public double dt_ocompra_descuento { get; set; }

        public double dt_ocompra_monto { get; set; }
    }
}
