using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteríaPuntoVenta.Model
{
    public class Producto
    {
        public int producto_codigo { get; set; }

        public String producto_codigo_unico { get; set; }
        public String producto_barra { get; set; }

        public int producto_marca_id { get; set; }

        public String producto_nombre { get; set; }

        public String producto_descripcion { get; set; }

        public int producto_unidad_medida_id { get; set; }

        public int producto_presentacion_id { get; set; }

        public int producto_clasificacion_id { get; set; }

        public int producto_estado_id { get; set; }
    
    }
}
