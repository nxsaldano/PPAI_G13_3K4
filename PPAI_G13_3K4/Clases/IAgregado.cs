using System;

namespace PPAI_G13_3K4.Clases
{
    public interface IAgregado
    {
        Iterador crearIterador(Object[] elementos, Object[] filtros);
    }
}