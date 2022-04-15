using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteríaPuntoVenta.Model
{
    public class DetallePedidoCompra
    {

        public int dt_pcompra_codigo { get; set; }

        public int dt_pcompra_compra_id { get; set; }

        public int dt_pcompra_producto_id { get; set; }

        public double dt_pcompra_precio { get; set; }

        public double dt_pcompra_cantidad { get; set; }

        public double dt_pcompra_descuento { get; set; }

        public double dt_pcompra_monto { get; set; }
        
    }
}
