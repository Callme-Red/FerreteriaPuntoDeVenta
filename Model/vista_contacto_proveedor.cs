using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteríaPuntoVenta.Model
{
    public class vista_contacto_proveedor
    {
        public int contacto_proveedor_codigo { get; set; }
        public String contacto_proveedor_cedula { get; set; }
        public String contacto_proveedor_nombre { get; set; }
        public String contacto_proveedor_apellido { get; set; }
        public int contacto_proveedor_genero { get; set; }
        public DateTime contacto_proveedor_fecha_nacimiento { get; set; }
        public int contacto_proveedor_estado_civil { get; set; }
        public String contacto_proveedor_estado { get; set; }
    }
}
