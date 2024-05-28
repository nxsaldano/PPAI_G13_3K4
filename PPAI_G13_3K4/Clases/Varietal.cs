using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_G13_3K4.Clases
{
    internal class Varietal
    {
        public string descripcion { get; set; }
        public int porcentajeComposicion { get; set; }

        public Varietal(string descripcion, int porcentajeComposicion)
        {
            this.descripcion = descripcion;
            this.porcentajeComposicion = porcentajeComposicion;
        }

        public string getDescripcion()
        {
            return descripcion;
        }
    }
}
