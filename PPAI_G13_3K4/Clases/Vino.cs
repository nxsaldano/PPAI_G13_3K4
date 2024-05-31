using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_G13_3K4.Clases
{
    internal class Vino
    {
        public string nombre { get; set; }
        public float precioARS { get; set; }
        public int añada { get; set; }
        public DateTime fechaActualizacion { get; set; }
        public string imgenEtiqueta { get; set; }
        public float notaDeCataBodega { get; set; }
        public Bodega bodega { get; set; }
        public List<Varietal> varietal { get; set; }
        public List<Reseña> reseña { get; set; }

        public Vino(string nombre, float precioARS, int añada, DateTime fechaActualizacion, string imgenEtiqueta, float notaDeCataBodega, Bodega bodega, List<Varietal> varietal, List<Reseña> reseña)
        {
            this.nombre = nombre;
            this.precioARS = precioARS;
            this.añada = añada;
            this.fechaActualizacion = fechaActualizacion;
            this.imgenEtiqueta = imgenEtiqueta;
            this.notaDeCataBodega = notaDeCataBodega;
            this.bodega = bodega;
            this.varietal = varietal;
            this.reseña = reseña;
        }

        public string getNombre()
        {
            return nombre;
        }
        public float getPrecio()
        {
            return precioARS;
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
        public float calcularPromedioPuntaje(float puntajes, float deSom)
        {
            return puntajes/deSom;
        }
        public float obtenerPuntajePromedio(DateTime fechaDesde, DateTime fechaHasta)
        {
            float puntajes = 0, deSom = 0;
            foreach (Reseña reseña in reseña)
            {
                if (reseña.sosDePeriodo(fechaDesde, fechaHasta)&& reseña.sosDeSommelier())
                {
                    puntajes += reseña.getPuntaje();
                    deSom += 1;
                }

            }
            return calcularPromedioPuntaje(puntajes, deSom);
        }

        public bool verificarReseñasEnPeriodoDeSom(DateTime fechaDesde, DateTime fechaHasta)
        {
            bool result = false;
            foreach (Reseña reseña in reseña)
            {
                if (reseña.sosDePeriodo(fechaDesde, fechaHasta) && reseña.sosDeSommelier())
                {
                    result=true;
                    break;
                }
            }
            return result;
        }

        public List<string> buscarDatosBodega()
        {
            string nomBodega = bodega.getNombre();
            List<string> datosRegPais = bodega.obtenerRegionPais();
            return new List<string> { nomBodega, datosRegPais[0], datosRegPais[1]};
        }

    }
}
