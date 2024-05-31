﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPAI_G13_3K4;
using Newtonsoft.Json;
using PPAI_G13_3K4.Pantalla;
namespace PPAI_G13_3K4.Clases
{
    internal class GestorRankingVinos
    {
        public DateTime fechaDesdeSeleccionada { get; set; }
        public DateTime fechaHastaSeleccionada { get; set; }
        public string tipoReseñaSeleccionada { get; set; }
        public string formasVisualizacion { get; set; }
        public List<(Vino vino, float puntajePromSom)> vinosPuntajeSom { get; set; }
        public List<Vino> vinosFiltrados { get; set; }
        public List<Bodega> bodegas { get; set; }
        public List<Pais> paises { get; set; }
        public List<RegionVitivinicola> regioneVit { get; set; }
        public List<Vino> vino { get; set; }
        public List<(string nombre, float puntajePromSom, float precioSugerido, string bodega, List<string> varietales, string region, string pais)> vinosRankingExcel { get; set; }
        private PantallaGenerarRanking pantalla;
        private InterfazExcel interfazExcel;

        public GestorRankingVinos(PantallaGenerarRanking pantalla)
        {
            this.fechaDesdeSeleccionada = DateTime.Today;
            this.fechaHastaSeleccionada = DateTime.Today;
            this.tipoReseñaSeleccionada = tipoReseñaSeleccionada;
            this.formasVisualizacion = formasVisualizacion;
            this.vinosPuntajeSom = new List<(Vino, float)>();
            this.vinosFiltrados = new List<Vino>();
            this.bodegas = new List<Bodega>();
            this.paises = new List<Pais>();
            this.regioneVit = new List<RegionVitivinicola>();
            this.vino = new List<Vino>();
            this.pantalla = pantalla;
            this.interfazExcel = new InterfazExcel();
            this.vinosRankingExcel = new List<(string, float, float, string, List<string>, string, string)>();
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
            buscarVinosReseñaEnPeriodoDeSom();
            if (vinosFiltrados.Count > 0)
            {
                calcularPuntajeProm();
                ordenarSegunPuntajePromedio();
                buscarDatosDiezMejoresVinos();
                generarReporteExcel();
                finCU();
            }
            else
            {
                pantalla.mensajeError("No se encontraron vinos en ese periodo");
            }

        }
        public void buscarVinosReseñaEnPeriodoDeSom()
        {
            string filePath = "..\\..\\Recursos\\jsonVinos.txt"; // Reemplaza con la ruta correcta del archivo
            string jsonContent = File.ReadAllText(filePath);
            // Deserializar el contenido JSON en una lista de objetos Vino
            vino = JsonConvert.DeserializeObject<List<Vino>>(jsonContent);
            foreach (Vino vino in vino)
            {
                if (vino.verificarReseñasEnPeriodoDeSom(fechaDesdeSeleccionada, fechaHastaSeleccionada))
                {
                    vinosFiltrados.Add(vino);
                }

            }
        }

        public void calcularPuntajeProm()
        {

            foreach (Vino vino in vinosFiltrados)
            {

                vinosPuntajeSom.Add((vino, vino.obtenerPuntajePromedio(fechaDesdeSeleccionada, fechaHastaSeleccionada)));
            }

        }
        public void ordenarSegunPuntajePromedio()
        {
            vinosPuntajeSom = vinosPuntajeSom.OrderByDescending(v => v.puntajePromSom).ToList();
        }
        public void buscarDatosDiezMejoresVinos()
        {


            for (int i = 0; i < 10; i++)
            {
                string nom = vinosPuntajeSom[i].vino.getNombre();
                float calSom = vinosPuntajeSom[i].puntajePromSom;
                float precSug = vinosPuntajeSom[i].vino.getPrecio();
                List<string> datosBodega = vinosPuntajeSom[i].vino.buscarDatosBodega();
                string bodega = datosBodega[0];
                string region = datosBodega[1];
                string pais = datosBodega[2];
                List<string> varietales = vinosPuntajeSom[i].vino.obtenerVarietal();
                vinosRankingExcel.Add((nom, calSom, precSug, bodega, varietales, region, pais));
            }
        }
        public void generarReporteExcel()
        {
            pantalla.informarGeneracionExitosa();
            interfazExcel.exportarExcel(this.vinosRankingExcel);
        }
        public void finCU()
        {
            pantalla.WindowState = FormWindowState.Minimized;
        }
    }
}
