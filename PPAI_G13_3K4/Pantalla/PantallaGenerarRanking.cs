using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPAI_G13_3K4.Clases;

namespace PPAI_G13_3K4
{
    public partial class PantallaGenerarRanking : Form
    {
        private GestorRankingVinos gestor;
        public PantallaGenerarRanking()
        {
            InitializeComponent();

            gestor = new GestorRankingVinos(this);
        }
        //METODOS////////////////////////////////////////////////////////
        public void opcGenerarRankVinos()
        {
            habilitarPantalla();
            gestor.opcGenerarRankVinos();
        }
        public void habilitarPantalla()
        {
            this.Show();
        }

        
        public void solicitarFechaDesdeHastaRanking()
        {
            datePickerFechaDesde.Visible = true;
            lblFechaDesde.Visible = true;
            datePickerFechaHasta.Visible = true;
            lblFechaHasta.Visible = true;
            lblPeriodo.Visible = true; 
        }
       private void tomarFechaDesdeRanking(object sender, EventArgs e)
        {
            bool validacion = this.validarFechas(datePickerFechaDesde.Value, datePickerFechaHasta.Value);
            if (validacion)
            {
                gestor.tomarFechaDesdeRanking(datePickerFechaDesde.Value);
            }
        }

        private void tomarFechaHastaRanking(object sender, EventArgs e)
        {
            bool validacion = this.validarFechas(datePickerFechaDesde.Value, datePickerFechaHasta.Value);
            if (validacion)
            {
                gestor.tomarFechaHastaRanking(datePickerFechaHasta.Value);
            };
        }
        public bool validarFechas(DateTime desde, DateTime hasta)
        {
            if (desde > hasta)
            {
                lblTipoReseña.Visible = false;
                cmbTipoReseña.Visible = false;
                lblFormasVisReporte.Visible = false;
                cmbFormasVisReporte.Visible = false;
                MessageBox.Show("La fecha 'Desde' no puede ser mayor que la fecha 'Hasta'.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        public void solicitarTipoReseña()
        {
            lblTipoReseña.Visible = true;
            cmbTipoReseña.Visible = true;
            MessageBox.Show("Seleccionar el tipo de reseña.");
        }



        public void mostrarFormasVisualizacion()
        {
            lblFormasVisReporte.Visible = true;
            cmbFormasVisReporte.Visible = true;
        }

        public void solicitarFormaVisualizacion()
        {
            MessageBox.Show("Seleccionar la forma de visualización.");
        }



        public void solicitarConfirmacionReporte()
        {
            msgBoxConfirmacion.Visible = true;
        }
        private void tomarConfirmacionReporte(object sender, EventArgs e)
        {
            gestor.tomarConfirmacionReporte();
            msgBoxConfirmacion.Visible = false;


        }

        private void tomarCancelacionReporte(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void informarGeneracionExitosa()
        {
            DialogResult opcion = MessageBox.Show("Reporte generado con exito");

        }




        private void tomarTipoReseña(object sender, EventArgs e)
        {
            if (cmbTipoReseña.SelectedItem != null)
            {
                string tipoReseña = cmbTipoReseña.SelectedItem.ToString();
                if (tipoReseña == "Reseñas de Sommelier")
                {
                    gestor.tomarTipoReseña(tipoReseña);
                }
            }
        }

        private void tomarFormaVisualizacion(object sender, EventArgs e)
        {
            if (cmbFormasVisReporte.SelectedItem != null)
            {
                string formaVis = cmbFormasVisReporte.SelectedItem.ToString();
                if (formaVis == "Archivo Excel")
                {
                    gestor.tomarFormaVisualizacion(formaVis);
                }
            }
        }

        public void mostrarMensajeError(string msg)//AGREGAR METODO
        {
            MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Restart();
        }

    }
}
