using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteríaPuntoVenta.Model
{
    public class Municipio
    {
        public int municipio_codigo { get; set; }
        public string municipio_nombre { get; set; }
        public int municipio_departamento_id { get; set; }
    }
}
