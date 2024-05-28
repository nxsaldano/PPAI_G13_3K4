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
        public int puntaje { get; set; }
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

        public int getPuntaje()
        {
            return puntaje;
        }
        public string sosDePeriodo
        {
            get
            {
                if (fechaReseña.Year == 2021)
                {
                    return "Si";
                }
                else
                {
                    return "No";
                }
            }
        }
        public string sosDeSommelier
        {
            get
            {
                if (esPremium)
                {
                    return "Si";
                }
                else
                {
                    return "No";
                }
            }
        }
    }
}
