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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipalBonVino));
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
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(651, 423);
            this.Controls.Add(this.btnGenerarRankingVinos);
            this.DoubleBuffered = true;
            this.Name = "PantallaPrincipalBonVino";
            this.Text = "PantallaPrincipalBonVino";
            this.Resize += new System.EventHandler(this.PantallaPrincipalBonVino_Resize);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnGenerarRankingVinos;
    }
}