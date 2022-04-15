using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteríaPuntoVenta.Model
{
    public class PersonaJuridica
    {
        public int pj_codigo { get; set; }
        public DateTime pj_fecha_constitucional { get; set; }
        public String pj_razon_social { get; set; }
        public String pn_pagina_web { get; set; }
    }
}
