using System;
using System.Windows.Forms;

namespace PPAI_G13_3K4.Pantalla
{
    public partial class PantallaPrincipalBonVino : Form
    {
        private PantallaGenerarRanking pantalla;
        public PantallaPrincipalBonVino()
        {
            InitializeComponent();
            pantalla = new PantallaGenerarRanking();

        }

        private void opcGenerarRankVinos(object sender, EventArgs e)
        {
            pantalla.opcGenerarRankVinos();
            this.WindowState = FormWindowState.Minimized;
        }

        private void PantallaPrincipalBonVino_Resize(object sender, EventArgs e)
        {
            int newSize = Math.Max(Width, Height);
            Width = newSize;
            Height = newSize;
        }
    }
}
