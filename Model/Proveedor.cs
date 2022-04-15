using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteríaPuntoVenta.Model
{
    public class Proveedor
    {
        public int proveedor_codigo { get; set; }
        public int proveedor_persona_id { get; set; }
        public int proveedor_contacto_proveedor_id { get; set; }
        public String proveedor_descripcion { get; set; }

        public int proveedor_estado_id { get; set; }
    }
}
