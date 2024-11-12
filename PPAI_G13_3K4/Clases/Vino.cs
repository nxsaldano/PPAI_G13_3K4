using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_G13_3K4.Clases
{
    internal class Vino : IAgregado
    {
        public string nombre { get; set; }
        public float precioARS { get; set; }
        public int añada { get; set; }
        public DateTime fechaActualizacion { get; set; }
        public string imagenEtiqueta { get; set; }
        public float notaDeCataBodega { get; set; }
        public Bodega bodega { get; set; }
        public List<Varietal> varietal { get; set; }
        public List<Reseña> reseña { get; set; }

        public Vino(string nombre, float precioARS, int añada, DateTime fechaActualizacion, string imagenEtiqueta, float notaDeCataBodega, Bodega bodega, List<Varietal> varietal, List<Reseña> reseña)
        {
            this.nombre = nombre;
            this.precioARS = precioARS;
            this.añada = añada;
            this.fechaActualizacion = fechaActualizacion;
            this.imagenEtiqueta = imagenEtiqueta;
            this.notaDeCataBodega = notaDeCataBodega;
            this.bodega = bodega;
            this.varietal = varietal;
            this.reseña = reseña;
        }
        public bool verificarReseñasEnPeriodoDeSom(DateTime fechaDesde, DateTime fechaHasta)
        {
            Object[] fechas = new Object[] {fechaDesde, fechaHasta};
            Object[] reseñas = new Object[] { reseña };
            
            Iterador iteradorReseñas = crearIterador(reseñas, fechas);
            
            iteradorReseñas.primero();
            
            bool result = false;
            Reseña reseñaResultado;
            while (iteradorReseñas.haTerminado())
                
            {
                
                reseñaResultado = (Reseña) iteradorReseñas.getActual();
                if (reseñaResultado != null)
                {
                    result = true;
                    break;
                }
                iteradorReseñas.siguiente();
                
            }
           
            return result;
        }
        public bool existeBodega()
        {
            return bodega!=null;
        }
        public float obtenerPuntajePromedio(DateTime fechaDesde, DateTime fechaHasta)
        {
            float puntajes = 0, deSom = 0;
            foreach (Reseña reseña in reseña)
            {
                if (reseña.sosDePeriodo(fechaDesde, fechaHasta) && reseña.sosDeSommelier())
                {
                    puntajes += reseña.getPuntaje();
                    deSom += 1;
                }

            }
            return calcularPromedioPuntaje(puntajes, deSom);
        }
        public float calcularPromedioPuntaje(float puntajes, float deSom)
        {
            return puntajes / deSom;
        }
        public List<string> buscarDatosBodega()
        {
            string nomBodega = bodega.getNombre();
            List<string> datosRegPais = bodega.obtenerRegionPais();
            return new List<string> { nomBodega, datosRegPais[0], datosRegPais[1] };
        }
        public List<string> obtenerVarietal()
        {
            List<string> descVarietales = new List<string>();
            foreach (Varietal varietal in varietal)
            {
                descVarietales.Add(varietal.getDescripcion());
            }
            return descVarietales;
        }
        public string getNombre()
        {
            return nombre;
        }
        public float getPrecio()
        {
            return precioARS;
        }
        
        public Iterador crearIterador(Object[] elementos, Object[] filtros)
        {
            return new IteradorReseñas(elementos, filtros);
        }
        
    }
}
