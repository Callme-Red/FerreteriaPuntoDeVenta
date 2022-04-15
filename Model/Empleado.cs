using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteríaPuntoVenta.Model
{
    public class Empleado
    {
        public int empleado_codigo { get; set; }

        public String empleado_inss { get; set; }
        public DateTime empleado_fecha_ingreso{ get; set; }
        public int empleado_persona_id { get; set; }
        public int empleado_estado_id { get; set; }
    }
}
