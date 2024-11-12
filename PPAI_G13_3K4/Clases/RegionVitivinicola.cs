using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_G13_3K4.Clases
{
    internal class RegionVitivinicola
    {
        public string nombre { get; set; }
        public string descripcion { get; set; }
        private Provincia provincia { get; set; }
        
        public RegionVitivinicola(string nombre, string descripcion, Provincia provincia)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.provincia = provincia;
        }

        public string getNombrePais()
        {
            return provincia.getNombrePais();
        }
        public string getNombre()
        {
            return nombre;
        }
    }
}
