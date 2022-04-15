using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteríaPuntoVenta.Model
{
    public class Usuario
    {
        public int usuario_codigo { get; set; }
        public int usuario_empleado_id { get; set; }

        public String usuario_nombre { get; set; }

        public String usuario_clave { get; set; }
        public int usuario_token_id { get; set; }
        public int usuario_estado_id { get; set; }
    }
}
