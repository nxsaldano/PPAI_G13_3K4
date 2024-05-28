using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_G13_3K4.Clases
{
    internal class Provincia
    {
        public string nombre { get; set; }
        private Pais pais { get; set; }
        private List<RegionVitivinicola> regiones { get; set; }
        public Provincia(string nombre, List<RegionVitivinicola> regiones, Pais pais)
        {
            this.nombre = nombre;
            this.regiones = regiones;
            this.pais = pais;
        }
        public string getNombrePais()
        {
            return pais.getNombre();
        }
    }
}
