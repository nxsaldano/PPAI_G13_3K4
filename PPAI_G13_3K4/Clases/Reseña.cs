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
        public float puntaje { get; set; }
        public string comentario { get; set; }
        public Boolean esPremium { get; set; }
        private Vino vino { get; set; }

        public Reseña(DateTime fechaReseña, int puntaje, string comentario, Boolean esPremium, Vino vino)
        {
            this.fechaReseña = fechaReseña;
            this.puntaje = puntaje;
            this.comentario = comentario;
            this.esPremium = esPremium;
            this.vino = vino;
        }

        public float getPuntaje()
        {
            return puntaje;
        }
        public bool sosDePeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {
            fechaDesde = new DateTime(2023, 11, 21);
            fechaHasta = new DateTime(2023, 11, 23);

            return fechaDesde <= this.fechaReseña && this.fechaReseña <= fechaHasta;
        }
        public bool sosDeSommelier()
        {
            return esPremium;
        }
    }
}
