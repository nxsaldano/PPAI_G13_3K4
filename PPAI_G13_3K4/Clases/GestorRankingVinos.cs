using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_G13_3K4.Clases
{
    internal class GestorRankingVinos
    {
        public DateTime fechaDesdeSeleccionada { get; set; }
        public DateTime fechaHastaSeleccionada { get; set; }
        public string tipoReseñaSeleccionada { get; set; }
        public string tiposReseña { get; set; }
        public string formasVisualizacion { get; set; }
        public float puntajePromSom { get; set; }
        public float puntajePromGral { get; set; }
        public string vinosFiltrados { get; set; }
        public float puntajesPromedio { get; set; }
        public string bodegas { get; set; }
        public string paises { get; set; }
        public string regioneVit { get; set; }
        public List<Vino> vino { get; set; }
        private PantallaGenerarRanking pantalla { get; set; }
        

        public GestorRankingVinos(DateTime fechaDesdeSeleccionada, DateTime fechaHastaSeleccionada, string tipoReseñaSeleccionada, string tiposReseña, string formasVisualizacion, float puntajePromSom, float puntajePromGral, string vinosFiltrados, float puntajesPromedio, string bodegas, string paises, string regioneVit, List<Vino> vino, PantallaGenerarRanking pantalla)
        {
            this.fechaDesdeSeleccionada = fechaDesdeSeleccionada;
            this.fechaHastaSeleccionada = fechaHastaSeleccionada;
            this.tipoReseñaSeleccionada = tipoReseñaSeleccionada;
            this.tiposReseña = tiposReseña;
            this.formasVisualizacion = formasVisualizacion;
            this.puntajePromSom = puntajePromSom;
            this.puntajePromGral = puntajePromGral;
            this.vinosFiltrados = vinosFiltrados;
            this.puntajesPromedio = puntajesPromedio;
            this.bodegas = bodegas;
            this.paises = paises;
            this.regioneVit = regioneVit;
            this.vino = vino;
            this.pantalla = pantalla;
        }

        public string opcGenerarRankVinos()
        {
            if (formasVisualizacion == "Por puntaje promedio")
            {
                return "Por puntaje promedio";
            }
            else
            {
                return "Por puntaje promedio de sommelier";
            }
        }
        public DateTime tomarFechaDesdeRanking()
        {
            return fechaDesdeSeleccionada;
        }
        public DateTime tomarFechaHastaRanking()
        {
            return fechaHastaSeleccionada;
        }
        public string tomarTipoReseña()
        {
            return tipoReseñaSeleccionada;
        }
        public string tomarFormaVisualizacion()
        {
            return formasVisualizacion;
        }
        public string tomarConfirmacionReporte()
        {
            return "Reporte generado";
        }
        /*public string buscarVinosReseñaEnPeriodoDeSom()
        {
            string vinos = "";
            foreach (var item in vino)
            {
                List<Reseña> list = item.reseña;
                for (int i = 0; i < list.Count; i++)
                {
                    Reseña item2 = list[i];
                    if (item2.fechaReseña >= fechaDesdeSeleccionada && item2.fechaReseña <= fechaHastaSeleccionada && item2.esPremium == true)
                    {
                        vinos += item.getNombre() + " ";
                    }
                }
            }
            return vinos;
        }*/

        /*public float calcularPuntajeProm()
        {
            float puntajePromedio = 0;
            foreach (var item in vino)
            {
                foreach (var item2 in item.reseña)
                {
                    puntajePromedio += item2.puntaje;
                }
            }
            return puntajePromedio / vino.Count;
        }*/
        public string ordenarSegunPuntajePromedio()
        {
            string vinos = "";
            foreach (var item in vino)
            {
                if (item.calcularPuntajePromedio() >= puntajePromGral)
                {
                    vinos += item.getNombre() + " ";
                }
            }
            return vinos;
        }
        public string buscarDatosDiezMejoresVinos()
        {
            string vinos = "";
            List<Vino> lista = new List<Vino>();
            foreach (var item in vino)
            {
                lista.Add(item);
            }
            lista.Sort((x, y) => y.calcularPuntajePromedio().CompareTo(x.calcularPuntajePromedio()));
            for (int i = 0; i < 10; i++)
            {
                vinos += lista[i].getNombre() + " ";
            }
            return vinos;
        }
        /*public string generarReporteExel()
        {
            string reporte = "";
            if (formasVisualizacion == "Por puntaje promedio")
            {
                reporte += "Vinos con puntaje promedio mayor a " + puntajePromGral + ": " + ordenarSegunPuntajePromedio() + "\n";
            }
            else
            {
                reporte += "Vinos con reseñas en periodo de sommelier: " + buscarVinosReseñaEnPeriodoDeSom() + "\n";
            }
            reporte += "Datos de los 10 mejores vinos: " + buscarDatosDiezMejoresVinos();
            return reporte;
        }*/
        public void finCU()
        {
            pantalla.Close();
        }
    }
}
