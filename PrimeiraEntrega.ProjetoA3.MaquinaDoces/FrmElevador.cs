using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiraEntrega.ProjetoA3.MaquinaDoces
{
    public partial class FrmElevador : Form
    {
        public FrmElevador()
        {
            InitializeComponent();
            txtSeta.Text = "-";
        }

        int andarAtual = 0;
  
        private async void TimerAndar(int andarSelecionado)
        {
            if (andarSelecionado == andarAtual)
                return;

            SimulacaoPortas(false);
            if (andarSelecionado < andarAtual)
            {
                txtSeta.Text = "↓";
                txtSeta.ForeColor = Color.Red;
                txtPainelAndar.ForeColor = Color.Red;
                for (int i = andarAtual; i >= andarSelecionado; i--)
                {
                    txtPainelAndar.Text = i.ToString();
                    await Task.Delay(1000);
                }
            }
            else
            {
                txtSeta.Text = "↑";
                txtSeta.ForeColor = Color.LightGreen;
                txtPainelAndar.ForeColor = Color.LightGreen;
                for (int i = andarAtual; i <= andarSelecionado; i++)
                {
                    txtPainelAndar.Text = i.ToString();
                    await Task.Delay(1000);
                }
            }
            andarAtual = andarSelecionado;
            SimulacaoPortas(true);
        }
    
        private void SimulacaoPortas(bool portaAberta)
        {
            if (portaAberta)
            {
                pictureBoxSimulacao.Image = Properties.Resources.elevadorAberto;
                txtSeta.Text = "-";
                txtSeta.ForeColor = Color.White;
                txtPainelAndar.ForeColor = Color.White;
                btnPrimeiroAndar.Enabled = true;
                btnSegundoAndar.Enabled = true;
                btnTerceiroAndar.Enabled = true;
                btnQuartoAndar.Enabled = true;
                btnQuintoAndar.Enabled = true;
                btnTerreo.Enabled = true;
            }
            else
            {
                pictureBoxSimulacao.Image = Properties.Resources.elevadorFechado;
                btnPrimeiroAndar.Enabled = false;
                btnSegundoAndar.Enabled = false;
                btnTerceiroAndar.Enabled = false;
                btnQuartoAndar.Enabled = false;
                btnQuintoAndar.Enabled = false;
                btnTerreo.Enabled = false;
            }
        }

        private void btnTerreo_Click(object sender, EventArgs e)
        {
            TimerAndar(0);
        }

        private void btnPrimeiroAndar_Click(object sender, EventArgs e)
        {
            TimerAndar(1);
        }

        private void btnSegundoAndar_Click(object sender, EventArgs e)
        {
            TimerAndar(2);
        }

        private void btnTerceiroAndar_Click(object sender, EventArgs e)
        {
            TimerAndar(3);
        }

        private void btnQuartoAndar_Click(object sender, EventArgs e)
        {
            TimerAndar(4);
        }

        private void btnQuintoAndar_Click(object sender, EventArgs e)
        {
            TimerAndar(5);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
