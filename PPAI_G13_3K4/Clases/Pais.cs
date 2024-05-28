using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_G13_3K4.Clases
{
    internal class Pais
    {
        public string nombre { get; set; }
        private List<Provincia> provincia { get; set; }

        public Pais(string nombre, List<Provincia> provincia)
        {
            this.nombre = nombre;
            this.provincia = provincia;
        }
        public string getNombre()
        {
            return nombre;
        }
    }
}
