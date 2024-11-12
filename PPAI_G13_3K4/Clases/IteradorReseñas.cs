using System;

namespace PPAI_G13_3K4.Clases
{
    public class IteradorReseñas : Iterador

    {
        private int posicion;
        private Reseña[] elementos;
        private Object[] filtros;

        public IteradorReseñas(Object[] elementos, Object[] filtros)
        {
            this.elementos = (Reseña[]) elementos[0];
            this.filtros = filtros;
        }

        public Object getActual()
        {
            if (cumpleFiltro(filtros))
            {
                return elementos[posicion];
            }

            return null;

        }

        // todo verificar que no corte antes del ultimo
        public bool haTerminado()
        {
            return posicion > elementos.Length;
        }

        public void primero()
        {
            posicion = 0;
        }

        public void siguiente()
        {
            posicion++;
        }

        public bool cumpleFiltro(Object[] filtros)
        {
            return elementos[posicion].sosDePeriodo((DateTime)filtros[0],
                (DateTime)filtros[1]) && elementos[posicion].sosDeSommelier();
        }

    }
}