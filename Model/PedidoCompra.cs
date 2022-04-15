using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteríaPuntoVenta.Model
{
    public class PedidoCompra
    {
        public int pcompra_codigo { get; set; }

        public int pcompra_proveedor_id { get; set; }

        public int pcompra_usr_id { get; set; }

        public String pcompra_num_factura { get; set; }
        public String pcompra_descripcion { get; set; }

        public int pcompra_mp_id { get; set; }
        public Double pcompra_descuento { get; set; }

        public Double pcompra_impuesto { get; set; }
        public Double pcompra_subtotal { get; set; }

        public Double pcompra_total { get; set; }

        public DateTime pcompra_fecha_registro { get; set; }

        public int pcompra_estado_id { get; set; }

        
    }
}
