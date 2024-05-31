using System.Drawing;

namespace PPAI_G13_3K4
{
    partial class PantallaGenerarRanking
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaGenerarRanking));
            this.datePickerFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.datePickerFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.cmbTipoReseña = new System.Windows.Forms.ComboBox();
            this.lblTipoReseña = new System.Windows.Forms.Label();
            this.lblFormasVisReporte = new System.Windows.Forms.Label();
            this.cmbFormasVisReporte = new System.Windows.Forms.ComboBox();
            this.msgBoxConfirmacion = new System.Windows.Forms.GroupBox();
            this.lblConfirmacion = new System.Windows.Forms.Label();
            this.btnCancelacion = new System.Windows.Forms.Button();
            this.btnConfirmacion = new System.Windows.Forms.Button();
            this.msgBoxConfirmacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // datePickerFechaHasta
            // 
            this.datePickerFechaHasta.Location = new System.Drawing.Point(25, 150);
            this.datePickerFechaHasta.Name = "datePickerFechaHasta";
            this.datePickerFechaHasta.Size = new System.Drawing.Size(275, 22);
            this.datePickerFechaHasta.TabIndex = 1;
            this.datePickerFechaHasta.Visible = false;
            this.datePickerFechaHasta.ValueChanged += new System.EventHandler(this.tomarFechaHastaRanking);
            // 
            // datePickerFechaDesde
            // 
            this.datePickerFechaDesde.Checked = false;
            this.datePickerFechaDesde.Location = new System.Drawing.Point(25, 75);
            this.datePickerFechaDesde.Name = "datePickerFechaDesde";
            this.datePickerFechaDesde.Size = new System.Drawing.Size(275, 22);
            this.datePickerFechaDesde.TabIndex = 2;
            this.datePickerFechaDesde.Visible = false;
            this.datePickerFechaDesde.ValueChanged += new System.EventHandler(this.tomarFechaDesdeRanking);
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.BackColor = System.Drawing.Color.Transparent;
            this.lblPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.Location = new System.Drawing.Point(25, 25);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(148, 16);
            this.lblPeriodo.TabIndex = 3;
            this.lblPeriodo.Text = "Periodo de reseñas:";
            this.lblPeriodo.Visible = false;
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaDesde.Location = new System.Drawing.Point(25, 50);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(90, 16);
            this.lblFechaDesde.TabIndex = 4;
            this.lblFechaDesde.Text = "Fecha desde:";
            this.lblFechaDesde.Visible = false;
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaHasta.Location = new System.Drawing.Point(25, 125);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(84, 16);
            this.lblFechaHasta.TabIndex = 5;
            this.lblFechaHasta.Text = "Fecha hasta:";
            this.lblFechaHasta.Visible = false;
            // 
            // cmbTipoReseña
            // 
            this.cmbTipoReseña.FormattingEnabled = true;
            this.cmbTipoReseña.Items.AddRange(new object[] {
            "Reseñas normales",
            "Reseñas de Sommelier",
            "Reseñas de Amigos"});
            this.cmbTipoReseña.Location = new System.Drawing.Point(25, 250);
            this.cmbTipoReseña.Name = "cmbTipoReseña";
            this.cmbTipoReseña.Size = new System.Drawing.Size(275, 24);
            this.cmbTipoReseña.TabIndex = 6;
            this.cmbTipoReseña.Visible = false;
            this.cmbTipoReseña.SelectedIndexChanged += new System.EventHandler(this.tomarTipoReseña);
            // 
            // lblTipoReseña
            // 
            this.lblTipoReseña.AutoSize = true;
            this.lblTipoReseña.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoReseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoReseña.Location = new System.Drawing.Point(25, 225);
            this.lblTipoReseña.Name = "lblTipoReseña";
            this.lblTipoReseña.Size = new System.Drawing.Size(117, 16);
            this.lblTipoReseña.TabIndex = 7;
            this.lblTipoReseña.Text = "Tipo de reseña:";
            this.lblTipoReseña.Visible = false;
            // 
            // lblFormasVisReporte
            // 
            this.lblFormasVisReporte.AutoSize = true;
            this.lblFormasVisReporte.BackColor = System.Drawing.Color.Transparent;
            this.lblFormasVisReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormasVisReporte.Location = new System.Drawing.Point(25, 325);
            this.lblFormasVisReporte.Name = "lblFormasVisReporte";
            this.lblFormasVisReporte.Size = new System.Drawing.Size(181, 16);
            this.lblFormasVisReporte.TabIndex = 8;
            this.lblFormasVisReporte.Text = "Formas de Visualización:";
            this.lblFormasVisReporte.Visible = false;
            // 
            // cmbFormasVisReporte
            // 
            this.cmbFormasVisReporte.FormattingEnabled = true;
            this.cmbFormasVisReporte.Items.AddRange(new object[] {
            "PDF",
            "Archivo Excel",
            "Pantalla"});
            this.cmbFormasVisReporte.Location = new System.Drawing.Point(25, 350);
            this.cmbFormasVisReporte.Name = "cmbFormasVisReporte";
            this.cmbFormasVisReporte.Size = new System.Drawing.Size(275, 24);
            this.cmbFormasVisReporte.TabIndex = 9;
            this.cmbFormasVisReporte.Visible = false;
            this.cmbFormasVisReporte.SelectedIndexChanged += new System.EventHandler(this.tomarFormaVisualizacion);
            // 
            // msgBoxConfirmacion
            // 
            this.msgBoxConfirmacion.Controls.Add(this.lblConfirmacion);
            this.msgBoxConfirmacion.Controls.Add(this.btnCancelacion);
            this.msgBoxConfirmacion.Controls.Add(this.btnConfirmacion);
            this.msgBoxConfirmacion.Location = new System.Drawing.Point(328, 173);
            this.msgBoxConfirmacion.Name = "msgBoxConfirmacion";
            this.msgBoxConfirmacion.Size = new System.Drawing.Size(286, 201);
            this.msgBoxConfirmacion.TabIndex = 10;
            this.msgBoxConfirmacion.TabStop = false;
            this.msgBoxConfirmacion.Visible = false;
            // 
            // lblConfirmacion
            // 
            this.lblConfirmacion.AutoSize = true;
            this.lblConfirmacion.Location = new System.Drawing.Point(50, 52);
            this.lblConfirmacion.Name = "lblConfirmacion";
            this.lblConfirmacion.Size = new System.Drawing.Size(172, 16);
            this.lblConfirmacion.TabIndex = 2;
            this.lblConfirmacion.Text = "¿Desea generar el reporte?";
            // 
            // btnCancelacion
            // 
            this.btnCancelacion.Location = new System.Drawing.Point(161, 111);
            this.btnCancelacion.Name = "btnCancelacion";
            this.btnCancelacion.Size = new System.Drawing.Size(91, 23);
            this.btnCancelacion.TabIndex = 1;
            this.btnCancelacion.Text = "Cancelar";
            this.btnCancelacion.UseVisualStyleBackColor = true;
            this.btnCancelacion.Click += new System.EventHandler(this.tomarCancelacionReporte);
            // 
            // btnConfirmacion
            // 
            this.btnConfirmacion.Location = new System.Drawing.Point(40, 111);
            this.btnConfirmacion.Name = "btnConfirmacion";
            this.btnConfirmacion.Size = new System.Drawing.Size(88, 23);
            this.btnConfirmacion.TabIndex = 0;
            this.btnConfirmacion.Text = "Confirmar";
            this.btnConfirmacion.UseVisualStyleBackColor = true;
            this.btnConfirmacion.Click += new System.EventHandler(this.tomarConfirmacionReporte);
            // 
            // PantallaGenerarRanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(893, 549);
            this.Controls.Add(this.msgBoxConfirmacion);
            this.Controls.Add(this.cmbFormasVisReporte);
            this.Controls.Add(this.lblFormasVisReporte);
            this.Controls.Add(this.lblTipoReseña);
            this.Controls.Add(this.cmbTipoReseña);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.datePickerFechaDesde);
            this.Controls.Add(this.datePickerFechaHasta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PantallaGenerarRanking";
            this.Text = "Generar Ranking de Vinos";
            this.msgBoxConfirmacion.ResumeLayout(false);
            this.msgBoxConfirmacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker datePickerFechaHasta;
        private System.Windows.Forms.DateTimePicker datePickerFechaDesde;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.ComboBox cmbTipoReseña;
        private System.Windows.Forms.Label lblTipoReseña;
        private System.Windows.Forms.Label lblFormasVisReporte;
        private System.Windows.Forms.ComboBox cmbFormasVisReporte;
        private System.Windows.Forms.GroupBox msgBoxConfirmacion;
        private System.Windows.Forms.Label lblConfirmacion;
        private System.Windows.Forms.Button btnCancelacion;
        private System.Windows.Forms.Button btnConfirmacion;
    }
}

