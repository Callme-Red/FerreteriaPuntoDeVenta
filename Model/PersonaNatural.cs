using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteríaPuntoVenta.Model
{
    public class PersonaNatural
    {
        public int pn_codigo { get; set; }
        public String pn_apellido { get; set; }
        public int pn_genero { get; set; }
        public DateTime pn_fecha_nacimiento { get; set; }
        public int pn_estado_civil { get; set; }
    }
}
