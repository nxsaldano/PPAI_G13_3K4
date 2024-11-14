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

namespace PPAI_G13_3K4.Pantalla
{
    public partial class InterfazExcel : Form
    {
        public InterfazExcel()
        {
            InitializeComponent();
        }

        internal void exportarExcel(List<(string, decimal, decimal, string, List<string>, string, string)> vinosRankingExcel)
        {

            for (int i=0; i < 10; i++) 
            {
                string nom = (vinosRankingExcel[i].Item1);
                decimal calSom = (vinosRankingExcel[i].Item2);
                decimal precSug = (vinosRankingExcel[i].Item3);
                string bod = (vinosRankingExcel[i].Item4);
                string var = string.Join(", ", vinosRankingExcel[i].Item5);
                string region = (vinosRankingExcel[i].Item6);
                string pais = (vinosRankingExcel[i].Item7);

                excelRankingVinos.Rows.Add(i+1,nom, calSom, precSug, bod, var, region, pais);
            }
            
                this.Show();
        }
    }
}
