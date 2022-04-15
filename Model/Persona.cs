using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteríaPuntoVenta.Model
{
    public class Persona
    {
        public int persona_codigo { get; set; }
        public String persona_cedula_ruc { get; set; }
        public String persona_nombre{ get; set; }
        public String persona_email{ get; set; }

        public int persona_pn_id { get; set; }
        public int persona_pj_id { get; set; }

        public String persona_hora_registro { get; set; }
    }
}
