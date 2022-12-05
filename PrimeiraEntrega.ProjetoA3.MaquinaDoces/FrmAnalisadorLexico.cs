using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiraEntrega.ProjetoA3.MaquinaDoces
{
    public partial class FrmAnalisadorLexico : Form
    {
        public FrmAnalisadorLexico()
        {
            InitializeComponent();
        }

        private void btnAnalise_Click(object sender, EventArgs e)
        {
            var resultado = Analisar(txtEntrada.Text);
            if (resultado)
            {
                labelResposta.Text = "EXPRESSÃO VÁLIDA";
                labelResposta.ForeColor = Color.Green;
            }
            else
            {
                labelResposta.Text = "EXPRESSÃO INVÁLIDA";
                labelResposta.ForeColor = Color.Red;
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtEntrada.Text = string.Empty;
            labelResposta.Text = "Resultado";
            labelResposta.ForeColor = Color.Black;
            dataGridSaida.Rows.Clear();
        }


        private bool Analisar(string sentenca)
        {
            string sentencaReplaced = sentenca.Replace(" ", "");
            var sentencaSplit = sentenca.Split(' ');

            bool isComentario = Regex.IsMatch(sentencaReplaced, "^['//']");
            if (isComentario)
            {
                dataGridSaida.Rows.Add("// ou /* */", "Comentário");
                return true;
            }

            bool isComentarioLinhas = Regex.IsMatch(sentencaReplaced, "^['/*']+['*/']+$");
            if (isComentarioLinhas)
            {
                dataGridSaida.Rows.Add("// ou /* */", "Comentário");
                return true;
            }

            bool isVariavelInt = Regex.IsMatch(sentencaReplaced, "^['int']+[a-zA-Z]+['=']+[0-9]+[';']");
            if (isVariavelInt)
            {
                dataGridSaida.Rows.Add(sentencaSplit[0], "Tipo Primitivo");
                dataGridSaida.Rows.Add(sentencaSplit[1].ToString(), "Nome de Variável");
                dataGridSaida.Rows.Add("=", "Operador de Atribuição");
                dataGridSaida.Rows.Add(sentencaSplit[3].ToString(), "Valor da Variável e Conclusão");
                return true;
            }

            bool isVariavelString = Regex.IsMatch(sentencaReplaced, "^['string']+[a-zA-Z]+['=']+[\"a-zA-Z\"]+[';']");

            if (isVariavelString)
            {
                dataGridSaida.Rows.Add(sentencaSplit[0], "Tipo Primitivo");
                dataGridSaida.Rows.Add(sentencaSplit[1].ToString(), "Nome de Variável");
                dataGridSaida.Rows.Add("=", "Operador de Atribuição");
                dataGridSaida.Rows.Add(sentencaSplit[3].ToString(), "Valor da Variável e Conclusão");
                return true;
            }

            bool isFuncao = Regex.IsMatch(sentencaReplaced, "^['private', 'protected', 'public', '']+['int', 'string', 'bool', 'void']+[a-zA-Z]+['()']+['{}']");
            if (isFuncao)
            {
                dataGridSaida.Rows.Add(sentencaSplit[0], "Encapsulador");
                dataGridSaida.Rows.Add(sentencaSplit[1].ToString(), "Tipo retorno do método");
                dataGridSaida.Rows.Add(sentencaSplit[2], "Nome do Método");
                dataGridSaida.Rows.Add(sentencaSplit[3].ToString(), "Declarador de Função e Receptor de Parâmetros");
                dataGridSaida.Rows.Add(sentencaSplit[3].ToString(), "Ações do método");
                return true;
            }

            return false;
        }       
    }
}
