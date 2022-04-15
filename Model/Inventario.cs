using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteríaPuntoVenta.Model
{
    public class Inventario
    {
        public int inventario_codigo { get; set; }
        public int inventario_producto_id { get; set; }
        public Double inventario_existencias { get; set; }

        public Double inventario_disponibilidad { get; set; }
        public Double inventario_stock_maximo { get; set; }
        public Double inventario_stock_minimo { get; set; }
        public DateTime inventario_fecha { get; set; }
    }
}
