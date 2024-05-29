using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private Bodega bodega { get; set; }
        private List<Varietal> varietal { get; set; }
        private List<Reseña> reseña { get; set; }

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
        public string obtenerVarietal()
        {
            string varietal = "";
            foreach (var item in this.varietal)
            {
                varietal += item.getDescripcion() + " ";
            }
            return varietal;
        }
        public string obtenerDatosBodega()
        {
            return bodega.getNombre();
        }
        public float calcularPromedioPuntaje()
        {
            float puntajePromedio = 0;
            foreach (var item in reseña)
            {
                puntajePromedio += item.puntaje;
            }
            return puntajePromedio / reseña.Count;
        }
        public float obtenerPuntajePromedio()
        {
            return calcularPromedioPuntaje();
        }
        public string verificarReseñasEnPeriodoDeSom()
        {
            string res = "";
            foreach (var item in reseña)
            {
                if (item.fechaReseña.Year == 2021)
                {
                    res = "Si";
                }
                else
                {
                    res = "No";
                }
            }
            return res;
        }
    }
}
