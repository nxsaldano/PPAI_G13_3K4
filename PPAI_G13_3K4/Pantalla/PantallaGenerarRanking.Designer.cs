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
            this.btnGenerarRankingVinos = new System.Windows.Forms.Button();
            this.fechaHasta = new System.Windows.Forms.DateTimePicker();
            this.fechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.cmbTipoReseña = new System.Windows.Forms.ComboBox();
            this.lblTipoReseña = new System.Windows.Forms.Label();
            this.lblFormasVisReporte = new System.Windows.Forms.Label();
            this.comboFormasVisReporte = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGenerarRankingVinos
            // 
            this.btnGenerarRankingVinos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarRankingVinos.Location = new System.Drawing.Point(325, 450);
            this.btnGenerarRankingVinos.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerarRankingVinos.Name = "btnGenerarRankingVinos";
            this.btnGenerarRankingVinos.Size = new System.Drawing.Size(224, 58);
            this.btnGenerarRankingVinos.TabIndex = 0;
            this.btnGenerarRankingVinos.Text = "Generar Ranking de Vinos";
            this.btnGenerarRankingVinos.UseVisualStyleBackColor = true;
            this.btnGenerarRankingVinos.Click += new System.EventHandler(this.btnGenerarRankingVinos_Click);
            // 
            // fechaHasta
            // 
            this.fechaHasta.Location = new System.Drawing.Point(25, 150);
            this.fechaHasta.Name = "fechaHasta";
            this.fechaHasta.Size = new System.Drawing.Size(275, 22);
            this.fechaHasta.TabIndex = 1;
            this.fechaHasta.Visible = false;
            this.fechaHasta.ValueChanged += new System.EventHandler(this.fechaHasta_ValueChanged);
            // 
            // fechaDesde
            // 
            this.fechaDesde.Checked = false;
            this.fechaDesde.Location = new System.Drawing.Point(25, 75);
            this.fechaDesde.Name = "fechaDesde";
            this.fechaDesde.Size = new System.Drawing.Size(275, 22);
            this.fechaDesde.TabIndex = 2;
            this.fechaDesde.Visible = false;
            this.fechaDesde.ValueChanged += new System.EventHandler(this.fechaDesde_ValueChanged);
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
            this.cmbTipoReseña.SelectedIndexChanged += new System.EventHandler(this.cmbTipoReseña_SelectedIndexChanged);
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
            // comboFormasVisReporte
            // 
            this.comboFormasVisReporte.FormattingEnabled = true;
            this.comboFormasVisReporte.Items.AddRange(new object[] {
            "PDF",
            "Archivo Excel",
            "Pantalla"});
            this.comboFormasVisReporte.Location = new System.Drawing.Point(25, 350);
            this.comboFormasVisReporte.Name = "comboFormasVisReporte";
            this.comboFormasVisReporte.Size = new System.Drawing.Size(275, 24);
            this.comboFormasVisReporte.TabIndex = 9;
            this.comboFormasVisReporte.Visible = false;
            this.comboFormasVisReporte.SelectedIndexChanged += new System.EventHandler(this.comboFormasVisReporte_SelectedIndexChanged);
            // 
            // PantallaGenerarRanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(893, 549);
            this.Controls.Add(this.comboFormasVisReporte);
            this.Controls.Add(this.lblFormasVisReporte);
            this.Controls.Add(this.lblTipoReseña);
            this.Controls.Add(this.cmbTipoReseña);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.fechaDesde);
            this.Controls.Add(this.fechaHasta);
            this.Controls.Add(this.btnGenerarRankingVinos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PantallaGenerarRanking";
            this.Text = "Generar Ranking de Vinos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarRankingVinos;
        private System.Windows.Forms.DateTimePicker fechaHasta;
        private System.Windows.Forms.DateTimePicker fechaDesde;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.ComboBox cmbTipoReseña;
        private System.Windows.Forms.Label lblTipoReseña;
        private System.Windows.Forms.Label lblFormasVisReporte;
        private System.Windows.Forms.ComboBox comboFormasVisReporte;
    }
}

