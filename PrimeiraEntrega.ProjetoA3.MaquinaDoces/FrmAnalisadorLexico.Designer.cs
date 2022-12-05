
namespace PrimeiraEntrega.ProjetoA3.MaquinaDoces
{
    partial class FrmAnalisadorLexico
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
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.btnAnalise = new System.Windows.Forms.Button();
            this.dataGridSaida = new System.Windows.Forms.DataGridView();
            this.Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saída = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelResposta = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSaida)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEntrada
            // 
            this.txtEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrada.Location = new System.Drawing.Point(12, 58);
            this.txtEntrada.Multiline = true;
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(417, 103);
            this.txtEntrada.TabIndex = 0;
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrada.Location = new System.Drawing.Point(11, 31);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(90, 20);
            this.lblEntrada.TabIndex = 1;
            this.lblEntrada.Text = "ENTRADA:";
            // 
            // btnAnalise
            // 
            this.btnAnalise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAnalise.Location = new System.Drawing.Point(124, 167);
            this.btnAnalise.Name = "btnAnalise";
            this.btnAnalise.Size = new System.Drawing.Size(305, 37);
            this.btnAnalise.TabIndex = 2;
            this.btnAnalise.Text = "ANALISAR";
            this.btnAnalise.UseVisualStyleBackColor = false;
            this.btnAnalise.Click += new System.EventHandler(this.btnAnalise_Click);
            // 
            // dataGridSaida
            // 
            this.dataGridSaida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSaida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSaida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Entrada,
            this.Saída});
            this.dataGridSaida.Location = new System.Drawing.Point(435, 58);
            this.dataGridSaida.Name = "dataGridSaida";
            this.dataGridSaida.ReadOnly = true;
            this.dataGridSaida.Size = new System.Drawing.Size(446, 146);
            this.dataGridSaida.TabIndex = 4;
            // 
            // Entrada
            // 
            this.Entrada.HeaderText = "Entrada";
            this.Entrada.Name = "Entrada";
            this.Entrada.ReadOnly = true;
            // 
            // Saída
            // 
            this.Saída.HeaderText = "Saida";
            this.Saída.Name = "Saída";
            this.Saída.ReadOnly = true;
            // 
            // labelResposta
            // 
            this.labelResposta.AutoSize = true;
            this.labelResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResposta.Location = new System.Drawing.Point(12, 224);
            this.labelResposta.Name = "labelResposta";
            this.labelResposta.Size = new System.Drawing.Size(82, 20);
            this.labelResposta.TabIndex = 5;
            this.labelResposta.Text = "Resultado";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLimpar.Location = new System.Drawing.Point(12, 168);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(106, 36);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FrmAnalisadorLexico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 290);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.labelResposta);
            this.Controls.Add(this.dataGridSaida);
            this.Controls.Add(this.btnAnalise);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.txtEntrada);
            this.MaximizeBox = false;
            this.Name = "FrmAnalisadorLexico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analisador Léxico";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSaida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Button btnAnalise;
        private System.Windows.Forms.DataGridView dataGridSaida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saída;
        private System.Windows.Forms.Label labelResposta;
        private System.Windows.Forms.Button btnLimpar;
    }
}