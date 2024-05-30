namespace PPAI_G13_3K4.Pantalla
{
    partial class InterfazExcel
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
            this.label1 = new System.Windows.Forms.Label();
            this.excelRankingVinos = new System.Windows.Forms.DataGridView();
            this.nomVino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.califSommelier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioSug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varietal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.excelRankingVinos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ranking de los 10 mejores Vinos:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // excelRankingVinos
            // 
            this.excelRankingVinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.excelRankingVinos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomVino,
            this.califSommelier,
            this.precioSug,
            this.bodega,
            this.varietal,
            this.region,
            this.pais});
            this.excelRankingVinos.Location = new System.Drawing.Point(25, 50);
            this.excelRankingVinos.Name = "excelRankingVinos";
            this.excelRankingVinos.RowHeadersWidth = 51;
            this.excelRankingVinos.RowTemplate.Height = 24;
            this.excelRankingVinos.Size = new System.Drawing.Size(750, 375);
            this.excelRankingVinos.TabIndex = 1;
            this.excelRankingVinos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.excelRankingVinos_CellContentClick);
            // 
            // nomVino
            // 
            this.nomVino.Frozen = true;
            this.nomVino.HeaderText = "Nombre";
            this.nomVino.MinimumWidth = 6;
            this.nomVino.Name = "nomVino";
            this.nomVino.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nomVino.Width = 125;
            // 
            // califSommelier
            // 
            this.califSommelier.HeaderText = "Calif. Sommelier";
            this.califSommelier.MinimumWidth = 6;
            this.califSommelier.Name = "califSommelier";
            this.califSommelier.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.califSommelier.Width = 125;
            // 
            // precioSug
            // 
            this.precioSug.HeaderText = "Precio sugerido";
            this.precioSug.MinimumWidth = 6;
            this.precioSug.Name = "precioSug";
            this.precioSug.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.precioSug.Width = 125;
            // 
            // bodega
            // 
            this.bodega.HeaderText = "Bodega";
            this.bodega.MinimumWidth = 6;
            this.bodega.Name = "bodega";
            this.bodega.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.bodega.Width = 125;
            // 
            // varietal
            // 
            this.varietal.HeaderText = "Varietal";
            this.varietal.MinimumWidth = 6;
            this.varietal.Name = "varietal";
            this.varietal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.varietal.Width = 125;
            // 
            // region
            // 
            this.region.HeaderText = "Región";
            this.region.MinimumWidth = 6;
            this.region.Name = "region";
            this.region.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.region.Width = 125;
            // 
            // pais
            // 
            this.pais.HeaderText = "País";
            this.pais.MinimumWidth = 6;
            this.pais.Name = "pais";
            this.pais.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pais.Width = 125;
            // 
            // InterfazExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.excelRankingVinos);
            this.Controls.Add(this.label1);
            this.Name = "InterfazExcel";
            this.Text = "InterfazExcel";
            this.Load += new System.EventHandler(this.InterfazExcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.excelRankingVinos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView excelRankingVinos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomVino;
        private System.Windows.Forms.DataGridViewTextBoxColumn califSommelier;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioSug;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodega;
        private System.Windows.Forms.DataGridViewTextBoxColumn varietal;
        private System.Windows.Forms.DataGridViewTextBoxColumn region;
        private System.Windows.Forms.DataGridViewTextBoxColumn pais;
    }
}