using System;

namespace PPAI_G13_3K4.Clases
{
    public interface Iterador 
    {

        Object getActual();
        bool haTerminado();
        void primero();
        void siguiente();
        bool cumpleFiltro(Object[] filtros);
        
    }
}