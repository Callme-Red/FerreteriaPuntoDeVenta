using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteríaPuntoVenta.Model
{
    public class OrdenCompra
    {
        public int ocompra_codigo { get; set; }

        public int ocompra_pedido_id { get; set; }
        public int ocompra_proveedor_id { get; set; }

        public int ocompra_usr_id { get; set; }

        public String ocompra_num_factura { get; set; }
        public String ocompra_descripcion { get; set; }

        public int ocompra_mp_id { get; set; }
        public Double ocompra_descuento { get; set; }

        public Double ocompra_impuesto { get; set; }
        public Double ocompra_subtotal { get; set; }

        public Double ocompra_total { get; set; }

        public DateTime ocompra_fecha_registro { get; set; }

        public int ocompra_estado_id { get; set; }
    }
}
