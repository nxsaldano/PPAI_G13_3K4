namespace PPAI_G13_3K4.Pantalla
{
    partial class PantallaPrincipalBonVino
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenerarRankingVinos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerarRankingVinos
            // 
            this.btnGenerarRankingVinos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarRankingVinos.Location = new System.Drawing.Point(348, 312);
            this.btnGenerarRankingVinos.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerarRankingVinos.Name = "btnGenerarRankingVinos";
            this.btnGenerarRankingVinos.Size = new System.Drawing.Size(224, 58);
            this.btnGenerarRankingVinos.TabIndex = 1;
            this.btnGenerarRankingVinos.Text = "Generar Ranking de Vinos";
            this.btnGenerarRankingVinos.UseVisualStyleBackColor = true;
            this.btnGenerarRankingVinos.Click += new System.EventHandler(this.opcGenerarRankVinos);
            // 
            // PantallaPrincipalBonVino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PPAI_G13_3K4.Properties.Resources.Captura_de_pantalla_2024_05_27_220325;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenerarRankingVinos);
            this.Name = "PantallaPrincipalBonVino";
            this.Text = "PantallaPrincipalBonVino";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarRankingVinos;
    }
}