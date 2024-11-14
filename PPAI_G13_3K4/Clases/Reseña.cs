using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_G13_3K4.Clases
{
    internal class Reseña
    {
        public DateTime fechaReseña { get; set; }
        public decimal puntaje { get; set; }
        public string comentario { get; set; }
        public bool esPremium { get; set; }
        private Vino vino { get; set; }

        public Reseña(DateTime fechaReseña, int puntaje, string comentario, bool esPremium, Vino vino)
        {
            this.fechaReseña = fechaReseña;
            this.puntaje = puntaje;
            this.comentario = comentario;
            this.esPremium = esPremium;
            this.vino = vino;
        }

        public decimal getPuntaje()
        {
            return puntaje;
        }
        public bool sosDePeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {
            return fechaDesde <= this.fechaReseña && this.fechaReseña <= fechaHasta;
        }
        public bool sosDeSommelier()
        {
            return esPremium;
        }
    }
}
