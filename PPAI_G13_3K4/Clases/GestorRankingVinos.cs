using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using PPAI_G13_3K4.Pantalla;

namespace PPAI_G13_3K4.Clases
{
    internal class GestorRankingVinos : IAgregado
    {
        public DateTime fechaDesdeSeleccionada { get; set; }
        public DateTime fechaHastaSeleccionada { get; set; }
        public string tipoReseñaSeleccionada { get; set; }
        public string formasVisualizacion { get; set; }
        public List<Vino> vinosTotales { get; set; }
        public List<Vino> vinosFiltrados { get; set; }
        public List<(Vino vino, float puntajePromSom)> vinosPuntajePromSom { get; set; }
        public List<(string nombre, float puntajePromSom, float precioSugerido, string bodega, List<string> varietales, 
            string region, string pais)> vinosRankingExcel { get; set; }

        private PantallaGenerarRanking pantalla;
        private InterfazExcel interfazExcel;

        public GestorRankingVinos(PantallaGenerarRanking pantalla)
        {
            this.fechaDesdeSeleccionada = DateTime.Today;
            this.fechaHastaSeleccionada = DateTime.Today;
            this.tipoReseñaSeleccionada = tipoReseñaSeleccionada;
            this.formasVisualizacion = formasVisualizacion;
            this.vinosPuntajePromSom = new List<(Vino,float)>();
            this.vinosFiltrados = new List<Vino>();
            this.vinosTotales = new List<Vino>();
            this.pantalla = pantalla;
            this.interfazExcel = new InterfazExcel();
            this.vinosRankingExcel = new List<(string, float, float, string, List<string>, string, string)>();
        }
       
        public void opcGenerarRankVinos()
        {
            pantalla.solicitarFechaDesdeHastaRanking();
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
            buscarVinosReseñaEnPeriodoDeSom();
         
 
        }
        public void buscarVinosReseñaEnPeriodoDeSom()
        {
            // ruta de la base de datos alternativa
            //string filePath = "..\\..\\Recursos\\jsonVinosSinBodega.txt";
            
            // ruta de la base de datos 
            string filePath = "..\\..\\Recursos\\jsonVinos.txt";
            
            string jsonContent = File.ReadAllText(filePath);
            // se convierte el string JSON a una lista de objetos de tipo "Vino"
            vinosTotales = JsonConvert.DeserializeObject<List<Vino>>(jsonContent);
            
            // se crea un array de tipo Object que consiste en dos elementos, que son las fechas seleccionadas
            Object[] fechas = new Object[] { fechaDesdeSeleccionada, fechaHastaSeleccionada };
            // se crea un array de tipo Object cuyo único elemento será un array con todos los vinos
            // como vinosTotales es una lista, la convertimos primero en un array Vino[] con .ToArray()
            Object[] vinos = new Object[] { vinosTotales.ToArray() };
            
            // todo resolver filtrado de vinos ya que se ejectua el mensaje de error de vinosFiltrados.Count == 0
            Iterador iteradorVinos = crearIterador(vinos, fechas);

            iteradorVinos.primero();
            while (iteradorVinos.haTerminado())
            {
                
                Vino vino = (Vino) iteradorVinos.getActual();
                vinosFiltrados.Add(vino);
                iteradorVinos.siguiente();
                
            }
            
            if (vinosFiltrados.Count == 0)
            {
                pantalla.mostrarMensajeError("No se encontraron reseñas creadas por Sommeliers en este periodo.");

            }
            
            // verifica si existen bodegas registradas para esos vinos
            else if (!chequearBodegasExistentes(vinosFiltrados))
            {
                pantalla.mostrarMensajeError("No existen bodegas registradas");
            }
            
            /* luego de filtrar los vinos, se calcula su puntaje promedio, se los ordena según ese puntaje, se añaden 
            los diez mejores vinos al excel y se genera el reporte */
            else
            {
                calcularPuntajeProm();
                ordenarSegunPuntajePromedio();
                buscarDatosDiezMejoresVinos();
                generarReporteExcel();
                finCU();
            }

        }
        public bool chequearBodegasExistentes(List<Vino> listaVinos)//AGREGAR METODO
        {
            foreach (Vino vino in listaVinos)
            {
                if (vino.existeBodega())
                {
                    return true;
                }
            }
            return false;
        }
        public void calcularPuntajeProm()
        {
            foreach (Vino vino in vinosFiltrados)
                             {
                                 /* calcula el puntaje promedio de cada vino y añade el vino junto a su puntaje a una colección de vinos
                                 y sus promedios */
                                 vinosPuntajePromSom.Add((vino, vino.obtenerPuntajePromedio(fechaDesdeSeleccionada, fechaHastaSeleccionada)));
            }
        }

        public void ordenarSegunPuntajePromedio()
        {
            vinosPuntajePromSom = vinosPuntajePromSom.OrderByDescending(v => v.puntajePromSom).ToList();
        }

        public void buscarDatosDiezMejoresVinos()
        {

            // se toman los diez vinos con puntaje promedio mas alto recorriendo 10 veces la colección de vinos con 
            // reseña de sommelier y sus puntajes promedio
            for (int i = 0; i < vinosPuntajePromSom.Take(10).Count(); i++)
            {
                
                // se guarda cada atributo del vino en su variable correspondiente 
                string nom = vinosPuntajePromSom[i].vino.getNombre();
                float calSom = vinosPuntajePromSom[i].puntajePromSom;
                float precSug = vinosPuntajePromSom[i].vino.getPrecio();
                List<string> datosBodega = vinosPuntajePromSom[i].vino.buscarDatosBodega();
                string bodega = datosBodega[0];
                string region = datosBodega[1];
                string pais = datosBodega[2];
                List<string> varietales = vinosPuntajePromSom[i].vino.obtenerVarietal();
                
                /* utilizando las variables se añade cada vino a una colección que posteriormente se utilizará
                para generar el excel con el ranking de vinos */
                vinosRankingExcel.Add((nom, calSom, precSug, bodega, varietales, region, pais));
                
            }
            
        }

        public void generarReporteExcel()
        {
            // se envia la colección de vinos para el ranking a la interfaz excel
            interfazExcel.exportarExcel(this.vinosRankingExcel);
            // luego de haberse exportado el excel, se informa al usuario la generación del excel
            pantalla.informarGeneracionExitosa();

        }

        public Iterador crearIterador(Object[] elementos, Object[] filtros)
        {
            return new IteradorVinos(elementos, filtros);
        }
        
        public void finCU()
        {
            pantalla.WindowState = FormWindowState.Minimized;
        }
    }
}
