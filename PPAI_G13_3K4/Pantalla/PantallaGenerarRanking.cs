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

        public void solicitarFechaDesdeHasta()
        {
            fechaDesde.Visible = true;
            fechaHasta.Visible = true;
            lblFechaDesde.Visible = true;
            lblFechaHasta.Visible = true;
            lblPeriodo.Visible = true; 
        }

        public void tomarFechaDesdeRanking(DateTime fechaDesde)
        {
            gestor.tomarFechaDesdeRanking(fechaDesde);
        }

        public void tomarFechaHastaRanking(DateTime fechaHasta)
        {
            gestor.tomarFechaHastaRanking(fechaHasta);
        }

        public bool validarFechas(DateTime desde, DateTime hasta)
        {
            if (desde > hasta)
            {
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

        public void tomarTipoReseña(string tipoReseña)
        {
            gestor.tomarTipoReseña(tipoReseña);
        }

        public void mostrarFormasVisualizacion()
        {
            lblFormasVisReporte.Visible = true;
            comboFormasVisReporte.Visible = true;
        }

        public void solicitarFormaVisualizacion()
        {
            MessageBox.Show("Seleccionar la forma de visualización.");
        }

        public void tomarFormaVisualizacion(string formaVis)
        {
            gestor.tomarFormaVisualizacion(formaVis);
        }
        public void tomarConfirmacionReporte()
        {
            gestor.tomarConfirmacionReporte();
        }

        public void solicitarConfirmacionReporte()
        {
            // Muestra el MessageBox y captura el resultado del botón presionado
            DialogResult opcion = MessageBox.Show("¿Desea generar el reporte?", "Confirmación", MessageBoxButtons.OKCancel);

            // Verifica la respuesta del usuario
            if (opcion == DialogResult.OK)
            {
                this.tomarConfirmacionReporte();
            }
            else
            {
                Application.Exit();
            }
        }

        private void btnGenerarRankingVinos_Click(object sender, EventArgs e)
        {
            gestor.opcGenerarRankVinos();
        }

        private void fechaDesde_ValueChanged(object sender, EventArgs e)
        {
           bool validacion = this.validarFechas(fechaDesde.Value, fechaHasta.Value);
           if (validacion)
            {
                this.tomarFechaDesdeRanking(fechaDesde.Value);
            }
        }

        private void fechaHasta_ValueChanged(object sender, EventArgs e)
        {
            bool validacion = this.validarFechas(fechaDesde.Value, fechaHasta.Value);
            if (validacion)
            {
                this.tomarFechaHastaRanking(fechaHasta.Value);
            };
        }

        private void cmbTipoReseña_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoReseña.SelectedItem != null)
            {
                string tipoReseña = cmbTipoReseña.SelectedItem.ToString();
                if (tipoReseña == "Reseñas de Sommelier")
                {
                    this.tomarTipoReseña(tipoReseña);
                }     
            }
        }

        private void comboFormasVisReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFormasVisReporte.SelectedItem != null)
            {
                string formaVis = comboFormasVisReporte.SelectedItem.ToString();
                if (formaVis == "Archivo Excel")
                {
                    this.tomarFormaVisualizacion(formaVis);
                }
            }
        }
    }
}
