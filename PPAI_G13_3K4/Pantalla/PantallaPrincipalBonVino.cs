using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
