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
            this.SuspendLayout();
            // 
            // btnGenerarRankingVinos
            // 
            this.btnGenerarRankingVinos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarRankingVinos.Location = new System.Drawing.Point(245, 371);
            this.btnGenerarRankingVinos.Name = "btnGenerarRankingVinos";
            this.btnGenerarRankingVinos.Size = new System.Drawing.Size(168, 47);
            this.btnGenerarRankingVinos.TabIndex = 0;
            this.btnGenerarRankingVinos.Text = "Generar Ranking de Vinos";
            this.btnGenerarRankingVinos.UseVisualStyleBackColor = true;
            // 
            // PantallaGenerarRanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(670, 446);
            this.Controls.Add(this.btnGenerarRankingVinos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaGenerarRanking";
            this.Text = "Generar Ranking de Vinos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarRankingVinos;
    }
}

