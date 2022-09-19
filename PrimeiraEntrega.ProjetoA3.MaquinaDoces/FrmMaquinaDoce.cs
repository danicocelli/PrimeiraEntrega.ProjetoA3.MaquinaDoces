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
    public partial class FrmMaquinaDoces : Form
    {
        public FrmMaquinaDoces()
        {
            InitializeComponent();
        }

        public struct Doce
        {
            public bool DoceA { get; set; }

            public bool DoceB { get; set; }

            public bool DoceC { get; set; }

        }

        private void btnUmReal_Click(object sender, EventArgs e)
        {
            decimal valor = 1;
            var doce = new Doce();
            CalculaDoces(valor, doce);
        }

        private void btnDoisReais_Click(object sender, EventArgs e)
        {
            decimal valor = 2;
            var doce = new Doce();
            CalculaDoces(valor, doce);
        }

        private void btnCincoReais_Click(object sender, EventArgs e)
        {
            decimal valor = 5;
            var doce = new Doce();
            CalculaDoces(valor, doce);
        }

        public void CalculaDoces(decimal valor, Doce doce)
        {
            decimal valorExistente = Convert.ToDecimal(lblRetorno.Text);
            decimal total = 0;
            if (doce.DoceA) total = valorExistente - 6; 

            else if (doce.DoceB) total = valorExistente - 7;

            else if (doce.DoceC) total = valorExistente - 8;
       
            else total = valor + valorExistente;

            if (total <= 0) lblRetorno.Text = "0";
            
            else lblRetorno.Text = total.ToString();

            AtivaDoce();
        }

        public void AtivaDoce()
        {
            decimal total = Convert.ToDecimal(lblRetorno.Text);

            if (total == 6)
            {
                btnDoceA.BackColor = Color.LightGreen;
                btnDoceA.Enabled = true;
            }
            else if (total == 7)
            {
                btnDoceA.BackColor = Color.LightGreen;
                btnDoceB.BackColor = Color.LightGreen;
                btnDoceA.Enabled = true;
                btnDoceB.Enabled = true;
            }
            else if (total >= 8)
            {
                btnDoceA.BackColor = Color.LightGreen;
                btnDoceB.BackColor = Color.LightGreen;
                btnDoceC.BackColor = Color.LightGreen;
                
                btnDoceA.Enabled = true;
                btnDoceB.Enabled = true;
                btnDoceC.Enabled = true;

                btnUmReal.Enabled = false;
                btnDoisReais.Enabled = false;
                btnCincoReais.Enabled = false;
            }
            else ResetarCampos();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            string valorTotal = lblRetorno.Text;
            if (valorTotal.Equals("0")) return;
            MessageBox.Show("Doces comprados! O seu troco será de: R$" + lblRetorno.Text + ",00", "COMPRA CONCLUÍDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetarCampos();
            lblRetorno.Text = "0";
            ResetarCampos();
        }

        private void ResetarCampos()
        {
            btnDoceA.UseVisualStyleBackColor = true;
            btnDoceB.UseVisualStyleBackColor = true;
            btnDoceC.UseVisualStyleBackColor = true;

            btnDoceA.Enabled = false;
            btnDoceB.Enabled = false;
            btnDoceC.Enabled = false;

            btnUmReal.Enabled = true;
            btnDoisReais.Enabled = true;
            btnCincoReais.Enabled = true;
        }

        private void btnDoceA_Click(object sender, EventArgs e)
        {
            var doce = new Doce();
            doce.DoceA = true;
            EnviarRequisicao(doce);
        }

        private void btnDoceB_Click(object sender, EventArgs e)
        {
            var doce = new Doce();
            doce.DoceB = true;
            EnviarRequisicao(doce);
        }

        private void btnDoceC_Click(object sender, EventArgs e)
        {
            var doce = new Doce();
            doce.DoceC = true;
            EnviarRequisicao(doce);
        }

        private void EnviarRequisicao(Doce doce)
        {
            decimal valorRecebido = Convert.ToDecimal(lblRetorno.Text);
            CalculaDoces(valorRecebido, doce);
        }
    }
}
