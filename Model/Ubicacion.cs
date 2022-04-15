using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteríaPuntoVenta.Model
{
    public class Ubicacion
    {
        public int ubicacion_codigo { get; set; }

        public String ubicacion_direccion{ get; set; }

        public int ubicacion_municipio_id { get; set; }

        public String ubicacion_celular { get; set; }

        public String ubicacion_telefono_conv { get; set; }
    }
}
