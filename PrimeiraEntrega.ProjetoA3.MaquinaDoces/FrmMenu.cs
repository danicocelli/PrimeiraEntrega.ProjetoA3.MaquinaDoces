using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiraEntrega.ProjetoA3.MaquinaDoces
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnDoce_Click(object sender, EventArgs e)
        {
            FrmMaquinaDoces frmMaquinaDoces = new FrmMaquinaDoces();
            frmMaquinaDoces.ShowDialog();
        }

        private void btnElevador_Click(object sender, EventArgs e)
        {
            FrmElevador frmElevador = new FrmElevador();
            frmElevador.ShowDialog();
        }
    }
}
