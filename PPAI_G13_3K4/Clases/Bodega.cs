using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_G13_3K4.Clases
{
    internal class Bodega
    {
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string periodoActualizacion { get; set; }
        private RegionVitivinicola region { get; set; }

        public Bodega(string nombre, string descripcion, string periodoActualizacion, RegionVitivinicola region)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.periodoActualizacion = periodoActualizacion;
            this.region = region;
        }

        public string getNombre()
        {
            return nombre;
        }

        public string obtenerRegionPais()
        {
            return region.getNombrePais();
        }
    }
}
