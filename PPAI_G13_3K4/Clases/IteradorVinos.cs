using System;

namespace PPAI_G13_3K4.Clases
{
    public class IteradorVinos : Iterador
    {
        private int posicion;
        private Vino[] elementos;
        private Object[] filtros;

        public IteradorVinos(Object[] elementos, Object[] filtros)
        {
            this.elementos = (Vino[]) elementos;
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
            return posicion >= elementos.Length;
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
            return elementos[posicion].verificarReseñasEnPeriodoDeSom((DateTime) filtros[0], 
                (DateTime) filtros[1]);
        }

    }
}