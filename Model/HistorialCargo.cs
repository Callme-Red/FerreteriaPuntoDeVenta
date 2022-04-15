using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteríaPuntoVenta.Model
{
    public class HistorialCargo
    {
        public int hcargo_codigo { get; set; }
        public int hcargo_empleado_id { get; set; }

        public int hcargo_cargo_id { get; set; }

        public DateTime hcargo_fecha_registro { get; set; }

        public DateTime hcargo_fecha_modificacion { get; set; }
    }
}
