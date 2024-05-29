using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPAI_G13_3K4;
using Newtonsoft.Json;
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
        private PantallaGenerarRanking pantalla;

        public GestorRankingVinos(PantallaGenerarRanking pantalla)
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
       
        public void opcGenerarRankVinos()
        {
            pantalla.solicitarFechaDesdeHasta();
        }
        public void tomarFechaDesdeRanking(DateTime fechaDesde)
        {
            fechaDesdeSeleccionada = fechaDesde;
        }
        public void tomarFechaHastaRanking(DateTime fechaHasta)
        {
            fechaHastaSeleccionada = fechaHasta;
            pantalla.solicitarTipoReseña();
        }
        public void tomarTipoReseña(string tipoReseña)
        {
            tipoReseñaSeleccionada = tipoReseña;
            pantalla.mostrarFormasVisualizacion();
            pantalla.solicitarFormaVisualizacion();
        }
        public void tomarFormaVisualizacion(string formaVis)
        {
            formasVisualizacion = formaVis;
            pantalla.solicitarConfirmacionReporte();
        }
        public void tomarConfirmacionReporte()
        {
            MessageBox.Show("Se generará el reporte.");
            Application.Exit();
        }
        public string buscarVinosReseñaEnPeriodoDeSom()
        {
            string filePath = "Recursos\\jsonVinos.txt"; // Reemplaza con la ruta correcta del archivo
            string jsonContent = File.ReadAllText(filePath);

            // Deserializar el contenido JSON en una lista de objetos Vino
            List<Vino> vinos = JsonConvert.DeserializeObject<List<Vino>>(jsonContent);
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
        }
        
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
